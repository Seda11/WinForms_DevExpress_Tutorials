using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreenExample
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmRadialMenu f = new frmRadialMenu();
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            //demo loading data
            for(int i = 0; i < 50; i++)
            {

                Thread.Sleep(50);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Veriler yükleniyor..");
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
            this.Hide();
            f.Show();
        }
    }
}