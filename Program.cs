using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilaDES
{

    class Program
    {
        static void Main(string[] args)
        {
            

            controle C = new controle();
            
            int opcao = 1;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Olá, seja bem-vindo!\nEscolha umas das seguintes opções:");
                Console.WriteLine("\n1 - Cadastrar");
                Console.WriteLine("2 - Visualizar fila");
                Console.WriteLine("3 - Excluir pessoa");
                Console.WriteLine("4 - Alterar dado");
                Console.WriteLine("0 - Sair");
                
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.Clear();

                    C.cadastrar();
                   // pDAO.cadastrar();

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
                    Console.WriteLine("--- Excluir pessoa ---");
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