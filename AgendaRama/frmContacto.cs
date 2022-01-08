﻿using System;
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
    public partial class frmContacto : Form
    {
        public string Nombre;
        public string Teléfono;
        public string Ciudad;

        public frmContacto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmContacto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCiudad Ciudad = new AgendaRama.frmCiudad();
            if(Ciudad.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(Ciudad.Nombre);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombre = textBox1.Text;
            Teléfono = maskedTextBox1.Text;
            Ciudad = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
