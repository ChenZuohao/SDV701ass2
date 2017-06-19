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
    public partial class FrmManage : Form
    {
        private static readonly FrmManage _Instance = new FrmManage();

       // private clsArtistList _ArtistList = new clsArtistList();

        public delegate void Notify(string prGalleryName);

        public event Notify GalleryNameChanged;

        public FrmManage()
        {
            InitializeComponent();
        }
        public static FrmManage Instance
        {
            get { return FrmManage._Instance; }
        }

        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery (v3 C) - " + prGalleryName;
        }

        public async void UpdateDisplay()
        {
            try
            {
                lstMange.DataSource = null;
                lstMange.DataSource = await ServiceClient.GetBrandName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new Brand");
            }
            
            //lstArtists.DataSource = null;
            //string[] lcDisplayList = new string[_ArtistList.Count];
            //_ArtistList.Keys.CopyTo(lcDisplayList, 0);
            //lstArtists.DataSource = lcDisplayList;
            //lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
        }

        private void BtnMback_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _ArtistList.Save();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "File Save Error");
            //}
            Close();
            //FrmMain Main = new FrmMain();
            //Main.Show();
            //this.Close();
        }

        private void lstMange_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = lstMange.SelectedValue.ToString();
            if (lcKey != null)
                try
                {
                    FrmBrand.Run(lstMange.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBrand.Run(null);
                //frmArtist.Run(new clsArtist(_ArtistList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new Brand");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = lstMange.SelectedValue.ToString();
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    await ServiceClient.RemoveCarBrandAsync(lcKey);
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting Car");
                }
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    _ArtistList = clsArtistList.RetrieveArtistList();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "File retrieve error");
            //}
            UpdateDisplay();
            //GalleryNameChanged += new Notify(updateTitle);
            //GalleryNameChanged(_ArtistList.GalleryName);
            //updateTitle(_ArtistList.GalleryName);
        }

    }
}
   
