using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace FilaDES
{
    class controle
    {
        public string nfila;
        public string nome;
        public string idade;
        public string sexo;

        public void cadastrar()
        {
            Console.WriteLine("N° Fila:");
            nfila = Console.ReadLine();

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            idade = Console.ReadLine();

            Console.WriteLine("Sexo:");
            sexo = Console.ReadLine();

        }
    }
}