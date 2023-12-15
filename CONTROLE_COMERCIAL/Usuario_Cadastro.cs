using BCrypt.Net;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;

namespace CONTROLE_COMERCIAL
{
    public partial class Usuario_Cadastro : Form
    {
        public Usuario_Cadastro()
        {
            InitializeComponent();
        }

        private void Txt_Nome_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nome = Txt_Nome_Usuario.Text;
            string aniversario = Date_Aniver.Text;
            string cargo = Cbx_Cargo.Text;
            string setor = Cbx_Setor.Text;
            string empresa = Cbx_Empresa.Text;
            string ramal = Txb_Ramal.Text;
            string telefone = Txb_Telefone.Text;
            string email = Tbx_Email.Text;
            string senha = Tbx_Senha.Text;

            #region Logica de dados 'Nome'
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Campo 'Nome Usuario' obrigatorio");
                return;
            }

            if (!nome.All(char.IsLetter))
            {
                MessageBox.Show("Campo 'Nome Usuario' so aceita letras");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Campo 'Cargo' obrigatorio");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(setor))
            {
                MessageBox.Show("Campo 'Setor' obrigatorio");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(empresa))
            {
                MessageBox.Show("Campo 'Empresa' obrigatorio");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(ramal))
            {
                MessageBox.Show("Campo 'Ramal' obrigatorio");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Campo 'Telefone' obrigatorio");
                return;
            }
            #endregion

            #region
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Campo 'Senha' obrigatorio");
                return;
            }
            #endregion

            #region 
            try
            {
                new MailAddress(email);
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo 'E-mail' digitado incorreto.");
                return;
            }
            #endregion

            #region
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            string senhahash = BCrypt.Net.BCrypt.HashPassword(senha, salt);
            #endregion

            Conexao_Client connection = new Conexao_Client();

            var cone = connection.CriarConexao();

            string comando = "INSERT INTO RNC_CADASTRO_USUARIO(Nome, Aniversario, Cargo, Setor, Empresa, Ramal, Telefone, Email, Senha, Salt, [Senha Hash]) VALUES('" + nome + "', '" + aniversario + "', '" + cargo + "', '" + setor + "', '" + empresa + "', '" + ramal + "', '" + telefone + "', '" + email + "', '" + senha + "', '" + salt + "', '" + senhahash + "')";

            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário" + ex.Message);
            }
        }

        private void Tbx_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario_Menu viajar = new Usuario_Menu();

            viajar.Show();

            this.Hide();
        }

        #region Processo de limpeza dos campos
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Nome_Usuario.Clear();
            Cbx_Cargo.SelectedIndex = -1;
            Cbx_Empresa.SelectedIndex = -1;
            Cbx_Setor.SelectedIndex = -1;
            Txb_Ramal.Clear();
            Txb_Telefone.Clear();
            Tbx_Email.Clear();
            Tbx_Senha.Clear();
        }
        #endregion
    }
}