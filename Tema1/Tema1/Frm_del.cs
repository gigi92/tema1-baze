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
    public partial class Frm_del : Form
    {
        public int cont;
        public Frm_del()
        {
            InitializeComponent();
            dgv.DataSource = variabile.ds.Tables[0];
            DataGridViewColumn column = dgv.Columns[0];
            column.Width = 200;
            DataGridViewColumn column2 = dgv.Columns[1];
            column2.Width = 180;
            DataGridViewColumn column3 = dgv.Columns[2];
            column3.Width = 200;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                rtf_nume.Text = row.Cells["Nume"].Value.ToString();
                rtf_numar.Text = row.Cells["Numar"].Value.ToString();
                rtf_email.Text = row.Cells["Email"].Value.ToString();
                cont = e.RowIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtf_nume.Text == "")
            {
                MessageBox.Show("Selectati un contact!");
                return;
            }
            variabile.ds.Tables[0].Rows.Remove(variabile.ds.Tables[0].Rows[cont]);
            dgv.DataSource = variabile.ds.Tables[0];
            variabile.ds.WriteXml("Contacte.xml");
            rtf_nume.Text = "";
            rtf_numar.Text = "";
            rtf_email.Text = "";
        }
    }
}
