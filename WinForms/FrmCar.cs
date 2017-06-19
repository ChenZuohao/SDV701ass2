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
    public partial class FrmCar : Form
    {
        protected string _type = string.Empty;
        protected clsCar _Car;
        public FrmCar()
        {
            InitializeComponent();
        }

        public void SetDetails(clsCar prCar)
        {
            _Car = prCar;
            updateForm();
            ShowDialog();
        }
        protected virtual void pushData()
        {
            //clsCar _clsCar = new clsCar();
            _Car.Car_ModleName = txtname.Text;
            _Car.Date_LastModified = DateTime.Parse(txtManDate.Text);
            _Car.Car_ID = int.Parse(txtid.Text);
        }

        protected virtual void updateForm()
        {
            txtname.Text = _Car.Car_ModleName;
            txtid.Text = _Car.Car_ID.ToString();
            txtManDate.Text = _Car.Date_LastModified.ToShortDateString();
           txtname.Enabled = string.IsNullOrEmpty(_Car.Car_ModleName);
            FrmManage.Instance.UpdateDisplay();
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            clsCar _Car = new clsCar();
            //if (isValid())
            
                _Car.Car_ModleName = txtname.Text;
                _Car.Date_LastModified = DateTime.Parse(txtManDate.Text);
                _Car.Car_ID = int.Parse(txtid.Text);
                _Car.Type = this._type;
               _Car.Car_Type = this._type;
               _Car.Car_BrandName = "";

            
            
            if (txtname.Enabled)
                    MessageBox.Show(await ServiceClient.InsertCarAsync(_Car));
                else
                    MessageBox.Show(await ServiceClient.UpdateCarkAsync(_Car));

                Close();
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        public delegate void LoadWorkFormDelegate(clsCar prCar);
        public static void DispatchWorkForm(clsCar prCar)
        {
            Dictionary<char, Delegate> WorksForm = new Dictionary<char, Delegate>
             {
               {'R', new LoadWorkFormDelegate(FrmRent.Run)},
               //{'H', new LoadWorkFormDelegate(frmPhotograph.Run)},
               {'S', new LoadWorkFormDelegate(FrmSell.Run)}
              };
            WorksForm[char.Parse(prCar.Type)].DynamicInvoke(prCar);
        }

        private void FrmCar_Load(object sender, EventArgs e)
        {

        }
    }
}
