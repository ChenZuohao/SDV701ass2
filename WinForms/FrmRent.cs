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
    public partial class FrmRent : WinForms.FrmCar
    {
        public string CarName { get; set; }
        public int CarID { get; set; }
        private static readonly FrmRent Instance = new FrmRent();
        public FrmRent()
        {
            InitializeComponent();
            base._type = "R";
        }
        public static void Run(clsCar prRent)
        {
            Instance.SetDetails(prRent);
        }

        protected override void updateForm()
        {
            base.updateForm();
            // clsPainting lcWork = (clsPainting)_Work;
            TxtPrace.Text = _Car.Car_Price.ToString();
        }

        protected override void pushData()
        {
            base.pushData();
            clsCar lcCar = (clsCar)_Car;
            lcCar.Car_Price = Convert.ToDecimal(TxtPrace.Text);
        }

    }
}
