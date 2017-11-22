using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indictus.Misc.Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = _add(Int32.Parse(txtOne.Text), Int32.Parse(txtTwo.Text)) + "";
              //this.txtResult.Text = _add(4,5) + ""
        }

        private int _add(int x, int y)
        {
            return x + y;
        }


    }
}
