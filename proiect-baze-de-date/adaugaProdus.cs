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
    public partial class adaugaProdus : Form
    {
        Entities db = new Entities();
        int id;
        public adaugaProdus()
        {
            InitializeComponent();
            FillComboboxCategorie();
            FillComboboxProducator();
        }
        public adaugaProdus(PRODUSE obj)
        {
            InitializeComponent();
            FillComboboxCategorie();
            FillComboboxProducator();
            db = new Entities();
            if (obj == null) { }
            else
            {
                id = obj.PRODUS_ID;
                txtModel.Text = obj.MODEL_PRODUS;
                txtPret.Text = obj.PRET.ToString();
                txtProdus.Text = obj.NUME_PRODUS;
                cmbCategorie.SelectedValue = obj.CATEGORIE_SPORT_ID;
                cmbProducator.SelectedValue = obj.PRODUCATOR_ID;
            }
        }
        #region incarcare_in_comboBox
        public void FillComboboxCategorie()
        {
            using (Entities c = new Entities())
            {
                //adauga in lista categorie sport
                List<CATEGORIE_SPORT> categorii = c.CATEGORIE_SPORT.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("categorie_sport_id");
                dt.Columns.Add("denumire");
                foreach (CATEGORIE_SPORT categorie in categorii)
                {
                    dt.Rows.Add(categorie.CATEGORIE_SPORT_ID, categorie.DENUMIRE);
                }
                cmbCategorie.ValueMember = dt.Columns[0].ColumnName;
                cmbCategorie.DisplayMember = dt.Columns[1].ColumnName;
                cmbCategorie.DataSource = dt;
                
               

            }
        }
        public void FillComboboxProducator()
        {
            using (Entities c = new Entities())
            {
                //adauga in lista producatorii
                List<PRODUCATOR> producatori = c.PRODUCATORs.ToList();
                DataTable dat = new DataTable();
                dat.Columns.Add("producator_id");
                dat.Columns.Add("nume_producator");
                foreach (PRODUCATOR producator in producatori)
                {
                    dat.Rows.Add(producator.PRODUCATOR_ID, producator.NUME_PRODUCATOR);
                }
                cmbProducator.ValueMember = dat.Columns[0].ColumnName;
                cmbProducator.DisplayMember = dat.Columns[1].ColumnName;
                cmbProducator.DataSource = dat;
            }
        }
        #endregion
        public bool isNumber(string s)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(s))
            {

                return false;
            }
            return true;
        }
        private void btnAddProdus_Click(object sender, EventArgs e)
        {
            if (txtProdus.Text.Length >= 3 && txtModel.Text.Length >= 3 && isNumber(txtPret.Text))
            {
                if (db.PRODUSEs.Any(x => x.PRODUS_ID == id))
                {
                    var produs= db.PRODUSEs.First<PRODUSE>();
                    produs.MODEL_PRODUS = txtModel.Text;
                    produs.NUME_PRODUS = txtProdus.Text;
                    produs.PRET = int.Parse(txtPret.Text);
                    produs.CATEGORIE_SPORT_ID= short.Parse(cmbCategorie.SelectedValue.ToString());
                    produs.PRODUCATOR_ID= short.Parse(cmbProducator.SelectedValue.ToString());
                }
                else
                {

                    short id_categorie = short.Parse(cmbCategorie.SelectedValue.ToString());
                    short id_producator = short.Parse(cmbProducator.SelectedValue.ToString());
                    var produs = new PRODUSE() { PRODUCATOR_ID = id_producator, CATEGORIE_SPORT_ID = id_categorie, NUME_PRODUS = txtProdus.Text, MODEL_PRODUS = txtModel.Text, PRET = int.Parse(txtPret.Text) };
                    db.PRODUSEs.Add(produs);
                    db.SaveChanges();
                }
                this.Close();
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
