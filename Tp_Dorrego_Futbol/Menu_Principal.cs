using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tp_Dorrego_Futbol
{
    public partial class Menu_Principal : Form, IObserver
    {
        BLL.IdiomaBLL idiomaBll = new BLL.IdiomaBLL();
        BLL.UserBLL userBll = new BLL.UserBLL();

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

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            LenguajeManager.GetInstance().AgregarObserver(this);

            CargarComboBoxIdiomas();

            if (SessionManager.GetInstance.Usuario != null)
            {
                int idIdiomaInicial = SessionManager.GetInstance.Usuario.IdIdioma;
                Dictionary<string, string> traduccionesIniciales = idiomaBll.ObtenerTraduccionesJson(idIdiomaInicial);

                if (traduccionesIniciales != null && traduccionesIniciales.Count > 0)
                {
                    LenguajeManager.GetInstance().CambiarIdioma(idIdiomaInicial, traduccionesIniciales);
                }
            }
        }

        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            LenguajeManager.GetInstance().RemoverObserver(this);
            Application.Exit();
        }

        private void CargarComboBoxIdiomas()
        {
            Dictionary<int, string> idiomas = idiomaBll.ObtenerIdiomasDisponibles();

            cmbIdioma.DataSource = null;

            List<OpcionComboBox> listaMapeada = new List<OpcionComboBox>();
            foreach (var item in idiomas)
            {
                listaMapeada.Add(new OpcionComboBox { ID = item.Key, Nombre = item.Value });
            }

            cmbIdioma.ValueMember = "ID";
            cmbIdioma.DisplayMember = "Nombre";
            cmbIdioma.DataSource = listaMapeada;

            if (SessionManager.GetInstance.Usuario != null)
            {
                cmbIdioma.SelectedValue = SessionManager.GetInstance.Usuario.IdIdioma;
            }
        }

        private void btn_CambiarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIdioma.SelectedValue == null || SessionManager.GetInstance.Usuario == null)
                    return;

                int idIdiomaSeleccionado = Convert.ToInt32(cmbIdioma.SelectedValue);

                
                if (idIdiomaSeleccionado == SessionManager.GetInstance.Usuario.IdIdioma)
                    return;

                Dictionary<string, string> nuevasTraducciones = idiomaBll.ObtenerTraduccionesJson(idIdiomaSeleccionado);

                if (nuevasTraducciones != null && nuevasTraducciones.Count > 0)
                {
                    int idUsuarioActual = SessionManager.GetInstance.Usuario.ID;

                    userBll.ActualizarIdiomaUsuario(idUsuarioActual, idIdiomaSeleccionado);

                    SessionManager.GetInstance.Usuario.IdIdioma = idIdiomaSeleccionado;

                    LenguajeManager.GetInstance().CambiarIdioma(idIdiomaSeleccionado, nuevasTraducciones);

                    MessageBox.Show("Idioma actualizado correctamente / Language updated successfully.", "Éxito / Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron traducciones en el archivo JSON para el idioma seleccionado.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cambiar el idioma: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void ActualizarIdioma(object traducciones)
        {
            var diccTraducciones = (Dictionary<string, string>)traducciones;

            if (diccTraducciones.ContainsKey(this.Name))
            {
                this.Text = diccTraducciones[this.Name];
            }
            
            foreach (var item in diccTraducciones)
            {
                string nombreControl = item.Key;
                string textoTraducido = item.Value;

                Control[] encontrados = this.Controls.Find(nombreControl, true);
                if (encontrados.Length > 0)
                {
                    encontrados[0].Text = textoTraducido;
                }
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_vertical.Width = (Menu_vertical.Width == 250) ? 88 : 250;
        }

        private void Administración_boton_Click(object sender, EventArgs e)
        {
            Contenedor_Usuario.Height = (Contenedor_Usuario.Height == 58) ? 155 : 58;
        }

        private void btn_Administracion_Click(object sender, EventArgs e)
        {
            Contenedor_Administracion.Height = (Contenedor_Administracion.Height == 54) ? 143 : 54;
        }

        private void Icono_Cerrar_Click(object sender, EventArgs e) { Application.Exit(); }
        private void Icono_Maximizar_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Maximized; Icono_Maximizar.Visible = false; resaturar_icono.Visible = true; }
        private void resaturar_icono_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Normal; Icono_Maximizar.Visible = true; resaturar_icono.Visible = false; }
        private void Icono_Minimizar_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void panel_Menu_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0); }

        private void btn_CambiarContraseña_Click(object sender, EventArgs e) { AbrirFormHijo(new Cambiar_Contraseña()); }
        private void button1_Click(object sender, EventArgs e) { AbrirFormHijo(new FormUsuarios()); }
        private void btnBitacora_Click(object sender, EventArgs e) { AbrirFormHijo(new Bitacora()); }

        private void Menu_vertical_Paint(object sender, PaintEventArgs e) { }
        private void panel_Contenedor_Paint(object sender, PaintEventArgs e) { }
        private void Contenedor_Usuario_Paint(object sender, PaintEventArgs e) { }

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
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
        }
    }

    public class OpcionComboBox
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
