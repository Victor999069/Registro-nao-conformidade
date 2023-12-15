using System.Data.SqlClient;

namespace CONTROLE_COMERCIAL
{
    public class Conexao_Client
    {
        string conectar = "Data Source=VICTOR-PC;DataBase=RNC_IMG;Integrated Security=True";

        public SqlConnection CriarConexao()
        {
            SqlConnection conexao = new SqlConnection(conectar);
            conexao.Open();
            return conexao;
        }
    }
}