
namespace E_JunkShop
{
    partial class ItemUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.availableLbl = new System.Windows.Forms.Label();
            this.tagsLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.infoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImage
            // 
            this.itemImage.Location = new System.Drawing.Point(30, 15);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(80, 80);
            this.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImage.TabIndex = 0;
            this.itemImage.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(126, 6);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(133, 23);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Item Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLbl
            // 
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(360, 68);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(60, 23);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "99/99/99";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // availableLbl
            // 
            this.availableLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLbl.Location = new System.Drawing.Point(347, 86);
            this.availableLbl.Name = "availableLbl";
            this.availableLbl.Size = new System.Drawing.Size(73, 23);
            this.availableLbl.TabIndex = 3;
            this.availableLbl.Text = "Unavailable";
            this.availableLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tagsLbl
            // 
            this.tagsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsLbl.Location = new System.Drawing.Point(126, 29);
            this.tagsLbl.Name = "tagsLbl";
            this.tagsLbl.Size = new System.Drawing.Size(133, 23);
            this.tagsLbl.TabIndex = 4;
            this.tagsLbl.Text = "Tags";
            this.tagsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLbl
            // 
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(126, 52);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(133, 23);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Type";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightLbl
            // 
            this.weightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLbl.Location = new System.Drawing.Point(126, 75);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(133, 23);
            this.weightLbl.TabIndex = 6;
            this.weightLbl.Text = "Weight";
            this.weightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(282, 6);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(138, 23);
            this.priceLbl.TabIndex = 7;
            this.priceLbl.Text = "Php99.00";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoImage
            // 
            this.infoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoImage.Location = new System.Drawing.Point(3, 3);
            this.infoImage.Name = "infoImage";
            this.infoImage.Size = new System.Drawing.Size(20, 20);
            this.infoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoImage.TabIndex = 8;
            this.infoImage.TabStop = false;
            this.infoImage.Click += new System.EventHandler(this.infoImage_Click);
            // 
            // ItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.infoImage);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.tagsLbl);
            this.Controls.Add(this.availableLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.itemImage);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 3, 10);
            this.MaximumSize = new System.Drawing.Size(425, 110);
            this.MinimumSize = new System.Drawing.Size(425, 110);
            this.Name = "ItemUserControl";
            this.Size = new System.Drawing.Size(425, 110);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label availableLbl;
        private System.Windows.Forms.Label tagsLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.PictureBox infoImage;
    }
}
