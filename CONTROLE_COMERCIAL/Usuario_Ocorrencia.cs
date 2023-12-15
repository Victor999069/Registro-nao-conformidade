using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CONTROLE_COMERCIAL
{
    public partial class Usuario_Ocorrencia : Form
    {
        public Usuario_Ocorrencia()
        {
            InitializeComponent();
        }

        private void Txb_n_ocorrencia_TextChanged(object sender, EventArgs e)
        {

        }

        #region Retorno do numero da RNC + 1
        private void Tsm_Ocorrencia_Cadastro_Click(object sender, EventArgs e)
        {
            int sequencia = BuscandoSequencia();
            int numeroSequencia = sequencia + 1;

            if (numeroSequencia != -1)
            {
                Txb_n_ocorrencia.Text = numeroSequencia.ToString();
            }

        }
        #endregion

        #region Conferencia dos campos e modulo de salvar
        private void Tsm_Salvar_Ocorerncia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txb_n_ocorrencia.Text))
            {
                MessageBox.Show("Gere um novo registro para salvar.");
                return;
            }

            string n_ocorrencia = Txb_n_ocorrencia.Text;
            string responsavel = txb_Responsavel.Text;
            string data_ocorrencia = Dtp_RegistroOcorrencia.Text;
            string reincidencia = Cbx_Reincidencia.Text;
            string n_pedido = Tbx_Pedido.Text;
            string n_nf = Tbx_Nota.Text;
            string referencia = Txb_Ref.Text;
            string tamanho = Cbx_Tamanho.Text;
            string status_ocorrencia = Cbx_StatusOcorre.Text;
            string setor = Cbx_Setor.Text;
            string origem_rnc = Cbx_Origem.Text;
            string categoria_ocorrencia = Cbx_Categoria.Text;
            string tipo_ocorrencia = Cbx_TipoOcorre.Text;
            string dados_Observacao = Txt_observacao.Text;
            string lote = Txb_lote_ocorrencia.Text;

            #region Campo obrigatorio 'Responsavel'
            if (string.IsNullOrWhiteSpace(responsavel))
            {
                MessageBox.Show("Campo responsavel obrigatorio.");
                return;
            }
            #endregion

            #region Conferencia de digito no campo 'Pedido'
            if (!n_pedido.All(char.IsDigit))
            {
                MessageBox.Show("Campo 'Pedido' so aceita numeros.");
                return;
            }
            #endregion

            #region  Conferencia de digito no campo 'Nota'
            if (!n_nf.All(char.IsDigit))
            {
                MessageBox.Show("Campo 'Nº Nota' so aceita numero.");
                return;
            }
            #endregion

            //#region Conferencia de digito no campo 'Lote'
            //if (!lote.All(char.IsDigit))
            //{
            //    MessageBox.Show("Campo 'Lote' so aceita numeros.");
            //    //return;
            //}
            //#endregion

            #region Campo obrigatorio 'Status Ocorrencia'
            if (string.IsNullOrWhiteSpace(status_ocorrencia))
            {
                MessageBox.Show("Campo Status Ocorrencia obrigatorio.");
                return;
            }
            #endregion

            #region Campo obrigatorio 'Setor'
            if (string.IsNullOrWhiteSpace(setor))
            {
                MessageBox.Show("Campo 'Setor' obrigatorio.");
                return;
            }
            #endregion

            #region Campo obrigatorio 'Origem RNC'
            if (string.IsNullOrWhiteSpace(origem_rnc))
            {
                MessageBox.Show("Campo 'Origem RNC' obrigatorio.");
                return;
            }
            #endregion

            #region Campo obrigatorio 'Categoria Ocorrencia'
            if (string.IsNullOrWhiteSpace(categoria_ocorrencia))
            {
                MessageBox.Show("Campo 'Categoria Ocorrencia' obrigatorio.");
                return;
            }
            #endregion

            #region Campo obrigatorio 'Tipo Ocorrencia'
            if (string.IsNullOrWhiteSpace(tipo_ocorrencia))
            {
                MessageBox.Show("Campo 'Tipo Ocorrencia' obrigatorio.");
                return;
            }
            #endregion

            #region salvar Dados
            Conexao_Client connection = new Conexao_Client();

            string comando = "INSERT INTO RNC_CADASTRO_OCORRENCIA([RNC N], Responsavel, [data Ocorrencia], Reincidencia, [N Pedido], [N Nota Fiscal], Referencia, Tamanho, [Status Ocorrencia], Setor, [Origem Rnc], [Categoria Ocorrencia], [Tipo Ocorrencia], [Dados Observacao], Lote) VALUES('" + n_ocorrencia + "', '" + responsavel + "', '" + data_ocorrencia + "', '" + reincidencia + "', '" + n_pedido + "', '" + n_nf + "', '" + referencia + "', '" + tamanho + "', '" + status_ocorrencia + "', '" + setor + "', '" + origem_rnc + "', '" + categoria_ocorrencia + "', '" + tipo_ocorrencia + "', '" + dados_Observacao + "', '" + lote + "')";

            try
            {
                SqlCommand command = new SqlCommand(comando, connection.CriarConexao());

                command.ExecuteNonQuery();

                MessageBox.Show("Rnc registrada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar RNC " + ex.Message);
            }
            #endregion
        }
        #endregion

        #region campo de voltar para menu
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario_Menu viajar = new Usuario_Menu();

            viajar.Show();

            this.Hide();
        }
        #endregion

        #region Load
        private void Usuario_Ocorrencia_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buscar pelo ultimo registro de RNC
        public int BuscandoSequencia()
        {
            Conexao_Client conexao = new Conexao_Client();

            string sql = "SELECT TOP 1 [RNC N] FROM RNC_CADASTRO_OCORRENCIA ORDER BY [RNC N] DESC;";

            SqlCommand command = new SqlCommand(sql, conexao.CriarConexao());

            object result = command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return -1;
        }
        #endregion

        #region Modulo de limpeza dos campos da tela ocorrencia
        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txb_Responsavel.Clear();
            Tbx_Pedido.Clear();
            Tbx_Nota.Clear();
            Txb_n_ocorrencia.Clear();
            Txb_Ref.Clear();
            Txt_observacao.Clear();
            Txb_lote_ocorrencia.Clear();
            Cbx_Reincidencia.SelectedIndex = -1;
            Cbx_Categoria.SelectedIndex = -1;
            Cbx_Origem.SelectedIndex = -1;
            Cbx_Setor.SelectedIndex = -1;
            Cbx_StatusOcorre.SelectedIndex = -1;
            Cbx_Tamanho.SelectedIndex = -1;
            Cbx_TipoOcorre.SelectedIndex = -1;
        }
        #endregion
    }
}
