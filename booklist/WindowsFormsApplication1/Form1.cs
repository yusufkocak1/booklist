using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LOGIN : Form
    {
        
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection(@"Data seurce=(localDB)
/MSSQLLOCALDB;AttachDbFilename=|DataDirectoy|/booklistDB.mdf;Integrated Security=True");

            conn.Open();
            SqlCommand cmd=new SqlCommand("select * from user",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr[1].ToString().Equals(textBox1.Text) && dr[2].ToString().Equals(textBox2.Text))
                {
                    katalogfrm katalogobj = new katalogfrm();
                    this.Hide();
                    katalogobj.Show();
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            signInfrm sgnin_obj = new signInfrm();
            
            sgnin_obj.Show();
            this.Close();
        }
    }
}
