using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FilaDES
{
    class DAO
    {
        public MySqlConnection conexao;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;database=fila;uid=root;password=;");
            try
            {
                conexao.Open();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao acessar o banco de dados, contate o desenvolvedor!");
             // Environment.Exit(0);
                Console.ReadKey();
            }
        }

        public void consultar()
        {
            String sql = "select * from controle";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("\nN° Fila: {0} | Nome: {1} | Idade: {2} | Sexo: {3}", rdr["nfila"], rdr["nome"], rdr["idade"], rdr["sexo"]);
            }
            Console.ReadKey();
        }

        /*public void cadastrar()
        {
            insert into controle values ()
            sql = "insert into controle values (null, @nome, @idade, @sexo)";
            cmd = new MySqlCommand(sql, conexao);
            
            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Cadastrado com Sucesso");
                Console.ReadLine();
            }
        }*/



    }
}