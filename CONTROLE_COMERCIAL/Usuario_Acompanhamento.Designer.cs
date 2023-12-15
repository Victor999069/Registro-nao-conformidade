namespace CONTROLE_COMERCIAL
{
    partial class Usuario_Acompanhamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Acompanhamento));
            menuStrip1 = new MenuStrip();
            Smi_Voltar_Acompanhamento = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            conexaoClientBindingSource1 = new BindingSource(components);
            conexaoClientBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Txb_BuscarOcorrencia = new TextBox();
            Lbl_BuscarOcorrencia = new Label();
            Dtp_PesquisaInicial = new DateTimePicker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conexaoClientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Smi_Voltar_Acompanhamento, atualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 44);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // Smi_Voltar_Acompanhamento
            // 
            Smi_Voltar_Acompanhamento.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Smi_Voltar_Acompanhamento.Image = (Image)resources.GetObject("Smi_Voltar_Acompanhamento.Image");
            Smi_Voltar_Acompanhamento.Name = "Smi_Voltar_Acompanhamento";
            Smi_Voltar_Acompanhamento.Size = new Size(54, 40);
            Smi_Voltar_Acompanhamento.Text = "Voltar";
            Smi_Voltar_Acompanhamento.TextAlign = ContentAlignment.TopCenter;
            Smi_Voltar_Acompanhamento.TextImageRelation = TextImageRelation.ImageAboveText;
            Smi_Voltar_Acompanhamento.Click += Smi_Voltar_Acompanhamento_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            atualizarToolStripMenuItem.Image = (Image)resources.GetObject("atualizarToolStripMenuItem.Image");
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(72, 40);
            atualizarToolStripMenuItem.Text = "Atualizar";
            atualizarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            atualizarToolStripMenuItem.Click += atualizarToolStripMenuItem_Click;
            // 
            // conexaoClientBindingSource1
            // 
            conexaoClientBindingSource1.DataSource = typeof(Conexao_Client);
            // 
            // conexaoClientBindingSource
            // 
            conexaoClientBindingSource.DataSource = typeof(Conexao_Client);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 317);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Txb_BuscarOcorrencia
            // 
            Txb_BuscarOcorrencia.Location = new Point(170, 72);
            Txb_BuscarOcorrencia.Name = "Txb_BuscarOcorrencia";
            Txb_BuscarOcorrencia.Size = new Size(125, 27);
            Txb_BuscarOcorrencia.TabIndex = 3;
            Txb_BuscarOcorrencia.TextChanged += Txb_BuscarOcorrencia_TextChanged;
            // 
            // Lbl_BuscarOcorrencia
            // 
            Lbl_BuscarOcorrencia.AutoSize = true;
            Lbl_BuscarOcorrencia.Location = new Point(33, 75);
            Lbl_BuscarOcorrencia.Name = "Lbl_BuscarOcorrencia";
            Lbl_BuscarOcorrencia.Size = new Size(131, 20);
            Lbl_BuscarOcorrencia.TabIndex = 4;
            Lbl_BuscarOcorrencia.Text = "Buscar Ocorrência:";
            // 
            // Dtp_PesquisaInicial
            // 
            Dtp_PesquisaInicial.Location = new Point(384, 73);
            Dtp_PesquisaInicial.Name = "Dtp_PesquisaInicial";
            Dtp_PesquisaInicial.Size = new Size(158, 27);
            Dtp_PesquisaInicial.TabIndex = 5;
            // 
            // Usuario_Acompanhamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(Dtp_PesquisaInicial);
            Controls.Add(Lbl_BuscarOcorrencia);
            Controls.Add(Txb_BuscarOcorrencia);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Usuario_Acompanhamento";
            Text = "Usuario_Acompanhamento";
            Load += Usuario_Acompanhamento_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conexaoClientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Smi_Voltar_Acompanhamento;
        private BindingSource conexaoClientBindingSource1;
        private BindingSource conexaoClientBindingSource;
        private DataGridView dataGridView1;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private TextBox Txb_BuscarOcorrencia;
        private Label Lbl_BuscarOcorrencia;
        private DateTimePicker Dtp_PesquisaInicial;
    }
}