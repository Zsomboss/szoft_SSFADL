using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zh2_SSFADL
{
    public partial class Form1 : Form
    {
        BindingList<Rep�l�> fv = new();
        public int maxim = int.MaxValue;
        public string kezdet;
        public string veg;
        public Form1()
        {
            InitializeComponent();
            rep�l�BindingSource.DataSource = fv;
        }

        private void button1Load_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("repulojaratok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Rep�l�>();

                foreach (var item in t�mb)
                {
                    if (item.IdotartamOra < maxim)
                    {
                        maxim = item.IdotartamOra;
                    }
                    if (item.IdotartamOra == maxim)
                    {
                        kezdet = item.IndulasiHely;
                        veg = item.CelHely;

                            
                            }

                    fv.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (rep�l�BindingSource.Current == null) return;
            if (MessageBox.Show("J�v�hagyod a t�rl�st", "Meger�s�t�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                rep�l�BindingSource.RemoveCurrent();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form�j hozz�ad�s = new Form�j();
            hozz�ad�s.�jRep�l� = rep�l�BindingSource.AddNew() as Rep�l�;
            hozz�ad�s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A leghoszabb menetidej� j�rat{kezdet}-b�l {veg}-be rep�l.");
        }
    }
}