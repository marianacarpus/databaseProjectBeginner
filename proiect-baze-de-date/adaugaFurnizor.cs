using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace proiect_baze_de_date
{
    public partial class adaugaFurnizor : Form
    {
        Entities db= new Entities();
        int objj;
        public adaugaFurnizor()
        {
            InitializeComponent();
        }
        public adaugaFurnizor(FURNIZOR obj)
        {
            InitializeComponent();
            db = new Entities();
            if(obj==null)
            {
 
            }
            else
            {
                objj = obj.FURNIZOR_ID;
                txtFurnizor.Text = obj.NUME_FURNIZOR;
                txtAdresa.Text = obj.ADRESA;
                txtEmail.Text = obj.EMAIL;
 
            }
            
         

        }

      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Parasesti aceasta forma? ", "Avertizare!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                
            }
           

        }

        private void btnAddFurnizor_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Length > 3 && txtEmail.Text.Length > 3 && txtFurnizor.Text.Length > 3)
            {
               
                if (db.FURNIZORs.Any(x => x.FURNIZOR_ID == objj))
                {
                    var furnizor = db.FURNIZORs.First<FURNIZOR>();
                    furnizor.NUME_FURNIZOR = txtFurnizor.Text;
                    furnizor.ADRESA = txtAdresa.Text;
                    furnizor.EMAIL = txtEmail.Text;
                    db.SaveChanges();

                }
                else
                {
                    var furnizor = new FURNIZOR() { NUME_FURNIZOR = txtFurnizor.Text, ADRESA = txtAdresa.Text, EMAIL = txtEmail.Text };
                    db.FURNIZORs.Add(furnizor);
                    db.SaveChanges();
                  
                }
            }
            else
            {
                txtFurnizor.Focus();
                txtEmail.Focus();
                MessageBox.Show("Introdu datele!");
            }
            this.Close();
        }

       
    }
}
