using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_JunkShop
{
    public partial class EditShopItem : Form
    {
        public EditShopItem()
        {
            InitializeComponent();
            imageFileDialog.Filter = "image files (*.png)|*.jpg";
        }
        private string destination;
        private string filename;

        public void setItem(string id, string name, string price, string tag, string type, string available, string filename)
        {
            if (available.Equals("Unavailable"))
                priceBox.Enabled = false;

            this.filename = filename;
            idLbl.Text = "#" + id;
            nameLbl.Text = name;
            nameBox.Text = name;
            priceBox.Text = price;

            var tagsTable = Functions.getTagsOrType(0);
            var typesTable = Functions.getTagsOrType(1);

            tagsCmb.DataSource = tagsTable;
            tagsCmb.ValueMember = "TAG ID";
            tagsCmb.DisplayMember = "NAME";

            typeCmb.DataSource = typesTable;
            typeCmb.ValueMember = "TYPE ID";
            typeCmb.DisplayMember = "NAME";

            for(int i = 0; i < tagsTable.Rows.Count; ++i)            
                if (tagsTable.Rows[i][1].ToString().Equals(tag))
                    tagsCmb.SelectedIndex = i;

            for (int i = 0; i < typesTable.Rows.Count; ++i)
                if (typesTable.Rows[i][1].ToString().Equals(type))
                    typeCmb.SelectedIndex = i;
            
            setImage(filename);
        }
        private void setImage(string filename)
        {
            try 
            {
                itemImageBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\ItemImageFolder\\{filename}");
            }
            catch
            {
                itemImageBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\ItemImageFolder\\defaultItemImage.png");
            }
        }        

        public event EventHandler<string> OnEditClicked;        

        protected virtual void OnEditClickedTrigger(string filename)
        {
            if (OnEditClicked != null)
                OnEditClicked(this, filename);  
        }      

        public virtual void editBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            imageFileDialog.Filter = "Image Files|*.png;*.jpg;*";

            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destination = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\ItemImageFolder";
                string filename = Path.GetFileName(imageFileDialog.FileName);
                setImage(filename);

                this.filename = filename;
                this.destination = destination;                
            }
        }        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (validPrice())
            {
                // SAVE CHANGES TO IMAGE
                try
                {
                    File.Copy(imageFileDialog.FileName, Path.Combine(destination, filename));
                }
                catch
                {
                    // DO NOTHING WHEN ALREADY EXIST
                }
                OnEditClickedTrigger(filename);
                Functions.Query(Functions.updateImage(filename, idLbl.Text.Replace("#", "")));

                // SAVE CHANGES TO NAME

                // SAVE CHANGES TO PRICE

                // SAVE CHANGES TO TAGS

                // SAVE CHANGES TO TYPES

                MessageBox.Show($"Changes saved for item {idLbl.Text}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                Close();
            }
            else
                MessageBox.Show("Invalid Price Format", "Price Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }   

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        private bool validPrice()
        {
            return Double.TryParse(priceBox.Text, out double x);
        }
       
    }
}
