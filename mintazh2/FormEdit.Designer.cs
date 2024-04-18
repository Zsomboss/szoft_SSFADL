namespace mintazh2
{
    partial class FormEdit
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
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            vizsgaKerdesekBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesekBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "sorszám";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 113);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(553, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 151);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(354, 88);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(389, 148);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(399, 91);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 268);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(354, 58);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(39, 355);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(679, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vizsgaKerdesekBindingSource
            // 
            vizsgaKerdesekBindingSource.DataSource = typeof(VizsgaKerdesek);
            // 
            // FormEdit
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
            Controls.Add(label1);
            Controls.Add(textBox1);
            DataBindings.Add(new Binding("Text", vizsgaKerdesekBindingSource, "Szam", true));
            Name = "FormEdit";
            Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)vizsgaKerdesekBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private BindingSource vizsgaKerdesekBindingSource;
    }
}