namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 50; i++)
            {
                Sor ujSor = new Sor();
                ujSor.Ertek = Fibonacci(i);
                ujSor.Sorszam = i;

                sorok.Add(ujSor);
            
            }
            dataGridView1.DataSource = sorok;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);


        }
    }
}