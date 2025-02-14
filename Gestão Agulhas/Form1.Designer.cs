namespace Gestão_Agulhas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pbFechar = new PictureBox();
            pbMinimizar = new PictureBox();
            btnEntrar = new Button();
            pbUserIcon = new PictureBox();
            pnlUsuario = new Panel();
            txtUsuario = new TextBox();
            pnlSenha = new Panel();
            txtSenha = new TextBox();
            pbPassIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassIcon).BeginInit();
            SuspendLayout();
            // 
            // pbFechar
            // 
            pbFechar.BackColor = Color.Transparent;
            pbFechar.BackgroundImage = Properties.Resources.FECHAR_3;
            pbFechar.BackgroundImageLayout = ImageLayout.Stretch;
            pbFechar.Cursor = Cursors.Hand;
            pbFechar.Location = new Point(375, 12);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(20, 20);
            pbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbFechar.TabIndex = 0;
            pbFechar.TabStop = false;
            pbFechar.Click += pbFechar_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.BackColor = Color.Transparent;
            pbMinimizar.BackgroundImage = Properties.Resources.minimizar_2;
            pbMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            pbMinimizar.Cursor = Cursors.Hand;
            pbMinimizar.Location = new Point(349, 12);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(20, 20);
            pbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizar.TabIndex = 1;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Zurich", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(45, 76, 107);
            btnEntrar.Location = new Point(116, 334);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(171, 59);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pbUserIcon
            // 
            pbUserIcon.BackgroundImage = Properties.Resources.USER;
            pbUserIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbUserIcon.Location = new Point(-2, -2);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(35, 35);
            pbUserIcon.TabIndex = 5;
            pbUserIcon.TabStop = false;
            pbUserIcon.Click += pbUserIcon_Click;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.White;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Controls.Add(pbUserIcon);
            pnlUsuario.Location = new Point(61, 153);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(280, 35);
            pnlUsuario.TabIndex = 2;
            pnlUsuario.Paint += pnlUsuario_Paint;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.FromArgb(45, 76, 107);
            txtUsuario.Location = new Point(39, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Utilizador";
            txtUsuario.Size = new Size(233, 23);
            txtUsuario.TabIndex = 0;
            // 
            // pnlSenha
            // 
            pnlSenha.BackColor = Color.White;
            pnlSenha.BorderStyle = BorderStyle.Fixed3D;
            pnlSenha.Controls.Add(txtSenha);
            pnlSenha.Controls.Add(pbPassIcon);
            pnlSenha.Location = new Point(61, 228);
            pnlSenha.Name = "pnlSenha";
            pnlSenha.Size = new Size(280, 35);
            pnlSenha.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Window;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(45, 76, 107);
            txtSenha.Location = new Point(39, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Password";
            txtSenha.Size = new Size(233, 23);
            txtSenha.TabIndex = 0;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // pbPassIcon
            // 
            pbPassIcon.BackgroundImage = Properties.Resources.password;
            pbPassIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbPassIcon.Location = new Point(-2, -2);
            pbPassIcon.Name = "pbPassIcon";
            pbPassIcon.Size = new Size(35, 35);
            pbPassIcon.TabIndex = 5;
            pbPassIcon.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 450);
            Controls.Add(pnlSenha);
            Controls.Add(btnEntrar);
            Controls.Add(pnlUsuario);
            Controls.Add(pbMinimizar);
            Controls.Add(pbFechar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlSenha.ResumeLayout(false);
            pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFechar;
        private PictureBox pbMinimizar;
        private Button btnEntrar;
        private PictureBox pbUserIcon;
        private Panel pnlUsuario;
        private TextBox txtUsuario;
        private Panel pnlSenha;
        private TextBox txtSenha;
        private PictureBox pbPassIcon;
    }
}
