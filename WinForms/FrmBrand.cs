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
    public partial class FrmBrand : Form
    {
        private clsCarBrand _Brand;
        //private clsWorksList _WorksList;

        private static Dictionary<string, FrmBrand> _BrandFormList = new Dictionary<string, FrmBrand>();

        public FrmBrand()
        {
            InitializeComponent();
        }

        public static void Run(string prBrandName)
        {
            FrmBrand lcBrandForm;
            if (string.IsNullOrEmpty(prBrandName) ||
            !_BrandFormList.TryGetValue(prBrandName, out lcBrandForm))
            {
                lcBrandForm = new FrmBrand();
                if (string.IsNullOrEmpty(prBrandName))
                    lcBrandForm.SetDetails(new clsCarBrand());
                else
                {
                    _BrandFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            }
            else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }

        }

        private async void  refreshFormFromDB(string prBrandName)
        {
            try
            {
                SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
            }
            catch
            {

            }
            
        }

        private void updateTitle(string prCarName)
        {
            if (!string.IsNullOrEmpty(prCarName))
                Text = "Car Details - " + prCarName;
        }

        private void UpdateDisplay()
        {

            lstBrand.DataSource = null;
            if (_Brand.WorksList != null)
            {
                lstBrand.DataSource = _Brand.WorksList;
                lstBrand.ValueMember = "Car_ID";
                lstBrand.DisplayMember = "_DisplayMember";
            }
        }

        public void UpdateForm()
        {
            txtBName.Text = _Brand.Car_BrandName;
            txtBcountry.Text = _Brand.BrandCountry;
            //_WorksList = _Artist.WorksList;

            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        public void SetDetails(clsCarBrand PrBrand)
        {
            _Brand = PrBrand;
            txtBName.Enabled = string.IsNullOrEmpty(PrBrand.Car_BrandName);
            UpdateForm();
            UpdateDisplay();
            FrmManage.Instance.GalleryNameChanged += new FrmManage.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
            Show();
        }

        private void pushData()
        {
            _Brand.Car_BrandName = txtBName.Text;
            _Brand.BrandCountry = txtBcountry.Text;
            //_WorksList.SortOrder = _SortOrder; // no longer required, updated with each rbByDate_CheckedChanged
        }


        private Boolean isValid()
        {
            //if (txtBName.Enabled && txtBName.Text != "")
            //    if (_Brand.IsDuplicate(txtBName.Text))
            //    {
            //        MessageBox.Show("Brand with that name already exists!", "Error adding Brand");
            //        return false;
            //    }
            //    else
            //        return true;
            //else
                return true;
        }

        private  void btnBadd_Click(object sender, EventArgs e)
        {
            FrmInputBox _FrmInputBox = new FrmInputBox();
            clsCar _clsCar = new clsCar();
            if (lstBrand.SelectedItem != null)
            {
                _clsCar = (clsCar)lstBrand.SelectedItem;
                _FrmInputBox.CarName = _clsCar.Car_ModleName;
                _FrmInputBox.CarID = _clsCar.Car_ID;
            }
            _FrmInputBox.Show();
            refreshFormFromDB(_BrandFormList.Keys.First());
            //FrmInputBox _FrmInputBox = new FrmInputBox();
            //clsCar _clsCar = (clsCar)lstBrand.SelectedItem;
            //_FrmInputBox.CarName = _clsCar.Car_ModleName;
            //_FrmInputBox.CarID = _clsCar.Car_ID;
            //_FrmInputBox.Show();
            //UpdateDisplay();
            //string lcReply = new InputBox(clsCar.FACTORY_PROMPT).Answer;
            //if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
            //{
            //    clsCar lcCar = clsCar.NewCar(lcReply[0]);
            //    if (lcCar != null) // valid artwork created?
            //    {
            //        if (txtBName.Enabled)       // new artist not saved?
            //        {
            //            pushData();
            //            await ServiceClient.InsertBrandAsync(_Brand);
            //            txtBName.Enabled = false;
            //        }
            //        lcCar.Car_BrandName = _Brand.Car_BrandName;
            //        FrmCar.DispatchWorkForm(lcCar);
            //        if (!string.IsNullOrEmpty(lcCar.Car_ModleName)) // not cancelled?
            //        {
            //            refreshFormFromDB(_Brand.Car_BrandName);
            //            FrmManage.Instance.UpdateDisplay();
            //        }
            //    }



            FrmManage.Instance.UpdateDisplay();
            }

        private void lstBrand_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //FrmBrand.Run(lstBrand.SelectedItem as string);

                //FrmManage.DispatchWorkForm(lstBrand.SelectedValue as clsAllWork);
                //   _WorksList.EditWork(lstWorks.SelectedIndex);
                FrmCar.DispatchWorkForm(lstBrand.SelectedValue as clsCar);
                UpdateDisplay();
                FrmManage.Instance.UpdateDisplay();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnBDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstBrand.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Delet That", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int lcKey = int.Parse(lstBrand.SelectedValue.ToString());
                await ServiceClient.RemoveCarAsync(lcKey);
                FrmManage.Instance.UpdateDisplay();
                //UpdateDisplay();
                //lstBrand.Items.RemoveAt(lcIndex);
                refreshFormFromDB(_BrandFormList.Keys.First());

            }

            //int lcIndex = lstBrand.SelectedIndex;

            //if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Delet That", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    int lcKey = int.Parse(lstBrand.SelectedValue.ToString());
            //    await ServiceClient.RemoveCarAsync(lcKey);
            //    UpdateDisplay();
            //    FrmManage.Instance.UpdateDisplay();
            //}
            //int lcIndex = lstBrand.SelectedIndex;

            //if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Delet That", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    MessageBox.Show(await ServiceClient.DeleteCarAsync(lstBrand.SelectedItem as clsCar));
            //    refreshFormFromDB(_Brand.Car_BrandName);
            //    FrmManage.Instance.UpdateDisplay();

            //}
        }

        private async void btnBBack_Click(object sender, EventArgs e)
        {
            pushData();
            if (txtBName.Enabled)
            {
                MessageBox.Show(await ServiceClient.InsertBrandAsync(_Brand));
               FrmManage.Instance.UpdateDisplay();
                txtBName.Enabled = false;
            }
            else
                MessageBox.Show(await ServiceClient.UpdateBrandAsync(_Brand));
            Hide();

        }

        private void lstBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


