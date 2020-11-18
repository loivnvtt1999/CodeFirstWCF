using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.ServiceRapChieuPhim;

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmThemPhong : Form
    {
        PhongChieuClient client;
        public ePhongChieu ePC;
        public frmThemPhong()
        {
            InitializeComponent();
            client = new PhongChieuClient();
            ePC = new ePhongChieu();
            this.DialogResult = DialogResult.None;
        }

        private void frmThemPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ePC.MaPhong = tbxMaPhong.Text;
            ePC.TenPhong = tbxPhongChieu.Text;
            int kq = client.ThemPhong(ePC);
            if (kq == 1)
                MessageBox.Show("Thêm thành công");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
