using System;
using System.Collections;
using System.Collections.Generic;
using MySqlConnector;
using hermanosMVC.Models;

namespace hermanosMVC.Models
{
    public class MensagemRepository
    {

        private const string DadosConexao = "DataBase=hermanos; DataSource=localhost; User Id=root;";

        public void Enviar (Mensagem mensagem)
        {
            
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            //Esse método recebe atributos chamado "DadosConexao", para criar conexão entre o meu .netcore com o banco de dados MySql
            

            Conexao.Open();
            //Abre conexão

            String Query = "INSERT INTO faleconosco (Nome, Email, Texto) VALUES (@Nome, @Email, @Texto)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            //Comando que ta dentro da variável "Query" que será usado dentro do banco de dados pela conexão do tipo "Conexao"
            //Por isso se tem dois parâmetros de entrada, um para o comando e outro pra conexão

            Comando.Parameters.AddWithValue("@Nome", mensagem.Nome);
            Comando.Parameters.AddWithValue("@Email", mensagem.Email);
            Comando.Parameters.AddWithValue("@Texto", mensagem.Texto);
            //Não precisa adicionar "Id"
            //Comando que insere dados/valores para manipular o banco de dados automaticamente
            //Faz uma tratativa para associar o Id recebido na View como o user.Id
            //Tem que sempre ser colocado no caso de MySqlInjection para proteger, relacionando a View com um objeto do Model

            Comando.ExecuteNonQuery();
            //Executa o objeto "Comando"
            

            Conexao.Close();
            //Fecha conexão
        }

        public List<Mensagem> Listar()
        {
            //Esse método possui no escopo uma List<> invés do void porque ele serve para mostrar as informações desejadas que estão no banco de dados


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            //Esse método recebe atributos chamado "DadosConexao", para criar conexão entre o meu .netcore com o banco de dados MySql
            

            Conexao.Open();
            //Abre conexão

            String Query = "SELECT * FROM faleconosco";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            //Comando que ta dentro da variável "Query" que será usado dentro do banco de dados pela conexão do tipo "Conexao"
            //Por isso se tem dois parâmetros de entrada, um para o comando e outro pra conexão

            MySqlDataReader Reader = Comando.ExecuteReader();
            //Comando para percorrer os registros do usuário

            List<Mensagem> Lista = new List<Mensagem>(); 

            while(Reader.Read())
            {
                Mensagem mensagem = new Mensagem();
                mensagem.Id = Reader.GetInt32("Id");

                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                //Trativa para usar nos campos do tipo String, para que caso o valor seja NULL retorne em branco ao invés de "NULL"
                    mensagem.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    mensagem.Email = Reader.GetString("Email");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Texto")))
                    mensagem.Texto = Reader.GetString("Texto");
                    
                Lista.Add(mensagem);
            }

            Conexao.Close();
            //Fecha conexão

            return Lista;
        }

        
    }
}