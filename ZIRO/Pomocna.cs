using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    class Pomocna
    {
        public string MsgNazivPozor = $"Pažnja";
        public string MsgNazivGreska = $"Greška";
        public string MsgPorukaPraznaCelija = $"Čelija ne smije biti prazna!";
        public string MsgPorukaInsertError = $"Unos nove stavke nije uspješan!\n";
        public string MsgPorukaEditError = $"Izmjena stavke nije uspjela!\n";

        public void PraznaCelija(TextBox textBox)
        {
            textBox.BackColor = Color.LightPink;
        }
        public void OkCelija(TextBox textBox)
        {
            textBox.BackColor = Color.White;
        }

    }
}
