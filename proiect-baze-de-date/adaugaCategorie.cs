using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_baze_de_date
{
    public partial class adaugaCategorie : Form
    {
        Entities db = new Entities();
        int objj;
        public adaugaCategorie()
        {
            InitializeComponent();
        }
        public adaugaCategorie(CATEGORIE_SPORT obj)
        {
            InitializeComponent();
            db = new Entities();
            if (obj == null)
            {
            }
            else
            {
                objj = obj.CATEGORIE_SPORT_ID;
                txtCategorie.Text = obj.DENUMIRE;

            }

        }
        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            if (txtCategorie.Text.Length >= 3)
            {
                if (db.CATEGORIE_SPORT.Any(x => x.CATEGORIE_SPORT_ID == objj))
                {
                    var cat = db.CATEGORIE_SPORT.First<CATEGORIE_SPORT>();
                    cat.DENUMIRE= txtCategorie.Text;
                    db.SaveChanges();

                }
                else
                {
                    var categorie = new CATEGORIE_SPORT() { DENUMIRE = txtCategorie.Text };
                    db.CATEGORIE_SPORT.Add(categorie);
                    db.SaveChanges();
                }
              
            }
            else
            {
                MessageBox.Show("Introdu datele corect!");
            }
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
