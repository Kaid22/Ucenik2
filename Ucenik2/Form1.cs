using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucenik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Odeljenje o = new Odeljenje();
        private void button1_Click(object sender, EventArgs e)
        {
            
            o.Oznaka = textBox3.Text;
            textBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {           
                Ucenik u = new Ucenik();
                u.Imeprezime = textBox1.Text;
                u.Prosek = Convert.ToInt32(textBox2.Text);
                textBox1.Clear();
                textBox2.Clear();
                o.dodajucenikanaspisak = u;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = o.PrikaziOdeljnje();
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }
    }
}
