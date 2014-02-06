using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Tema1
{
    class variabile
    {
       public static DataSet ds = new DataSet();
       public static DataTable dt = new DataTable();
       variabile()
       {
           DataColumn dc1 = new DataColumn("Nume");
           DataColumn dc2 = new DataColumn("Numar");
           DataColumn dc3 = new DataColumn("Email");
           dt.Columns.Add(dc1);
           dt.Columns.Add(dc2);
           dt.Columns.Add(dc3);
       }
    }
   
}
