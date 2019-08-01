using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_baze_de_date
{
    public partial class adaugaProducator : Form
    {
        Entities db = new Entities();
        int objId;
        public adaugaProducator()
        {
            InitializeComponent();
        }
        public adaugaProducator(PRODUCATOR obj)
        {
            InitializeComponent();
            db = new Entities();
            if (obj == null) { }
            else
            {
                objId = obj.PRODUCATOR_ID;
                txtProducator.Text = obj.NUME_PRODUCATOR;
                txtTelefon.Text = obj.TELEFON.ToString();
                txtWebsite.Text = obj.WEBSITE;
            }

        }
        public bool isNumber(string s)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(s))
            {
               
                return false;
            }
            return true;
        }
        private void btnAddProducator_Click(object sender, EventArgs e)
        {
         
            if( txtProducator.Text.Length >=3 && txtWebsite.Text.Length > 5 && isNumber(txtTelefon.Text)) {
                if (db.PRODUCATORs.Any(x => x.PRODUCATOR_ID == objId))
                {
                    var prod = db.PRODUCATORs.First<PRODUCATOR>();
                    prod.NUME_PRODUCATOR = txtProducator.Text;
                    prod.TELEFON = int.Parse(txtTelefon.Text);
                    prod.WEBSITE = txtWebsite.Text;
                    db.SaveChanges();

                }
                else
                {
                    var producator = new PRODUCATOR() { NUME_PRODUCATOR = txtProducator.Text, WEBSITE = txtWebsite.Text, TELEFON = int.Parse(txtTelefon.Text) };
                    db.PRODUCATORs.Add(producator);
                    db.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("Introdu datele corect!");
            }
           
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Parasesti aceasta forma? ", "Avertizare!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }

        }
    }
}
