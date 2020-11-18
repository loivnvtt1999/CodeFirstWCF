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
    public partial class frmQuanLyNhanVien : Form
    {
        List<eNhanVien> listenv;
        PhongChieuClient cli;
        OpenFileDialog ofdLoadAnh;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            cli = new PhongChieuClient();
            ofdLoadAnh = new OpenFileDialog();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            listenv = cli.LayDanhSachNhanVien().ToList();
            loadtoDataGridView();
            customComboChucVu();
            BlockButton();
            BlockTextBox();
        }

        void customDataGridView()
        {
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.ReadOnly = true;
            dgvNV.AutoResizeColumns();
            dgvNV.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvNV.Columns["MaNhanVien"].DisplayIndex = 0;
            dgvNV.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvNV.Columns["TenNhanVien"].DisplayIndex = 1;
            dgvNV.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvNV.Columns["ChucVu"].DisplayIndex = 2;
            dgvNV.Columns["CMND"].HeaderText = "Chứng minh nhân dân";
            dgvNV.Columns["CMND"].DisplayIndex = 3;
            dgvNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNV.Columns["SDT"].DisplayIndex = 4;
            dgvNV.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNV.Columns["Anh"].Visible = false;
            dgvNV.Columns["MatKhau"].Visible = false;
        }
        void BlockButton()
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThayAnh.Enabled = false;
        }
        void BlockTextBox()
        {
            tbxMaNV.ReadOnly = true;
            tbxTen.ReadOnly = true;
            tbxCMND.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            tbxSDT.ReadOnly = true;
            tbxEmail.ReadOnly = true;
            cbChucVu.Enabled = false;
        }
        void UnBlockTextBox()
        {
            tbxMaNV.ReadOnly = true;
            tbxTen.ReadOnly = false;
            tbxCMND.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            tbxSDT.ReadOnly = false;
            tbxEmail.ReadOnly = false;
            cbChucVu.Enabled = true;
        }
        void ClearTextBox()
        {
            tbxMaNV.Text = "";
            tbxTen.Text = "";
            tbxCMND.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            tbxSDT.Text = "";
            tbxEmail.Text = "";
            cbChucVu.Text = "";
        }
        void customComboChucVu()
        {
            cbChucVu.Items.Add("Quản Lý");
            cbChucVu.Items.Add("Bán vé");
            cbChucVu.Items.Add("Dịch vụ");
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void loadtoDataGridView()
        {
            dgvNV.DataSource = listenv;
            customDataGridView();
            dgvNV.Refresh();
        }
        Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void dgvNV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                if (btnThemNV.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnThemNV.Text = "Thêm";
                    btnSua.Enabled = true;
                    Anh.Image = null;
                }
                if (btnSua.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnSua.Text = "Sửa";
                    btnThemNV.Enabled = true;
                    Anh.Image = null;
                }
                btnSua.Enabled = true;
                tbxMaNV.Text = dgvNV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
                tbxTen.Text = dgvNV.SelectedRows[0].Cells["TenNhanVien"].Value.ToString();
                tbxCMND.Text = dgvNV.SelectedRows[0].Cells["CMND"].Value.ToString();
                dateTimePicker1.Value = (DateTime)dgvNV.SelectedRows[0].Cells["NgaySinh"].Value;
                tbxSDT.Text = dgvNV.SelectedRows[0].Cells["SDT"].Value.ToString();
                tbxEmail.Text = dgvNV.SelectedRows[0].Cells["Email"].Value.ToString();
                cbChucVu.Text = dgvNV.SelectedRows[0].Cells["ChucVu"].Value.ToString();
                eNhanVien env = cli.TimNhanVienTheoMa(e.Row.Cells["MaNhanVien"].Value.ToString());
                if (env.Anh == null)
                {
                    Anh.Image = null;
                    return;
                }
                else
                {
                    Image img = byteArrayToImage(env.Anh);
                    Anh.Image = img;
                }
            }
        }

        eNhanVien TaoNhanVien()
        {
            eNhanVien env = new eNhanVien();
            env.MaNhanVien = tbxMaNV.Text;
            env.TenNhanVien = tbxTen.Text;
            env.CMND = tbxCMND.Text;
            env.NgaySinh = dateTimePicker1.Value;
            env.SDT = tbxSDT.Text;
            env.Email = tbxEmail.Text;
            env.ChucVu = cbChucVu.Text;
            if (Anh.Image != null)
            {
                env.Anh = ImageToByteArray(Anh.Image);
            }
            else
                env.Anh = null;
            env.MatKhau = "12345678";
            return env;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (btnThemNV.Text.Equals("Thêm"))
            {
                ClearTextBox();
                UnBlockTextBox();
                tbxMaNV.Text = cli.PhatSinhMaNhanVien();
                btnThemNV.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThayAnh.Enabled = true;
                Anh.Image = null;
                dgvNV.ClearSelection();
            }
            else
            {
                ClearTextBox();
                BlockTextBox();
                btnThemNV.Text = "Thêm phim";
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnThayAnh.Enabled = false;
                Anh.Image = null;
                dgvNV.ClearSelection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThayAnh.Enabled = true;
                btnThemNV.Enabled = false;
                UnBlockTextBox();
            }
            else
            {
                BlockTextBox();
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThayAnh.Enabled = false;
                btnThemNV.Enabled = true;
                Anh.Image = null;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMaNV.Text) || string.IsNullOrEmpty(tbxTen.Text) || string.IsNullOrEmpty(tbxCMND.Text) || string.IsNullOrEmpty(tbxSDT.Text) || string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(cbChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnThemNV.Text == "Hủy")
                {
                    eNhanVien env = TaoNhanVien();
                    cli.ThemNhanVien(env);
                    listenv = cli.LayDanhSachNhanVien().ToList();
                    dgvNV.DataSource = listenv;
                    customDataGridView();
                    ClearTextBox();
                    Anh.Image = null;
                    dgvNV.ClearSelection();
                    MessageBox.Show("Thêm thành công");
                    BlockButton();
                    BlockTextBox();
                    ClearTextBox();
                }
                else
                {
                    eNhanVien env = TaoNhanVien();
                    cli.SuaNhanVien(env);
                    listenv = cli.LayDanhSachNhanVien().ToList();
                    dgvNV.DataSource = listenv;
                    ClearTextBox();
                    Anh.Image = null;
                    dgvNV.ClearSelection();
                    customDataGridView();
                    MessageBox.Show("Sửa thành công");
                    BlockButton();
                    BlockTextBox();
                }
            }
        }

        private void btnMK_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxMaNV.Text))
                cli.DatLaiMatKhau(tbxMaNV.Text);
        }
    }
}
