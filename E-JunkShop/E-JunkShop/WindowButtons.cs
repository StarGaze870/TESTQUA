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
    public partial class WindowButtons : UserControl
    {
        public WindowButtons()
        {
            InitializeComponent();
            close.Image = Image.FromFile(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + $"\\Resources\\close.png");
        }

        private void close_Click(object sender, EventArgs e)
        {            
            ((Form)TopLevelControl).Close();
        }
    }
}
