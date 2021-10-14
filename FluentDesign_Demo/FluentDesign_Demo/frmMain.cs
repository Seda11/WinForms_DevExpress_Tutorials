using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentDesign_Demo
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void accordionControlElementKategori_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(XtraUserControlKategori.Instance))
            {
                fluentDesignFormContainer.Controls.Add(XtraUserControlKategori.Instance);
                XtraUserControlKategori.Instance.Dock = DockStyle.Fill;
                XtraUserControlKategori.Instance.BringToFront();
            }
            XtraUserControlKategori.Instance.BringToFront();
        }

        private void accordionControlElementÜrünler_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(XtraUserControlUrunler.Instance))
            {
                fluentDesignFormContainer.Controls.Add(XtraUserControlUrunler.Instance);
                XtraUserControlUrunler.Instance.Dock = DockStyle.Fill;
                XtraUserControlUrunler.Instance.BringToFront();
            }
            XtraUserControlUrunler.Instance.BringToFront();
        }
    }
}