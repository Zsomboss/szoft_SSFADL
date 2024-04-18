using CsvHelper;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Globalization;

namespace zh_gyak
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countrylist = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            countryDataBindingSource.DataSource = countrylist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("european_countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countrylist.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }
    }
}