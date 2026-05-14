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

namespace Tp_Dorrego_Futbol
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void click(object sender, EventArgs e)
        {
            
        }

        

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtContraseña_logIn.Text == "Contraseña")
            {
                txtContraseña_logIn.PasswordChar = '*';
                txtContraseña_logIn.Text = "";
                txtContraseña_logIn.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void txtContraseña_logIn_Leave(object sender, EventArgs e)
        {
            
            txtContraseña_logIn.ForeColor = System.Drawing.Color.Gray;
            txtContraseña_logIn.Text = "Contraseña";
            txtContraseña_logIn.PasswordChar = ' ';

        }

        private void txtNombre_LogIn_Enter(object sender, EventArgs e)
        {
            if(txtNombre_LogIn.Text == "Nombre")
            {
                txtNombre_LogIn.Text = "";
                txtNombre_LogIn.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void txtNombre_LogIn_Leave(object sender, EventArgs e)
        {
            txtNombre_LogIn.ForeColor = System.Drawing.Color.Gray;
            txtNombre_LogIn.Text = "Nombre";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Log_in_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
