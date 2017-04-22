using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            userDS.userRow r;


            if (r.userName.Equals(textBox1.Text) && r.password.Equals(textBox2.Text))
            {
                MessageBox.Show(r.userName);
                
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
