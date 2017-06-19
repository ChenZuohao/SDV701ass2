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
    public partial class FrmSell : WinForms.FrmCar
    {
        public string CarName { get; set; }
        public int CarID { get; set; }
        private static readonly FrmSell Instance = new FrmSell();

        public FrmSell()
        {
            InitializeComponent();
            base._type = "S";
        }
        public static void Run(clsCar prSell)
        {
            Instance.SetDetails(prSell);
        }

        protected override void updateForm()
        {
            base.updateForm();
            // clsPainting lcWork = (clsPainting)_Work;
            txtSprice.Text = _Car.Car_Price.ToString();
        }

        protected override void pushData()
        {
            base.pushData();
            clsCar lcCar = (clsCar)_Car;
            lcCar.Car_Price = Convert.ToDecimal(txtSprice.Text);
        }
    }
}
