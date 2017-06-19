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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmMain Main = new FrmMain();
            Main.Show();
            this.Close();
        }

        private async void FrmOrder_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            List<ClsCarOrder> _ClsCarOrderList= await ServiceClient.GetCarOrderListAsync();

            foreach (ClsCarOrder result in _ClsCarOrderList)
            {
                var lvi = new ListViewItem(result.Car_ID.ToString());
                lvi.SubItems.Add(result.Customer_Name);
                lvi.SubItems.Add(result.Customer_Phone);
                lvi.SubItems.Add(result.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));
                lvi.SubItems.Add(result.Type.ToString());
                lvi.SubItems.Add(result.Price.ToString());
                listView1.Items.Add(lvi);
            }
            this.listView1.FullRowSelect = true;
            if (this.listView1.Items.Count > 0)
            {
                listView1.SelectedItems.Clear();
                this.listView1.Items[0].Selected = true;
                this.listView1.Items[0].EnsureVisible();
                this.listView1.Items[0].Focused = true;
                this.listView1.Select();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            MessageBox.Show(await ServiceClient.RemoveCarOrderAsync(int.Parse(listView1.SelectedItems[0].SubItems[0].Text)));
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
