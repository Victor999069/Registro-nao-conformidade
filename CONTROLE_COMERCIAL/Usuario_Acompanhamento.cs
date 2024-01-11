using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CONTROLE_COMERCIAL
{
    public partial class Usuario_Acompanhamento : Form
    {

        public Usuario_Acompanhamento()
        {
            InitializeComponent();
        }

        private void Smi_Voltar_Acompanhamento_Click(object sender, EventArgs e)
        {
            Usuario_Menu viajar = new Usuario_Menu();

            viajar.Show();

            this.Hide();
        }

        private void Lstv_Acompanhamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Acompanhamento_Load(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            Conexao_Client connection = new Conexao_Client();

            var cone = connection.CriarConexao();

            string query = "SELECT * FROM RNC_CADASTRO_OCORRENCIA";


            SqlDataAdapter adapter = new SqlDataAdapter(query, cone);

            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);

                DataGridViewComboBoxColumn checkBoxColumn = new DataGridViewComboBoxColumn();

                checkBoxColumn.Name = "Status";
                checkBoxColumn.HeaderText = "Status Ocorrência";

                checkBoxColumn.DataPropertyName = "Staus Ocorrencia";

                dataGridView1.Columns.Add(checkBoxColumn);

                dataGridView1.DataSource = dt;
                #region
                dataGridView1.Columns["RNC N"].HeaderText = "Nº RNC";
                dataGridView1.Columns["Responsavel"].HeaderText = "Responsável";
                dataGridView1.Columns["Data Ocorrencia"].HeaderText = "Data Ocorrência";
                dataGridView1.Columns["Reincidencia"].HeaderText = "Reincidência";
                dataGridView1.Columns["N Pedido"].HeaderText = "Nº Pedido";
                dataGridView1.Columns["N Nota Fiscal"].HeaderText = "Nº Nota Fiscal";
                dataGridView1.Columns["Referencia"].HeaderText = "Referência";
                dataGridView1.Columns["Status Ocorrencia"].HeaderText = "Status Iniciado";
                dataGridView1.Columns["Categoria Ocorrencia"].HeaderText = "Categoria Ocorrência";
                dataGridView1.Columns["Tipo Ocorrencia"].HeaderText = "Tipo Ocorrência";
                dataGridView1.Columns["Dados Observacao"].HeaderText = "Dados Observação";
                #endregion
                #region
                dataGridView1.Columns["Id Registro"].Visible = false;

                dataGridView1.Columns["RNC N"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Responsavel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Data Ocorrencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Reincidencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["N Pedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["N Nota Fiscal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Referencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Tamanho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Status Ocorrencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Setor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Origem Rnc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Categoria Ocorrencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Tipo Ocorrencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Dados Observacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Lote"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["RNC N"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Responsavel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Data Ocorrencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Reincidencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["N Pedido"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["N Nota Fiscal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Referencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Tamanho"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Status Ocorrencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Setor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Origem Rnc"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Categoria Ocorrencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Tipo Ocorrencia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Dados Observacao"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Lote"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                #endregion

                int statusIndex = dataGridView1.Columns["Status"].DisplayIndex;
                int statusocorrenIndex = dataGridView1.Columns["Status Ocorrencia"].DisplayIndex;

                dataGridView1.Columns["Status Ocorrencia"].DisplayIndex = statusIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados: " + ex.Message);
            }
            finally
            {
                cone.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Estrutura que repassa as opções para atualizar.
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell cell = dataGridView1.Rows[e.RowIndex].Cells["Status"] as DataGridViewComboBoxCell;
                if (cell != null)
                {
                    cell.Items.Clear();

                    cell.Items.AddRange("Iniciado", "Suspenso", "Transferido", "Finalizado");
                }
            }
        }
        //Estrutura que atualiza o status de acordo com o input do usuario
        private async void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dev = dataGridView1.SelectedRows[0];

                if (dev.Cells["Status"].Value != null && dev.Cells["Status"].Value is string)
                {
                    string status = dev.Cells["Status"].Value as string;

                    await Task.Run(() => AtualizarBancoDeDados(status, dev));
                }
                else
                {
                    MessageBox.Show("Selecione uma linha.");
                }
            }
        }

        //Estrutura de rota para salvar a mudança realizada do status
        private void AtualizarBancoDeDados(string status, DataGridViewRow dev)
        {
            Conexao_Client connection = new Conexao_Client();

            var cone = connection.CriarConexao();

            string update = "UPDATE RNC_CADASTRO_OCORRENCIA SET [Status Ocorrencia] = '" + status + "' WHERE [Id Registro] = " + dev.Cells["Id Registro"].Value;

            try
            {
                SqlCommand command = new SqlCommand(update, cone);

                command.ExecuteNonQuery();

                dev.Cells["Status Ocorrencia"].Value = status;

                MessageBox.Show("Atualização realizada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar registro: " + ex.Message);
            }
        }

        private void Txb_BuscarOcorrencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
