using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudiProject
{
    public partial class frmModels : Form
    {
        public frmModels()
        {
            InitializeComponent();
        }


        public void BindFormIntoMainForm(Form Main)
        {
            Main.TopLevel = false;
            Main.WindowState = FormWindowState.Maximized;
            Main.AutoScroll = true;

            Main.Show();
        }
     

       
    }
}
