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
    public partial class AddTaalWoord : Form
    {
        public AddTaalWoord()
        {
            InitializeComponent();
        }
        public string ned, eng, frans, hung, germ;
        public string translate = "";


        private void btAdd_Click(object sender, EventArgs e)
        {
            ned = txtNederland.Text;
            eng = txtEngels.Text;
            frans=txtFrans.Text;
            hung = txtHungarian.Text;
            germ = txtGermany.Text;
            translate = $"Engels: {eng}\nFrans: {frans}\nHungarian: {hung}\nGermany: {germ}";
            this.DialogResult = DialogResult.OK;
        }
    }
}
