using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas
{
    //classe que representa o banco de dados
    public class BananaContext : DbContext
    {
        //propriedade que representa a tabela usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Comanda> Comandas { get; set; }
        //public DbSet<PedidoCozinha> PedidosCozinha { get; set; }

        //metodo que configura informando para o EF que o banco sera SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
