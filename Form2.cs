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
        int id;
        public Form2(int _id)
        {
            InitializeComponent();
            id = _id;
            if (_id!=0)
            {
                populateform();
            }
            dt = sqlcommands.getsingle(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void populateform()
        {
            dt = sqlcommands.getsingle(id);
            textBox1.Text = dt.Rows[0][1].ToString();
            numericUpDown1.Value = Convert.ToInt16(dt.Rows[0][2]);
            numericUpDown2.Value = Convert.ToInt16(dt.Rows[0][3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id!=0)
            {
                sqlcommands.modify(Convert.ToInt16(dt.Rows[0][0]), textBox1.Text, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            }
            else
            {
                sqlcommands.addnew(textBox1.Text, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            }
            Close();
        }
    }
}
