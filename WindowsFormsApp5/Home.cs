using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Form item in this.MdiChildren)
            
                item.Dispose();
            
            Books frm = new Books();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            item.Dispose();
            Users frm = new Users();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            Deposit frm = new Deposit();
            frm.MdiParent = this;
            frm.Show();
            frm.Location = new Point(0, 0);
        }
    }
}
