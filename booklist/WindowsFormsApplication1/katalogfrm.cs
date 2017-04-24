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
    public partial class katalogfrm : Form
    {
        public katalogfrm()
        {
            InitializeComponent();
        }

        private void katalogfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDS.kitap' table. You can move, or remove it, as needed.
            this.kitapTableAdapter.Fill(this.userDS.kitap);

        }
    }
}
