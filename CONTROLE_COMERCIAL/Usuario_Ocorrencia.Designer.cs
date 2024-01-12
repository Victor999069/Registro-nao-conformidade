namespace CONTROLE_COMERCIAL
{
    partial class Usuario_Ocorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Ocorrencia));
            Lbl_TipoOcorren = new Label();
            menuStrip1 = new MenuStrip();
            Tsm_Ocorrencia_Cadastro = new ToolStripMenuItem();
            Tsm_Salvar_Ocorerncia = new ToolStripMenuItem();
            cancelarToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            Cbx_TipoOcorre = new ComboBox();
            Lbl_CategoriaOcorrencia = new Label();
            Cbx_Categoria = new ComboBox();
            Lbl_DataOcorre = new Label();
            Dtp_RegistroOcorrencia = new DateTimePicker();
            Lbl_Status = new Label();
            Cbx_StatusOcorre = new ComboBox();
            Lbl_Pedido = new Label();
            Tbx_Pedido = new TextBox();
            Lbl_Nota = new Label();
            Tbx_Nota = new TextBox();
            Lbl_n_ocorrencia = new Label();
            Txb_n_ocorrencia = new TextBox();
            Lbl_Setor = new Label();
            Cbx_Setor = new ComboBox();
            Lbl_Origem = new Label();
            Cbx_Origem = new ComboBox();
            Lbl_Reincidencia = new Label();
            Cbx_Reincidencia = new ComboBox();
            Lbl_Responsavel = new Label();
            txb_Responsavel = new TextBox();
            panel1 = new Panel();
            Txb_lote_ocorrencia = new TextBox();
            Lbl_lote = new Label();
            Cbx_Tamanho = new ComboBox();
            Lbl_Tamanho = new Label();
            Txb_Ref = new TextBox();
            Lbl_Referencia = new Label();
            Lbl_Titulo = new Label();
            panel2 = new Panel();
            Txt_observacao = new TextBox();
            Lbl_OBS = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_TipoOcorren
            // 
            Lbl_TipoOcorren.AutoSize = true;
            Lbl_TipoOcorren.BorderStyle = BorderStyle.Fixed3D;
            Lbl_TipoOcorren.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_TipoOcorren.Location = new Point(418, 252);
            Lbl_TipoOcorren.Name = "Lbl_TipoOcorren";
            Lbl_TipoOcorren.Size = new Size(143, 21);
            Lbl_TipoOcorren.TabIndex = 0;
            Lbl_TipoOcorren.Text = "Tipo Ocorrencia:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Tsm_Ocorrencia_Cadastro, Tsm_Salvar_Ocorerncia, cancelarToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 44);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Ocorrencia_Cadastro
            // 
            Tsm_Ocorrencia_Cadastro.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tsm_Ocorrencia_Cadastro.Image = (Image)resources.GetObject("Tsm_Ocorrencia_Cadastro.Image");
            Tsm_Ocorrencia_Cadastro.Name = "Tsm_Ocorrencia_Cadastro";
            Tsm_Ocorrencia_Cadastro.Size = new Size(49, 40);
            Tsm_Ocorrencia_Cadastro.Text = "Novo";
            Tsm_Ocorrencia_Cadastro.TextImageRelation = TextImageRelation.ImageAboveText;
            Tsm_Ocorrencia_Cadastro.Click += Tsm_Ocorrencia_Cadastro_Click;
            // 
            // Tsm_Salvar_Ocorerncia
            // 
            Tsm_Salvar_Ocorerncia.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tsm_Salvar_Ocorerncia.Image = (Image)resources.GetObject("Tsm_Salvar_Ocorerncia.Image");
            Tsm_Salvar_Ocorerncia.ImageAlign = ContentAlignment.TopCenter;
            Tsm_Salvar_Ocorerncia.Name = "Tsm_Salvar_Ocorerncia";
            Tsm_Salvar_Ocorerncia.Size = new Size(56, 40);
            Tsm_Salvar_Ocorerncia.Text = "Salvar";
            Tsm_Salvar_Ocorerncia.TextAlign = ContentAlignment.BottomCenter;
            Tsm_Salvar_Ocorerncia.TextImageRelation = TextImageRelation.ImageAboveText;
            Tsm_Salvar_Ocorerncia.Click += Tsm_Salvar_Ocorerncia_Click;
            // 
            // cancelarToolStripMenuItem
            // 
            cancelarToolStripMenuItem.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cancelarToolStripMenuItem.Image = (Image)resources.GetObject("cancelarToolStripMenuItem.Image");
            cancelarToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            cancelarToolStripMenuItem.Size = new Size(60, 40);
            cancelarToolStripMenuItem.Text = "Limpar";
            cancelarToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            cancelarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            cancelarToolStripMenuItem.Click += cancelarToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            voltarToolStripMenuItem.Image = (Image)resources.GetObject("voltarToolStripMenuItem.Image");
            voltarToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(54, 40);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            voltarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // Cbx_TipoOcorre
            // 
            Cbx_TipoOcorre.FormattingEnabled = true;
            Cbx_TipoOcorre.Items.AddRange(new object[] { "Peça Avariada", "Peça Despadronizada", "Peça em Tamanho Divergente", "Peça com Etiqueta Trocada", "Entrega Atrasada", "Envio Divergente", "Pedido Duplicado", "Problema em Sistema", "Pedido Faltando Peça", "Troca de Peça", "Falha no processo", "Medida Especial Não Informada" });
            Cbx_TipoOcorre.Location = new Point(559, 249);
            Cbx_TipoOcorre.MaxDropDownItems = 10;
            Cbx_TipoOcorre.Name = "Cbx_TipoOcorre";
            Cbx_TipoOcorre.Size = new Size(232, 28);
            Cbx_TipoOcorre.TabIndex = 10;
            // 
            // Lbl_CategoriaOcorrencia
            // 
            Lbl_CategoriaOcorrencia.AutoSize = true;
            Lbl_CategoriaOcorrencia.BorderStyle = BorderStyle.Fixed3D;
            Lbl_CategoriaOcorrencia.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_CategoriaOcorrencia.Location = new Point(33, 305);
            Lbl_CategoriaOcorrencia.Name = "Lbl_CategoriaOcorrencia";
            Lbl_CategoriaOcorrencia.Size = new Size(185, 21);
            Lbl_CategoriaOcorrencia.TabIndex = 4;
            Lbl_CategoriaOcorrencia.Text = "Categoria Ocorrencia:";
            // 
            // Cbx_Categoria
            // 
            Cbx_Categoria.FormattingEnabled = true;
            Cbx_Categoria.Items.AddRange(new object[] { "Não Conformidade", "Reclamação Cliente Interno", "Reclamação Cliente Externo", "Falha de Comunicação", "Tecnologia", "Infraestrutura" });
            Cbx_Categoria.Location = new Point(216, 301);
            Cbx_Categoria.Name = "Cbx_Categoria";
            Cbx_Categoria.Size = new Size(210, 28);
            Cbx_Categoria.TabIndex = 7;
            // 
            // Lbl_DataOcorre
            // 
            Lbl_DataOcorre.AutoSize = true;
            Lbl_DataOcorre.BorderStyle = BorderStyle.Fixed3D;
            Lbl_DataOcorre.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_DataOcorre.Location = new Point(323, 76);
            Lbl_DataOcorre.Name = "Lbl_DataOcorre";
            Lbl_DataOcorre.Size = new Size(145, 21);
            Lbl_DataOcorre.TabIndex = 6;
            Lbl_DataOcorre.Text = "Data Ocorrencia:";
            // 
            // Dtp_RegistroOcorrencia
            // 
            Dtp_RegistroOcorrencia.Location = new Point(466, 72);
            Dtp_RegistroOcorrencia.Name = "Dtp_RegistroOcorrencia";
            Dtp_RegistroOcorrencia.Size = new Size(124, 27);
            Dtp_RegistroOcorrencia.TabIndex = 8;
            // 
            // Lbl_Status
            // 
            Lbl_Status.AutoSize = true;
            Lbl_Status.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Status.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Status.Location = new Point(33, 245);
            Lbl_Status.Name = "Lbl_Status";
            Lbl_Status.Size = new Size(160, 21);
            Lbl_Status.TabIndex = 8;
            Lbl_Status.Text = "Status Ocorrencia:";
            // 
            // Cbx_StatusOcorre
            // 
            Cbx_StatusOcorre.FormattingEnabled = true;
            Cbx_StatusOcorre.ItemHeight = 20;
            Cbx_StatusOcorre.Items.AddRange(new object[] { "Iniciado", "Suspenso", "Transferido", "Finalizado" });
            Cbx_StatusOcorre.Location = new Point(190, 241);
            Cbx_StatusOcorre.Name = "Cbx_StatusOcorre";
            Cbx_StatusOcorre.Size = new Size(109, 28);
            Cbx_StatusOcorre.TabIndex = 4;
            // 
            // Lbl_Pedido
            // 
            Lbl_Pedido.AutoSize = true;
            Lbl_Pedido.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Pedido.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Pedido.Location = new Point(21, 133);
            Lbl_Pedido.Name = "Lbl_Pedido";
            Lbl_Pedido.Size = new Size(94, 21);
            Lbl_Pedido.TabIndex = 12;
            Lbl_Pedido.Text = "Nº Pedido:";
            // 
            // Tbx_Pedido
            // 
            Tbx_Pedido.Location = new Point(111, 129);
            Tbx_Pedido.Name = "Tbx_Pedido";
            Tbx_Pedido.Size = new Size(74, 27);
            Tbx_Pedido.TabIndex = 2;
            // 
            // Lbl_Nota
            // 
            Lbl_Nota.AutoSize = true;
            Lbl_Nota.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Nota.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Nota.Location = new Point(187, 131);
            Lbl_Nota.Name = "Lbl_Nota";
            Lbl_Nota.Size = new Size(77, 21);
            Lbl_Nota.TabIndex = 14;
            Lbl_Nota.Text = "Nº Nota:";
            // 
            // Tbx_Nota
            // 
            Tbx_Nota.Location = new Point(259, 127);
            Tbx_Nota.Name = "Tbx_Nota";
            Tbx_Nota.Size = new Size(81, 27);
            Tbx_Nota.TabIndex = 3;
            // 
            // Lbl_n_ocorrencia
            // 
            Lbl_n_ocorrencia.AutoSize = true;
            Lbl_n_ocorrencia.BorderStyle = BorderStyle.Fixed3D;
            Lbl_n_ocorrencia.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_n_ocorrencia.Location = new Point(655, 18);
            Lbl_n_ocorrencia.Name = "Lbl_n_ocorrencia";
            Lbl_n_ocorrencia.Size = new Size(76, 21);
            Lbl_n_ocorrencia.TabIndex = 16;
            Lbl_n_ocorrencia.Text = "RNC Nº:";
            // 
            // Txb_n_ocorrencia
            // 
            Txb_n_ocorrencia.Location = new Point(732, 14);
            Txb_n_ocorrencia.Name = "Txb_n_ocorrencia";
            Txb_n_ocorrencia.Size = new Size(59, 27);
            Txb_n_ocorrencia.TabIndex = 0;
            Txb_n_ocorrencia.TextChanged += Txb_n_ocorrencia_TextChanged;
            // 
            // Lbl_Setor
            // 
            Lbl_Setor.AutoSize = true;
            Lbl_Setor.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Setor.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Setor.Location = new Point(306, 245);
            Lbl_Setor.Name = "Lbl_Setor";
            Lbl_Setor.Size = new Size(60, 21);
            Lbl_Setor.TabIndex = 18;
            Lbl_Setor.Text = "Setor:";
            // 
            // Cbx_Setor
            // 
            Cbx_Setor.FormattingEnabled = true;
            Cbx_Setor.Items.AddRange(new object[] { "Comercial", "Corte", "Desenvolvimento", "Diretoria", "Expedição", "Financeiro", "Produção", "Pcp", "Qualidade" });
            Cbx_Setor.Location = new Point(365, 241);
            Cbx_Setor.Name = "Cbx_Setor";
            Cbx_Setor.Size = new Size(159, 28);
            Cbx_Setor.TabIndex = 5;
            // 
            // Lbl_Origem
            // 
            Lbl_Origem.AutoSize = true;
            Lbl_Origem.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Origem.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Origem.Location = new Point(531, 245);
            Lbl_Origem.Name = "Lbl_Origem";
            Lbl_Origem.Size = new Size(115, 21);
            Lbl_Origem.TabIndex = 20;
            Lbl_Origem.Text = "Origem RNC:";
            // 
            // Cbx_Origem
            // 
            Cbx_Origem.FormattingEnabled = true;
            Cbx_Origem.Items.AddRange(new object[] { "Produção", "Comercial", "Expedição", "Financeiro", "Desenvolvimento", "Corte", "Pcp", "Sistema de ERP", "Diretoria", "Qualidade", "Fornecedor", "Auditoria Externa", "Auditoria Interna", "Produto", "Cliente", "Logística" });
            Cbx_Origem.Location = new Point(644, 241);
            Cbx_Origem.Name = "Cbx_Origem";
            Cbx_Origem.Size = new Size(161, 28);
            Cbx_Origem.TabIndex = 6;
            // 
            // Lbl_Reincidencia
            // 
            Lbl_Reincidencia.AutoSize = true;
            Lbl_Reincidencia.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Reincidencia.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Reincidencia.Location = new Point(597, 75);
            Lbl_Reincidencia.Name = "Lbl_Reincidencia";
            Lbl_Reincidencia.Size = new Size(116, 21);
            Lbl_Reincidencia.TabIndex = 22;
            Lbl_Reincidencia.Text = "Reincidência:";
            // 
            // Cbx_Reincidencia
            // 
            Cbx_Reincidencia.FormattingEnabled = true;
            Cbx_Reincidencia.Items.AddRange(new object[] { "Sim", "Não" });
            Cbx_Reincidencia.Location = new Point(711, 72);
            Cbx_Reincidencia.MaxDropDownItems = 9;
            Cbx_Reincidencia.Name = "Cbx_Reincidencia";
            Cbx_Reincidencia.Size = new Size(80, 28);
            Cbx_Reincidencia.TabIndex = 9;
            // 
            // Lbl_Responsavel
            // 
            Lbl_Responsavel.AutoSize = true;
            Lbl_Responsavel.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Responsavel.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Responsavel.Location = new Point(33, 129);
            Lbl_Responsavel.Name = "Lbl_Responsavel";
            Lbl_Responsavel.Size = new Size(117, 21);
            Lbl_Responsavel.TabIndex = 24;
            Lbl_Responsavel.Text = "Responsavel:";
            // 
            // txb_Responsavel
            // 
            txb_Responsavel.Location = new Point(147, 125);
            txb_Responsavel.Name = "txb_Responsavel";
            txb_Responsavel.Size = new Size(183, 27);
            txb_Responsavel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Txb_lote_ocorrencia);
            panel1.Controls.Add(Lbl_lote);
            panel1.Controls.Add(Cbx_Tamanho);
            panel1.Controls.Add(Lbl_Tamanho);
            panel1.Controls.Add(Txb_Ref);
            panel1.Controls.Add(Cbx_Reincidencia);
            panel1.Controls.Add(Lbl_Reincidencia);
            panel1.Controls.Add(Lbl_Referencia);
            panel1.Controls.Add(Lbl_Titulo);
            panel1.Controls.Add(Txb_n_ocorrencia);
            panel1.Controls.Add(Lbl_n_ocorrencia);
            panel1.Controls.Add(Tbx_Pedido);
            panel1.Controls.Add(Lbl_Pedido);
            panel1.Controls.Add(Cbx_TipoOcorre);
            panel1.Controls.Add(Tbx_Nota);
            panel1.Controls.Add(Lbl_TipoOcorren);
            panel1.Controls.Add(Lbl_Nota);
            panel1.Controls.Add(Dtp_RegistroOcorrencia);
            panel1.Controls.Add(Lbl_DataOcorre);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 322);
            panel1.TabIndex = 25;
            // 
            // Txb_lote_ocorrencia
            // 
            Txb_lote_ocorrencia.Location = new Point(585, 127);
            Txb_lote_ocorrencia.Name = "Txb_lote_ocorrencia";
            Txb_lote_ocorrencia.Size = new Size(58, 27);
            Txb_lote_ocorrencia.TabIndex = 29;
            // 
            // Lbl_lote
            // 
            Lbl_lote.AutoSize = true;
            Lbl_lote.BorderStyle = BorderStyle.Fixed3D;
            Lbl_lote.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_lote.Location = new Point(532, 131);
            Lbl_lote.Name = "Lbl_lote";
            Lbl_lote.Size = new Size(52, 21);
            Lbl_lote.TabIndex = 28;
            Lbl_lote.Text = "Lote:";
            // 
            // Cbx_Tamanho
            // 
            Cbx_Tamanho.FormattingEnabled = true;
            Cbx_Tamanho.ItemHeight = 20;
            Cbx_Tamanho.Items.AddRange(new object[] { "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "XPP", "XP", "PP", "P", "M", "G", "GG", "XG", "XGG", "X3G", "ESP" });
            Cbx_Tamanho.Location = new Point(732, 126);
            Cbx_Tamanho.Name = "Cbx_Tamanho";
            Cbx_Tamanho.Size = new Size(59, 28);
            Cbx_Tamanho.TabIndex = 27;
            // 
            // Lbl_Tamanho
            // 
            Lbl_Tamanho.AutoSize = true;
            Lbl_Tamanho.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Tamanho.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Tamanho.Location = new Point(649, 129);
            Lbl_Tamanho.Name = "Lbl_Tamanho";
            Lbl_Tamanho.Size = new Size(88, 21);
            Lbl_Tamanho.TabIndex = 27;
            Lbl_Tamanho.Text = "Tamanho:";
            // 
            // Txb_Ref
            // 
            Txb_Ref.Location = new Point(439, 127);
            Txb_Ref.Name = "Txb_Ref";
            Txb_Ref.Size = new Size(88, 27);
            Txb_Ref.TabIndex = 27;
            // 
            // Lbl_Referencia
            // 
            Lbl_Referencia.AutoSize = true;
            Lbl_Referencia.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Referencia.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Referencia.Location = new Point(344, 131);
            Lbl_Referencia.Name = "Lbl_Referencia";
            Lbl_Referencia.Size = new Size(100, 21);
            Lbl_Referencia.TabIndex = 27;
            Lbl_Referencia.Text = "Referencia:";
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.Location = new Point(3, 2);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(124, 19);
            Lbl_Titulo.TabIndex = 20;
            Lbl_Titulo.Text = "Dados da RNC";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Txt_observacao);
            panel2.Controls.Add(Lbl_OBS);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.ImeMode = ImeMode.NoControl;
            panel2.Location = new Point(12, 399);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 238);
            panel2.TabIndex = 26;
            // 
            // Txt_observacao
            // 
            Txt_observacao.Location = new Point(17, 30);
            Txt_observacao.Multiline = true;
            Txt_observacao.Name = "Txt_observacao";
            Txt_observacao.Size = new Size(781, 190);
            Txt_observacao.TabIndex = 21;
            // 
            // Lbl_OBS
            // 
            Lbl_OBS.AutoSize = true;
            Lbl_OBS.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_OBS.Location = new Point(3, 0);
            Lbl_OBS.Name = "Lbl_OBS";
            Lbl_OBS.Size = new Size(182, 19);
            Lbl_OBS.TabIndex = 20;
            Lbl_OBS.Text = "Dados da Observação";
            // 
            // Usuario_Ocorrencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 662);
            Controls.Add(panel2);
            Controls.Add(txb_Responsavel);
            Controls.Add(Lbl_Responsavel);
            Controls.Add(Cbx_Origem);
            Controls.Add(Lbl_Origem);
            Controls.Add(Cbx_Setor);
            Controls.Add(Lbl_Setor);
            Controls.Add(Cbx_StatusOcorre);
            Controls.Add(Lbl_Status);
            Controls.Add(Cbx_Categoria);
            Controls.Add(Lbl_CategoriaOcorrencia);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Usuario_Ocorrencia";
            Text = "Cadastro Ocorrencia";
            Load += Usuario_Ocorrencia_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_TipoOcorren;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Tsm_Ocorrencia_Cadastro;
        private ToolStripMenuItem Tsm_Salvar_Ocorerncia;
        private ComboBox Cbx_TipoOcorre;
        private Label Lbl_CategoriaOcorrencia;
        private ComboBox Cbx_Categoria;
        private Label Lbl_DataOcorre;
        private DateTimePicker Dtp_RegistroOcorrencia;
        private Label Lbl_Status;
        private ComboBox Cbx_StatusOcorre;
        private Label Lbl_Pedido;
        private TextBox Tbx_Pedido;
        private Label Lbl_Nota;
        private TextBox Tbx_Nota;
        private Label Lbl_n_ocorrencia;
        private TextBox Txb_n_ocorrencia;
        private Label Lbl_Setor;
        private ComboBox Cbx_Setor;
        private Label Lbl_Origem;
        private ComboBox Cbx_Origem;
        private Label Lbl_Reincidencia;
        private ComboBox Cbx_Reincidencia;
        private Label Lbl_Responsavel;
        private TextBox txb_Responsavel;
        private Panel panel1;
        private Label Lbl_Titulo;
        private Panel panel2;
        private TextBox Txt_observacao;
        private Label Lbl_OBS;
        private ComboBox Cbx_Tamanho;
        private Label Lbl_Tamanho;
        private TextBox Txb_Ref;
        private Label Lbl_Referencia;
        private ToolStripMenuItem cancelarToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Label Lbl_lote;
        private TextBox Txb_lote_ocorrencia;
    }
}