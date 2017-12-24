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

        private void btndelbook_Click(object sender, EventArgs e)
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
                listView1.Items.Add(statcoms.makerow(row));
            }
        }

        private void btnnewbook_Click(object sender, EventArgs e)
        {
                change frm2 = new change(0);
                frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                frm2.Show();
        }

        private void frm2_FormClosed(object sender, EventArgs e)
        {
            populate();
        }

        private void btnpopbook_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnmodbook_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2(Convert.ToInt16(listView1.SelectedItems[0].Tag));
                f2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                f2.Show();
            }
            catch
            {
                MessageBox.Show("Please select a book");
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0].Tag != null)
                {
                    refreshnotes();
                }
            }
        }

        private void refreshnotes()
        {
            tabControl1.TabPages.Clear();
            DataTable notes = sqlcommands.getnotes(Convert.ToInt16(listView1.SelectedItems[0].Tag));

            int i = 0;
            foreach (DataRow row in notes.Rows)
            {
                i++;
                notescom note = new notescom(i, Convert.ToInt16(row[0]),Convert.ToInt16(listView1.SelectedItems[0].Tag),row[1].ToString(),tabControl1.Width);
                TabPage tp = note.makepage();
                tabControl1.TabPages.Add(tp); // pridedame tab page'a i controlus
            }
        }

        private void btndelnote_Click(object sender, EventArgs e)
        {
            try
            {
                custompage cp = (custompage)tabControl1.SelectedTab.Tag;
                sqlcommands.deletenote(cp.id);
                refreshnotes();
            }
            catch
            {
                MessageBox.Show("You have not selected a note");
            }
            
        }

        private void btnnewnote_Click(object sender, EventArgs e)
        {
            TabPage tabPage1 = new TabPage();
            int i = 1;
            foreach (TabPage tab in tabControl1.TabPages)
            {
                i++;
            }
            notescom note = new notescom(i, 0, Convert.ToInt16(listView1.SelectedItems[0].Tag), "", tabControl1.Width);
            TabPage tp = note.makepage();
            tabControl1.TabPages.Add(tp); // pridedame tab page'a i controlus
        }
        private void btnsavenote_Click(object sender, EventArgs e)
        {
            try
            {
                custompage cp = (custompage)tabControl1.SelectedTab.Tag;
                MessageBox.Show($"Note #{tabControl1.TabPages.Count} has been updated");
                sqlcommands.modifynote(cp.id, cp.asd, Convert.ToInt16(listView1.SelectedItems[0].Tag));
            }
            catch
            {
                MessageBox.Show("No current note selected");
            }
        }
    }
}
