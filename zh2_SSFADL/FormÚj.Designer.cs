namespace zh2_SSFADL
{
    partial class FormÚj
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
            label1 = new Label();
            textBox1 = new TextBox();
            repülőBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)repülőBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Járat azonosító";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", repülőBindingSource, "JaratID", true));
            textBox1.Location = new Point(43, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 1;
            // 
            // repülőBindingSource
            // 
            repülőBindingSource.DataSource = typeof(Repülő);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Légitársaság";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 169);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "Járat indulási hely";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 247);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Járat végállomás";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 300);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "Utasok száma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 362);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Időtartam";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", repülőBindingSource, "Legitarsasag", true));
            textBox2.Location = new Point(43, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", repülőBindingSource, "IndulasiHely", true));
            textBox3.Location = new Point(43, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", repülőBindingSource, "CelHely", true));
            textBox4.Location = new Point(43, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", repülőBindingSource, "UtasokSzama", true));
            textBox5.Location = new Point(43, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", repülőBindingSource, "IdotartamOra", true));
            textBox6.Location = new Point(43, 389);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 23);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(467, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormÚj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormÚj";
            Text = "FormÚj";
            ((System.ComponentModel.ISupportInitialize)repülőBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private BindingSource repülőBindingSource;
        private Button button1;
    }
}