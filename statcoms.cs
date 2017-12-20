using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace knyga2_01
{
    static class statcoms
    {
        public static ListViewItem makerow(DataRow row)
        {
            ListViewItem lwi = new ListViewItem(row[1].ToString());
            lwi.SubItems.Add(row[2].ToString());
            lwi.SubItems.Add(row[3].ToString());
            lwi.Tag = (row[0]);
            try
            {
                double percent = Math.Round(Convert.ToDouble(row[3]) / Convert.ToDouble(row[2]) * 100, 2);
                lwi.SubItems.Add(percent.ToString() + "%");
            }
            catch { }

            lwi.Tag = Convert.ToInt16(row[0]);


            return lwi;
        }
    }
}
