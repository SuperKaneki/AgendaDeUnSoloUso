using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaRama
{
    public partial class frm : Form
    {
        List<clsContacto> Contactos = new List<clsContacto>();

        public frm()
        {
            InitializeComponent();
        }

        clsContacto Contacto = new clsContacto();
        private void LlenarDataGrid()
        {
            dataGridView1.DataSource = null;
            if (Contactos.Count > 0)
                dataGridView1.DataSource = Contactos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContacto Nuevo = new AgendaRama.frmContacto();
            if(Nuevo.ShowDialog() == DialogResult.OK)
            {
                //Cargar nuevamente el listado
                Contacto = new AgendaRama.clsContacto();
                Contacto.Nombre = Nuevo.Nombre;
                Contacto.Teléfono = Nuevo.Teléfono;
                Contacto.Ciudad = Nuevo.Ciudad;
                Contactos.Add(Contacto);
                LlenarDataGrid();
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contactos.RemoveAt(dataGridView1.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
