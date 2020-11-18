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
    public partial class frmThongTinNhanVien : Form
    {
        eNhanVien nv;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        public frmThongTinNhanVien(eNhanVien nhanVien)
        {
            InitializeComponent();
            nv = nhanVien;
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            tbxma.Text = nv.MaNhanVien;
            tbxTen.Text = nv.TenNhanVien;
            tbxCV.Text = nv.ChucVu;
        }
    }
}
