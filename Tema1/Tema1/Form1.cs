using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Tema1
{
    public partial class FrmMain : Form
    {
        /*private void frmMain_Resize(object sender, System.EventArgs e)
        {
           rtf_search.Size = this.ClientSize;
        }*/
        public FrmMain()
        {
            InitializeComponent();
            variabile.ds = new DataSet();

            //variabile.dt.TableName = "Agenda";
            DataColumn dc1 = new DataColumn("Nume");
            DataColumn dc2 = new DataColumn("Numar");
            DataColumn dc3 = new DataColumn("Email");
            variabile.dt.Columns.Add(dc1);
            variabile.dt.Columns.Add(dc2);
            variabile.dt.Columns.Add(dc3);
            //variabile.dt.Rows.Add(null,null,null);
            //variabile.dt.Rows.Add("Paraschiv Vlad", "0723657845", "paraschiv.vlad92@yahoo.com");
           
            //variabile.ds.DataSetName = "Contacte";
            //variabile.ds.Tables.Add(variabile.dt);
           // variabile.ds.WriteXml("Contacte.xml");


            // Reading XML file and copying to dataset
           
            variabile.ds.ReadXml("Contacte.xml");
            dgv.DataSource = variabile.ds.Tables[0];
            DataGridViewColumn column = dgv.Columns[0];
            column.Width = 200;
            DataGridViewColumn column2 = dgv.Columns[1];
            column2.Width = 180;
            DataGridViewColumn column3 = dgv.Columns[2];
            column3.Width = 200;
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            using (Frm_add Frm_add = new Frm_add())
            {
                //this.Visible = false;
                Frm_add.ShowDialog();
                //DataSet ds = new DataSet();
                //ds.ReadXml("Contacte.xml");
                dgv.DataSource = variabile.ds.Tables[0];
                //this.Visible = true;
                
            }
        }
        private void but_Edit_Click(object sender, EventArgs e)
        {
            using (Frm_edit Frm_edit = new Frm_edit())
            {
                Frm_edit.ShowDialog();
            }
        }
        private void but_del_Click(object sender, EventArgs e)
        {
            using (Frm_del Frm_del = new Frm_del())
            {
                Frm_del.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rtf_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(variabile.ds.Tables[0]);
            dv.RowFilter = "(Nume like '%" + rtf_search.Text + "%') AND (numar like '%" + rtf_search2.Text + "%') AND (email like '%" + rtf_search3.Text + "%')";
            dgv.DataSource = dv;
        }
        private void rtf_search2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(variabile.ds.Tables[0]);
            dv.RowFilter = "(Nume like '%" + rtf_search.Text + "%') AND (numar like '%" + rtf_search2.Text + "%') AND (email like '%" + rtf_search3.Text + "%')";
            dgv.DataSource = dv;
        }
        private void rtf_search3_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(variabile.ds.Tables[0]);
            dv.RowFilter = "(Nume like '%" + rtf_search.Text + "%') AND (numar like '%" + rtf_search2.Text + "%') AND (email like '%" + rtf_search3.Text + "%')";
            dgv.DataSource = dv;
        }
        //
        protected void rtf_search_Focus(Object sender, EventArgs e)
        {
            rtf_search.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Documents (*.xml)|*.xml";
            sfd.FileName = "Agenda.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
               // ds = (DataSet)dgv.DataSource;
                variabile.ds.Tables[0].WriteXml(sfd.FileName, System.Data.XmlWriteMode.IgnoreSchema);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd2 = new SaveFileDialog();
            sfd2.Filter = "XLS Documents (*.xls)|*.xlsx";
            sfd2.FileName = "Agenda.xls";
            if (sfd2.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "";
                string sHeaders = "";
                for (int j = 0; j < dgv.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                for (int i = 0; i < dgv.RowCount - 1; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
                Encoding unicode = Encoding.ASCII;
                byte[] output = unicode.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd2.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length);
                bw.Flush();
                bw.Close();
                fs.Close();
            }
        }
        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (frm_help Frm_help = new frm_help())
            {
                Frm_help.ShowDialog();
            }
        }
    }
}
