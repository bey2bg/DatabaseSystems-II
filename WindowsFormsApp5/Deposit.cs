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
    public partial class Deposit : Form
    {
        Database v;
        public Deposit()
        {
            InitializeComponent();
            v = new Database();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        void Refresh() => Deposit;
    }
}
