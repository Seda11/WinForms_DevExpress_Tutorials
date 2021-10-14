using DevExpress.XtraEditors;
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

namespace LayoutControlDemo
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            string dosyaAdı = string.Format("{0}/{1}.xml", Application.StartupPath, this.Name);
            if (File.Exists(dosyaAdı))
            {
                layoutControl1.RestoreLayoutFromXml(dosyaAdı);
            }
        }
        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                layoutControl1.SaveLayoutToXml(string.Format("{0}/{1}.xml", Application.StartupPath, this.Name));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}