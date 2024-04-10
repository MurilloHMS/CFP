using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroPessoal.Model.Databases
{
    internal class ControleFinanceiroContext : DbContext
    {
        //private string _connectionString = "Data Source=192.168.18.100,1435;Initial Catalog=KINGDOM;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FinanceiroKingdomDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public DbSet<Member> Members { get; set; }
        public DbSet<Financeiro> Financeiros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasKey(m => m.ID);
        }

        public void CriarTabelaSql()
        {
            Database.ExecuteSqlRaw(@"CREATE TABLE Members (
                ID INT PRIMARY KEY IDENTITY(1, 1),
                Nome NVARCHAR(100) NOT NULL CONSTRAINT Nome_Length CHECK (LEN(Nome) <= 100),
                Email NVARCHAR(100) NOT NULL UNIQUE,
                Telefone NVARCHAR(MAX) NOT NULL,
                DataDeNascimento NVARCHAR(MAX) NOT NULL,
                PerguntaECristao NVARCHAR(MAX) NOT NULL,
                PerguntaFrequentaIgreja NVARCHAR(MAX) NOT NULL,
                CEP NVARCHAR(MAX) NOT NULL,
                Rua NVARCHAR(100) NOT NULL CONSTRAINT Rua_Length CHECK (LEN(Rua) <= 100),
                Numero NVARCHAR(6) NOT NULL CONSTRAINT Numero_Length CHECK (LEN(Numero) <= 6),
                Bairro NVARCHAR(100) NOT NULL CONSTRAINT Bairro_Length CHECK (LEN(Bairro) <= 100),
                Cidade NVARCHAR(100) NOT NULL CONSTRAINT Cidade_Length CHECK (LEN(Cidade) <= 100),
                UF NVARCHAR(2) NOT NULL CONSTRAINT UF_Length CHECK (LEN(UF) <= 2),
                Complemento NVARCHAR(100) NOT NULL CONSTRAINT Complemento_Length CHECK (LEN(Complemento) <= 100)
            );


            CREATE TABLE Financeiros (
                ID INT PRIMARY KEY IDENTITY(1, 1),
                TipoLancamento NVARCHAR(MAX) NOT NULL,
                Valor DECIMAL(18, 2) NOT NULL,
                DataVencimento DATETIME NULL,
                TipoEvento NVARCHAR(MAX) NOT NULL,
                Categoria NVARCHAR(MAX) NOT NULL,
                Descricao NVARCHAR(MAX) NULL,
                DataEntrada DATETIME NULL 
            );");
        }
    }
}
