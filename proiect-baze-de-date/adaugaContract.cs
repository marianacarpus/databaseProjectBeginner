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
    public partial class adaugaContract : Form
    {
        Entities db = new Entities();
        int id;
        public adaugaContract()
        {
            InitializeComponent();
            FillCombobox();
        }
        public adaugaContract(CONTRACT obj)
        {
            InitializeComponent();
            FillCombobox();
            db = new Entities();
            if (obj == null) { }
            else
            {
                id = obj.CONTRACT_ID;
                txtPret.Text = obj.PRET.ToString();
                dataContract.Value = obj.DATA_CONTRACT.Value;
                cmbFurnizor.SelectedValue = obj.FURNIZOR_ID;
                cmbProdus.SelectedValue = obj.PRODUSE_ID;


            }
        }
        #region combo_chei_straine
        private void FillCombobox()
        {
            using (Entities c = new Entities())
            {
                //adauga in lista furnizorii
                List<FURNIZOR> furnizor = c.FURNIZORs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("furnizor_id");
                dt.Columns.Add("nume");
                foreach (FURNIZOR usepurpose in furnizor)
                {
                    dt.Rows.Add(usepurpose.FURNIZOR_ID, usepurpose.NUME_FURNIZOR);
                }
                cmbFurnizor.ValueMember = dt.Columns[0].ColumnName;
                cmbFurnizor.DisplayMember = dt.Columns[1].ColumnName;
                cmbFurnizor.DataSource = dt;
                //adauga in lista produse
                List<PRODUSE> produse = c.PRODUSEs.ToList();
                DataTable dat = new DataTable();
                dat.Columns.Add("produs_id");
                dat.Columns.Add("nume_produs");
                foreach (PRODUSE produs in produse)
                {
                    dat.Rows.Add(produs.PRODUS_ID, produs.NUME_PRODUS);
                }
                cmbProdus.ValueMember = dat.Columns[0].ColumnName;
                cmbProdus.DisplayMember = dat.Columns[1].ColumnName;
                cmbProdus.DataSource = dat;
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
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            if (isNumber(txtPret.Text))
            {
                if (db.CONTRACTs.Any(x => x.CONTRACT_ID == id))
                {
                    var contract = db.CONTRACTs.First<CONTRACT>();
                    contract.DATA_CONTRACT = dataContract.Value;
                    contract.PRET = int.Parse(txtPret.Text);
                    contract.FURNIZOR_ID= short.Parse(cmbFurnizor.SelectedValue.ToString());
                    contract.PRODUSE_ID= short.Parse(cmbProdus.SelectedValue.ToString());
                    db.SaveChanges();
                }
                else
                {
  
                    short id_furnizor = short.Parse(cmbFurnizor.SelectedValue.ToString());
                    short id_produse = short.Parse(cmbProdus.SelectedValue.ToString());
                    var contract = new CONTRACT() { FURNIZOR_ID = id_furnizor, PRODUSE_ID = id_produse, DATA_CONTRACT = Convert.ToDateTime(dataContract.Text), PRET = int.Parse(txtPret.Text) };
                    db.CONTRACTs.Add(contract);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Introdu corect datele!");
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
