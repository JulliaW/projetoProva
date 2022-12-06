using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using projetoProva.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace projetoProva.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
