using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fila_DES
{

    class Program
    {
        static void Main(string[] args)
        {

            DAO daoo;
            controle con = new controle();

            int opcao = 1;
            while (opcao != 0)
            {
                daoo = new DAO();
                Console.Clear();
                Console.WriteLine("Olá, seja bem-vindo!\nEscolha umas das seguintes opções:");
                Console.WriteLine("\n1 - Cadastrar");
                Console.WriteLine("2 - Visualizar fila");
                Console.WriteLine("3 - Excluir pessoa");
                Console.WriteLine("4 - Alterar informção");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Clear();

                    con.cadastro();
                    daoo.insert(con);

                    Console.ReadKey();


                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    DAO pDAO = new DAO();
                    pDAO.consultar();

                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    Console.Clear();

                    con.delete();
                    daoo.delete(con);

                    Console.ReadKey();
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.WriteLine("--- Alterar dado ----");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida");
                    Console.ReadKey();
                }

            }

            Console.ReadKey();
        }
    }
}