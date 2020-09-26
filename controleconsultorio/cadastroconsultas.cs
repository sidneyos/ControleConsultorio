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
    public partial class cadastroconsultas : Form
    {
        public cadastroconsultas()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visual_studioDataSet);

        }

        private void cadastroconsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'visual_studioDataSet.medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.visual_studioDataSet.medico);
            // TODO: esta linha de código carrega dados na tabela 'visual_studioDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.visual_studioDataSet.paciente);
            // TODO: esta linha de código carrega dados na tabela 'visual_studioDataSet.consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.visual_studioDataSet.consulta);

        }

        private void rETORNOCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hORARIOLabel_Click(object sender, EventArgs e)
        {

        }

        private void hORARIODateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
