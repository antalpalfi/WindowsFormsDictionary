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
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> numbersTot10 = new Dictionary<int, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Dictionary<int, string> numbersTot10 = new Dictionary<int, string>();
            numbersTot10.Add(1, "een");
            numbersTot10.Add(2, "twee");
            numbersTot10.Add(3, "drie");
            numbersTot10.Add(4, "vier");
            numbersTot10.Add(5, "vijf");
            numbersTot10.Add(6, "zes");
            numbersTot10.Add(7, "zeven");
            numbersTot10.Add(8, "acht");
            numbersTot10.Add(9, "negen");
            numbersTot10.Add(10, "tien");
            
            foreach (KeyValuePair<int,string> item in numbersTot10)
            {
                cmbNumber.Items.Add(item.Key);
            }

        }

        private void cmbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumber.Text = numbersTot10[cmbNumber.SelectedIndex + 1];
        }
    }
}
