namespace controleconsultorio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnmedicos = new System.Windows.Forms.ToolStripButton();
            this.btnpacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnconsultas = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpsegundo = new System.Windows.Forms.DateTimePicker();
            this.dtpprimeiro = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbmedico = new System.Windows.Forms.RadioButton();
            this.rbpaciente = new System.Windows.Forms.RadioButton();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgconsultas = new System.Windows.Forms.DataGridView();
            this.IDCODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETORNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaTableAdapter1 = new controleconsultorio.visual_studioDataSetTableAdapters.consultaTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmedicos,
            this.btnpacientes,
            this.toolStripSeparator1,
            this.btnconsultas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnmedicos
            // 
            this.btnmedicos.Image = global::controleconsultorio.Properties.Resources.asistante_icon_icons_com_55049__1_;
            this.btnmedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnmedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmedicos.Name = "btnmedicos";
            this.btnmedicos.Size = new System.Drawing.Size(56, 51);
            this.btnmedicos.Text = "Médicos";
            this.btnmedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmedicos.Click += new System.EventHandler(this.btnmedicos_Click);
            // 
            // btnpacientes
            // 
            this.btnpacientes.Image = global::controleconsultorio.Properties.Resources.Patient_Male_icon_icons_com_75053;
            this.btnpacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpacientes.Name = "btnpacientes";
            this.btnpacientes.Size = new System.Drawing.Size(61, 51);
            this.btnpacientes.Text = "Pacientes";
            this.btnpacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpacientes.Click += new System.EventHandler(this.btnpacientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnconsultas
            // 
            this.btnconsultas.Image = global::controleconsultorio.Properties.Resources.x_office_spreadsheet_35982;
            this.btnconsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnconsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(63, 51);
            this.btnconsultas.Text = "Consultas";
            this.btnconsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpsegundo);
            this.groupBox1.Controls.Add(this.dtpprimeiro);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo entre datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Até:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // dtpsegundo
            // 
            this.dtpsegundo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsegundo.Location = new System.Drawing.Point(58, 57);
            this.dtpsegundo.Name = "dtpsegundo";
            this.dtpsegundo.Size = new System.Drawing.Size(136, 26);
            this.dtpsegundo.TabIndex = 2;
            this.dtpsegundo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpprimeiro
            // 
            this.dtpprimeiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpprimeiro.Location = new System.Drawing.Point(58, 25);
            this.dtpprimeiro.Name = "dtpprimeiro";
            this.dtpprimeiro.Size = new System.Drawing.Size(136, 26);
            this.dtpprimeiro.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.rbmedico);
            this.groupBox2.Controls.Add(this.rbpaciente);
            this.groupBox2.Controls.Add(this.txtpesquisa);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(227, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de pesquisas";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbmedico
            // 
            this.rbmedico.AutoSize = true;
            this.rbmedico.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedico.Location = new System.Drawing.Point(120, 62);
            this.rbmedico.Name = "rbmedico";
            this.rbmedico.Size = new System.Drawing.Size(79, 24);
            this.rbmedico.TabIndex = 1;
            this.rbmedico.TabStop = true;
            this.rbmedico.Text = "Médico";
            this.rbmedico.UseVisualStyleBackColor = true;
            // 
            // rbpaciente
            // 
            this.rbpaciente.AutoSize = true;
            this.rbpaciente.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpaciente.Location = new System.Drawing.Point(20, 62);
            this.rbpaciente.Name = "rbpaciente";
            this.rbpaciente.Size = new System.Drawing.Size(90, 24);
            this.rbpaciente.TabIndex = 1;
            this.rbpaciente.TabStop = true;
            this.rbpaciente.Text = "Paciente";
            this.rbpaciente.UseVisualStyleBackColor = true;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(20, 30);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(305, 26);
            this.txtpesquisa.TabIndex = 0;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(577, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultas do dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "para exibir as consultas\r\n do dia, defina a data\r\n nos campos apropriados\r\n e cli" +
    "que em pesquisar";
            // 
            // dtgconsultas
            // 
            this.dtgconsultas.AllowUserToAddRows = false;
            this.dtgconsultas.AllowUserToDeleteRows = false;
            this.dtgconsultas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCODIGO,
            this.NOME_PACIENTE,
            this.IDMEDICO,
            this.IDPACIENTE,
            this.RETORNO,
            this.NOME_MEDICO,
            this.HORARIO,
            this.DATA});
            this.dtgconsultas.Location = new System.Drawing.Point(0, 216);
            this.dtgconsultas.Name = "dtgconsultas";
            this.dtgconsultas.ReadOnly = true;
            this.dtgconsultas.RowHeadersVisible = false;
            this.dtgconsultas.Size = new System.Drawing.Size(752, 264);
            this.dtgconsultas.TabIndex = 4;
            this.dtgconsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDCODIGO
            // 
            this.IDCODIGO.DataPropertyName = "ID_CONSULTA";
            this.IDCODIGO.HeaderText = "Código";
            this.IDCODIGO.Name = "IDCODIGO";
            this.IDCODIGO.ReadOnly = true;
            this.IDCODIGO.Width = 50;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.HeaderText = "Paciente";
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.ReadOnly = true;
            this.NOME_PACIENTE.Width = 200;
            // 
            // IDMEDICO
            // 
            this.IDMEDICO.HeaderText = "codigo medico";
            this.IDMEDICO.Name = "IDMEDICO";
            this.IDMEDICO.ReadOnly = true;
            this.IDMEDICO.Visible = false;
            // 
            // IDPACIENTE
            // 
            this.IDPACIENTE.HeaderText = "codigo paciente";
            this.IDPACIENTE.Name = "IDPACIENTE";
            this.IDPACIENTE.ReadOnly = true;
            this.IDPACIENTE.Visible = false;
            // 
            // RETORNO
            // 
            this.RETORNO.DataPropertyName = "RETORNO";
            this.RETORNO.HeaderText = "Retorno";
            this.RETORNO.Name = "RETORNO";
            this.RETORNO.ReadOnly = true;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.HeaderText = "Médico";
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.ReadOnly = true;
            this.NOME_MEDICO.Width = 200;
            // 
            // HORARIO
            // 
            this.HORARIO.DataPropertyName = "HORARIO";
            this.HORARIO.HeaderText = "Horário";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            this.HORARIO.Width = 110;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 110;
            // 
            // consultaTableAdapter1
            // 
            this.consultaTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controleconsultorio.Properties.Resources.repertorium_icon_icons_com_76243;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 479);
            this.Controls.Add(this.dtgconsultas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE CONSULTAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnmedicos;
        private System.Windows.Forms.ToolStripButton btnpacientes;
        private System.Windows.Forms.ToolStripButton btnconsultas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpsegundo;
        private System.Windows.Forms.DateTimePicker dtpprimeiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbmedico;
        private System.Windows.Forms.RadioButton rbpaciente;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgconsultas;
        private visual_studioDataSetTableAdapters.consultaTableAdapter consultaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETORNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
    }
}

