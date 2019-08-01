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
    public partial class adaugaComanda : Form
    {
        Entities db = new Entities();
        int objID;
        public adaugaComanda()
        {
            InitializeComponent();
            FillCombobox();
        }
        public adaugaComanda(COMANDA_STOC obj)
        {
            InitializeComponent();
            FillCombobox();
            db = new Entities();
            if (obj == null) { }
            else
            {
                objID = int.Parse(obj.COMANDA_STOC_ID.ToString());
                txtCantitate.Text = obj.CANTITATE.ToString();
                dataLivrare.Value = obj.DATA_LIVRARE.Value;
                dataPlasare.Value = obj.DATA_PLASARE.Value;
                cmbProdus.SelectedValue = obj.CONTRACT_ID;
                

            }
        }

        #region combo_chei_straine
        private void FillCombobox()
        {
            using (Entities c = new Entities())
            {
              
                //adauga in lista produse
                List<CONTRACT> contracte = c.CONTRACTs.ToList();
                DataTable dat = new DataTable();
                dat.Columns.Add("contract_id");
                dat.Columns.Add("nume_produs");
                foreach (CONTRACT contract in contracte)
                {
                    dat.Rows.Add(contract.CONTRACT_ID, contract.PRODUSE.NUME_PRODUS);
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
        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            if (isNumber(txtCantitate.Text))
            {

                if (db.COMANDA_STOC.Any(x => x.COMANDA_STOC_ID== objID))
                {
                    var com = db.COMANDA_STOC.First<COMANDA_STOC>();
                    com.CANTITATE = int.Parse(txtCantitate.Text);
                    com.DATA_LIVRARE = dataLivrare.Value;
                    com.DATA_PLASARE = dataPlasare.Value;
                    com.CONTRACT_ID = short.Parse(cmbProdus.SelectedValue.ToString());

                    db.SaveChanges();

                }
                else
                {
                    short id_contract = short.Parse(cmbProdus.SelectedValue.ToString());
                    var comanda = new COMANDA_STOC() { CONTRACT_ID = id_contract, DATA_PLASARE = dataPlasare.Value, DATA_LIVRARE = dataLivrare.Value, CANTITATE = int.Parse(txtCantitate.Text) };
                    db.COMANDA_STOC.Add(comanda);
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
