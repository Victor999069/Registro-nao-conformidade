using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net;

namespace CONTROLE_COMERCIAL
{
    public partial class Usuario_Login : Form
    {
        public Usuario_Login()
        {
            InitializeComponent();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string Email = Tbx_Email.Text;
            string Senha = Txt_Senha.Text;

            Conexao_Client conectar = new Conexao_Client();
            var cone = conectar.CriarConexao();

            string comando = "SELECT COUNT(*) FROM RNC_CADASTRO_USUARIO WHERE Email = @Email AND Senha = @Senha";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(comando, cone))
                {
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlCommand.Parameters.AddWithValue("@Senha", Senha);

                    int count = (int)sqlCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        Usuario_Menu viajar = new Usuario_Menu();
                        viajar.Show();

                        this.Hide();

                        MessageBox.Show("Login realizado!");
                    }
                    else
                    {
                        MessageBox.Show("Login invalido!");
                    }
                }
                cone.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private bool VerificarSenha(string senhaDigitada, string senhahash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(senhaDigitada, senhahash);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Senha errada:" + ex.Message);
                return false;
            }
        }
    }
}
