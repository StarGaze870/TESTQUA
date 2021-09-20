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
    public partial class LoginForm : Form
    {
        // USER CONTROL FOR CLOSING FORMS
        private WindowButtons windowButtons = new WindowButtons();

        // ADMIN CLASS
        private AdminForm adminForm;

        public LoginForm()
        {
            InitializeComponent();
            Controls.Add(windowButtons);
            windowButtons.Location = new Point(400, 5);

            logoBox.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\loginLogo.png");                        
        }

        private int roleid;
        private void loginButton_Click(object sender, EventArgs e)
        {
            string password = Functions.getColumnData("Users", "username", usernameBox.Text, "password");
            string roleid = Functions.getColumnData("Users", "username", usernameBox.Text, "roleid");
            Int32.TryParse(roleid, out this.roleid);

            if (passwordBox.Text.Equals(password) && password.Length != 0)
            {
                if(roleid.Equals("1")) // ADMIN SIDE
                {
                    Visible = false;
                    adminForm = new AdminForm();
                    adminForm.FormClosing += new FormClosingEventHandler(Form_Closed);
                    adminForm.setAdmin(roleid);
                    adminForm.Visible = true;
                                        
                }
                else                   // CUSTOMER SIDE
                {

                }
            }
            else
                MessageBox.Show("incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        void Form_Closed(object sender, FormClosingEventArgs e)
        {                        
            if(roleid == 1) // CLOSING ADMIN FORM
            {
                adminForm.Dispose();
                adminForm.Close();                
            }
            else if (roleid == 2) // CLOSING CUSTOMER FORM
            {

            }
            else                 // CLOSING REGISTER FORM
            {

            }

            // CLEARING USERNAME AND PASSWORD TEXT BOX
            usernameBox.Text = null;
            passwordBox.Text = null;
            
            Visible = true;            
        }        

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Warning", buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Dispose();
                Environment.Exit(0);
            }
            e.Cancel = true;
        }

        
    }
}
