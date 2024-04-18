namespace zh2_SSFADL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            jaratIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legitarsasagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indulasiHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utasokSzamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idotartamOraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repülőBindingSource = new BindingSource(components);
            button1Load = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repülőBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jaratIDDataGridViewTextBoxColumn, legitarsasagDataGridViewTextBoxColumn, indulasiHelyDataGridViewTextBoxColumn, celHelyDataGridViewTextBoxColumn, utasokSzamaDataGridViewTextBoxColumn, idotartamOraDataGridViewTextBoxColumn });
            dataGridView1.DataSource = repülőBindingSource;
            dataGridView1.Location = new Point(57, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(518, 259);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // jaratIDDataGridViewTextBoxColumn
            // 
            jaratIDDataGridViewTextBoxColumn.DataPropertyName = "JaratID";
            jaratIDDataGridViewTextBoxColumn.HeaderText = "JaratID";
            jaratIDDataGridViewTextBoxColumn.Name = "jaratIDDataGridViewTextBoxColumn";
            // 
            // legitarsasagDataGridViewTextBoxColumn
            // 
            legitarsasagDataGridViewTextBoxColumn.DataPropertyName = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.HeaderText = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.Name = "legitarsasagDataGridViewTextBoxColumn";
            // 
            // indulasiHelyDataGridViewTextBoxColumn
            // 
            indulasiHelyDataGridViewTextBoxColumn.DataPropertyName = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.HeaderText = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.Name = "indulasiHelyDataGridViewTextBoxColumn";
            // 
            // celHelyDataGridViewTextBoxColumn
            // 
            celHelyDataGridViewTextBoxColumn.DataPropertyName = "CelHely";
            celHelyDataGridViewTextBoxColumn.HeaderText = "CelHely";
            celHelyDataGridViewTextBoxColumn.Name = "celHelyDataGridViewTextBoxColumn";
            // 
            // utasokSzamaDataGridViewTextBoxColumn
            // 
            utasokSzamaDataGridViewTextBoxColumn.DataPropertyName = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.HeaderText = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.Name = "utasokSzamaDataGridViewTextBoxColumn";
            // 
            // idotartamOraDataGridViewTextBoxColumn
            // 
            idotartamOraDataGridViewTextBoxColumn.DataPropertyName = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.HeaderText = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.Name = "idotartamOraDataGridViewTextBoxColumn";
            // 
            // repülőBindingSource
            // 
            repülőBindingSource.DataSource = typeof(Repülő);
            // 
            // button1Load
            // 
            button1Load.Location = new Point(593, 65);
            button1Load.Name = "button1Load";
            button1Load.Size = new Size(75, 23);
            button1Load.TabIndex = 1;
            button1Load.Text = "Betöltés";
            button1Load.UseVisualStyleBackColor = true;
            button1Load.Click += button1Load_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(500, 65);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(500, 397);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(642, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Új sor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 47);
            button2.Name = "button2";
            button2.Size = new Size(178, 41);
            button2.TabIndex = 5;
            button2.Text = "érdekességek";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(button1Load);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repülőBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1Load;
        private DataGridViewTextBoxColumn jaratIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legitarsasagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indulasiHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn utasokSzamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idotartamOraDataGridViewTextBoxColumn;
        private BindingSource repülőBindingSource;
        private Button buttonSave;
        private Button buttonDelete;
        private Button button1;
        private Button button2;
    }
}