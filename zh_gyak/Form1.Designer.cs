namespace zh_gyak
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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            countryDataBindingSource2 = new BindingSource(components);
            countryDataBindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(50, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(537, 346);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            populationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            areaInSquareKmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // countryDataBindingSource2
            // 
            countryDataBindingSource2.DataSource = typeof(CountryData);
            // 
            // countryDataBindingSource1
            // 
            countryDataBindingSource1.DataSource = typeof(CountryData);
            // 
            // button1
            // 
            button1.Location = new Point(684, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "optimusz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(677, 183);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "prime";
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
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn areaInSqareKMDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button button1;
        private BindingSource countryDataBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource2;
        private Button button2;
    }
}