using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLE_COMERCIAL
{
    public partial class Usuario_Menu : Form
    {
        public Usuario_Menu()
        {
            InitializeComponent();
        }

        private void Mst_CadastroUsuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_Cadastro viajar = new Usuario_Cadastro();
            viajar.Show();
        }

        private void registrarOcorrenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_Ocorrencia viajar = new Usuario_Ocorrencia();
            viajar.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acompanhamentoOcorrenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario_Acompanhamento viajar = new Usuario_Acompanhamento();
            viajar.Show();
        }
    }
}
