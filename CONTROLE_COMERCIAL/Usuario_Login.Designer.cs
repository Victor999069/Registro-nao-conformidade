namespace CONTROLE_COMERCIAL
{
    partial class Usuario_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_Login));
            Lbl_Email = new Label();
            Tbx_Email = new TextBox();
            Lbl_Senha = new Label();
            Txt_Senha = new TextBox();
            Btn_Entrar = new Button();
            Btn_Sair = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Email.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Email.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            Lbl_Email.Location = new Point(71, 128);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(59, 21);
            Lbl_Email.TabIndex = 0;
            Lbl_Email.Text = "E-mail";
            // 
            // Tbx_Email
            // 
            Tbx_Email.Location = new Point(131, 125);
            Tbx_Email.Name = "Tbx_Email";
            Tbx_Email.Size = new Size(174, 27);
            Tbx_Email.TabIndex = 1;
            // 
            // Lbl_Senha
            // 
            Lbl_Senha.AutoSize = true;
            Lbl_Senha.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Senha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Senha.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            Lbl_Senha.Location = new Point(316, 128);
            Lbl_Senha.Name = "Lbl_Senha";
            Lbl_Senha.Size = new Size(60, 21);
            Lbl_Senha.TabIndex = 2;
            Lbl_Senha.Text = "Senha";
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(377, 125);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(99, 27);
            Txt_Senha.TabIndex = 3;
            // 
            // Btn_Entrar
            // 
            Btn_Entrar.BackColor = SystemColors.ButtonHighlight;
            Btn_Entrar.FlatStyle = FlatStyle.Popup;
            Btn_Entrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Entrar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Entrar.Image = (Image)resources.GetObject("Btn_Entrar.Image");
            Btn_Entrar.ImageAlign = ContentAlignment.BottomCenter;
            Btn_Entrar.Location = new Point(125, 98);
            Btn_Entrar.Name = "Btn_Entrar";
            Btn_Entrar.Size = new Size(57, 33);
            Btn_Entrar.TabIndex = 4;
            Btn_Entrar.TextAlign = ContentAlignment.TopCenter;
            Btn_Entrar.UseVisualStyleBackColor = false;
            Btn_Entrar.Click += Btn_Entrar_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.BackColor = SystemColors.ButtonHighlight;
            Btn_Sair.FlatStyle = FlatStyle.Popup;
            Btn_Sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Sair.Image = (Image)resources.GetObject("Btn_Sair.Image");
            Btn_Sair.ImageAlign = ContentAlignment.BottomCenter;
            Btn_Sair.Location = new Point(258, 98);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(57, 33);
            Btn_Sair.TabIndex = 5;
            Btn_Sair.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Btn_Entrar);
            panel1.Controls.Add(Btn_Sair);
            panel1.Location = new Point(58, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 147);
            panel1.TabIndex = 6;
            // 
            // Usuario_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 287);
            Controls.Add(Txt_Senha);
            Controls.Add(Lbl_Senha);
            Controls.Add(Tbx_Email);
            Controls.Add(Lbl_Email);
            Controls.Add(panel1);
            Name = "Usuario_Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Email;
        private TextBox Tbx_Email;
        private Label Lbl_Senha;
        private TextBox Txt_Senha;
        private Button Btn_Entrar;
        private Button Btn_Sair;
        private Panel panel1;
    }
}