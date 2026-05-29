using BLL;
using Servicios_Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Dorrego_Futbol
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }
        private readonly UserBLL userBLL = new UserBLL();

        private void Cambiar_Contraseña_Load(object sender, EventArgs e)
        {

        }

        private void btn_CambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                UserService usuarioActual = SessionManager.GetInstance.Usuario;

                bool exito = userBLL.CambiarClave(usuarioActual, txtbActual.Text, txtbNueva.Text, txtbRepetir.Text);

                if (exito)
                {
                    MessageBox.Show("Contraseña modificada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SessionManager.Logout();

                    Form menuAbierto = Application.OpenForms["Menu_Principal"];
                    if (menuAbierto != null)
                    {
                        menuAbierto.Close();
                    }

                    Log_in login = new Log_in();
                    login.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la contraseña en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
