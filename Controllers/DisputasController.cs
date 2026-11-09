using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisputasController : ControllerBase
    {
        private readonly DataContext _context;

        public DisputasController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("Arma")]
        public async Task<IActionResult> AtaqueComArmaAsync(Disputa d)
        {
            try
            {
                if (d.AtacanteId <= 0 || d.OponenteId <= 0 || d.AtacanteId == d.OponenteId)
                    return BadRequest("Informe dois personagens diferentes com Ids válidos.");

                Personagem? atacante = await _context.TB_PERSONAGENS
                    .Include(p => p.Armas)
                    .FirstOrDefaultAsync(p => p.Id == d.AtacanteId);
                Personagem? oponente = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == d.OponenteId);

                if (atacante == null || oponente == null)
                    return NotFound("Atacante ou oponente não encontrado.");
                if (atacante.Armas == null)
                    return BadRequest("O atacante não possui uma arma.");
                if (atacante.PontosVida <= 0 || oponente.PontosVida <= 0)
                    return BadRequest("Os personagens precisam estar vivos para disputar.");
                if (atacante.Forca < 0 || oponente.Defesa < 0 || atacante.Armas.Dano < 0)
                    return BadRequest("Força, defesa e dano não podem ser negativos.");

                int dano = Math.Max(0, checked(atacante.Armas.Dano
                    + Random.Shared.Next(atacante.Forca) - Random.Shared.Next(oponente.Defesa)));

                await RegistrarAtaqueAsync(d, atacante, oponente, dano, "Arma", atacante.Armas.Nome);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Habilidade")]
        public async Task<IActionResult> AtaqueComHabilidadeAsync(Disputa d)
        {
            try
            {
                if (d.AtacanteId <= 0 || d.OponenteId <= 0 || d.AtacanteId == d.OponenteId)
                    return BadRequest("Informe dois personagens diferentes com Ids válidos.");
                if (d.HabilidadeId == null || d.HabilidadeId <= 0)
                    return BadRequest("Informe o Id da habilidade.");

                Personagem? atacante = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == d.AtacanteId);
                Personagem? oponente = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == d.OponenteId);

                if (atacante == null || oponente == null)
                    return NotFound("Atacante ou oponente não encontrado.");
                if (atacante.PontosVida <= 0 || oponente.PontosVida <= 0)
                    return BadRequest("Os personagens precisam estar vivos para disputar.");

                PersonagemHabilidade? ph = await _context.TB_PERSONAGEM_HABILIDADES
                    .Include(p => p.Habilidade)
                    .FirstOrDefaultAsync(p => p.PersonagemId == d.AtacanteId
                        && p.HabilidadeId == d.HabilidadeId);

                if (ph?.Habilidade == null)
                {
                    d.Id = 0;
                    d.Narracao = $"{atacante.Nome} não possui esta habilidade.";
                    d.DataDisputa = DateTime.Now;
                    return Ok(d);
                }
                if (atacante.Inteligencia < 0 || oponente.Defesa < 0 || ph.Habilidade.Dano < 0)
                    return BadRequest("Inteligência, defesa e dano não podem ser negativos.");

                int dano = Math.Max(0, checked(ph.Habilidade.Dano
                    + Random.Shared.Next(atacante.Inteligencia) - Random.Shared.Next(oponente.Defesa)));

                await RegistrarAtaqueAsync(d, atacante, oponente, dano, "Habilidade", ph.Habilidade.Nome);
                return Ok(d);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private async Task RegistrarAtaqueAsync(Disputa d, Personagem atacante,
            Personagem oponente, int dano, string tipo, string recurso)
        {
            oponente.PontosVida = Math.Max(0, oponente.PontosVida - dano);
            StringBuilder dados = new StringBuilder();
            if (oponente.PontosVida == 0)
                dados.Append($"{oponente.Nome} foi derrotado! ");
            dados.AppendFormat("Atacante: {0}. Oponente: {1}. ", atacante.Nome, oponente.Nome);
            dados.AppendFormat("Pontos de vida do atacante: {0}. Pontos de vida do oponente: {1}. ",
                atacante.PontosVida, oponente.PontosVida);
            dados.AppendFormat("{0} utilizada: {1}. Dano: {2}.", tipo, recurso, dano);

            d.Id = 0;
            d.Narracao = dados.ToString();
            d.DataDisputa = DateTime.Now;
            _context.TB_DISPUTAS.Add(d);
            // A vida e o registro da disputa são salvos na mesma transação.
            await _context.SaveChangesAsync();
        }
    }
}
