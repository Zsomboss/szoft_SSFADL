using Timer = System.Windows.Forms.Timer;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        K�rtya el�z�K�rtya;
        K�rtya jelenlegiK�rtya;
        bool k�rty�kZ�rva = false;
        ComboBox neh�zs�gComboBox;
        int sorokSz�ma;
        int oszlopokSz�ma;
        int j�K�s�rletekSz�ma = 0;
        int rosszK�s�rletekSz�ma = 0;
        Label statisztikaLabel;
        Timer j�t�kId�z�t�;
        DateTime j�t�kInd�t�siId�;
        List<int> el�rhet�K�pek = Enumerable.Range(1, 18).ToList(); // Legfeljebb 18 k�p

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeStatisztikaLabel();
            InitializeId�z�t�();
        }

        private void InitializeComboBox()
        {
            neh�zs�gComboBox = new ComboBox();
            neh�zs�gComboBox.Items.AddRange(new object[] { "4x4", "6x6" });
            neh�zs�gComboBox.SelectedIndex = 0; // Alap�rtelmezett kiv�laszt�s a 4x4
            neh�zs�gComboBox.SelectedIndexChanged += Neh�zs�gComboBox_SelectedIndexChanged;
            Controls.Add(neh�zs�gComboBox);
        }

        private void InitializeStatisztikaLabel()
        {
            statisztikaLabel = new Label();
            statisztikaLabel.Top = 40;
            statisztikaLabel.Left = 10;
            statisztikaLabel.AutoSize = true;
            Controls.Add(statisztikaLabel);
            Friss�tStatisztika();
        }

        private void InitializeId�z�t�()
        {
            j�t�kId�z�t� = new Timer();
            j�t�kId�z�t�.Interval = 1000;
            j�t�kId�z�t�.Tick += (s, e) =>
            {
                TimeSpan elteltId� = DateTime.Now - j�t�kInd�t�siId�;
                Friss�tStatisztika(elteltId�);
            };
        }

        private void Neh�zs�gComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (neh�zs�gComboBox.SelectedItem.ToString())
            {
                case "4x4":
                    sorokSz�ma = 4;
                    oszlopokSz�ma = 4;
                    break;
                case "6x6":
                    sorokSz�ma = 6;
                    oszlopokSz�ma = 6;
                    break;
            }
            �jJ�t�k();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.h�tt�rk�p);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

            sorokSz�ma = 4;
            oszlopokSz�ma = 4;
            �jJ�t�k();
        }

        private void �jJ�t�k()
        {
            Controls.Clear();
            Controls.Add(neh�zs�gComboBox);
            Controls.Add(statisztikaLabel);
    
            el�z�K�rtya = null;
            jelenlegiK�rtya = null;
            k�rty�kZ�rva = false;
            j�K�s�rletekSz�ma = 0;
            rosszK�s�rletekSz�ma = 0;
            j�t�kInd�t�siId� = DateTime.Now;
            j�t�kId�z�t�.Start();
            Friss�tStatisztika();

            int k�rty�kSz�ma = sorokSz�ma * oszlopokSz�ma;
            if (k�rty�kSz�ma / 2 > 18) k�rty�kSz�ma = 36; // Maximum 18 p�ros lehet

            int[] t = Kever�s(k�rty�kSz�ma);
            int sorSz�m = 0;

            for (int s = 0; s < sorokSz�ma; s++)
            {
                for (int o = 0; o < oszlopokSz�ma; o++)
                {
                    if (sorSz�m >= k�rty�kSz�ma) break;

                    K�rtya k = new K�rtya(s, o, t[sorSz�m]);
                    Controls.Add(k);
                    k.Click += K_Click;
                    sorSz�m++;
                }
            }
        }

        private void K_Click(object? sender, EventArgs e)
        {
            if (sender is K�rtya k && !k�rty�kZ�rva)
            {
                if (k == el�z�K�rtya || k == jelenlegiK�rtya) return; // Ha ugyanarra a k�rty�ra kattintanak

                k.Felford�t();

                if (el�z�K�rtya == null)
                {
                    el�z�K�rtya = k;
                }
                else if (jelenlegiK�rtya == null)
                {
                    jelenlegiK�rtya = k;
                    if (jelenlegiK�rtya.k�pSz�m == el�z�K�rtya.k�pSz�m)
                    {
                        j�K�s�rletekSz�ma++;
                        jelenlegiK�rtya = null;
                        el�z�K�rtya = null;
                    }
                    else
                    {
                        rosszK�s�rletekSz�ma++;
                        k�rty�kZ�rva = true;
                        Timer timer = new Timer();
                        timer.Interval = 1000;
                        timer.Tick += (s, ev) =>
                        {
                            el�z�K�rtya.Leford�t();
                            jelenlegiK�rtya.Leford�t();
                            el�z�K�rtya = null;
                            jelenlegiK�rtya = null;
                            k�rty�kZ�rva = false;
                            timer.Stop();
                        };
                        timer.Start();
                    }
                    Friss�tStatisztika();
                }
            }
        }

        private void Friss�tStatisztika()
        {
            Friss�tStatisztika(DateTime.Now - j�t�kInd�t�siId�);
        }

        private void Friss�tStatisztika(TimeSpan elteltId�)
        {
            int �sszesK�s�rlet = j�K�s�rletekSz�ma + rosszK�s�rletekSz�ma;
            double ar�ny = �sszesK�s�rlet > 0 ? (double)j�K�s�rletekSz�ma / �sszesK�s�rlet * 100 : 0;
            statisztikaLabel.Text = $"J� k�s�rletek: {j�K�s�rletekSz�ma}\nRossz k�s�rletek: {rosszK�s�rletekSz�ma}\nAr�ny: {ar�ny:F2}%\nEltelt id�: {elteltId�:mm\\:ss}";
        }

        int[] Kever�s(int k�rtyasz�m)
        {
            Random rnd = new Random();
            List<int> kevertK�pek = el�rhet�K�pek.OrderBy(x => rnd.Next()).Take(k�rtyasz�m / 2).ToList();
            kevertK�pek.AddRange(kevertK�pek); // P�ros�tjuk a k�peket
            kevertK�pek = kevertK�pek.OrderBy(x => rnd.Next()).ToList();

            return kevertK�pek.ToArray();
        }
    }
}
