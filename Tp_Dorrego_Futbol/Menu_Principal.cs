using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tp_Dorrego_Futbol
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Menu_vertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Menu_vertical.Width == 250)
            {
                Menu_vertical.Width = 88;
            }
            else
            {
                Menu_vertical.Width = 250;
            }
        }

        private void Administración_boton_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Icono_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Icono_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Icono_Maximizar.Visible = false;
            resaturar_icono.Visible = true;
        }

        private void resaturar_icono_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            Icono_Maximizar.Visible = true;
            resaturar_icono.Visible = false;
        }

        private void Icono_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
