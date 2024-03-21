namespace kigyos
{
    public partial class Form1 : Form
    {
        int fej_x;
        int fej_y;
        int ir�ny_x;
        int ir�ny_y;
        int l�p�ssz�m;
        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        public Form1()
        {

            InitializeComponent();
            fej_x = 100;
            fej_y = 100;
            ir�ny_x = 1;
            ir�ny_y = 0;
            l�p�ssz�m = 0;

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
            l�p�ssz�m++;

            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

            }

            K�gy�Elem ke = new K�gy�Elem();
            k�gy�.Add(ke); //Amikor �j fejet nevezt�nk a k�gy�nak, azt beletessz�k a `k�gy�` list�ba is ..
            Controls.Add(ke);
            if (k�gy�.Count > K�gy�Elem.Hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}