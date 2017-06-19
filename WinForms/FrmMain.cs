using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmMain : Form
    {
        FrmManage Manage = new FrmManage();
        FrmOrder order = new FrmOrder();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            order = new FrmOrder();
            order.Show();



        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage = new FrmManage();
            Manage.Show();
        }
    }
}
