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
    public partial class frmQuanLyKhachHang : Form
    {
        PhongChieuClient qlpc;
        List<eKhachHang> lKH;
        DataTable dts;
        int flag = 0;
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            qlpc = new PhongChieuClient();
            lKH = new List<eKhachHang>();
            dts = new DataTable();
        }

        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Chứng minh thư");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Email");
            return dt;
        }
        void dis_enable(bool e)
        {
            tbxMaKhachHang.Enabled = e;
            tbxTenKhachHang.Enabled = e;
            tbxSoDienThoai.Enabled = e;
            tbxEmail.Enabled = e;
            tbxCMND.Enabled = e;
            dPTNgaySinh.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
        }
        void binding()
        {
            tbxMaKhachHang.DataBindings.Clear();
            tbxMaKhachHang.DataBindings.Add("Text", dgvKH.DataSource, "Mã khách hàng");
            tbxTenKhachHang.DataBindings.Clear();
            tbxTenKhachHang.DataBindings.Add("Text", dgvKH.DataSource, "Tên khách hàng");
            tbxCMND.DataBindings.Clear();
            tbxCMND.DataBindings.Add("Text", dgvKH.DataSource, "Chứng minh thư");
            tbxEmail.DataBindings.Clear();
            tbxEmail.DataBindings.Add("Text", dgvKH.DataSource, "Email");
            tbxSoDienThoai.DataBindings.Clear();
            tbxSoDienThoai.DataBindings.Add("Text", dgvKH.DataSource, "Số điện thoại");
            dPTNgaySinh.DataBindings.Clear();
            dPTNgaySinh.DataBindings.Add("Text", dgvKH.DataSource, "Ngày sinh");
        }
        void TaoKhachHang(eKhachHang khmoi)
        {
            khmoi.MaKhachHang = tbxMaKhachHang.Text;
            khmoi.TenKhachHang = tbxTenKhachHang.Text;
            khmoi.CMND = tbxCMND.Text;
            khmoi.SDT = tbxSoDienThoai.Text;
            khmoi.Email = tbxEmail.Text;
            khmoi.NgaySinh = DateTime.Parse(dPTNgaySinh.Text);
        }
        private void SetAutoComplete()
        {

            tbxTimKiemKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxTimKiemKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroTbxTenKhachHang(List<eKhachHang> l)
        {
            tbxTimKiemKhachHang.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxTimKiemKhachHang.AutoCompleteCustomSource.Add(kh.TenKhachHang);
            }
        }

        void FormatDataGridView(DataGridView dgr)
        {
            dgr.Columns["Ngày sinh"].Width = 250;
            //dgr.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgr.Columns["Email"].Width = 350;
            dgr.Columns["Mã khách hàng"].Width = 100;
            dgr.Columns["Tên khách hàng"].Width = 250;
        }
        void LoadDataDataGridView(DataGridView dgr, List<eKhachHang> l)
        {

            dts = CreatData();
            dts.Clear();
            foreach (eKhachHang kh in l)
            {
                dts.Rows.Add(kh.MaKhachHang, kh.TenKhachHang, String.Format("{0:MM/dd/yyyy}", kh.NgaySinh), kh.CMND, kh.SDT, kh.Email);
                dgr.DataSource = dts;
                dgr.RefreshEdit();
            }
            FormatDataGridView(dgr);
            binding();
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            lKH = qlpc.LayDanhSachKhachHang().ToList();
            LoadDataDataGridView(dgvKH, lKH);
            dis_enable(false);
            SetAutoComplete();
            XuLyHoTroTbxTenKhachHang(lKH);
        }

        void resetData()
        {

            tbxMaKhachHang.Text = qlpc.PhatSinhMaKhachHang();
            tbxMaKhachHang.Enabled = true;
            tbxTenKhachHang.Text = "";
            tbxSoDienThoai.Text = "";
            tbxEmail.Text = "";
            tbxCMND.Text = "";
            dPTNgaySinh.Text = DateTime.Today.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            resetData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                eKhachHang khmoi = new eKhachHang();
                TaoKhachHang(khmoi);
                int kq = qlpc.ThemKhachHang(khmoi);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lKH = qlpc.LayDanhSachKhachHang().ToList();
                    LoadDataDataGridView(dgvKH, lKH);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                eKhachHang khmoi = new eKhachHang();
                TaoKhachHang(khmoi);
                int kq = qlpc.SuaKhachHang(khmoi);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lKH = qlpc.LayDanhSachKhachHang().ToList();
                    LoadDataDataGridView(dgvKH, lKH);
                    dis_enable(false);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lKH = qlpc.LayDanhSachKhachHang().ToList();
            LoadDataDataGridView(dgvKH, lKH);
            dis_enable(false);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            eKhachHang khtim = new eKhachHang();
            if (!String.IsNullOrWhiteSpace(tbxTimKiemKhachHang.Text))
            {

                khtim = qlpc.TimKhachHangTheoTen(tbxTimKiemKhachHang.Text);
                if (khtim != null)
                {
                    dts = CreatData();
                    dts.Clear();
                    dts.Rows.Add(khtim.MaKhachHang, khtim.TenKhachHang, String.Format("{0:MM/dd/yyyy}", khtim.NgaySinh), khtim.CMND, khtim.SDT, khtim.Email);
                    dgvKH.DataSource = dts;
                    dgvKH.RefreshEdit();
                    FormatDataGridView(dgvKH);
                    binding();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lKH = qlpc.LayDanhSachKhachHang().ToList();
                LoadDataDataGridView(dgvKH, lKH);
            }
        }
    }
}
