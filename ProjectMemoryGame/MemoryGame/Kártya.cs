using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class Kártya : PictureBox
    {
        public int képSzám;
        public bool Felfordítva { get; private set; }

        public Kártya(int sor, int oszlop, int képSzám)
        {
            this.képSzám = képSzám;

            this.Height = Properties.Settings.Default.képMéret;
            this.Width = Properties.Settings.Default.képMéret;

            this.Left = oszlop * Properties.Settings.Default.képTávolság + 150;
            this.Top = sor * Properties.Settings.Default.képTávolság;

            Lefordít();
            //Felfordít();
        }

        public void Felfordít()
        {
            this.Image = Bitmap.FromFile(Properties.Settings.Default.képKönyvtár + képSzám.ToString() + Properties.Settings.Default.képUtótag);
            Felfordítva = true;
        }

        public void Lefordít()
        {
            this.Image = Bitmap.FromFile(Properties.Settings.Default.képKönyvtár + "card_back.png");
            Felfordítva = true;
        }
    }
}
