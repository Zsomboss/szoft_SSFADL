using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_SSFADL
{
    internal class OnOFFButton : Button
    {
        int szam = 0;

        public OnOFFButton()
        {
            Height = 50;
            Width = 50;
            MouseClick += OnOFFButton_MouseClick;
            Text = szam.ToString();
        }

        private void OnOFFButton_MouseClick(object? sender, MouseEventArgs e)
        {
            Text = szam++.ToString();

            if (szam > 2)
            {
                szam = 0;
            }
            if (szam == 1)
                {
                 Text = "ON";
                    BackColor = Color.Red;
                }
                if (szam == 0)
                {
                    Text = "OFF";
                    BackColor = Color.Green;
                }
        
            
        }
    }
}
