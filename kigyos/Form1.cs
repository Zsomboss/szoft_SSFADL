namespace kigyos
{
    public partial class Form1 : Form
    {
        int fej_x;
        int fej_y;
        int irány_x;
        int irány_y;
        int lépésszám;
        List<KígyóElem> kígyó = new List<KígyóElem>();
        public Form1()
        {

            InitializeComponent();
            fej_x = 100;
            fej_y = 100;
            irány_x = 1;
            irány_y = 0;
            lépésszám = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            List<string> list = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {

            }

            foreach (string items in list)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

            }

            KígyóElem ke = new KígyóElem();
            kígyó.Add(ke); //Amikor új fejet neveztünk a kígyónak, azt beletesszük a `kígyó` listába is ..
            Controls.Add(ke);
            if (kígyó.Count > KígyóElem.Hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}