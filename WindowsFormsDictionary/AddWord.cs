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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }
        public string ned;
        public string eng;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ned = txtNederland.Text;
            eng = txtEngels.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
