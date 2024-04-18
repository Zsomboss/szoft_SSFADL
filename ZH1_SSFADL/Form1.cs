namespace ZH1_SSFADL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> lista = new List<Sor>();
            for (int i = 0; i < 11; i++)
            {
                Sor sorok = new Sor();
                sorok.Szám = i;
                sorok.Fibo = Fibonacci(i);
                lista.Add(sorok);

            }
            dataGridView1.DataSource = lista;
        }
        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 6; j++)
            {


                for (int i = 0; i < 6; i++)
                {
                    OnOFFButton gomb = new OnOFFButton();
                    gomb.Left = i * 50;
                    Controls.Add(gomb);
                }
            }
        }
    }
}