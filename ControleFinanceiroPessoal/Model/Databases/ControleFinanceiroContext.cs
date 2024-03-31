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
        private string _connectionString = "Data Source=192.168.18.100,1435;Initial Catalog=KINGDOM;User ID=sa;Password=Xj7hpmtmma@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
    }
}
