using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Ucenik2
{
    class Odeljenje:Ucenik
    {
        private string oznakaOdeljenja;
        public ArrayList spisakUcenika = new ArrayList();
        private string tempstring;
        public string Oznaka
        {
            get { return oznakaOdeljenja; }
            set { oznakaOdeljenja = value; }
        }
        public ArrayList spisak
        {
            get { return spisakUcenika; }
            
        }
        public Ucenik dodajucenikanaspisak
        {
            set { spisakUcenika.Add(value); }
        }

        public Odeljenje()
        {

        }
        public Odeljenje(string oznakaOdeljenja,ArrayList spisak)
        {
            this.oznakaOdeljenja = oznakaOdeljenja;
            this.spisakUcenika = spisak;
        }
        public virtual string PrikaziOdeljnje()
        {
            foreach (Ucenik x in spisakUcenika)
            {
                tempstring += x.PrikaziUcenika();
            }
            return "Odeljenje: " + this.oznakaOdeljenja + "\n" + this.tempstring;
        }
    }
}
