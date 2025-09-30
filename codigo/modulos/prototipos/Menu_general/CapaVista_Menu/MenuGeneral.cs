using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad;
using Capa_Vista_Navegador;
using PruebaEjecucionNavegador;
using System.Diagnostics;

namespace CapaVista_Menu
{
    public partial class MenuGeneral : Form
    {

        public MenuGeneral()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Mensaje",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();//Cierra el formulario
        }

        private void consultaBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.frmBitacora bitacora = new CapaVista_Seguridad.frmBitacora();
            bitacora.ShowDialog();
        }

        private void identificacionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.alumno bitacora = new CapaVista_Seguridad.alumno();
            bitacora.ShowDialog();
        }

        private void mantenimiento1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.CRUD bitacora = new CapaVista_Seguridad.CRUD();
            bitacora.ShowDialog();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaVista_Seguridad.reporte bitacora = new CapaVista_Seguridad.reporte();
            bitacora.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaCHM = @"C:\Users\dannus\Desktop\FORK\ayudas\ayudas.chm";

            try
            {
                Process.Start(rutaCHM);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo de ayuda. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
