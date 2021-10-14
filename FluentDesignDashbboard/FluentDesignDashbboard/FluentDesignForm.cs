using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FluentDesignDashbboard
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FluentDesignForm_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new XtraUserControlDashBoard() { Dock = DockStyle.Fill });
        }
    }
}
