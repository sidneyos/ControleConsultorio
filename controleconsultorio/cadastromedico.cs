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
    public partial class cadastromedico : Form
    {
        public cadastromedico()
        {
            InitializeComponent();
        }

        private void medicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.visual_studioDataSet);

        }

        private void cadastromedico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'visual_studioDataSet.medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.visual_studioDataSet.medico);

        }

        private void iD_MEDICOLabel_Click(object sender, EventArgs e)
        {

        }

        private void tELEFONE_MEDICOLabel_Click(object sender, EventArgs e)
        {

        }

        private void nOME_MEDICOLabel_Click(object sender, EventArgs e)
        {

        }

        private void vALOR_CONSULTALabel_Click(object sender, EventArgs e)
        {

        }

        private void vALOR_CONSULTATextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
