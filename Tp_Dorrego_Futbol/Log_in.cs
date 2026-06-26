using BLL;
using Servicios_Seguridad;
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
    public partial class Log_in : Form, IObserver
    {
        UserBLL userBll = new UserBLL();
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
            LenguajeManager.GetInstance().AgregarObserver(this);
        }
        private void Log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            LenguajeManager.GetInstance().RemoverObserver(this);
            Application.Exit();
        }

        private void click(object sender, EventArgs e)
        {

        }



        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtContraseña_logIn.Text == "Contraseña")
            {
                txtContraseña_logIn.PasswordChar = '*';
                txtContraseña_logIn.Text = "";
                txtContraseña_logIn.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void txtContraseña_logIn_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtContraseña_logIn.Text))
            {
                txtContraseña_logIn.Text = "Contraseña";
                txtContraseña_logIn.ForeColor = System.Drawing.Color.Gray;
                txtContraseña_logIn.PasswordChar = '\0';
            }

        }

        private void txtNombre_LogIn_Enter(object sender, EventArgs e)
        {
            if (txtNombre_LogIn.Text == "Nombre")
            {
                txtNombre_LogIn.Text = "";
                txtNombre_LogIn.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void txtNombre_LogIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre_LogIn.Text))
            {
                txtNombre_LogIn.Text = "Nombre";
                txtNombre_LogIn.ForeColor = System.Drawing.Color.Gray;
            }
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


        private void boton_Log_in_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre_LogIn.Text) || string.IsNullOrWhiteSpace(txtContraseña_logIn.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (userBll.Login(txtNombre_LogIn.Text, txtContraseña_logIn.Text))
                {
                    MessageBox.Show("Bienvenido al sistema " + txtNombre_LogIn.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Busco el idioma cargado en el usuario
                    int idiomaUsuario = Servicios_Seguridad.SessionManager.GetInstance.Usuario.IdIdioma;

                    // busco en la tabla de traducciones
                    BLL.IdiomaBLL idiomaBll = new BLL.IdiomaBLL();
                    DataTable dtTraducciones = idiomaBll.ObtenerTraducciones(idiomaUsuario);

                    
                    if (dtTraducciones != null && dtTraducciones.Rows.Count > 0)
                    {
                        Servicios_Seguridad.LenguajeManager.GetInstance().CambiarIdioma(idiomaUsuario, dtTraducciones);
                    }

                    
                    this.Hide();
                    Menu_Principal principal = new Menu_Principal();
                    principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña_logIn.Clear();
                txtContraseña_logIn.Focus();
            }
        }

        public void ActualizarIdioma(object traducciones)
        {
            System.Data.DataTable dtTraducciones = (System.Data.DataTable)traducciones;

            foreach (System.Data.DataRow row in dtTraducciones.Rows)
            {
                string nombreControl = row["ClaveControl"].ToString();
                string textoTraducido = row["Texto"].ToString();


                Control[] encontrados = this.Controls.Find(nombreControl, true);
                if (encontrados.Length > 0)
                {
                    encontrados[0].Text = textoTraducido;
                }
            }

        }
    }
}
