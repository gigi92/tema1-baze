using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tema1
{
    public partial class Frm_add : Form
    {
        public Frm_add()
        {
            InitializeComponent();
            //Close();
        }
        private void but_renunta_Click(object sender, System.EventArgs e)
        {

            if (MessageBox.Show("Sunteti sigur ca doriti sa renuntati?", "Confirmati iesirea?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void but_gata_click(object sender, System.EventArgs e)
        {
            DataTable dt2=new DataTable();
            //dt2.TableName = "agenda";
            DataSet ds2 = new DataSet();
            String nume= rtf_nume.Text;
            String numar = rtf_nr.Text;
            String email = rtf_em.Text;
            
            
            DataColumn dc1 = new DataColumn("Nume");
            DataColumn dc2 = new DataColumn("Numar");
            DataColumn dc3 = new DataColumn("Email");
            dt2.Columns.Add(dc1);
            dt2.Columns.Add(dc2);
            dt2.Columns.Add(dc3);
            dt2.Rows.Add(nume, numar, email);
            
            ds2.Tables.Add(dt2);
            variabile.ds.Merge(ds2);
            variabile.dt.Merge(dt2);
            variabile.ds.WriteXml("Contacte.xml");
            MessageBox.Show("Adaugarea s-a completat cu succes.");
            //FrmMain
            //this.Parent.Refresh();
            this.Close();
        }

        private void Frm_add_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtf_nume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}