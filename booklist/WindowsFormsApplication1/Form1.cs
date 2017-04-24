using System;

using System.Windows.Forms;

using System.Data.SqlClient;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class LOGIN : Form
    {
        public static object ConfigurationManager { get; private set; }

        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\booklistDB.mdf;Integrated Security=True");
            
            conn.Open();
            SqlCommand cmd=new SqlCommand("select * from [user]",conn);
            SqlDataReader dr;
            dr= cmd.ExecuteReader();

            uyumluluk();
            while (dr.Read())
            {
                MessageBox.Show(dr[1].ToString().Equals(textBox1.Text).ToString());

                if (dr[1].ToString().Equals(textBox1.Text) && dr[2].ToString()==textBox2.Text)
                {
                    katalogfrm katalogobj = new katalogfrm();
                    this.Hide();
                    katalogobj.Show();
                }
            }
            
        }

        private void uyumluluk()
        {
            while(textBox1.Text.Length<20)
            {
               // MessageBox.Show(textBox1.Text.Length.ToString());
                textBox1.Text=textBox1.Text + " ";
            }
            while(textBox2.TextLength<20)
            {
                textBox2.Text = textBox2.Text + " ";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            signInfrm sgnin_obj = new signInfrm();
            
            sgnin_obj.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean temp = false;
        Point ilkkonum;
        private Point mouseOffset;
        private bool isMouseDown;

        private void LOGIN_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)

            {

                Point mousePos = Control.MousePosition;

                mousePos.Offset(mouseOffset.X, mouseOffset.Y);

                Location = mousePos;

            }
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;

            int yOffset;

            if

            (e.Button == MouseButtons.Left)

            {

                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;

                yOffset = -e.Y - SystemInformation.CaptionHeight -

SystemInformation.FrameBorderSize.Height;

                mouseOffset = new Point(xOffset, yOffset);

                isMouseDown = true;

            }
        }

        private void LOGIN_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                isMouseDown = false;

            }
        }
    }
}
