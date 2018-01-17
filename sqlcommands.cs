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

    static class sqlcommands
    {
        static string constr = ConfigurationManager.ConnectionStrings["knyga2_01.Properties.Settings.Database1ConnectionString"].ConnectionString;


        static public int count()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Knygos", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
            }
            con.Close();
            return i;
        }

        static public DataTable getinfo()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Knygos", con);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            con.Close();

            return dt;
        }

        static public DataTable getnotes(int id)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Notes WHERE bookid="+id, con);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            con.Close();

            return dt;
        }

        static public DataTable getsingle(int id)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Knygos WHERE Id="+id, con);

            DataTable dt = new DataTable();
            ada.Fill(dt);

            con.Close();

            return dt;
        }

        static public void addnew(string name, int psl, int read)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Knygos (Name,Psl,done) VALUES (@Name,@psl,@read)", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@psl", psl);
            cmd.Parameters.AddWithValue("@read", read);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        static public void addnewnote(string note, int bookid)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Notes (Note,bookid) VALUES (@Note,@bookid)", con);
            cmd.Parameters.AddWithValue("@Note", note);
            cmd.Parameters.AddWithValue("@bookid", bookid);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        static public void modify(int id, string name, int psl, int read)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Knygos SET Name=@Name , Psl=@psl ,done=@read WHERE id=" + id, con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@psl", psl);
            cmd.Parameters.AddWithValue("@read", read);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        static public void modifynote(int id, string Note, int bookid)
        {
            if (id == 0)
            {
                addnewnote(Note, bookid);
            }
            else
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Notes SET Note=@Note WHERE id=" + id, con);
                cmd.Parameters.AddWithValue("@Note", Note);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        static public void delete(int id)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Knygos WHERE Id=" + id, con);


            cmd.ExecuteNonQuery();
            con.Close();
        }

        static public void deletenote(int id)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE Id=" + id, con);


            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
