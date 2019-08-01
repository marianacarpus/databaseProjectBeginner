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
    public partial class Form1 : Form
    {
        private Entities db = new Entities();
        int selectedRow;
        public Form1()
        {
          
            InitializeComponent();
        }
        #region adauga_din_baza_de_date
        private Task<object> getFurnizor()
        {
            return Task.Run(() =>
            {
                var res = db.FURNIZORs.Select(z => new {z.FURNIZOR_ID, z.NUME_FURNIZOR,z.ADRESA,z.EMAIL}).ToList();
                return (object)res;
            });
        }
        private Task<object> getStoc()
        {
            return Task.Run(() =>
            {
                //   var objTmp = db..Where(x => x.FURNIZOR_ID == ID).First();
                var res = db.COMANDA_STOC.Where(z=> z.DATA_LIVRARE<=DateTime.Now).Select(z => new { z.CONTRACT.PRODUSE.NUME_PRODUS, z.CONTRACT.PRODUSE.MODEL_PRODUS, z.CANTITATE, z.CONTRACT.FURNIZOR.NUME_FURNIZOR }).ToList();
                return (object)res;
            });
        }
        private Task<object> getComenzi()
        {
            return Task.Run(() =>
            {
                var res = db.COMANDA_STOC.Select(z => new {z.COMANDA_STOC_ID, z.DATA_PLASARE,z.DATA_LIVRARE,z.CONTRACT.PRODUSE.NUME_PRODUS,z.CANTITATE}).ToList();
                return (object)res;
            });
        }
        private Task<object> getContract()
        {
            return Task.Run(() =>
            {
               
                var res = db.CONTRACTs.Select(z => new {z.CONTRACT_ID,z.DATA_CONTRACT, z.PRODUSE.NUME_PRODUS,z.FURNIZOR.NUME_FURNIZOR}).ToList();
                return (object)res;
            });
        }
        private Task<object> getCategorii()
        {
            return Task.Run(() =>
            {
                var res = db.CATEGORIE_SPORT.Select(z => new { z.CATEGORIE_SPORT_ID,z.DENUMIRE}).ToList();
                return (object)res;
            });
        }
        private Task<object> getProduse()
        {
            return Task.Run(() =>
            {
                var res = db.PRODUSEs.Select(z => new {z.PRODUS_ID,z.CATEGORIE_SPORT.DENUMIRE,z.PRODUCATOR.NUME_PRODUCATOR, z.NUME_PRODUS,z.MODEL_PRODUS,z.PRET }).ToList();
                return (object)res;
            });
        }
        private Task<object> getProducatori()
        {
            return Task.Run(() =>
            {
                var res = db.PRODUCATORs.Select(z => new { z.PRODUCATOR_ID,z.NUME_PRODUCATOR,z.WEBSITE,z.TELEFON }).ToList();
                return (object)res;
            });
        }
        #endregion
        #region ordonare
        private Task<object> ordPret()
        {

            return Task.Run(() =>
            {
                var res = db.PRODUSEs.Select(z => new { z.PRODUS_ID, z.CATEGORIE_SPORT.DENUMIRE, z.PRODUCATOR.NUME_PRODUCATOR, z.NUME_PRODUS, z.MODEL_PRODUS, z.PRET }).OrderBy(z=> z.PRET).ToList();
                return (object)res;
            });

        }
        private Task<object> ordProducator()
        {

            return Task.Run(() =>
            {
                var res = db.PRODUSEs.Select(z => new { z.PRODUS_ID, z.CATEGORIE_SPORT.DENUMIRE, z.PRODUCATOR.NUME_PRODUCATOR, z.NUME_PRODUS, z.MODEL_PRODUS, z.PRET }).OrderBy(z => z.NUME_PRODUCATOR).ToList();
                return (object)res;
            });

        }
        private Task<object> ordCategorie()
        {

            return Task.Run(() =>
            {
                var res = db.PRODUSEs.Select(z => new { z.PRODUS_ID, z.CATEGORIE_SPORT.DENUMIRE, z.PRODUCATOR.NUME_PRODUCATOR, z.NUME_PRODUS, z.MODEL_PRODUS, z.PRET }).OrderBy(z => z.DENUMIRE).ToList();
                return (object)res;
            });

        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                dataGridView1.DataSource = await getFurnizor();
            else if (tabControl1.SelectedIndex == 1)
                dataGridView2.DataSource = await getContract();
            else if (tabControl1.SelectedIndex == 2)
                dataGridView3.DataSource = await getComenzi();
            else if (tabControl1.SelectedIndex == 3)
                dataGridView4.DataSource = await getCategorii();
            else if (tabControl1.SelectedIndex == 4)
                dataGridView5.DataSource = await getProduse();
            else if (tabControl1.SelectedIndex == 5)
                dataGridView6.DataSource = await getProducatori();
            else if (tabControl1.SelectedIndex == 6)
            {
                dataGridView7.DataSource = await getStoc();
               
            }
        }


        private  void btnAdd1_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                adaugaFurnizor frm = new adaugaFurnizor();
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                adaugaContract frm = new adaugaContract();
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                adaugaComanda frm = new adaugaComanda();
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                adaugaCategorie frm = new adaugaCategorie();
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                adaugaProdus frm = new adaugaProdus();
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                adaugaProducator frm = new adaugaProducator();
                frm.Show();
            }

        }
        #region actualizare
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.FURNIZORs.Where(x => x.FURNIZOR_ID == ID).First();
                adaugaFurnizor frm = new adaugaFurnizor(objTmp);
                frm.Show();
            }
            else if(tabControl1.SelectedIndex == 1)
            {

                int ID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.CONTRACTs.Where(x => x.CONTRACT_ID == ID).First();
                adaugaContract frm = new adaugaContract(objTmp);
                 frm.Show();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                int ID = Convert.ToInt32(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.COMANDA_STOC.Where(x => x.COMANDA_STOC_ID == ID).First();
                adaugaComanda frm = new adaugaComanda(objTmp);
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                int ID = Convert.ToInt32(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.CATEGORIE_SPORT.Where(x => x.CATEGORIE_SPORT_ID == ID).First();
                adaugaCategorie frm = new adaugaCategorie(objTmp);
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 4)
            {

                int ID = Convert.ToInt32(dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.PRODUSEs.Where(x => x.PRODUS_ID == ID).First();
                adaugaProdus frm = new adaugaProdus(objTmp);
                frm.Show();
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                int ID = Convert.ToInt32(dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.PRODUCATORs.Where(x => x.PRODUCATOR_ID == ID).First();
                adaugaProducator frm=new adaugaProducator(objTmp);
                frm.Show();
            }



        }
        #endregion
        #region delete
        private void btnDel1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                
                int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.FURNIZORs.Where(x => x.FURNIZOR_ID == ID).First();
                db.FURNIZORs.Remove(objTmp);
                db.SaveChanges();

            }
            else if (tabControl1.SelectedIndex == 1)
            {

                int ID = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.CONTRACTs.Where(x => x.CONTRACT_ID == ID).First();
                db.CONTRACTs.Remove(objTmp);
                db.SaveChanges();

            }
            else if (tabControl1.SelectedIndex == 2)
            {

                int ID = Convert.ToInt32(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.COMANDA_STOC.Where(x => x.COMANDA_STOC_ID == ID).First();
                db.COMANDA_STOC.Remove(objTmp);
                db.SaveChanges();
            } 
            else if (tabControl1.SelectedIndex == 3)
            {

                int ID = Convert.ToInt32(dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.CATEGORIE_SPORT.Where(x => x.CATEGORIE_SPORT_ID == ID).First();
                db.CATEGORIE_SPORT.Remove(objTmp);
                db.SaveChanges();
            }
            else if (tabControl1.SelectedIndex == 4)
            {

                int ID = Convert.ToInt32(dataGridView5.Rows[dataGridView5.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.PRODUSEs.Where(x => x.PRODUS_ID == ID).First();
                db.PRODUSEs.Remove(objTmp);
                db.SaveChanges();
            }
            else if (tabControl1.SelectedIndex == 5)
            {

                int ID = Convert.ToInt32(dataGridView6.Rows[dataGridView6.CurrentRow.Index].Cells[0].Value);
                var objTmp = db.PRODUCATORs.Where(x => x.PRODUCATOR_ID == ID).First();
                db.PRODUCATORs.Remove(objTmp);
                db.SaveChanges();
            }


        }
        #endregion

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            adaugaFurnizor frm = new adaugaFurnizor();
              //  DataGridView row = dataGridView1.Rows[selectedRow];

        }

        private  async void btnOrdPret_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = await ordPret();
        }

        private async void btnOrdCat_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = await ordCategorie();
        }

        private async void btnOrdProd_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = await ordProducator();
        }
    }
}
