using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_JunkShop
{
    public partial class AdminForm : Form
    {        
        public AdminForm()
        {
            InitializeComponent();
            
            adminLogoBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\loginLogo.png");            
        }       
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dashboardBtn.PerformClick();
        }

        // VARIABLES

        private string userid;

        // SETTING UP NEEDED DATA
        public void setAdmin(string userid)
        {
            this.userid = userid;            
        }

        // DASHBOARD
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            dashboardPanel.Visible = true;
            
        }

        // MANAGE ITEMS
        private void manageBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            managePanel.Visible = true;

            shopItemCmb.SelectedIndex = 0;
            
        }
        private void fillShopItems(int option, string search)
        {
            shopItemsFlowLayoutPanel.Controls.Clear();
            //var list = Functions.getShopItems(option, search);
            
            for (int i = 0; i < 5; ++i)
            {
                var temp = new ItemUserControl();
                //temp.setDetails(list[i].Item1, list[i].Item2, list[i].Item3, list[i].Item4, list[i].Item5, list[i].Item6, list[i].Item7, list[i].Item8, list[i].Item9);

                shopItemsFlowLayoutPanel.Controls.Add(temp);
            }
        }
        private void shopItemCmb_SelectedIndexChanged(object sender, EventArgs e)
        {            
            fillShopItems(shopItemCmb.SelectedIndex, "");
        }
        private void shopItemSearchBox_TextChanged(object sender, EventArgs e)
        {
            if(shopItemSearchBox.Text.Length == 0)
                fillShopItems(shopItemCmb.SelectedIndex, "");
            else
            {
                fillShopItems(shopItemCmb.SelectedIndex, shopItemSearchBox.Text);
            }
        }

        // ITEM TYPES
        private void itemTypeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            itemTypePanel.Visible = true;
        }

        // TRANSACTIONS
        private void transactionBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            transactionPanel.Visible = true;
        }

        // FUNDS
        private void fundsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            fundsPanel.Visible = true;
        }

        // REPORTS
        private void reportsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; ++i)
                setPanels(i);
            reportsPanel.Visible = true;
        }

        // LOGOUT
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        // PREPARING PANELS
        private void setPanels(int x)
        {
            switch (x)
            {
                case 0:
                    dashboardPanel.Visible = false;
                    break;

                case 1:
                    managePanel.Visible = false;
                    break;

                case 2: 
                    itemTypePanel.Visible = false;
                    break;

                case 3:
                    transactionPanel.Visible = false;
                    break;

                case 4:
                    fundsPanel.Visible = false;
                    break;

                case 5:
                    reportsPanel.Visible = false;
                    break;
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Logout ?", "Account", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Dispose();                                
            }
            e.Cancel = true;            
        }      
    }
}
