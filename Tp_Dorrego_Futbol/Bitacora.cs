using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tp_Dorrego_Futbol
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void ConfigurarDGV()
        {
            if (dataGridViewBitacora.Columns.Count == 0) 
            { 
                return; 
            }

            dataGridViewBitacora.Columns["Id"].HeaderText = "ID";
            dataGridViewBitacora.Columns["Id_Usuario"].Visible = false;
            dataGridViewBitacora.Columns["Username"].HeaderText = "Usuario";
            dataGridViewBitacora.Columns["Nombre"].HeaderText = "Nombre";
            dataGridViewBitacora.Columns["Apellido"].HeaderText = "Apellido";
            dataGridViewBitacora.Columns["Fecha"].HeaderText = "Fecha / Hora";
            dataGridViewBitacora.Columns["Modulo"].HeaderText = "Módulo";
            dataGridViewBitacora.Columns["Evento"].HeaderText = "Acción / Evento";
            dataGridViewBitacora.Columns["Criticidad"].HeaderText = "Criticidad";


            dataGridViewBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBitacora.MultiSelect = false;
            dataGridViewBitacora.ReadOnly = true;
            dataGridViewBitacora.AllowUserToAddRows = false;
        }

        private void CargarCombos()
        {
            if (dataGridViewBitacora.DataSource == null) 
            {  
                return; 
            }

            DataTable tabla = null;


            //aca convertimos el dgv en una tabla asi podemos utilizarlo
            if (dataGridViewBitacora.DataSource is DataTable)
            {
                tabla = (DataTable)dataGridViewBitacora.DataSource;
            }
            else if (dataGridViewBitacora.DataSource is DataView)
            {
                tabla = ((DataView)dataGridViewBitacora.DataSource).Table;
            }

            if (tabla == null)
            {
                return;
            }

            cmbLogin.Items.Clear();
            cmbModulo.Items.Clear();
            cmbEvento.Items.Clear();
            cmbCriticidad.Items.Clear();

            cmbLogin.Items.Add("Cualquiera");
            cmbModulo.Items.Add("Cualquiera");
            cmbEvento.Items.Add("Cualquiera");
            cmbCriticidad.Items.Add("Cualquiera");


            //utilizamos listas para poder comparar todos los registros y que no haya duplicidades
            List<string> logins = new List<string>();
            List<string> modulos = new List<string>();
            List<string> eventos = new List<string>();

            //recorremos la tabla para evitar valores repetidos y almacenarlo en su respectiva lista
            foreach (DataRow fila in tabla.Rows)
            {
                string login = "";
                string modulo = "";
                string evento = "";

                if (fila["Username"] != DBNull.Value)
                {
                    login = fila["Username"].ToString();
                }

                if (fila["Modulo"] != DBNull.Value)
                {
                    modulo = fila["Modulo"].ToString();
                }

                if (fila["Evento"] != DBNull.Value)
                {
                    evento = fila["Evento"].ToString();
                }

                if (!string.IsNullOrWhiteSpace(login) && !logins.Contains(login))
                {
                    logins.Add(login);
                }

                if (!string.IsNullOrWhiteSpace(modulo) && !modulos.Contains(modulo))
                {
                    modulos.Add(modulo);
                }

                if (!string.IsNullOrWhiteSpace(evento) && !eventos.Contains(evento))
                {
                    eventos.Add(evento);
                }

            }


            //ordena los resultados, pura prolijidad
            logins.Sort();
            modulos.Sort();
            eventos.Sort();


            //Por ultimo cargamos los valores en las cmbos
            foreach (string login in logins)
            {
                cmbLogin.Items.Add(login);
            }
            

            foreach (string modulo in modulos)
            {
                cmbModulo.Items.Add(modulo);
            }

            foreach (string evento in eventos)
            {
                cmbEvento.Items.Add(evento);
            }

            cmbCriticidad.Items.Add("1");
            cmbCriticidad.Items.Add("2");
            cmbCriticidad.Items.Add("3");
            cmbCriticidad.Items.Add("4");
            cmbCriticidad.Items.Add("5");

            //cualquiera por defecto
            cmbLogin.SelectedIndex = 0;
            cmbModulo.SelectedIndex = 0;
            cmbEvento.SelectedIndex = 0;
            cmbCriticidad.SelectedIndex = 0;

            //evitamos que el usuario escriba en la combo
            cmbLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriticidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void Bitacora_Load(object sender, EventArgs e)
        {
            dateFechadesde.ShowCheckBox = true;
            dateFechaHasta.ShowCheckBox = true;

            dateFechadesde.Checked = false;
            dateFechaHasta.Checked = false;

            CargarGrillaBitacora();
            CargarCombos();
        }

        private bool ValidarFechas()
        {
            if (dateFechadesde.Checked && dateFechaHasta.Checked)
            {
                DateTime fechaInicio = dateFechadesde.Value.Date;
                DateTime fechaFin = dateFechaHasta.Value.Date;

                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.", "Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                   
                    return false;
                }
            }


            return true;
        }

        private void CargarGrillaBitacora()
        {
            try
            {
                BLL.BitacoraBLL bitacoraBll = new BLL.BitacoraBLL();

                dataGridViewBitacora.DataSource = bitacoraBll.ObtenerBitacora();

                ConfigurarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitacora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private string ObtenerValorCombo(ComboBox comboBox)
        {
            if(comboBox.SelectedItem == null)
            {
                return null;
            }

            string valor = comboBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(valor) || valor == "Cualquiera")
            {
                return null;
            }

            return valor;
        } 

        private int? ObtenerValorComboCriticidad(ComboBox cmbCriticidad)
        {
            string valor = ObtenerValorCombo(cmbCriticidad);

            if (valor == null)
            {
                return null;
            }

            int criticidad;

            if (!int.TryParse(valor, out criticidad))
            {
                return null;
            }

            return criticidad;
        }


        private void CargarGrillaBitacoraFiltrada()
        {
            try
            {

                string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text.Trim();
                string apellido = string.IsNullOrWhiteSpace(txtApellido.Text) ? null : txtApellido.Text.Trim();

                string username = ObtenerValorCombo(cmbLogin);
                string modulo = ObtenerValorCombo(cmbModulo);
                string evento = ObtenerValorCombo(cmbEvento);

                //si el usuario elige en la comboBox la opcion de cualquiera lo tomamos como un null por eso los if y los ? en los tipo de dato
                int? criticidad = ObtenerValorComboCriticidad(cmbCriticidad);

                DateTime? fechaInicio = dateFechadesde.Checked ? dateFechadesde.Value.Date : (DateTime?) null;
                DateTime? fechaFin = dateFechaHasta.Checked ? dateFechaHasta.Value.Date : (DateTime?)null;

                BLL.BitacoraBLL bitacoraBll = new BLL.BitacoraBLL();

                dataGridViewBitacora.DataSource = bitacoraBll.ObtenerBitacoraFiltrada(nombre,apellido,username,modulo,evento,criticidad,fechaInicio,fechaFin);


                if (dataGridViewBitacora.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No se encontraron eventos para los filtros ingresados", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                ConfigurarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la bitacora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!ValidarFechas())
            {
                return;
            }

            CargarGrillaBitacoraFiltrada();

        }

        private void LimpiarControles()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void LimpiarCombo(ComboBox comboBox)
        {
            if (comboBox.Items.Contains("Cualquiera"))
            {
                comboBox.SelectedItem = "Cualquiera";
            }
            else if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            txtApellido.Clear();

            /*
            LimpiarCombo(cmbCriticidad);
            LimpiarCombo(cmbEvento);
            LimpiarCombo(cmbModulo);
            LimpiarCombo(cmbLogin);
            */

            CargarGrillaBitacora();
        }
    }
}
