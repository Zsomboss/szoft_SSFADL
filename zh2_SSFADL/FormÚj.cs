using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh2_SSFADL
{

    public partial class FormÚj : Form
    {
        public Repülő ÚjRepülő = new Repülő();
        public FormÚj()
        {
            InitializeComponent();
            repülőBindingSource.DataSource = ÚjRepülő;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
