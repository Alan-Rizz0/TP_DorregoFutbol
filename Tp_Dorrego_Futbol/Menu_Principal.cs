using Servicios_Seguridad;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tp_Dorrego_Futbol
{
    public partial class Menu_Principal : Form, IObserver
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();
        }

        /*
        private void VerRol(usuario usuario)
        {
            if(usuario.rol == "recepcionista")
            {
                 btn_usuarios.Enabled = false;
            }
        }
        */

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
            if (Contenedor_Usuario.Height == 58)
            {
                Contenedor_Usuario.Height = 155;
            }
            else
            {
                Contenedor_Usuario.Height = 58;
            }
        }


        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            LenguajeManager.GetInstance().AgregarObserver(this);
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

        private void panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_CambiarContraseña_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Cambiar_Contraseña());
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            if (Contenedor_Administracion.Height == 54)
            {
                Contenedor_Administracion.Height = 143;
            }
            else
            {
                Contenedor_Administracion.Height = 54;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AbrirFormHijo(new btnCrearUsuario());
        }

        private void Boton_Logout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿quiere cerrar la sesion?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                try
                {
                    SessionManager.Logout();
                    MessageBox.Show("Sesion cerrada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Log_in login = new Log_in();
                    login.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
           
        }

        private void Contenedor_Usuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Bitacora());
        }

        private void btn_CambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {

                int idiomaActual = Servicios_Seguridad.SessionManager.GetInstance.Usuario.IdIdioma;


                int nuevoIdioma;

                if (idiomaActual == 2)
                {
                    nuevoIdioma = 1;
                }
                else
                {
                    nuevoIdioma = 2;
                }


                BLL.IdiomaBLL idiomaBll = new BLL.IdiomaBLL();
                DataTable dtTraducciones = idiomaBll.ObtenerTraducciones(nuevoIdioma);

                if (dtTraducciones != null && dtTraducciones.Rows.Count > 0)
                {
                    Servicios_Seguridad.LenguajeManager.GetInstance().CambiarIdioma(nuevoIdioma, dtTraducciones);
                }
                else
                {
                    MessageBox.Show("No se encontraron traducciones en la Base de Datos para el idioma seleccionado.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cambiar el idioma: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarIdioma(object traducciones)
        {
            DataTable dtTraducciones = (DataTable)traducciones;


            foreach (DataRow row in dtTraducciones.Rows)
            {
                if (row["ClaveControl"].ToString() == this.Name)
                {
                    this.Text = row["Texto"].ToString();
                }
            }


            foreach (DataRow row in dtTraducciones.Rows)
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
