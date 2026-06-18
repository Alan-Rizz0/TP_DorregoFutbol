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
    public partial class btnCrearUsuario : Form
    {
        public btnCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtbNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtbApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtbDNI.Text))
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios", "Validar Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtbDNI.Text.Trim(), out int dniConvertido))
                {
                    MessageBox.Show("El campo DNI debe tener un numero entero valido", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BLL.UserBLL userbll= new BLL.UserBLL();
                userbll.CrearUsuario(
                    txtbUsername.Text.Trim(),
                    txtbNombre.Text.Trim(),
                    txtbApellido.Text.Trim(),
                    dniConvertido);

                txtbUsername.Clear();
                txtbNombre.Clear();
                txtbApellido.Clear();
                txtbDNI.Clear();
                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al procesar alta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void btnCrearUsuario_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }




        private void ActualizarGrilla()
        {
            try
            {
                BLL.UserBLL userBLL = new BLL.UserBLL();

                dataGridView1.DataSource = userBLL.ObtenerTodosLosUsuarios();
                dataGridView1.Columns["Bloqueado"].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios");
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("seleccione un usuario de la lista para desbloquear", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                //agarramos el id de la fila seleccionada
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value); 
                string username = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                int dni = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Dni"].Value);


                DialogResult result = MessageBox.Show("¿Esta seguro que desea desbloquear al usuario? "+username.ToString(), "Confirmar Desbloqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    BLL.UserBLL userBll = new BLL.UserBLL();

                    if (userBll.DesbloquearUsuario(idUsuario, nombre, dni))
                    {
                        MessageBox.Show("El usuario "+username.ToString()+" fue desbloqueado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrilla(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el desbloqueo en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar desbloquear: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActDesact_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un usuario de la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                string username = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();

                bool estaBloqueado = false;
                if (dataGridView1.CurrentRow.Cells["Bloqueado"].Value != null && dataGridView1.CurrentRow.Cells["Bloqueado"].Value != DBNull.Value)
                {
                    estaBloqueado = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Bloqueado"].Value);
                }

                
                string accion;
                if (estaBloqueado == true)
                {
                    accion = "ACTIVAR";
                }
                else
                {
                    accion = "DESACTIVAR";
                }

                DialogResult result = MessageBox.Show("Esta seguro que desea " + accion + " al usuario " + username, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    BLL.UserBLL userBll = new BLL.UserBLL();

                    if (userBll.CambiarEstadoActivo(idUsuario, estaBloqueado))
                    {
                        string mensajeExito = estaBloqueado ? "activado" : "desactivado";
                        MessageBox.Show("El usuario " + username + " fue " + mensajeExito + " correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarGrilla(); 
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

