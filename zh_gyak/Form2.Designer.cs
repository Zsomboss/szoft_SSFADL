namespace zh_gyak
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            countryDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Name", true));
            textBox1.Location = new Point(286, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Population", true));
            textBox2.Location = new Point(293, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", countryDataBindingSource, "AreaInSquareKm", true));
            textBox3.Location = new Point(286, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 23);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(642, 199);
            button1.Name = "button1";
            button1.Size = new Size(76, 41);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private BindingSource countryDataBindingSource;
        private BindingSource bindingSource1;
    }
}