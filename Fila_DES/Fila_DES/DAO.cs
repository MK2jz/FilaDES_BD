using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fila_DES
{
    class DAO
    {
        public MySqlConnection conexao;
        public MySqlCommand cmd;

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

        public void insert (controle C)
        {
            
            String sql = "insert into controle (nome, idade, sexo) values(@nome, @idade, @sexo)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", C.nome);
            cmd.Parameters.AddWithValue("@Idade", C.idade);
            cmd.Parameters.AddWithValue("@Sexo", C.sexo);
            cmd.ExecuteNonQuery();
            Console.WriteLine("\nCadastro efetuado!");
            
        }

        public void delete(controle P)
        {
            Console.Clear();

            String sql = "DELETE from paciente where nfila=@nfila";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nfila", P.nfila);
            cmd.ExecuteNonQuery();
            Console.Clear();
            Console.WriteLine("\nPessoa deletada!");
            Console.ReadKey();
            conexao.Close();
        }

    }
}