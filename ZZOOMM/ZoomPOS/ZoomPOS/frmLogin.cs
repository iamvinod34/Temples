using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomPOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelZ1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void panelZ1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xButton13_Click(object sender, EventArgs e)
        {

        }

        private void xButton15_Click(object sender, EventArgs e)
        {
            frmSalesInvoice.show();  
        }
    }
}
