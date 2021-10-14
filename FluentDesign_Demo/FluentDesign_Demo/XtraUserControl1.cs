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
    public partial class XtraUserControlKategori : DevExpress.XtraEditors.XtraUserControl
    {
        private static XtraUserControlKategori _instance;

        public static XtraUserControlKategori Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new XtraUserControlKategori();
                return _instance;
            }
        }
        public XtraUserControlKategori()
        {
            InitializeComponent();
        }

        private void XtraUserControlKategori_Load(object sender, EventArgs e)
        {
            using (StokTakipDBEntities db=new StokTakipDBEntities())
            {
                gridControl1.DataSource = db.Müsteriler.ToList();
            }
        }
    }
}
