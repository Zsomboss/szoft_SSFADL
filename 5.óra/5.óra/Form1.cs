namespace _5.óra
{
    public partial class Form1 : Form
    {
        List<Kérdés> Összeskérdés;
        List<Kérdés> Aktuáliskérdések;
        int MegjelenitettKérdésekSzáma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = KérdésekBetöltése();
            Aktuáliskérdések = new List<Kérdés>();

            for (int i = 0; i < 7; i++)
            {
                Aktuáliskérdések.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);

            }
            dataGridView1.DataSource = Aktuáliskérdések;
            KérdésMegjelenítés(Aktuáliskérdések[MegjelenitettKérdésekSzáma]);
        }

        List<Kérdés> KérdésekBetöltése()
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {

                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                Kérdés k = new Kérdés();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3].Trim('"');
                k.Válasz3 = tömb[4].Trim('"');
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;


                kérdések.Add(k);
            }

            sr.Close();
            return kérdések;

        }

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKérdésekSzáma++;
            if (MegjelenitettKérdésekSzáma == Aktuáliskérdések.Count) MegjelenitettKérdésekSzáma = 0;

            KérdésMegjelenítés(Aktuáliskérdések[MegjelenitettKérdésekSzáma]);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            Színezés();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
            Színezés();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Red;
            Színezés();
        }

        void Színezés()
        {
            int helyesVálasz = Aktuáliskérdések[MegjelenitettKérdésekSzáma].HelyesVálasz;
            if(helyesVálasz == 1) textBox1.BackColor = Color.Yellow;
            if (helyesVálasz == 2) textBox2.BackColor = Color.Yellow;
            if (helyesVálasz == 3) textBox3.BackColor = Color.Yellow;
        }
    }
}