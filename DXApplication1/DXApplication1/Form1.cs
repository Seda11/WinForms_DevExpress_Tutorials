using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tileItem1_CheckedChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MessageBox.Show("Tile Checked state has changes!", "Tile Control");
        }
    }
}
