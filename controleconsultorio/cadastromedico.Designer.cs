﻿namespace controleconsultorio
{
    partial class cadastromedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastromedico));
            System.Windows.Forms.Label iD_MEDICOLabel;
            System.Windows.Forms.Label nOME_MEDICOLabel;
            System.Windows.Forms.Label tELEFONE_MEDICOLabel;
            System.Windows.Forms.Label vALOR_CONSULTALabel;
            this.visual_studioDataSet = new controleconsultorio.visual_studioDataSet();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new controleconsultorio.visual_studioDataSetTableAdapters.medicoTableAdapter();
            this.tableAdapterManager = new controleconsultorio.visual_studioDataSetTableAdapters.TableAdapterManager();
            this.medicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.nOME_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONE_MEDICOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vALOR_CONSULTATextBox = new System.Windows.Forms.TextBox();
            this.medicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_MEDICOLabel = new System.Windows.Forms.Label();
            nOME_MEDICOLabel = new System.Windows.Forms.Label();
            tELEFONE_MEDICOLabel = new System.Windows.Forms.Label();
            vALOR_CONSULTALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visual_studioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).BeginInit();
            this.medicoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visual_studioDataSet
            // 
            this.visual_studioDataSet.DataSetName = "visual_studioDataSet";
            this.visual_studioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "medico";
            this.medicoBindingSource.DataSource = this.visual_studioDataSet;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.medicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = controleconsultorio.visual_studioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicoBindingNavigator
            // 
            this.medicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicoBindingNavigator.BindingSource = this.medicoBindingSource;
            this.medicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicoBindingNavigatorSaveItem});
            this.medicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicoBindingNavigator.Name = "medicoBindingNavigator";
            this.medicoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.medicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicoBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.medicoBindingNavigator.TabIndex = 0;
            this.medicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // medicoBindingNavigatorSaveItem
            // 
            this.medicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicoBindingNavigatorSaveItem.Image")));
            this.medicoBindingNavigatorSaveItem.Name = "medicoBindingNavigatorSaveItem";
            this.medicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.medicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicoBindingNavigatorSaveItem_Click);
            // 
            // iD_MEDICOLabel
            // 
            iD_MEDICOLabel.AutoSize = true;
            iD_MEDICOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_MEDICOLabel.Location = new System.Drawing.Point(23, 55);
            iD_MEDICOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iD_MEDICOLabel.Name = "iD_MEDICOLabel";
            iD_MEDICOLabel.Size = new System.Drawing.Size(61, 16);
            iD_MEDICOLabel.TabIndex = 1;
            iD_MEDICOLabel.Text = "codigo:";
            iD_MEDICOLabel.Click += new System.EventHandler(this.iD_MEDICOLabel_Click);
            // 
            // iD_MEDICOTextBox
            // 
            this.iD_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "ID_MEDICO", true));
            this.iD_MEDICOTextBox.Location = new System.Drawing.Point(92, 52);
            this.iD_MEDICOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iD_MEDICOTextBox.Name = "iD_MEDICOTextBox";
            this.iD_MEDICOTextBox.Size = new System.Drawing.Size(123, 22);
            this.iD_MEDICOTextBox.TabIndex = 2;
            // 
            // nOME_MEDICOLabel
            // 
            nOME_MEDICOLabel.AutoSize = true;
            nOME_MEDICOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_MEDICOLabel.Location = new System.Drawing.Point(29, 87);
            nOME_MEDICOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOME_MEDICOLabel.Name = "nOME_MEDICOLabel";
            nOME_MEDICOLabel.Size = new System.Drawing.Size(55, 16);
            nOME_MEDICOLabel.TabIndex = 3;
            nOME_MEDICOLabel.Text = "Nome:";
            nOME_MEDICOLabel.Click += new System.EventHandler(this.nOME_MEDICOLabel_Click);
            // 
            // nOME_MEDICOTextBox
            // 
            this.nOME_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "NOME_MEDICO", true));
            this.nOME_MEDICOTextBox.Location = new System.Drawing.Point(92, 84);
            this.nOME_MEDICOTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nOME_MEDICOTextBox.Name = "nOME_MEDICOTextBox";
            this.nOME_MEDICOTextBox.Size = new System.Drawing.Size(343, 22);
            this.nOME_MEDICOTextBox.TabIndex = 4;
            // 
            // tELEFONE_MEDICOLabel
            // 
            tELEFONE_MEDICOLabel.AutoSize = true;
            tELEFONE_MEDICOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONE_MEDICOLabel.Location = new System.Drawing.Point(9, 119);
            tELEFONE_MEDICOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tELEFONE_MEDICOLabel.Name = "tELEFONE_MEDICOLabel";
            tELEFONE_MEDICOLabel.Size = new System.Drawing.Size(75, 16);
            tELEFONE_MEDICOLabel.TabIndex = 5;
            tELEFONE_MEDICOLabel.Text = "Telefone:";
            tELEFONE_MEDICOLabel.Click += new System.EventHandler(this.tELEFONE_MEDICOLabel_Click);
            // 
            // tELEFONE_MEDICOMaskedTextBox
            // 
            this.tELEFONE_MEDICOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "TELEFONE_MEDICO", true));
            this.tELEFONE_MEDICOMaskedTextBox.Location = new System.Drawing.Point(92, 116);
            this.tELEFONE_MEDICOMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tELEFONE_MEDICOMaskedTextBox.Mask = "(99) 0000-0000";
            this.tELEFONE_MEDICOMaskedTextBox.Name = "tELEFONE_MEDICOMaskedTextBox";
            this.tELEFONE_MEDICOMaskedTextBox.Size = new System.Drawing.Size(123, 22);
            this.tELEFONE_MEDICOMaskedTextBox.TabIndex = 6;
            // 
            // vALOR_CONSULTALabel
            // 
            vALOR_CONSULTALabel.AutoSize = true;
            vALOR_CONSULTALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vALOR_CONSULTALabel.Location = new System.Drawing.Point(262, 119);
            vALOR_CONSULTALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vALOR_CONSULTALabel.Name = "vALOR_CONSULTALabel";
            vALOR_CONSULTALabel.Size = new System.Drawing.Size(51, 16);
            vALOR_CONSULTALabel.TabIndex = 7;
            vALOR_CONSULTALabel.Text = "Valor:";
            vALOR_CONSULTALabel.Click += new System.EventHandler(this.vALOR_CONSULTALabel_Click);
            // 
            // vALOR_CONSULTATextBox
            // 
            this.vALOR_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "VALOR_CONSULTA", true));
            this.vALOR_CONSULTATextBox.Location = new System.Drawing.Point(321, 116);
            this.vALOR_CONSULTATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vALOR_CONSULTATextBox.Name = "vALOR_CONSULTATextBox";
            this.vALOR_CONSULTATextBox.Size = new System.Drawing.Size(114, 22);
            this.vALOR_CONSULTATextBox.TabIndex = 8;
            this.vALOR_CONSULTATextBox.TextChanged += new System.EventHandler(this.vALOR_CONSULTATextBox_TextChanged);
            // 
            // medicoDataGridView
            // 
            this.medicoDataGridView.AllowUserToAddRows = false;
            this.medicoDataGridView.AllowUserToDeleteRows = false;
            this.medicoDataGridView.AutoGenerateColumns = false;
            this.medicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.medicoDataGridView.DataSource = this.medicoBindingSource;
            this.medicoDataGridView.Location = new System.Drawing.Point(0, 194);
            this.medicoDataGridView.Name = "medicoDataGridView";
            this.medicoDataGridView.ReadOnly = true;
            this.medicoDataGridView.RowHeadersVisible = false;
            this.medicoDataGridView.Size = new System.Drawing.Size(450, 239);
            this.medicoDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDICO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_MEDICO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_MEDICO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR_CONSULTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cadastromedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 434);
            this.Controls.Add(this.medicoDataGridView);
            this.Controls.Add(iD_MEDICOLabel);
            this.Controls.Add(this.iD_MEDICOTextBox);
            this.Controls.Add(nOME_MEDICOLabel);
            this.Controls.Add(this.nOME_MEDICOTextBox);
            this.Controls.Add(tELEFONE_MEDICOLabel);
            this.Controls.Add(this.tELEFONE_MEDICOMaskedTextBox);
            this.Controls.Add(vALOR_CONSULTALabel);
            this.Controls.Add(this.vALOR_CONSULTATextBox);
            this.Controls.Add(this.medicoBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "cadastromedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE MEDICOS";
            this.Load += new System.EventHandler(this.cadastromedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visual_studioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).EndInit();
            this.medicoBindingNavigator.ResumeLayout(false);
            this.medicoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private visual_studioDataSet visual_studioDataSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private visual_studioDataSetTableAdapters.medicoTableAdapter medicoTableAdapter;
        private visual_studioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_MEDICOTextBox;
        private System.Windows.Forms.TextBox nOME_MEDICOTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONE_MEDICOMaskedTextBox;
        private System.Windows.Forms.TextBox vALOR_CONSULTATextBox;
        private System.Windows.Forms.DataGridView medicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}