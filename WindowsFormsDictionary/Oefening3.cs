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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }
        Dictionary<string, string> worden5Taal = new Dictionary<string, string>();
       
        private void Oefening3_Load(object sender, EventArgs e)
        {
            worden5Taal.Add("hond", "Engels: dog\nFrans: chien\nHungarian: kutya\nGermany: hund");
            worden5Taal.Add("paard","Engels: horse\nFrans: cheval\nHungarian: lo\nGermany: pferd");
           
            //cmbNederlands.DataSource = new BindingSource(worden5Taal, null);
            cmbNederlands.DisplayMember = "Key";
            cmbNederlands.SelectedValue = "Value";
            cmbNederlands.DataSource = new BindingSource(worden5Taal, null);

        }

        private void cmbNederlands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNederlands != null)
            {
                KeyValuePair<string, string> engelse = (KeyValuePair<string, string>)cmbNederlands.SelectedItem;
                lblEngels.Text = engelse.Value;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTaalWoord addword = new AddTaalWoord();
            if (addword.ShowDialog()==DialogResult.OK)
            {
                worden5Taal.Add(addword.ned, addword.translate);/*$"Engels: {addword.eng}\nFrans: {addword.frans}\nHungarian: {addword.hung}\nGermany: {addword.germ}")*/;
            }
            cmbNederlands.DataSource = new BindingSource(worden5Taal, null);
            cmbNederlands.DisplayMember = "Key";
            cmbNederlands.ValueMember = "Value";
        }
    }
}
