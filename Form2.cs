using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knyga2_01
{
    public partial class Form2 : Form
    {
        DataTable dt;
        public Form2(int _id)
        {
            InitializeComponent();
            dt = sqlcommands.getsingle(_id);
            populateform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void populateform()
        {
            textBox1.Text = dt.Rows[0][1].ToString();
            numericUpDown1.Value = Convert.ToInt16(dt.Rows[0][2]);
            numericUpDown2.Value = Convert.ToInt16(dt.Rows[0][3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlcommands.modify(Convert.ToInt16(dt.Rows[0][0]), textBox1.Text,Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            Close();
        }
    }
}
