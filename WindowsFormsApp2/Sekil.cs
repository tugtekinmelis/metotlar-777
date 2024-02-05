using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Sekil
    {
        public int uzunKenar { get; set; }
        public int kisaKenar { get; set; }

        // parametre almayan ve değer döndürmeyen (void).
        public void KareYaz()
        {
            int sonuc = this.kisaKenar * this.uzunKenar;
            MessageBox.Show($"şeklin karesi : {sonuc}");
        }

        // parametre alan ve değer döndürmeyen (void).
        public void SekilCiz (Button btn, Color renk)
        {
            btn.Width = this.uzunKenar;
            btn.Height = this.kisaKenar;
            btn.BackColor = renk;
        }
        public void mesajDegistir (Button btn, string mesaj)
        {
            btn.Text = mesaj;
        }
    }
}
