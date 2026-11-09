using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmasController : ControllerBase
    {
        private readonly DataContext _context;

        public ArmasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            List<Armas> lista = await _context.TB_ARMAS
                .AsNoTracking()
                .ToListAsync();

            return Ok(lista);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            Armas? arma = await _context.TB_ARMAS
                .AsNoTracking()
                .FirstOrDefaultAsync(armaBusca => armaBusca.Id == id);

            if (arma == null)
            {
                return NotFound("Arma não encontrada");
            }

            return Ok(arma);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Armas novaArma)
        {
            try
            {
            
                if (novaArma.Dano == 0)
                    return BadRequest("O dano da arma não pode ser 0.");

                if (novaArma.Dano > 150)
                    return BadRequest("Dano da arma não pode ser maior que 150");

            
                Personagem p = await _context.TB_PERSONAGENS
                    .FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);

                if (p == null)
                    return BadRequest("Não existe personagem com o Id informado");

           
                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

           
                return CreatedAtAction(nameof(GetSingle), new { id = novaArma.Id }, novaArma);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update(Armas armaAtualizada)
        {
            if (armaAtualizada.Dano > 150)
            {
                return BadRequest("Dano da arma não pode ser maior que 150");
            }

            Armas? arma = await _context.TB_ARMAS
                .FirstOrDefaultAsync(armaBusca => armaBusca.Id == armaAtualizada.Id);

            if (arma == null)
            {
                return NotFound("Arma não encontrada");
            }

            arma.Nome = armaAtualizada.Nome;
            arma.Dano = armaAtualizada.Dano;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            Armas? arma = await _context.TB_ARMAS
                .FirstOrDefaultAsync(armaBusca => armaBusca.Id == id);

            if (arma == null)
            {
                return NotFound("Arma não encontrada");
            }

            _context.TB_ARMAS.Remove(arma);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
