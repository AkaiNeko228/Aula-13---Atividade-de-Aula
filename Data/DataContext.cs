using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RpgApi.Models;
using RpgApi.Models.Enuns;
using RpgApi.Utils;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        //ctor --> Cria um construtor (Atalho)
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Personagem> TB_PERSONAGENS { get; set; }
        public DbSet<Disputa> TB_DISPUTAS { get; set; }
        public DbSet<Armas> TB_ARMAS{ get; set; }
        public DbSet<Usuario> TB_USUARIOS { get; set; }
        public DbSet<Habilidade> TB_HABILIDADE {get; set;}
        public DbSet<PersonagemHabilidade> TB_PERSONAGEM_HABILIDADES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().ToTable("TB_PERSONAGENS");
            modelBuilder.Entity<Armas>().ToTable("TB_ARMAS");
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");

            modelBuilder.Entity<Disputa>(entity =>
            {
                entity.ToTable("TB_DISPUTAS");
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Id).ValueGeneratedOnAdd();
                entity.Property(d => d.DataDisputa).HasColumnName("Dt_Disputa").HasColumnType("datetime");
                entity.Property(d => d.AtacanteId).HasColumnName("AtacanteId");
                entity.Property(d => d.OponenteId).HasColumnName("OponenteId");
                entity.Property(d => d.Narracao).HasColumnName("Tx_Narracao")
                    .HasColumnType("varchar(max)").HasMaxLength(int.MaxValue);
            });

             //Relacionamento One to Many (Um para muitos)
            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Personagens)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId)
                .IsRequired(false);
            
            modelBuilder.Entity<Personagem>()
                .HasOne(e => e.Armas)
                .WithOne(e => e.Personagem)
                .HasForeignKey<Armas>(e => e.PersonagemId)
                .IsRequired();


            modelBuilder.Entity<Personagem>().HasData
            (
                new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro, UsuarioId=1},
                new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro, UsuarioId=1},
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo, UsuarioId=1 },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago, UsuarioId=1 },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro, UsuarioId=1 },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo, UsuarioId=1 },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago, UsuarioId=1 }
            );

           modelBuilder.Entity<Armas>().HasData
           (
                new Armas { Id = 1, Nome = "Glock-18", Dano = 30, PersonagemId = 1 },
                new Armas { Id = 2, Nome = "AK-47", Dano = 36, PersonagemId = 2  },
                new Armas { Id = 3, Nome = "M4A1-S", Dano = 38, PersonagemId = 3 },
                new Armas { Id = 4, Nome = "Desert Eagle", Dano = 53, PersonagemId = 4 },
                new Armas { Id = 5, Nome = "AWP", Dano = 115, PersonagemId = 5 },
                new Armas { Id = 6, Nome = "Negev", Dano = 35, PersonagemId = 6 },
                new Armas { Id = 7, Nome = "P90", Dano = 26, PersonagemId = 7 }
                );

            modelBuilder.Entity<PersonagemHabilidade>()
                .HasKey(ph => new {ph.PersonagemId, ph.HabilidadeId});

            modelBuilder.Entity<Habilidade>().HasData(
                new Habilidade(){Id=1, Nome="Adomercer", Dano=39},
                new Habilidade(){Id=2, Nome="Congelar", Dano=41},
                new Habilidade(){Id=3, Nome="Hipnostizar", Dano=37}
            );

            modelBuilder.Entity<PersonagemHabilidade>().HasData(
                new PersonagemHabilidade(){PersonagemId = 1, HabilidadeId =1},
                new PersonagemHabilidade(){PersonagemId = 1, HabilidadeId =2},
                new PersonagemHabilidade(){PersonagemId = 2, HabilidadeId =2},
                new PersonagemHabilidade(){PersonagemId = 3, HabilidadeId =2},
                new PersonagemHabilidade(){PersonagemId = 3, HabilidadeId =3},
                new PersonagemHabilidade(){PersonagemId = 4, HabilidadeId =3},
                new PersonagemHabilidade(){PersonagemId = 5, HabilidadeId =1},
                new PersonagemHabilidade(){PersonagemId = 6, HabilidadeId =2},
                new PersonagemHabilidade(){PersonagemId = 7, HabilidadeId =1}

            );

           //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);
            //Fim da criação do usuário padrão.   

            //Define que se o Perfil não for informado, o valor padrão será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");     

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>()
                .HaveColumnType("varchar").HaveMaxLength(200);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings
                .Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        






    }
}
