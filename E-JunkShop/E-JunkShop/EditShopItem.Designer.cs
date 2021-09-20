
namespace E_JunkShop
{
    partial class EditShopItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.typeCmb = new System.Windows.Forms.ComboBox();
            this.tagsCmb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.LinkLabel();
            this.itemImageBox = new System.Windows.Forms.PictureBox();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(166, 477);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 30);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(299, 477);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 30);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.Black;
            this.nameLbl.Location = new System.Drawing.Point(29, 147);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(451, 30);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Mc-FLoat";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLbl
            // 
            this.idLbl.BackColor = System.Drawing.Color.Transparent;
            this.idLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.Color.Black;
            this.idLbl.Location = new System.Drawing.Point(41, 177);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(439, 20);
            this.idLbl.TabIndex = 6;
            this.idLbl.Text = "#1737";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tags";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(130, 247);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(319, 31);
            this.nameBox.TabIndex = 11;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(130, 299);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(319, 31);
            this.priceBox.TabIndex = 12;
            // 
            // typeCmb
            // 
            this.typeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCmb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCmb.FormattingEnabled = true;
            this.typeCmb.Location = new System.Drawing.Point(130, 349);
            this.typeCmb.Name = "typeCmb";
            this.typeCmb.Size = new System.Drawing.Size(319, 30);
            this.typeCmb.TabIndex = 13;
            // 
            // tagsCmb
            // 
            this.tagsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagsCmb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsCmb.FormattingEnabled = true;
            this.tagsCmb.Location = new System.Drawing.Point(130, 399);
            this.tagsCmb.Name = "tagsCmb";
            this.tagsCmb.Size = new System.Drawing.Size(319, 30);
            this.tagsCmb.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.itemImageBox);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.tagsCmb);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.typeCmb);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 557);
            this.panel1.TabIndex = 15;
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = true;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(118, 128);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(25, 13);
            this.editBtn.TabIndex = 16;
            this.editBtn.TabStop = true;
            this.editBtn.Text = "Edit";
            this.editBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editBtn_LinkClicked);
            // 
            // itemImageBox
            // 
            this.itemImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImageBox.Location = new System.Drawing.Point(25, 25);
            this.itemImageBox.Name = "itemImageBox";
            this.itemImageBox.Size = new System.Drawing.Size(120, 120);
            this.itemImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImageBox.TabIndex = 15;
            this.itemImageBox.TabStop = false;
            // 
            // EditShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(500, 567);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditShopItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditShopItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox typeCmb;
        private System.Windows.Forms.ComboBox tagsCmb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox itemImageBox;
        private System.Windows.Forms.LinkLabel editBtn;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
    }
}