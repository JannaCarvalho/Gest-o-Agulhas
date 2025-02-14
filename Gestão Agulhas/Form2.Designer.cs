namespace Gestão_Agulhas
{
    partial class frmErrologin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmErrologin));
            lbIncorreto = new Label();
            pbFecharErro = new PictureBox();
            btnOk = new Button();
            lbContacto = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFecharErro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lbIncorreto
            // 
            lbIncorreto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbIncorreto.AutoSize = true;
            lbIncorreto.BackColor = Color.Transparent;
            lbIncorreto.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIncorreto.ForeColor = SystemColors.ButtonFace;
            lbIncorreto.Location = new Point(42, 154);
            lbIncorreto.Name = "lbIncorreto";
            lbIncorreto.Size = new Size(308, 44);
            lbIncorreto.TabIndex = 1;
            lbIncorreto.Text = "Utilizador ou senha incorretos!\r\nTente Novamente";
            lbIncorreto.TextAlign = ContentAlignment.MiddleCenter;
            lbIncorreto.Click += lbIncorreto_Click;
            // 
            // pbFecharErro
            // 
            pbFecharErro.BackColor = Color.Transparent;
            pbFecharErro.BackgroundImage = Properties.Resources.FECHAR_3;
            pbFecharErro.BackgroundImageLayout = ImageLayout.Stretch;
            pbFecharErro.Location = new Point(368, 12);
            pbFecharErro.Name = "pbFecharErro";
            pbFecharErro.Size = new Size(20, 20);
            pbFecharErro.TabIndex = 2;
            pbFecharErro.TabStop = false;
            pbFecharErro.Click += pictureBox1_Click;
            // 
            // btnOk
            // 
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Zurich", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.FromArgb(45, 76, 107);
            btnOk.Location = new Point(258, 346);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 39);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lbContacto
            // 
            lbContacto.AutoSize = true;
            lbContacto.BackColor = Color.Transparent;
            lbContacto.Font = new Font("Zurich", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContacto.ForeColor = SystemColors.ButtonFace;
            lbContacto.Location = new Point(42, 257);
            lbContacto.Name = "lbContacto";
            lbContacto.Size = new Size(314, 38);
            lbContacto.TabIndex = 5;
            lbContacto.Text = "Se o problema persistir, contacte o \r\nadministrador do sistema.";
            lbContacto.TextAlign = ContentAlignment.MiddleCenter;
            lbContacto.Click += lbContacto_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(5, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(60, 60);
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // frmErrologin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 450);
            Controls.Add(pbLogo);
            Controls.Add(lbContacto);
            Controls.Add(btnOk);
            Controls.Add(pbFecharErro);
            Controls.Add(lbIncorreto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmErrologin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pbFecharErro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIncorreto;
        private PictureBox pbFecharErro;
        private Button btnOk;
        private Label lbContacto;
        private PictureBox pbLogo;
    }
}