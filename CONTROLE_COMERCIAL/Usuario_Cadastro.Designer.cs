namespace CONTROLE_COMERCIAL
{
    partial class Usuario_Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Cadastro));
            Txt_Nome_Usuario = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Lbl_Nome = new Label();
            Date_Aniver = new DateTimePicker();
            Lbl_Aniversario = new Label();
            lbl_Setor = new Label();
            Cbx_Setor = new ComboBox();
            Lbl_Cargo = new Label();
            Cbx_Cargo = new ComboBox();
            Lbl_Email = new Label();
            Tbx_Email = new TextBox();
            Lbl_Empresa = new Label();
            Cbx_Empresa = new ComboBox();
            Lbl_Ramal = new Label();
            Txb_Telefone = new MaskedTextBox();
            Lbl_Tel = new Label();
            Txb_Ramal = new MaskedTextBox();
            panel1 = new Panel();
            Lbl_Titulo = new Label();
            panel2 = new Panel();
            Tbx_Senha = new TextBox();
            Lbl_Senha = new Label();
            Lbl_UsuarioAcesso = new Label();
            menuStrip1 = new MenuStrip();
            novoToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            cancelarToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Nome_Usuario
            // 
            Txt_Nome_Usuario.BorderStyle = BorderStyle.FixedSingle;
            Txt_Nome_Usuario.Location = new Point(96, 101);
            Txt_Nome_Usuario.Name = "Txt_Nome_Usuario";
            Txt_Nome_Usuario.Size = new Size(263, 27);
            Txt_Nome_Usuario.TabIndex = 1;
            Txt_Nome_Usuario.TextChanged += Txt_Nome_Usuario_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Nome.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Nome.Location = new Point(32, 103);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(64, 23);
            Lbl_Nome.TabIndex = 3;
            Lbl_Nome.Text = "Nome:";
            // 
            // Date_Aniver
            // 
            Date_Aniver.Location = new Point(467, 101);
            Date_Aniver.Name = "Date_Aniver";
            Date_Aniver.Size = new Size(234, 27);
            Date_Aniver.TabIndex = 2;
            // 
            // Lbl_Aniversario
            // 
            Lbl_Aniversario.AutoSize = true;
            Lbl_Aniversario.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Aniversario.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Aniversario.Location = new Point(363, 103);
            Lbl_Aniversario.Name = "Lbl_Aniversario";
            Lbl_Aniversario.Size = new Size(106, 23);
            Lbl_Aniversario.TabIndex = 5;
            Lbl_Aniversario.Text = "Aniversario:";
            // 
            // lbl_Setor
            // 
            lbl_Setor.AutoSize = true;
            lbl_Setor.BorderStyle = BorderStyle.Fixed3D;
            lbl_Setor.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Setor.Location = new Point(266, 160);
            lbl_Setor.Name = "lbl_Setor";
            lbl_Setor.Size = new Size(60, 23);
            lbl_Setor.TabIndex = 6;
            lbl_Setor.Text = "Setor:";
            // 
            // Cbx_Setor
            // 
            Cbx_Setor.FormattingEnabled = true;
            Cbx_Setor.Items.AddRange(new object[] { "Produção", "Comercial", "Expedição", "Financeiro", "Desenvolvimento", "Corte", "Pcp", "Diretoria", "Qualidade" });
            Cbx_Setor.Location = new Point(323, 157);
            Cbx_Setor.Name = "Cbx_Setor";
            Cbx_Setor.Size = new Size(155, 28);
            Cbx_Setor.TabIndex = 4;
            // 
            // Lbl_Cargo
            // 
            Lbl_Cargo.AutoSize = true;
            Lbl_Cargo.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Cargo.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Cargo.Location = new Point(32, 160);
            Lbl_Cargo.Name = "Lbl_Cargo";
            Lbl_Cargo.Size = new Size(66, 23);
            Lbl_Cargo.TabIndex = 8;
            Lbl_Cargo.Text = "Cargo:";
            // 
            // Cbx_Cargo
            // 
            Cbx_Cargo.FormattingEnabled = true;
            Cbx_Cargo.Items.AddRange(new object[] { "Analista", "Assistente", "Atendente", "Coordenador(a)", "Supervisor(a)", "Gerente", "Diretor(a)", "" });
            Cbx_Cargo.Location = new Point(96, 157);
            Cbx_Cargo.Name = "Cbx_Cargo";
            Cbx_Cargo.Size = new Size(164, 28);
            Cbx_Cargo.TabIndex = 3;
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Email.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Email.Location = new Point(33, 326);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(67, 23);
            Lbl_Email.TabIndex = 10;
            Lbl_Email.Text = "E-mail:";
            // 
            // Tbx_Email
            // 
            Tbx_Email.BorderStyle = BorderStyle.FixedSingle;
            Tbx_Email.Location = new Point(79, 34);
            Tbx_Email.Name = "Tbx_Email";
            Tbx_Email.Size = new Size(266, 27);
            Tbx_Email.TabIndex = 8;
            // 
            // Lbl_Empresa
            // 
            Lbl_Empresa.AutoSize = true;
            Lbl_Empresa.BackColor = SystemColors.Control;
            Lbl_Empresa.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Empresa.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Empresa.ForeColor = SystemColors.ControlText;
            Lbl_Empresa.Location = new Point(484, 160);
            Lbl_Empresa.Name = "Lbl_Empresa";
            Lbl_Empresa.Size = new Size(88, 23);
            Lbl_Empresa.TabIndex = 12;
            Lbl_Empresa.Text = "Empresa:";
            // 
            // Cbx_Empresa
            // 
            Cbx_Empresa.FormattingEnabled = true;
            Cbx_Empresa.Items.AddRange(new object[] { "Córdoba", "Cenário" });
            Cbx_Empresa.Location = new Point(569, 157);
            Cbx_Empresa.Name = "Cbx_Empresa";
            Cbx_Empresa.Size = new Size(134, 28);
            Cbx_Empresa.TabIndex = 5;
            // 
            // Lbl_Ramal
            // 
            Lbl_Ramal.AutoSize = true;
            Lbl_Ramal.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Ramal.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Ramal.Location = new Point(10, 148);
            Lbl_Ramal.Name = "Lbl_Ramal";
            Lbl_Ramal.Size = new Size(68, 23);
            Lbl_Ramal.TabIndex = 14;
            Lbl_Ramal.Text = "Ramal:";
            // 
            // Txb_Telefone
            // 
            Txb_Telefone.Location = new Point(210, 146);
            Txb_Telefone.Mask = "(99) 00000-0000";
            Txb_Telefone.Name = "Txb_Telefone";
            Txb_Telefone.Size = new Size(165, 27);
            Txb_Telefone.TabIndex = 7;
            // 
            // Lbl_Tel
            // 
            Lbl_Tel.AutoSize = true;
            Lbl_Tel.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Tel.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Tel.Location = new Point(127, 148);
            Lbl_Tel.Name = "Lbl_Tel";
            Lbl_Tel.Size = new Size(86, 23);
            Lbl_Tel.TabIndex = 17;
            Lbl_Tel.Text = "Telefone:";
            // 
            // Txb_Ramal
            // 
            Txb_Ramal.Location = new Point(74, 146);
            Txb_Ramal.Mask = "(000)";
            Txb_Ramal.Name = "Txb_Ramal";
            Txb_Ramal.Size = new Size(46, 27);
            Txb_Ramal.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Lbl_Titulo);
            panel1.Controls.Add(Lbl_Ramal);
            panel1.Controls.Add(Txb_Ramal);
            panel1.Controls.Add(Txb_Telefone);
            panel1.Controls.Add(Lbl_Tel);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(20, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 202);
            panel1.TabIndex = 0;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Titulo.Location = new Point(3, 0);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(125, 19);
            Lbl_Titulo.TabIndex = 20;
            Lbl_Titulo.Text = "Dados Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(Tbx_Senha);
            panel2.Controls.Add(Lbl_Senha);
            panel2.Controls.Add(Lbl_UsuarioAcesso);
            panel2.Controls.Add(Tbx_Email);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.ImeMode = ImeMode.NoControl;
            panel2.Location = new Point(20, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 151);
            panel2.TabIndex = 0;
            // 
            // Tbx_Senha
            // 
            Tbx_Senha.BorderStyle = BorderStyle.FixedSingle;
            Tbx_Senha.CharacterCasing = CharacterCasing.Upper;
            Tbx_Senha.Location = new Point(79, 69);
            Tbx_Senha.Name = "Tbx_Senha";
            Tbx_Senha.Size = new Size(120, 27);
            Tbx_Senha.TabIndex = 9;
            Tbx_Senha.TextChanged += Tbx_Senha_TextChanged;
            // 
            // Lbl_Senha
            // 
            Lbl_Senha.AutoSize = true;
            Lbl_Senha.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Senha.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Senha.Location = new Point(11, 71);
            Lbl_Senha.Name = "Lbl_Senha";
            Lbl_Senha.Size = new Size(69, 23);
            Lbl_Senha.TabIndex = 20;
            Lbl_Senha.Text = "Senha:";
            // 
            // Lbl_UsuarioAcesso
            // 
            Lbl_UsuarioAcesso.AutoSize = true;
            Lbl_UsuarioAcesso.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_UsuarioAcesso.Location = new Point(3, 0);
            Lbl_UsuarioAcesso.Name = "Lbl_UsuarioAcesso";
            Lbl_UsuarioAcesso.Size = new Size(120, 19);
            Lbl_UsuarioAcesso.TabIndex = 20;
            Lbl_UsuarioAcesso.Text = "Dados Acesso";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { novoToolStripMenuItem, salvarToolStripMenuItem, cancelarToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(750, 48);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Image = (Image)resources.GetObject("novoToolStripMenuItem.Image");
            novoToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(59, 44);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            novoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = (Image)resources.GetObject("salvarToolStripMenuItem.Image");
            salvarToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(63, 44);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            salvarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // cancelarToolStripMenuItem
            // 
            cancelarToolStripMenuItem.Image = (Image)resources.GetObject("cancelarToolStripMenuItem.Image");
            cancelarToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            cancelarToolStripMenuItem.Size = new Size(69, 44);
            cancelarToolStripMenuItem.Text = "Limpar";
            cancelarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            cancelarToolStripMenuItem.Click += cancelarToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Image = (Image)resources.GetObject("voltarToolStripMenuItem.Image");
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(62, 44);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // Usuario_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 486);
            Controls.Add(menuStrip1);
            Controls.Add(Cbx_Empresa);
            Controls.Add(Lbl_Empresa);
            Controls.Add(Lbl_Email);
            Controls.Add(Cbx_Cargo);
            Controls.Add(Lbl_Cargo);
            Controls.Add(Cbx_Setor);
            Controls.Add(lbl_Setor);
            Controls.Add(Date_Aniver);
            Controls.Add(Lbl_Aniversario);
            Controls.Add(Lbl_Nome);
            Controls.Add(Txt_Nome_Usuario);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Name = "Usuario_Cadastro";
            Text = "Cadastro Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Nome_Usuario;
        private ContextMenuStrip contextMenuStrip1;
        private Label Lbl_Nome;
        private DateTimePicker Date_Aniver;
        private Label Lbl_Aniversario;
        private Label lbl_Setor;
        private ComboBox Cbx_Setor;
        private Label Lbl_Cargo;
        private ComboBox Cbx_Cargo;
        private Label Lbl_Email;
        private TextBox Tbx_Email;
        private Label Lbl_Empresa;
        private ComboBox Cbx_Empresa;
        private Label Lbl_Ramal;
        private MaskedTextBox Txb_Telefone;
        private Label Lbl_Tel;
        private MaskedTextBox Txb_Ramal;
        private Panel panel1;
        private Label Lbl_Titulo;
        private Panel panel2;
        private Label Lbl_UsuarioAcesso;
        private TextBox Tbx_Senha;
        private Label Lbl_Senha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem cancelarToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}