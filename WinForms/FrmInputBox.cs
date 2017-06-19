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
    public partial class FrmInputBox : Form
    {
        public FrmInputBox()
        {
            InitializeComponent();
        }

        public string CarName { get; set; }
        public int CarID { get; set; }


        private void btnInOK_Click_1(object sender, EventArgs e)
        {
            string _selectType = textCarSelect.Text;
            if (_selectType.ToLower() == "r")
            {
                FrmRent _FrmRent = new FrmRent();
                _FrmRent.Show();
            }
            else if (_selectType.ToLower() == "s")
            {
                FrmSell _FrmSell = new FrmSell();
                _FrmSell.CarName = CarName;
                _FrmSell.CarID = CarID;
                _FrmSell.Show();
            }

        }

        private void btnInBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}