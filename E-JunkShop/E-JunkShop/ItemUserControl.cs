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
    public partial class ItemUserControl : UserControl
    {
        private string id;
        private string filename;

        public ItemUserControl()
        {
            InitializeComponent();            
            infoImage.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\infoImage.png");
        }
        public void setDetails(string id, string tag, string type, string name,string price, string weight, string available, string date, string filename)
        {
            this.id = id;
            tagsLbl.Text = tag;
            typeLbl.Text = type;
            nameLbl.Text = name;
            priceLbl.Text = price;
            weightLbl.Text = weight;
            availableLbl.Text = available;
            dateLbl.Text = date;
            this.filename = filename;
            setImage(filename);
        }
        private void setImage(string filename)
        {
            try
            {
                itemImage.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\ItemImageFolder\\{filename}");
            }
            catch
            {
                itemImage.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\ItemImageFolder\\defaultItemImage.png");
            }
        }

        private void infoImage_Click(object sender, EventArgs e)
        {            
            var edit = new EditShopItem();
            edit.setItem(id, nameLbl.Text, priceLbl.Text.Replace("Php", ""), tagsLbl.Text, typeLbl.Text, availableLbl.Text,filename);
            edit.OnEditClicked += OnEditClikedAction;            
            edit.ShowDialog();
            
        }
        private void OnEditClikedAction(object sender, string filename)
        {
            setImage(filename);
            this.filename = filename;
        }        
    }
}
