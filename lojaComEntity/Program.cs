using lojaComEntity.Entity;
using lojaComEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            //Salva Produto, informando o ID da categoria 
            /*Produto p = new Produto()
            {
                nome = "Teclado",
                preco = 20,
                categoriaID = 1
            };
            contexto.Produtos.Add(p);
            contexto.SaveChanges();*/

            //Busca produto com inner da categoria 
            //Produto p = contexto.Produtos.Include(Produto => Produto.categoria).FirstOrDefault(produto => produto.ID == 1);

            /* Filtrando da categoria 
            var categoria = contexto.Categorias.Include(c => c.produtos). FirstOrDefault(c => c.ID == 1);
            foreach (var p in categoria.produtos)
            {
                //Console.WriteLine(p.nome);
            }*/


            /*
            //Categoria de roupas
            Categoria c = new Categoria() {
                nome = "Roupas",
            };
            contexto.Categorias.Add(c);
            contexto.SaveChanges();
           
            Produto r1 = new Produto()
            {
                nome = "Moleton",
                preco = 50,
                categoriaID = 2
            };
            contexto.Produtos.Add(r1);
            contexto.SaveChanges();
            */

            var busca = from p in contexto.Produtos select p;
            foreach( var produto in busca)
            {
                Console.WriteLine(produto.nome);
            }




            Console.WriteLine("funcionou");
            Console.ReadKey();

        }
    }
}
