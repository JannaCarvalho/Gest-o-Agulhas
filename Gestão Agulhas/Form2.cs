using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_Agulhas
{
    public partial class frmErrologin : Form
    {
        public frmErrologin()
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
            btnOk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOk.Width, btnOk.Height, 15, 15));
        }
        // Evento do botão fechar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbIncorreto_Click(object sender, EventArgs e)
        {

        }

        private void lbContacto_Click(object sender, EventArgs e)
        {

        }
    }
}
