namespace knyga2_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndelbook = new System.Windows.Forms.Button();
            this.btnnewbook = new System.Windows.Forms.Button();
            this.btnpopbook = new System.Windows.Forms.Button();
            this.btnmodbook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnnewnote = new System.Windows.Forms.Button();
            this.btndelnote = new System.Windows.Forms.Button();
            this.btnsavenote = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(442, 169);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pavadinimas";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Psl ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Perskaityta";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "% Perskaityta";
            this.columnHeader4.Width = 120;
            // 
            // btndelbook
            // 
            this.btndelbook.Location = new System.Drawing.Point(3, 146);
            this.btndelbook.Name = "btndelbook";
            this.btndelbook.Size = new System.Drawing.Size(75, 23);
            this.btndelbook.TabIndex = 3;
            this.btndelbook.Text = "Delete";
            this.btndelbook.UseVisualStyleBackColor = true;
            this.btndelbook.Click += new System.EventHandler(this.btndelbook_Click);
            // 
            // btnnewbook
            // 
            this.btnnewbook.Location = new System.Drawing.Point(2, 32);
            this.btnnewbook.Name = "btnnewbook";
            this.btnnewbook.Size = new System.Drawing.Size(75, 23);
            this.btnnewbook.TabIndex = 1;
            this.btnnewbook.Text = "Add new";
            this.btnnewbook.UseVisualStyleBackColor = true;
            this.btnnewbook.Click += new System.EventHandler(this.btnnewbook_Click);
            // 
            // btnpopbook
            // 
            this.btnpopbook.Location = new System.Drawing.Point(3, 3);
            this.btnpopbook.Name = "btnpopbook";
            this.btnpopbook.Size = new System.Drawing.Size(75, 23);
            this.btnpopbook.TabIndex = 0;
            this.btnpopbook.Text = "Refresh";
            this.btnpopbook.UseVisualStyleBackColor = true;
            this.btnpopbook.Click += new System.EventHandler(this.btnpopbook_Click);
            // 
            // btnmodbook
            // 
            this.btnmodbook.Location = new System.Drawing.Point(3, 61);
            this.btnmodbook.Name = "btnmodbook";
            this.btnmodbook.Size = new System.Drawing.Size(75, 23);
            this.btnmodbook.TabIndex = 2;
            this.btnmodbook.Text = "Modify";
            this.btnmodbook.UseVisualStyleBackColor = true;
            this.btnmodbook.Click += new System.EventHandler(this.btnmodbook_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 175);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndelbook);
            this.panel2.Controls.Add(this.btnmodbook);
            this.panel2.Controls.Add(this.btnnewbook);
            this.panel2.Controls.Add(this.btnpopbook);
            this.panel2.Location = new System.Drawing.Point(468, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 175);
            this.panel2.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(15, 193);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 157);
            this.tabControl1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnnewnote);
            this.panel3.Controls.Add(this.btndelnote);
            this.panel3.Controls.Add(this.btnsavenote);
            this.panel3.Location = new System.Drawing.Point(468, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 157);
            this.panel3.TabIndex = 9;
            // 
            // btnnewnote
            // 
            this.btnnewnote.Location = new System.Drawing.Point(2, 25);
            this.btnnewnote.Name = "btnnewnote";
            this.btnnewnote.Size = new System.Drawing.Size(75, 23);
            this.btnnewnote.TabIndex = 4;
            this.btnnewnote.Text = "Add new";
            this.btnnewnote.UseVisualStyleBackColor = true;
            this.btnnewnote.Click += new System.EventHandler(this.btnnewnote_Click);
            // 
            // btndelnote
            // 
            this.btndelnote.Location = new System.Drawing.Point(3, 131);
            this.btndelnote.Name = "btndelnote";
            this.btndelnote.Size = new System.Drawing.Size(75, 23);
            this.btndelnote.TabIndex = 6;
            this.btndelnote.Text = "Delete";
            this.btndelnote.UseVisualStyleBackColor = true;
            this.btndelnote.Click += new System.EventHandler(this.btndelnote_Click);
            // 
            // btnsavenote
            // 
            this.btnsavenote.Location = new System.Drawing.Point(2, 54);
            this.btnsavenote.Name = "btnsavenote";
            this.btnsavenote.Size = new System.Drawing.Size(75, 23);
            this.btnsavenote.TabIndex = 5;
            this.btnsavenote.Text = "Save";
            this.btnsavenote.UseVisualStyleBackColor = true;
            this.btnsavenote.Click += new System.EventHandler(this.btnsavenote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 362);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Book log";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btndelbook;
        private System.Windows.Forms.Button btnnewbook;
        private System.Windows.Forms.Button btnpopbook;
        private System.Windows.Forms.Button btnmodbook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsavenote;
        private System.Windows.Forms.Button btndelnote;
        private System.Windows.Forms.Button btnnewnote;
    }
}

