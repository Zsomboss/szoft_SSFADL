using Timer = System.Windows.Forms.Timer;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Kártya elõzõKártya;
        Kártya jelenlegiKártya;
        bool kártyákZárva = false;
        ComboBox nehézségComboBox;
        int sorokSzáma;
        int oszlopokSzáma;
        int jóKísérletekSzáma = 0;
        int rosszKísérletekSzáma = 0;
        Label statisztikaLabel;
        Timer játékIdõzítõ;
        DateTime játékIndításiIdõ;
        List<int> elérhetõKépek = Enumerable.Range(1, 18).ToList(); // Legfeljebb 18 kép

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeStatisztikaLabel();
            InitializeIdõzítõ();
        }

        private void InitializeComboBox()
        {
            nehézségComboBox = new ComboBox();
            nehézségComboBox.Items.AddRange(new object[] { "4x4", "6x6" });
            nehézségComboBox.SelectedIndex = 0; // Alapértelmezett kiválasztás a 4x4
            nehézségComboBox.SelectedIndexChanged += NehézségComboBox_SelectedIndexChanged;
            Controls.Add(nehézségComboBox);
        }

        private void InitializeStatisztikaLabel()
        {
            statisztikaLabel = new Label();
            statisztikaLabel.Top = 40;
            statisztikaLabel.Left = 10;
            statisztikaLabel.AutoSize = true;
            Controls.Add(statisztikaLabel);
            FrissítStatisztika();
        }

        private void InitializeIdõzítõ()
        {
            játékIdõzítõ = new Timer();
            játékIdõzítõ.Interval = 1000;
            játékIdõzítõ.Tick += (s, e) =>
            {
                TimeSpan elteltIdõ = DateTime.Now - játékIndításiIdõ;
                FrissítStatisztika(elteltIdõ);
            };
        }

        private void NehézségComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nehézségComboBox.SelectedItem.ToString())
            {
                case "4x4":
                    sorokSzáma = 4;
                    oszlopokSzáma = 4;
                    break;
                case "6x6":
                    sorokSzáma = 6;
                    oszlopokSzáma = 6;
                    break;
            }
            ÚjJáték();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Bitmap.FromFile(Properties.Settings.Default.háttérkép);
            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

            sorokSzáma = 4;
            oszlopokSzáma = 4;
            ÚjJáték();
        }

        private void ÚjJáték()
        {
            Controls.Clear();
            Controls.Add(nehézségComboBox);
            Controls.Add(statisztikaLabel);
    
            elõzõKártya = null;
            jelenlegiKártya = null;
            kártyákZárva = false;
            jóKísérletekSzáma = 0;
            rosszKísérletekSzáma = 0;
            játékIndításiIdõ = DateTime.Now;
            játékIdõzítõ.Start();
            FrissítStatisztika();

            int kártyákSzáma = sorokSzáma * oszlopokSzáma;
            if (kártyákSzáma / 2 > 18) kártyákSzáma = 36; // Maximum 18 páros lehet

            int[] t = Keverés(kártyákSzáma);
            int sorSzám = 0;

            for (int s = 0; s < sorokSzáma; s++)
            {
                for (int o = 0; o < oszlopokSzáma; o++)
                {
                    if (sorSzám >= kártyákSzáma) break;

                    Kártya k = new Kártya(s, o, t[sorSzám]);
                    Controls.Add(k);
                    k.Click += K_Click;
                    sorSzám++;
                }
            }
        }

        private void K_Click(object? sender, EventArgs e)
        {
            if (sender is Kártya k && !kártyákZárva)
            {
                if (k == elõzõKártya || k == jelenlegiKártya) return; // Ha ugyanarra a kártyára kattintanak

                k.Felfordít();

                if (elõzõKártya == null)
                {
                    elõzõKártya = k;
                }
                else if (jelenlegiKártya == null)
                {
                    jelenlegiKártya = k;
                    if (jelenlegiKártya.képSzám == elõzõKártya.képSzám)
                    {
                        jóKísérletekSzáma++;
                        jelenlegiKártya = null;
                        elõzõKártya = null;
                    }
                    else
                    {
                        rosszKísérletekSzáma++;
                        kártyákZárva = true;
                        Timer timer = new Timer();
                        timer.Interval = 1000;
                        timer.Tick += (s, ev) =>
                        {
                            elõzõKártya.Lefordít();
                            jelenlegiKártya.Lefordít();
                            elõzõKártya = null;
                            jelenlegiKártya = null;
                            kártyákZárva = false;
                            timer.Stop();
                        };
                        timer.Start();
                    }
                    FrissítStatisztika();
                }
            }
        }

        private void FrissítStatisztika()
        {
            FrissítStatisztika(DateTime.Now - játékIndításiIdõ);
        }

        private void FrissítStatisztika(TimeSpan elteltIdõ)
        {
            int összesKísérlet = jóKísérletekSzáma + rosszKísérletekSzáma;
            double arány = összesKísérlet > 0 ? (double)jóKísérletekSzáma / összesKísérlet * 100 : 0;
            statisztikaLabel.Text = $"Jó kísérletek: {jóKísérletekSzáma}\nRossz kísérletek: {rosszKísérletekSzáma}\nArány: {arány:F2}%\nEltelt idõ: {elteltIdõ:mm\\:ss}";
        }

        int[] Keverés(int kártyaszám)
        {
            Random rnd = new Random();
            List<int> kevertKépek = elérhetõKépek.OrderBy(x => rnd.Next()).Take(kártyaszám / 2).ToList();
            kevertKépek.AddRange(kevertKépek); // Párosítjuk a képeket
            kevertKépek = kevertKépek.OrderBy(x => rnd.Next()).ToList();

            return kevertKépek.ToArray();
        }
    }
}
