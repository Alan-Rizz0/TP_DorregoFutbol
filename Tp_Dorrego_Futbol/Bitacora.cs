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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarGrillaBitacora();
        }


        private void CargarGrillaBitacora()
        {
            try
            {
                BLL.BitacoraBLL bitacoraBll = new BLL.BitacoraBLL();

                dataGridViewBitacora.DataSource = bitacoraBll.ObtenerBitacora();

                dataGridViewBitacora.Columns["Id"].HeaderText = "ID";
                dataGridViewBitacora.Columns["Id_Usuario"].Visible = false;
                dataGridViewBitacora.Columns["Username"].HeaderText = "Usuario";
                dataGridViewBitacora.Columns["Fecha"].HeaderText = "Fecha / Hora";
                dataGridViewBitacora.Columns["Modulo"].HeaderText = "Módulo";
                dataGridViewBitacora.Columns["Evento"].HeaderText = "Acción / Evento";
                dataGridViewBitacora.Columns["Criticidad"].HeaderText = "Criticidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
