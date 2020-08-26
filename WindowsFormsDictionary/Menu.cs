using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDictionary
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOef2_Click(object sender, EventArgs e)
        {
            Oefen2 oef = new Oefen2();
            oef.Show();
        }

        private void buttonOef1_Click(object sender, EventArgs e)
        {
            Oefening1 oef = new Oefening1();
            oef.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oefening3 oef = new Oefening3();
            oef.Show();
        }
    }
}
