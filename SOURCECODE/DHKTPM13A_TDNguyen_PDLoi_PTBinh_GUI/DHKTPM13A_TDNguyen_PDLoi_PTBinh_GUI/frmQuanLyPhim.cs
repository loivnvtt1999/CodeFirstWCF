using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.ServiceRapChieuPhim;

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmQuanLyPhim : Form
    {
        List<ePhim> listep;
        List<eNhaSanXuat> listensx;
        PhongChieuClient cli;
        OpenFileDialog ofdLoadAnh;
        public frmQuanLyPhim()
        {
            InitializeComponent();
            cli = new PhongChieuClient();
            ofdLoadAnh = new OpenFileDialog();
        }

        private void frmQuanLyPhim_Load(object sender, EventArgs e)
        {
            BlockButton();
            listensx = cli.LayDanhSachNhaSanXuat().ToList();
            customComboBoxNSX();
            listep = cli.LayDanhSachPhim().ToList();
            loadtoDataGridView();
            customComboBoxGioiHanDoTuoi();
            BlockTextBox();
        }

        void customDataGridView()
        {
            dgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhim.ReadOnly = true;
            dgvPhim.AutoResizeColumns();
            dgvPhim.Columns["MoTa"].Visible = false;
            dgvPhim.Columns["MaNSX"].Visible = false;
            dgvPhim.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvPhim.Columns["MaPhim"].DisplayIndex = 0;
            dgvPhim.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvPhim.Columns["TenPhim"].DisplayIndex = 1;
            dgvPhim.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dgvPhim.Columns["DaoDien"].DisplayIndex = 2;
            dgvPhim.Columns["TheLoai"].HeaderText = "Thể loại";
            dgvPhim.Columns["TheLoai"].DisplayIndex = 3;
            dgvPhim.Columns["DienVienChinh"].HeaderText = "Diễn viên chính";
            dgvPhim.Columns["GioiHanDoTuoi"].HeaderText = "Giới hạn độ tuổi";
            dgvPhim.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvPhim.Columns["NgayCongChieu"].HeaderText = "Ngày công chiếu";
            dgvPhim.Columns["Poster"].HeaderText = "Poster";
            dgvPhim.Columns["Poster"].Visible = false;
            dgvPhim.Columns["NgonNgu"].HeaderText = "Ngôn ngữ";
        }

        void loadtoDataGridView()
        {
            dgvPhim.DataSource = listep;
            customDataGridView();
            dgvPhim.Refresh();
        }

        void customComboBoxGioiHanDoTuoi()
        {
            cbGioiHan.Items.Add("Không");
            cbGioiHan.Items.Add("C13");
            cbGioiHan.Items.Add("C16");
            cbGioiHan.Items.Add("C18");
            cbGioiHan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void customComboBoxNSX()
        {
            cbNSX.DataSource = listensx;
            cbNSX.DisplayMember = "TenNSX";
            cbNSX.ValueMember = "MaNSX";
            cbNSX.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void BlockTextBox()
        {
            tbxMaPhim.ReadOnly = true;
            tbxThoiLuong.ReadOnly = true;
            tbxTenPhim.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            tbxDaoDien.ReadOnly = true;
            tbxTheLoai.ReadOnly = true;
            tbxDienVien.ReadOnly = true;
            tbxNgonNgu.ReadOnly = true;
            cbGioiHan.Enabled = false;
            rtbxMoTa.ReadOnly = true;
            cbNSX.Enabled = false;
            tbxQuocGia.ReadOnly = true;
        }

        void UnBlockTexBox()
        {
            tbxMaPhim.ReadOnly = true;
            tbxThoiLuong.ReadOnly = false;
            tbxTenPhim.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            tbxDaoDien.ReadOnly = false;
            tbxTheLoai.ReadOnly = false;
            tbxDienVien.ReadOnly = false;
            tbxNgonNgu.ReadOnly = false;
            cbGioiHan.Enabled = true;
            rtbxMoTa.ReadOnly = false;
            cbNSX.Enabled = true;
            tbxQuocGia.ReadOnly = true;
        }

        void BlockButton()
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThayDoiAnh.Enabled = false;
        }

        void ClearTextBox()
        {
            tbxMaPhim.Text = "";
            tbxThoiLuong.Text = "";
            tbxTenPhim.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            tbxDaoDien.Text = "";
            tbxTheLoai.Text = "";
            tbxDienVien.Text = "";
            tbxNgonNgu.Text = "";
            cbGioiHan.Text = "";
            cbNSX.Text = "";
            tbxQuocGia.Text = "";
            rtbxMoTa.Text = "";
        }

        private void dgvPhim_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPhim.SelectedRows.Count > 0)
            {
                if (btnThemPhim.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnThemPhim.Text = "Thêm phim";
                    btnSua.Enabled = true;
                    poster.Image = null;
                }
                if (btnSua.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnSua.Text = "Sửa";
                    btnThemPhim.Enabled = true;
                    poster.Image = null;
                }
                btnSua.Enabled = true;
                tbxMaPhim.Text = dgvPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString();
                tbxThoiLuong.Text = dgvPhim.SelectedRows[0].Cells["ThoiLuong"].Value.ToString();
                tbxTenPhim.Text = dgvPhim.SelectedRows[0].Cells["TenPhim"].Value.ToString();
                dateTimePicker1.Value = (DateTime)dgvPhim.SelectedRows[0].Cells["NgayCongChieu"].Value;
                tbxDaoDien.Text = dgvPhim.SelectedRows[0].Cells["DaoDien"].Value.ToString();
                tbxTheLoai.Text = dgvPhim.SelectedRows[0].Cells["TheLoai"].Value.ToString();
                tbxDienVien.Text = dgvPhim.SelectedRows[0].Cells["DienVienChinh"].Value.ToString();
                tbxNgonNgu.Text = dgvPhim.SelectedRows[0].Cells["NgonNgu"].Value.ToString();
                cbGioiHan.Text = dgvPhim.SelectedRows[0].Cells["GioiHanDoTuoi"].Value.ToString();
                rtbxMoTa.Text = dgvPhim.SelectedRows[0].Cells["MoTa"].Value.ToString();
                cbNSX.SelectedValue = dgvPhim.SelectedRows[0].Cells["MaNSX"].Value.ToString();
                tbxQuocGia.Text = cli.LayQuocGiaTheoMaNSX(dgvPhim.SelectedRows[0].Cells["MaNSX"].Value.ToString());
                ePhim ep = cli.TimPhimTheoMa(e.Row.Cells["MaPhim"].Value.ToString());
                if (ep.Poster == null)
                {
                    poster.Image = null;
                    return;
                }
                else
                {
                    Image img = byteArrayToImage(ep.Poster);
                    poster.Image = img;
                }
            }
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private ePhim TaoPhim()
        {
            ePhim ep = new ePhim();
            ep.MaPhim = tbxMaPhim.Text;
            ep.TenPhim = tbxTenPhim.Text;
            ep.NgayCongChieu = dateTimePicker1.Value;
            ep.DaoDien = tbxDaoDien.Text;
            ep.TheLoai = tbxTheLoai.Text;
            ep.ThoiLuong = int.Parse(tbxThoiLuong.Text);
            ep.DienVienChinh = tbxDienVien.Text;
            ep.NgonNgu = tbxNgonNgu.Text;
            ep.GioiHanDoTuoi = cbGioiHan.Text;
            if (poster.Image != null)
            {
                ep.Poster = ImageToByteArray(poster.Image);
            }
            else
                ep.Poster = null;
            ep.MoTa = rtbxMoTa.Text;
            ep.MaNSX = cbNSX.SelectedValue.ToString();
            return ep;
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            if (btnThemPhim.Text.Equals("Thêm phim"))
            {
                ClearTextBox();
                UnBlockTexBox();
                tbxMaPhim.Text = cli.PhatSinhMaPhim();
                btnThemPhim.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThayDoiAnh.Enabled = true;
                poster.Image = null;
                dgvPhim.ClearSelection();
            }
            else
            {
                ClearTextBox();
                BlockTextBox();
                btnThemPhim.Text = "Thêm phim";
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnThayDoiAnh.Enabled = false;
                poster.Image = null;
                dgvPhim.ClearSelection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThayDoiAnh.Enabled = true;
                btnThemPhim.Enabled = false;
                UnBlockTexBox();
            }
            else
            {
                BlockTextBox();
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThayDoiAnh.Enabled = false;
                btnThemPhim.Enabled = true;
                poster.Image = null;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTenPhim.Text) || string.IsNullOrEmpty(tbxThoiLuong.Text) || string.IsNullOrEmpty(tbxDaoDien.Text) || string.IsNullOrEmpty(tbxTheLoai.Text) || string.IsNullOrEmpty(tbxDienVien.Text) || string.IsNullOrEmpty(tbxNgonNgu.Text) || string.IsNullOrEmpty(cbGioiHan.Text) || string.IsNullOrEmpty(cbNSX.Text) || string.IsNullOrEmpty(tbxQuocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(tbxThoiLuong.Text, out int a) == true)
                {
                    if (btnThemPhim.Text == "Hủy")
                    {
                        ePhim ep = TaoPhim();
                        cli.ThemPhim(ep);
                        listep = cli.LayDanhSachPhim().ToList();
                        dgvPhim.DataSource = listep;
                        ClearTextBox();
                        poster.Image = null;
                        dgvPhim.ClearSelection();
                        MessageBox.Show("Thêm thành công");
                        BlockButton();
                        BlockTextBox();
                        ClearTextBox();
                    }
                    else
                    {
                        ePhim ep = TaoPhim();
                        cli.SuaPhim(ep);
                        listep = cli.LayDanhSachPhim().ToList();
                        dgvPhim.DataSource = listep;
                        ClearTextBox();
                        poster.Image = null;
                        dgvPhim.ClearSelection();
                        MessageBox.Show("Sửa thành công");
                        BlockButton();
                        BlockTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Thời lượng phim phải nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThayDoiAnh_Click(object sender, EventArgs e)
        {
            ofdLoadAnh.ShowDialog();
            string file = ofdLoadAnh.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            poster.Image = Image.FromFile(file);
        }

        private void btnThemNSX_Click(object sender, EventArgs e)
        {
            frmThemNhaSanXuat frm = new frmThemNhaSanXuat();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                listensx = cli.LayDanhSachNhaSanXuat().ToList();
                customComboBoxNSX();
            }
        }

        private void cbNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxQuocGia.Text = cli.LayQuocGiaTheoMaNSX(cbNSX.SelectedValue.ToString());
        }
    }
}
