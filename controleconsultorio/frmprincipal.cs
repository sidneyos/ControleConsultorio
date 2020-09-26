using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleconsultorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmedicos_Click(object sender, EventArgs e)
        {
            cadastromedico novomedico = new cadastromedico();
            novomedico.ShowDialog();
        }

        private void btnpacientes_Click(object sender, EventArgs e)
        {
            cadastropacientes novopaciente = new cadastropacientes();
            novopaciente.ShowDialog();
        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            cadastroconsultas novaconsulta = new cadastroconsultas();
            novaconsulta.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dtgconsultas.DataSource = consultaTableAdapter1.retornarconsultas(dtpprimeiro.Value);
            if (txtpesquisa.Text == "")
            {
                dtgconsultas.DataSource = consultaTableAdapter1.retornarmedicos(txtpesquisa.Text, dtpprimeiro.Value, dtpsegundo.Value);
            }
            else
            {
                if (rbmedico.Checked == true)
                {
                    dtgconsultas.DataSource = consultaTableAdapter1.retornarmedicos(txtpesquisa.Text, dtpprimeiro.Value, dtpsegundo.Value);
                }
                else
                {
                    if (rbpaciente.Checked == true)
                    {
                        dtgconsultas.DataSource = consultaTableAdapter1.retornarpacientes(txtpesquisa.Text, dtpprimeiro.Value, dtpsegundo.Value);
                    }
                }
            }
        }

      

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgconsultas.DataSource = consultaTableAdapter1.retornarconsultas(dtpprimeiro.Value);
        }
    }
}
