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
    public partial class Oefen2 : Form
    {
        public Oefen2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> nederlanEngels = new Dictionary<string, string>();
        private void Oefen2_Load(object sender, EventArgs e)
        {
            nederlanEngels.Add("hond", "dog");
            nederlanEngels.Add("thuis", "house");
            nederlanEngels.Add("stoel", "chair");
            nederlanEngels.Add("kip", "chiken");

            //foreach (KeyValuePair<string,string> item in nederlanEngels)
            //{
            //    cmbNederland.Items.Add(item.Key);
            //}
            cmbNederland.DisplayMember = "Key";
            cmbNederland.SelectedValue = "Value";
            cmbNederland.DataSource = new BindingSource(nederlanEngels, null);
        }

        private void cmbNederland_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblEngels.Text = nederlanEngels[cmbNederland.SelectedItem]; 
            if (cmbNederland!=null)
            {
                KeyValuePair<string, string> engelse = (KeyValuePair<string, string>)cmbNederland.SelectedItem;
                lblEngels.Text = engelse.Value;
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord();
            if (addWord.ShowDialog()==DialogResult.OK)
            {
                nederlanEngels.Add(addWord.ned, addWord.eng);

            }
            cmbNederland.DataSource = new BindingSource(nederlanEngels, null);
            cmbNederland.DisplayMember = "Key";
            cmbNederland.ValueMember = "Value";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> remove = (KeyValuePair<string, string>)cmbNederland.SelectedItem;
            nederlanEngels.Remove(remove.Key);
            cmbNederland.DataSource = new BindingSource(nederlanEngels, null);
            cmbNederland.DisplayMember = "Key";
            cmbNederland.ValueMember = "Value";
        }
    }
}
