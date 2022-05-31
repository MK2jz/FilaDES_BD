using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Fila_DES
{
    class controle
    {

        public string nfila { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }

        public void cadastro()
        {
  
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo:");
            sexo = Console.ReadLine();

        }

        public void delete()
        {
            Console.WriteLine("\n Digite o número da fila de quem você deseja excluir:");
            nfila = Console.ReadLine();
        }

        public void atualizar()
        {
            Console.Clear();

            Console.WriteLine("\n Digite o número da fila de quem você deseja atualizar um dado:");
            nfila = Console.ReadLine();

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo:");
            sexo = Console.ReadLine();

        }
    }
}