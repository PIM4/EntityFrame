using lojaComEntity.Entity;
using lojaComEntity.Model.Entity;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{   
    // Classe do Entity, que eu criei como EntidadesContext e ela herda de uma Classe "DbContext"
    public class EntidadesContext : DbContext 
    {
        // Realiza o mapeamento das classes para refletir em entidades 
        public DbSet<Usuario>  Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; } 
        public DbSet<Produto> Produtos { get; set; }

        // Um metodo que existe na classe pai, a "DbContext" e aqui eu estou usando o "override" para sobreescrever o metodo
        // Com os dados que eu quero, no caso 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // String de conexão. Essa string esta dentro do "App.config", que mostra a configuração do banco de dados
            string stringConexao = ConfigurationManager.ConnectionStrings["LojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao );
            base.OnConfiguring(optionsBuilder);
        }
    }
}
