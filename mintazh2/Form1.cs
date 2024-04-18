using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintazh2
{

    public partial class Form1 : Form
    {
        BindingList<VizsgaKerdesek> k�rd�sek = new BindingList<VizsgaKerdesek>();

        public Form1()
        {
            InitializeComponent();
            vizsgaKerdesekBindingSource.DataSource = k�rd�sek;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<VizsgaKerdesek>();

                foreach (var item in t�mb)
                {
                    k�rd�sek.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SFD = new SaveFileDialog();

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(SFD.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(k�rd�sek);
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
            if (vizsgaKerdesekBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgaKerdesekBindingSource.RemoveCurrent();
            }

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            if (formAddNew.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (vizsgaKerdesekBindingSource.Current == null) return;

            FormEdit formEdit = new FormEdit();
            formEdit.�jVizsgaK�rd�s = vizsgaKerdesekBindingSource.Current as VizsgaKerdesek;
            formEdit.Show();
        }
    }
}
