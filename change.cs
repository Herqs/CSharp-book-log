﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace knyga2_01
{
    public partial class change : Form
    {
        int i;
        public change(int _i)
        {
            InitializeComponent();
            i=_i;
            getdetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int psl = Convert.ToInt32(textBox2.Text);
                int read = Convert.ToInt32(textBox3.Text);
                string name = textBox1.Text;
                if (psl < read)
                {
                    MessageBox.Show("You can read more pages than there are in a book duuuh");
                }
                else
                {
                    try
                    {
                        sqlcommands.addnew(name, psl, read);
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error updating");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Input error");
            }
            

        }

        private void getdetails()
        {
            DataTable dt = sqlcommands.getinfo();
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt16(dr[0])==i)
                {
                    textBox1.Text = dr[1].ToString();
                    textBox2.Text = dr[2].ToString();
                    textBox3.Text = dr[3].ToString();
                    button1.Text = "Update";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
