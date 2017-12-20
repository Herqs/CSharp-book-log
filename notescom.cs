using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace knyga2_01
{
    class notescom
    {
        int i, id, bookid, width;
        string text;
        public notescom(int _i, int _id, int _bookid, string _text,int _width)
        {
            i = _i;
            id = _id;
            bookid = _bookid;
            text = _text;
            width = _width;
        }
    
        public TabPage makepage()
        {
            TabPage tp = new TabPage();     // sukuriam nauja tab page kuri idesime

            tp.Name = i.ToString(); // pavadinimas
            tp.Text = "Note #" + i; // jo tekstas virsuje
            RichTextBox lab = new RichTextBox(); // idedame i ji textboxa
            lab.Text = text;
            lab.Width = width-5;
            lab.Height = 5000; // prisiskiriame jam dydi
            tp.Controls.Add(lab); // priskiriame textboxa tam tab page'ui
            custompage cp = new custompage(lab.Text,id,bookid); // SUKURIAME KLASE SU TEKSTU IR ID
            tp.Tag = cp; // priosiskiriame tam tabui klase kaip tag'a
            lab.TextChanged += (sender, e) =>
            {
                cp.asd = lab.Text;
            };

            return tp;
        }
    }
}
