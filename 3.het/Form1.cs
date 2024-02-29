namespace _3.het
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);
            

            b.Left = ClientRectangle.Width / 2 - b.Width/2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;

            int meret = 20;
            Random random = new Random();
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = meret;
                    p.Width = meret;
                    p.Left = meret * oszlop;
                    p.Top = meret * sor;
                    p.BackColor = Color.FromArgb(random.Next(0,255),0,0);

                }
            }
        }
    }
}