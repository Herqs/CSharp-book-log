using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcommands.delete(Convert.ToInt16(listView1.SelectedItems[0].Tag));
            }
            catch
            {
                MessageBox.Show("You have not selected a book", "Error");
            }
            populate();
        }
         
        private void populate()
        {
            listView1.Items.Clear();
            DataTable info = sqlcommands.getinfo();

            foreach (DataRow row in info.Rows)
            {
                ListViewItem lwi = new ListViewItem(row[1].ToString());
                lwi.SubItems.Add(row[2].ToString());
                lwi.SubItems.Add(row[3].ToString());
                lwi.Tag=(row[0]);
                try
                {
                    double percent = Math.Round(Convert.ToDouble(row[3]) / Convert.ToDouble(row[2]) * 100, 2);
                    lwi.SubItems.Add(percent.ToString()+"%");
                }
                catch { }

                lwi.Tag = Convert.ToInt16(row[0]);

                listView1.Items.Add(lwi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                change frm2 = new change(0);
                frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                frm2.Show();
        }

        private void frm2_FormClosed(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Convert.ToInt16(listView1.SelectedItems[0].Tag));
            f2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            f2.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshnotes();
        }

        private void refreshnotes()
        {
            tabControl1.TabPages.Clear();
            DataTable notes = sqlcommands.getnotes(Convert.ToInt16(listView1.SelectedItems[0].Tag));
            int i = 0;
            foreach (DataRow row in notes.Rows)
            {
                string asd = row[1].ToString();
                i++;
                TabPage tabPage1 = new TabPage(); // sukuriam nauja tab page kuri idesime
                tabPage1.Name = i.ToString(); // pavadinimas
                tabPage1.Text = "Note #" + i; // jo tekstas virsuje
                RichTextBox lab = new RichTextBox(); // idedame i ji textboxa
                lab.Text = asd;
                lab.Width = tabControl1.Width - 5;
                lab.Height = 5000; // prisiskiriame jam dydi
                tabPage1.Controls.Add(lab); // priskiriame textboxa tam tab page'ui
                tabControl1.TabPages.Add(tabPage1); // pridedame tab page'a i controlus
                custompage cp = new custompage(lab.Text, Convert.ToInt16(row[0]),Convert.ToInt16(listView1.SelectedItems[0].Tag)); // SUKURIAME KLASE SU TEKSTU IR ID
                tabPage1.Tag = cp; // priosiskiriame tam tabui klase kaip tag'a
                lab.TextChanged += (sender, e) =>
                 {
                     cp.asd = lab.Text;
                 };
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            custompage cp = (custompage)tabControl1.SelectedTab.Tag;
            sqlcommands.deletenote(cp.id);
            refreshnotes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TabPage tabPage1 = new TabPage();
            int i = 1;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                i++;
            }

            tabPage1.Name = i.ToString();
            tabPage1.Text = "Note #" + i;
            RichTextBox lab = new RichTextBox();
            lab.Width = tabControl1.Width - 5;
            lab.Height = 5000;
            tabPage1.Controls.Add(lab);
            tabControl1.TabPages.Add(tabPage1);
            custompage cp = new custompage("Enter your note here", 0, Convert.ToInt16(listView1.SelectedItems[0].Tag));
            tabPage1.Tag = cp;
            lab.TextChanged += (senderr, ee) =>
             {
                 cp.asd = lab.Text;
             };
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                custompage cp = (custompage)tabControl1.SelectedTab.Tag;
                MessageBox.Show(cp.asd, cp.id.ToString());
                sqlcommands.modifynote(cp.id, cp.asd, Convert.ToInt16(listView1.SelectedItems[0].Tag));
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
