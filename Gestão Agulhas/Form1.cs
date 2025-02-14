using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gestão_Agulhas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ArredondarBordas();
        }

        // Importação da DLL para criar bordas arredondadas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Método para arredondar as bordas do formulário e do botão
        private void ArredondarBordas()
        {
            // Arredonda o próprio formulário
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

            // Arredonda o botão "ENTRAR"
            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEntrar.Width, btnEntrar.Height, 15, 15));
        }

        // Evento do botão fechar
        private void pbFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbUserIcon_Click(object sender, EventArgs e)
        {

        }

        // Evento do botão Minimizar
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza a janela
        }

        // Evento do botão "ENTRAR"
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234")
            {
                frmEcraPrincipal ecraPrincipal = new frmEcraPrincipal();
                ecraPrincipal.ShowDialog(); //Exibe o formulário Ecra Principal
                
                this.Close(); //Fecha Formulario de Log In
                //ANTIGO MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmErrologin erroLogin = new frmErrologin();
                erroLogin.ShowDialog(); // Exibe o formulário de erro
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
