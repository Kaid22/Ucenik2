using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ucenik2
{
    class Ucenik
    {
        private string prezimeIme;
            private int prosek;
        public string Imeprezime
        {
            get { return prezimeIme; }
            set { prezimeIme = value; }
        }
        public int Prosek
        {
            get { return prosek; }
            set { if (value >= 1 && value <= 5)
                {
                    prosek = value;
                }
                   
                else
                {
                    MessageBox.Show("Prosek mora biti izmedju 1 i 5");
                    
                }
                    
            }
        }
        public Ucenik()
        {

        }
        public Ucenik(string prezimeIme,int prosek)
        {
            this.prezimeIme = prezimeIme;
            this.prosek = prosek;
        }
        public virtual string PrikaziUcenika()
        {
            return "\nIme i prezime:" + this.Imeprezime + " prosek:" + this.prosek;
        }
    }
}
