namespace Gestão_Agulhas
{
    partial class frmEcraPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcraPrincipal));
            pbFechar = new PictureBox();
            pbMinimizar = new PictureBox();
            lbBoasvindas = new Label();
            lbTear = new Label();
            lbAgulha = new Label();
            lbQty = new Label();
            lbObs = new Label();
            pnlTear = new Panel();
            cbMaq = new ComboBox();
            pnlAgulha = new Panel();
            cbAgulha = new ComboBox();
            pnlQty = new Panel();
            txtQty = new TextBox();
            pnlObs = new Panel();
            txtObs = new TextBox();
            gbTearInfo = new GroupBox();
            lblQtyAgulhas = new Label();
            label4 = new Label();
            lblPolegada = new Label();
            lblJogo = new Label();
            lblVersao = new Label();
            pictureBox1 = new PictureBox();
            btnGravar = new Button();
            pbAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            pnlTear.SuspendLayout();
            pnlAgulha.SuspendLayout();
            pnlQty.SuspendLayout();
            pnlObs.SuspendLayout();
            gbTearInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).BeginInit();
            SuspendLayout();
            // 
            // pbFechar
            // 
            pbFechar.BackColor = Color.Transparent;
            pbFechar.BackgroundImage = Properties.Resources.FECHAR_3;
            pbFechar.BackgroundImageLayout = ImageLayout.Stretch;
            pbFechar.Cursor = Cursors.Hand;
            pbFechar.Location = new Point(1418, 12);
            pbFechar.Name = "pbFechar";
            pbFechar.Size = new Size(20, 20);
            pbFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbFechar.TabIndex = 1;
            pbFechar.TabStop = false;
            pbFechar.Click += pbFechar_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.BackColor = Color.Transparent;
            pbMinimizar.BackgroundImage = Properties.Resources.minimizar_2;
            pbMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            pbMinimizar.Cursor = Cursors.Hand;
            pbMinimizar.Location = new Point(1392, 12);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(20, 20);
            pbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMinimizar.TabIndex = 2;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // lbBoasvindas
            // 
            lbBoasvindas.AutoSize = true;
            lbBoasvindas.BackColor = Color.Transparent;
            lbBoasvindas.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBoasvindas.ForeColor = Color.White;
            lbBoasvindas.Location = new Point(98, 48);
            lbBoasvindas.Name = "lbBoasvindas";
            lbBoasvindas.Size = new Size(294, 22);
            lbBoasvindas.TabIndex = 3;
            lbBoasvindas.Text = "Bem Vindo [Nome Utilizador]";
            // 
            // lbTear
            // 
            lbTear.AutoSize = true;
            lbTear.BackColor = Color.Transparent;
            lbTear.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTear.ForeColor = Color.White;
            lbTear.Location = new Point(98, 98);
            lbTear.Name = "lbTear";
            lbTear.Size = new Size(73, 22);
            lbTear.TabIndex = 4;
            lbTear.Text = "Tear #";
            // 
            // lbAgulha
            // 
            lbAgulha.AutoSize = true;
            lbAgulha.BackColor = Color.Transparent;
            lbAgulha.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgulha.ForeColor = Color.White;
            lbAgulha.Location = new Point(98, 149);
            lbAgulha.Name = "lbAgulha";
            lbAgulha.Size = new Size(79, 22);
            lbAgulha.TabIndex = 5;
            lbAgulha.Text = "Agulha";
            // 
            // lbQty
            // 
            lbQty.AutoSize = true;
            lbQty.BackColor = Color.Transparent;
            lbQty.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQty.ForeColor = Color.White;
            lbQty.Location = new Point(98, 200);
            lbQty.Name = "lbQty";
            lbQty.Size = new Size(121, 22);
            lbQty.TabIndex = 6;
            lbQty.Text = "Quantidade";
            lbQty.Click += lbQty_Click;
            // 
            // lbObs
            // 
            lbObs.AutoSize = true;
            lbObs.BackColor = Color.Transparent;
            lbObs.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbObs.ForeColor = Color.White;
            lbObs.Location = new Point(98, 251);
            lbObs.Name = "lbObs";
            lbObs.Size = new Size(133, 22);
            lbObs.TabIndex = 7;
            lbObs.Text = "Observações";
            lbObs.Click += label1_Click;
            // 
            // pnlTear
            // 
            pnlTear.BorderStyle = BorderStyle.Fixed3D;
            pnlTear.Controls.Add(cbMaq);
            pnlTear.Location = new Point(264, 98);
            pnlTear.Name = "pnlTear";
            pnlTear.Size = new Size(250, 35);
            pnlTear.TabIndex = 8;
            // 
            // cbMaq
            // 
            cbMaq.FlatStyle = FlatStyle.Flat;
            cbMaq.FormattingEnabled = true;
            cbMaq.Location = new Point(-1, 5);
            cbMaq.Name = "cbMaq";
            cbMaq.Size = new Size(249, 23);
            cbMaq.TabIndex = 0;
            cbMaq.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pnlAgulha
            // 
            pnlAgulha.BorderStyle = BorderStyle.Fixed3D;
            pnlAgulha.Controls.Add(cbAgulha);
            pnlAgulha.Location = new Point(264, 149);
            pnlAgulha.Name = "pnlAgulha";
            pnlAgulha.Size = new Size(250, 35);
            pnlAgulha.TabIndex = 9;
            // 
            // cbAgulha
            // 
            cbAgulha.FlatStyle = FlatStyle.Flat;
            cbAgulha.FormattingEnabled = true;
            cbAgulha.Location = new Point(-1, 4);
            cbAgulha.Name = "cbAgulha";
            cbAgulha.Size = new Size(249, 23);
            cbAgulha.TabIndex = 1;
            // 
            // pnlQty
            // 
            pnlQty.BorderStyle = BorderStyle.Fixed3D;
            pnlQty.Controls.Add(txtQty);
            pnlQty.Location = new Point(264, 200);
            pnlQty.Name = "pnlQty";
            pnlQty.Size = new Size(250, 35);
            pnlQty.TabIndex = 10;
            // 
            // txtQty
            // 
            txtQty.BackColor = SystemColors.Control;
            txtQty.BorderStyle = BorderStyle.None;
            txtQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(-2, 6);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(250, 22);
            txtQty.TabIndex = 0;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // pnlObs
            // 
            pnlObs.BorderStyle = BorderStyle.Fixed3D;
            pnlObs.Controls.Add(txtObs);
            pnlObs.Location = new Point(264, 258);
            pnlObs.Name = "pnlObs";
            pnlObs.Size = new Size(912, 88);
            pnlObs.TabIndex = 11;
            // 
            // txtObs
            // 
            txtObs.BackColor = SystemColors.Control;
            txtObs.BorderStyle = BorderStyle.None;
            txtObs.Location = new Point(-2, 3);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(912, 78);
            txtObs.TabIndex = 0;
            // 
            // gbTearInfo
            // 
            gbTearInfo.BackColor = Color.Transparent;
            gbTearInfo.BackgroundImageLayout = ImageLayout.Stretch;
            gbTearInfo.Controls.Add(lblQtyAgulhas);
            gbTearInfo.Controls.Add(label4);
            gbTearInfo.Controls.Add(lblPolegada);
            gbTearInfo.Controls.Add(lblJogo);
            gbTearInfo.Controls.Add(lblVersao);
            gbTearInfo.FlatStyle = FlatStyle.Flat;
            gbTearInfo.Font = new Font("Zurich", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbTearInfo.ForeColor = Color.FromArgb(79, 154, 195);
            gbTearInfo.Location = new Point(599, 54);
            gbTearInfo.Name = "gbTearInfo";
            gbTearInfo.Size = new Size(683, 198);
            gbTearInfo.TabIndex = 1;
            gbTearInfo.TabStop = false;
            gbTearInfo.Text = "Tear #";
            // 
            // lblQtyAgulhas
            // 
            lblQtyAgulhas.AutoSize = true;
            lblQtyAgulhas.Font = new Font("Zurich", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtyAgulhas.ForeColor = Color.White;
            lblQtyAgulhas.Location = new Point(6, 95);
            lblQtyAgulhas.Name = "lblQtyAgulhas";
            lblQtyAgulhas.Size = new Size(169, 18);
            lblQtyAgulhas.TabIndex = 4;
            lblQtyAgulhas.Text = "[NUM AGU] Agulhas";
            lblQtyAgulhas.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Zurich", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(274, 77);
            label4.Name = "label4";
            label4.Size = new Size(118, 36);
            label4.TabIndex = 3;
            label4.Text = "Matrícula\r\n[MATRICULA]";
            // 
            // lblPolegada
            // 
            lblPolegada.AutoSize = true;
            lblPolegada.Font = new Font("Zurich", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPolegada.ForeColor = Color.White;
            lblPolegada.Location = new Point(481, 23);
            lblPolegada.Name = "lblPolegada";
            lblPolegada.Size = new Size(196, 18);
            lblPolegada.TabIndex = 2;
            lblPolegada.Text = "[POLEGADA] Polegadas";
            lblPolegada.Click += label3_Click;
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.Font = new Font("Zurich", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJogo.ForeColor = Color.White;
            lblJogo.Location = new Point(274, 23);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(109, 18);
            lblJogo.TabIndex = 1;
            lblJogo.Text = "Jogo [JOGO]";
            lblJogo.Click += label2_Click_1;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Zurich", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersao.ForeColor = Color.White;
            lblVersao.Location = new Point(6, 23);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(88, 18);
            lblVersao.TabIndex = 0;
            lblVersao.Text = "[VERSAO]";
            lblVersao.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Opções;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1366, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnGravar
            // 
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Zurich", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = Color.FromArgb(45, 76, 107);
            btnGravar.Location = new Point(1182, 258);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 88);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // pbAdmin
            // 
            pbAdmin.BackColor = Color.Transparent;
            pbAdmin.BackgroundImage = Properties.Resources.Admin;
            pbAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            pbAdmin.Cursor = Cursors.Hand;
            pbAdmin.Location = new Point(1340, 12);
            pbAdmin.Name = "pbAdmin";
            pbAdmin.Size = new Size(20, 20);
            pbAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdmin.TabIndex = 15;
            pbAdmin.TabStop = false;
            // 
            // frmEcraPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1450, 750);
            Controls.Add(pbAdmin);
            Controls.Add(btnGravar);
            Controls.Add(pictureBox1);
            Controls.Add(gbTearInfo);
            Controls.Add(pnlObs);
            Controls.Add(pnlQty);
            Controls.Add(pnlAgulha);
            Controls.Add(pnlTear);
            Controls.Add(lbObs);
            Controls.Add(lbQty);
            Controls.Add(lbAgulha);
            Controls.Add(lbTear);
            Controls.Add(lbBoasvindas);
            Controls.Add(pbMinimizar);
            Controls.Add(pbFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEcraPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pbFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            pnlTear.ResumeLayout(false);
            pnlAgulha.ResumeLayout(false);
            pnlQty.ResumeLayout(false);
            pnlQty.PerformLayout();
            pnlObs.ResumeLayout(false);
            pnlObs.PerformLayout();
            gbTearInfo.ResumeLayout(false);
            gbTearInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFechar;
        private PictureBox pbMinimizar;
        private Label lbBoasvindas;
        private Label lbTear;
        private Label lbAgulha;
        private Label lbQty;
        private Label lbObs;
        private Panel pnlTear;
        private Panel pnlAgulha;
        private Panel pnlQty;
        private Panel pnlObs;
        private GroupBox gbTearInfo;
        private PictureBox pictureBox1;
        private Button btnGravar;
        private Label lblVersao;
        private Label lblJogo;
        private Label lblPolegada;
        private Label lblQtyAgulhas;
        private Label label4;
        private TextBox txtObs;
        private TextBox txtQty;
        private ComboBox cbMaq;
        private ComboBox cbAgulha;
        private PictureBox pbAdmin;
    }
}