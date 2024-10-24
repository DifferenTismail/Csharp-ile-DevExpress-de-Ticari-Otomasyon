using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        FrmUrunler fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmMusteriler fr2;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            { 
                fr2 = new FrmMusteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FrmFirmalar fr3;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr3 == null)
            {
                fr3 = new FrmFirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
    }
}
