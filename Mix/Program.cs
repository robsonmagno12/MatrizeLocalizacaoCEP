using Mix.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Mix
{
    class Program
    {
        static void Main(string[] args)
        {

            string cep = Console.ReadLine();
            string result = string.Empty;

            if (cep.Length > 8)
            {
                Console.WriteLine("CEP Inválido");

                cep = Console.ReadLine();
            }

            if (cep is null || cep.Length > 8 || cep.Length < 8)
            {
                Console.WriteLine("CEP Inválido");
            }

            MySqlConnection obj = new MySqlConnection("server=localhost;database=cep;user=root;password=1234");
            obj.Open();
           string query = "INSERT INTO cep (cep, logradouro, complemento, bairro,localidade,uf,unidade,ibge,gia)" +
                " VALUES (null,?,?,?,?,?,?,?,?,?)";
           

            ViaCEPServicoController servicoController = new ViaCEPServicoController();
            servicoController.ToString();

            MySqlConnection connection = new MySqlConnection("server=localhost;database=cep;user=root;password=1234");
            MySqlCommand MysqlCommand = new MySqlCommand(query, connection);

            MysqlCommand.CommandType = CommandType.Text;

            try
            {
               
                connection.Open();

                MysqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            MysqlCommand.Dispose();
            connection.Close();
            connection.Dispose();


            Console.WriteLine("Deseja visualizar todos os CEPs alguma UF? Se sim, informar UF, se não, informar sair.");
            string resposta = Console.ReadLine();

            if (resposta == "sair")
            {
                return;
            }

            if (resposta.Length > 2)
            {
                Console.WriteLine("UF inválida");
                resposta = Console.ReadLine();
            }

            if (resposta == "sair")
            {
                return;
            }



            connection = new MySqlConnection("server=localhost;database=cep;user=root;password=1234");
            MysqlCommand = new MySqlCommand("Select * from cep", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            DataView dv;
            MysqlCommand.CommandType = CommandType.Text;

            try
            {
                connection.Open();
                adapter.SelectCommand = MysqlCommand;
                adapter.Fill(ds, "Create DataView");
                adapter.Dispose();

                dv = ds.Tables[0].DefaultView;

                for (int i = 0; i < dv.Count; i++)
                {
                    if (dv[i]["uf"].ToString() == resposta)
                    {
                        if (i == 0)
                        {
                            Console.Write(dv[i]["cep"]);
                        }
                        else
                        {
                            Console.Write(";" + dv[i]["cep"]);
                        }
                    }
                }
            }
                finally
                {
                    connection.Close();
                }

                MysqlCommand.Dispose();
                connection.Close();
                connection.Dispose();

                Console.ReadLine();
             }
            }
 
}
    

