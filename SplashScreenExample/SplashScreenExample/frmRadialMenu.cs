using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SplashScreenExample
{
    public partial class frmRadialMenu : DevExpress.XtraEditors.XtraForm
    {
        public frmRadialMenu()
        {
            InitializeComponent();
        }

        private void frmRadialMenu_Load(object sender, EventArgs e)
        {
            Point p = this.Location;
            p.Offset(this.Width / 2, this.Height / 2);
            radialMenu1.ShowPopup(p);
        }
    }
}