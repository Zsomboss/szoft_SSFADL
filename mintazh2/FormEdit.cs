using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintazh2
{
    public partial class FormEdit : Form
    {
        public VizsgaKerdesek ÚjVizsgaKérdés = new();
        public FormEdit()
        {
            InitializeComponent();
            vizsgaKerdesekBindingSource.DataSource = ÚjVizsgaKérdés;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        
    }
}
