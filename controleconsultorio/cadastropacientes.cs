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
    public partial class cadastropacientes : Form
    {
        public cadastropacientes()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visual_studioDataSet);

        }

        private void cadastropacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'visual_studioDataSet.paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.visual_studioDataSet.paciente);

        }

        private void sEXOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sEXOLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
