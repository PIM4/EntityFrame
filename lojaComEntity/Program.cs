using lojaComEntity.Entity;
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
            // Instancia os objetos, tanto do Entity quanto o Usuario.
            EntidadesContext contexto = new EntidadesContext();
            Usuario user = new Usuario();

            // Mostra mensagem na tela e pega a resposta, savlando isso no "Nome".
            Console.WriteLine("Sistema de cadastro de usuario. \n");
            Console.WriteLine("Digite seu nome: ");
            user.Nome = Console.ReadLine();

            // Pula linha \o/
            Console.WriteLine("\n");

            // Mostra mensagem na tela e pega a resposta, savlando isso no "Senha".
            Console.WriteLine("Digite sua senha: ");
            user.Senha = Console.ReadLine();

            // Metodos do objeto "contexto" que foi criado na instancia do "EntidadesContext" que é a
            // Classe que criei pro entity, lá no começo do codigo 
            contexto.Usuarios.Add(user);
            contexto.SaveChanges();
            contexto.Dispose();

            // Mensagem de sucesso e uma pausa, para a tela não fechar direito.
            Console.WriteLine("Salvou o Usuario");
            Console.ReadKey();
        }   
    }
}
