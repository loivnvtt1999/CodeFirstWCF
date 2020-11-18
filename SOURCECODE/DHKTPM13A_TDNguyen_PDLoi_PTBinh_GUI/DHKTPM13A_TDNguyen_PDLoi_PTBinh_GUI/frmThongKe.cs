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
    public partial class frmThongKe : Form
    {
        List<eThongKeDoanhThuVe> listDT;
        PhongChieuClient qlpc;
        double doanhthutong;
        double doanhthuchitiet;
        DataTable dtsHD;
        DataTable dtsCT;
        List<eThongKeCTHD> lstCTHD;
        public frmThongKe()
        {
            InitializeComponent();
            listDT = new List<eThongKeDoanhThuVe>();
            lstCTHD = new List<eThongKeCTHD>();
            qlpc = new PhongChieuClient();
            dtsHD = new DataTable();
            dtsCT = new DataTable();
        }

        public DataTable CreatDataChiTiet()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Thành tiền (VNĐ)");
            return dt;
        }
        public DataTable CreatDataVe()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Tổng tiền (VNĐ)");

            return dt;
        }

        private void dataGridViewX1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                eThongKeDoanhThuVe hoadonduochon = new eThongKeDoanhThuVe();
                foreach (eThongKeDoanhThuVe ect in listDT)
                {
                    if (ect.MaHoaDon.Equals(e.Row.Cells[0].Value.ToString()))
                    {
                        hoadonduochon = ect;
                    }
                }
                if (hoadonduochon != null)
                {
                    lstCTHD = qlpc.thongKeCTHD(hoadonduochon).ToList();
                    dtsCT.Clear();
                    dtsCT = CreatDataChiTiet();
                    doanhthuchitiet = 0;
                    foreach (eThongKeCTHD echitiet in lstCTHD)
                    {
                        dtsCT.Rows.Add(echitiet.TenSanPham, echitiet.SoLuong, echitiet.DonGia, echitiet.TongCong);
                        doanhthuchitiet += echitiet.TongCong;
                    }
                    dataGridViewX2.DataSource = dtsCT;
                    dataGridViewX2.RefreshEdit();
                    tbxDoanhThuChiTiet.Text = String.Format("{0:#,#.}", doanhthuchitiet);
                }
            }
        }
        void LoadDataDataGridViewPhim(DataGridView dgr, List<eThongKeDoanhThuVe> l)
        {
            dtsHD.Clear();
            dtsHD = CreatDataVe();
            foreach (eThongKeDoanhThuVe tk in listDT)
            {
                dtsHD.Rows.Add(tk.MaHoaDon, tk.NgayLap.Value.ToString("dd/MM/yyyy"), tk.TongTien);
            }
            dgr.DataSource = dtsHD;
            dgr.RefreshEdit();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            listDT = qlpc.thongKeDoanhThuVe(dtpTuNgay.Value, dtpDenNgay.Value).ToList();
            LoadDataDataGridViewPhim(dataGridViewX1, listDT);
            doanhthutong = 0;
            for (int i = 0; i < listDT.Count(); i++)
            {
                doanhthutong += listDT[i].TongTien;
            }
            tbxDoanhThu.Text = String.Format("{0:#,#.}", doanhthutong);
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(2020, 7, 1);
            dtpDenNgay.Value = DateTime.Now;
        }
    }
}
