namespace CONTROLE_COMERCIAL
{
    partial class Usuario_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Menu));
            menuStrip1 = new MenuStrip();
            Tsm_Cadastro_Menu = new ToolStripMenuItem();
            Tsm_Usuario_Menu = new ToolStripMenuItem();
            Tsm_Ocorrencia_Menu = new ToolStripMenuItem();
            Tsm_RegistrarOcorrencia_Menu = new ToolStripMenuItem();
            Tsm_Modo_Menu = new ToolStripMenuItem();
            Tsm_Sair_menu = new ToolStripMenuItem();
            Tsm_Suporte_Menu = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            acompanhamentoOcorrenciaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Tsm_Cadastro_Menu, Tsm_Ocorrencia_Menu, Tsm_Modo_Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Cadastro_Menu
            // 
            Tsm_Cadastro_Menu.DropDownItems.AddRange(new ToolStripItem[] { Tsm_Usuario_Menu });
            Tsm_Cadastro_Menu.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Tsm_Cadastro_Menu.Image = (Image)resources.GetObject("Tsm_Cadastro_Menu.Image");
            Tsm_Cadastro_Menu.Name = "Tsm_Cadastro_Menu";
            Tsm_Cadastro_Menu.Size = new Size(128, 44);
            Tsm_Cadastro_Menu.Text = "Cadastro/Atualizar";
            Tsm_Cadastro_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Tsm_Usuario_Menu
            // 
            Tsm_Usuario_Menu.Image = (Image)resources.GetObject("Tsm_Usuario_Menu.Image");
            Tsm_Usuario_Menu.Name = "Tsm_Usuario_Menu";
            Tsm_Usuario_Menu.Size = new Size(132, 26);
            Tsm_Usuario_Menu.Text = "Usuario";
            Tsm_Usuario_Menu.Click += Mst_CadastroUsuar_Click;
            // 
            // Tsm_Ocorrencia_Menu
            // 
            Tsm_Ocorrencia_Menu.DropDownItems.AddRange(new ToolStripItem[] { Tsm_RegistrarOcorrencia_Menu, acompanhamentoOcorrenciaToolStripMenuItem });
            Tsm_Ocorrencia_Menu.Image = (Image)resources.GetObject("Tsm_Ocorrencia_Menu.Image");
            Tsm_Ocorrencia_Menu.Name = "Tsm_Ocorrencia_Menu";
            Tsm_Ocorrencia_Menu.Size = new Size(154, 44);
            Tsm_Ocorrencia_Menu.Text = "Registro Ocorrencia";
            Tsm_Ocorrencia_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Tsm_RegistrarOcorrencia_Menu
            // 
            Tsm_RegistrarOcorrencia_Menu.Image = (Image)resources.GetObject("Tsm_RegistrarOcorrencia_Menu.Image");
            Tsm_RegistrarOcorrencia_Menu.Name = "Tsm_RegistrarOcorrencia_Menu";
            Tsm_RegistrarOcorrencia_Menu.Size = new Size(291, 26);
            Tsm_RegistrarOcorrencia_Menu.Text = "Registrar Ocorrencia";
            Tsm_RegistrarOcorrencia_Menu.Click += registrarOcorrenciaToolStripMenuItem_Click;
            // 
            // Tsm_Modo_Menu
            // 
            Tsm_Modo_Menu.DropDownItems.AddRange(new ToolStripItem[] { Tsm_Sair_menu, Tsm_Suporte_Menu });
            Tsm_Modo_Menu.Image = (Image)resources.GetObject("Tsm_Modo_Menu.Image");
            Tsm_Modo_Menu.Name = "Tsm_Modo_Menu";
            Tsm_Modo_Menu.Size = new Size(63, 44);
            Tsm_Modo_Menu.Text = "Modo";
            Tsm_Modo_Menu.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Tsm_Sair_menu
            // 
            Tsm_Sair_menu.Image = (Image)resources.GetObject("Tsm_Sair_menu.Image");
            Tsm_Sair_menu.Name = "Tsm_Sair_menu";
            Tsm_Sair_menu.Size = new Size(144, 26);
            Tsm_Sair_menu.Text = "Sair";
            Tsm_Sair_menu.Click += sairToolStripMenuItem_Click;
            // 
            // Tsm_Suporte_Menu
            // 
            Tsm_Suporte_Menu.Image = (Image)resources.GetObject("Tsm_Suporte_Menu.Image");
            Tsm_Suporte_Menu.Name = "Tsm_Suporte_Menu";
            Tsm_Suporte_Menu.Size = new Size(144, 26);
            Tsm_Suporte_Menu.Text = "Suporte";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 698);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // acompanhamentoOcorrenciaToolStripMenuItem
            // 
            acompanhamentoOcorrenciaToolStripMenuItem.Image = (Image)resources.GetObject("acompanhamentoOcorrenciaToolStripMenuItem.Image");
            acompanhamentoOcorrenciaToolStripMenuItem.Name = "acompanhamentoOcorrenciaToolStripMenuItem";
            acompanhamentoOcorrenciaToolStripMenuItem.Size = new Size(291, 26);
            acompanhamentoOcorrenciaToolStripMenuItem.Text = "Acompanhamento Ocorrencia";
            acompanhamentoOcorrenciaToolStripMenuItem.Click += acompanhamentoOcorrenciaToolStripMenuItem_Click;
            // 
            // Usuario_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            Name = "Usuario_Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Tsm_Cadastro_Menu;
        private ToolStripMenuItem Tsm_Usuario_Menu;
        private ToolStripMenuItem Tsm_Ocorrencia_Menu;
        private ToolStripMenuItem Tsm_RegistrarOcorrencia_Menu;
        private ToolStripMenuItem Tsm_Modo_Menu;
        private ToolStripMenuItem Tsm_Sair_menu;
        private ToolStripMenuItem Tsm_Suporte_Menu;
        private PictureBox pictureBox1;
        private ToolStripMenuItem acompanhamentoOcorrenciaToolStripMenuItem;
    }
}