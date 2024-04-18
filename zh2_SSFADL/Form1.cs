using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zh2_SSFADL
{
    public partial class Form1 : Form
    {
        BindingList<Repülõ> fv = new();
        public int maxim = int.MaxValue;
        public string kezdet;
        public string veg;
        public Form1()
        {
            InitializeComponent();
            repülõBindingSource.DataSource = fv;
        }

        private void button1Load_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("repulojaratok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Repülõ>();

                foreach (var item in tömb)
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
            if (repülõBindingSource.Current == null) return;
            if (MessageBox.Show("Jóváhagyod a törlést", "Megerõsítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repülõBindingSource.RemoveCurrent();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormÚj hozzáadás = new FormÚj();
            hozzáadás.ÚjRepülõ = repülõBindingSource.AddNew() as Repülõ;
            hozzáadás.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A leghoszabb menetidejû járat{kezdet}-bõl {veg}-be repül.");
        }
    }
}