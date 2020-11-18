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
using DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.ServiceRapChieuPhim;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmHoaDonDichVu : Form
    {
        eHoaDon hoadoncuoicung;
        frmDichVu main;
        List<eCT_HoaDon_DichVu> lstDichVuThanhToan;
        PhongChieuClient qlpc;
        DataTable dts;
        public frmHoaDonDichVu()
        {
            InitializeComponent();
        }

        public frmHoaDonDichVu(frmDichVu frm, eHoaDon hd, List<eCT_HoaDon_DichVu> dvmua)
        {
            InitializeComponent();
            main = frm;
            hoadoncuoicung = hd;
            lstDichVuThanhToan = dvmua;
            qlpc = new PhongChieuClient();
            dts = new DataTable();
        }

        private void frmHoaDonDichVu_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(dgvCT, lstDichVuThanhToan);
            double tien = 0;
            tien += TinhTien(lstDichVuThanhToan);
            tbxTongTien.Text = tien.ToString();
            tbxMaHoaDon.Text = hoadoncuoicung.MaHoaDon;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(dgvCT, lstDichVuThanhToan);
            double tien = 0;
            tien += TinhTien(lstDichVuThanhToan);
            tbxTongTien.Text = tien.ToString();
            tbxMaHoaDon.Text = hoadoncuoicung.MaHoaDon;
        }

        private void SetAutoComplete()
        {

            tbxSoDienThoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbxSoDienThoai.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void XuLyHoTroTbxTenKhachHang(List<eKhachHang> l)
        {
            tbxSoDienThoai.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang kh in l)
            {
                tbxSoDienThoai.AutoCompleteCustomSource.Add(kh.SDT);
            }
        }

        private void tbxSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            eKhachHang khtim = qlpc.TimKhachHangTheoSDT(tbxSoDienThoai.Text);
            tbxKhachHang.Text = khtim.MaKhachHang;
        }

        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Sản phẩm");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Thành tiền");
            return dt;
        }
        void LoadDataToDataGridView(DataGridView dgr, List<eCT_HoaDon_DichVu> l)
        {
            dts.Clear();
            dts = CreatData();
            foreach (eCT_HoaDon_DichVu ectdv in l)
            {
                dts.Rows.Add(qlpc.LayDichVuTheoMa(ectdv.MaDichVu).TenDichVu, ectdv.SoLuong, qlpc.LayDichVuTheoMa(ectdv.MaDichVu).DonGia, ectdv.SoLuong * qlpc.LayDichVuTheoMa(ectdv.MaDichVu).DonGia);
            }
            dgvCT.DataSource = dts;
            dgvCT.Refresh();
        }
        private double TinhTien(List<eCT_HoaDon_DichVu> l)
        {
            double thanhtien = 0;
            double dongia = 0;
            foreach (eCT_HoaDon_DichVu eCTDV in l)
            {
                dongia = qlpc.LayDichVuTheoMa(eCTDV.MaDichVu).DonGia;
                thanhtien += eCTDV.SoLuong * dongia;
            }
            return thanhtien;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            XuatPDF();
            hoadoncuoicung.MaKhachHang = tbxKhachHang.Text;
            if (qlpc.ThemHoaDon(hoadoncuoicung) == 1)
            {
                if (lstDichVuThanhToan.Count > 0)
                {
                    foreach (eCT_HoaDon_DichVu ct in lstDichVuThanhToan)
                    {
                        qlpc.ThemCT_DichVu(ct);
                    }
                }
                MessageBox.Show("Đã xong!");
                main.GoNext();
            }
        }

        private void XuatPDF()
        {
            if (dgvCT.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = hoadoncuoicung.MaHoaDon + DateTime.Today.Day + DateTime.Today.Month + DateTime.Today.Year + "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvCT.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvCT.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvCT.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                        pdfTable.AddCell(cell.Value.ToString());
                                    else break;
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất pdf thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.GoBack();
        }
    }
}
