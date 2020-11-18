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
    public partial class frmQuanLyDichVu : Form
    {
        PhongChieuClient cli;
        List<eDichVu> listedv;
        eDichVu edv;
        OpenFileDialog ofdLoadAnh;
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            cli = new PhongChieuClient();
            listedv = new List<eDichVu>();
            edv = new eDichVu();
            ofdLoadAnh = new OpenFileDialog();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            listedv = cli.LayDanhSachDichVu().ToList();
            loadtoDataGridView();
            BlockButton();
            BlockTextBox();
        }

        void customDataGridView()
        {
            dgvDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDV.ReadOnly = true;
            dgvDV.AutoResizeColumns();
            dgvDV.Columns["MaDichVu"].HeaderText = "Mã Dịch vụ";
            dgvDV.Columns["MaDichVu"].DisplayIndex = 0;
            dgvDV.Columns["TenDichVu"].HeaderText = "Tên Dịch vụ";
            dgvDV.Columns["TenDichVu"].DisplayIndex = 1;
            dgvDV.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDV.Columns["Anh"].Visible = false;
        }
        void loadtoDataGridView()
        {
            dgvDV.DataSource = listedv;
            customDataGridView();
            dgvDV.Refresh();
        }
        void BlockTextBox()
        {
            tbxMaDV.ReadOnly = true;
            tbxTenDV.ReadOnly = true;
            tbxDonGia.ReadOnly = true;
        }
        void UnBlockTexBox()
        {
            tbxMaDV.ReadOnly = true;
            tbxTenDV.ReadOnly = false;
            tbxDonGia.ReadOnly = false;
        }
        void BlockButton()
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThayAnh.Enabled = false;
        }
        void ClearTextBox()
        {
            tbxTenDV.Text = "";
            tbxDonGia.Text = "";
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnThayAnh_Click(object sender, EventArgs e)
        {
            ofdLoadAnh.ShowDialog();
            string file = ofdLoadAnh.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Anh.Image = Image.FromFile(file);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                ClearTextBox();
                UnBlockTexBox();
                tbxMaDV.Text = cli.PhatSinhMaDichVu();
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThayAnh.Enabled = true;
                dgvDV.ClearSelection();
            }
            else
            {
                tbxMaDV.Text = "";
                ClearTextBox();
                BlockTextBox();
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnThayAnh.Enabled = false;
                dgvDV.ClearSelection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnThayAnh.Enabled = true;
                UnBlockTexBox();
            }
            else
            {
                BlockTextBox();
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnThayAnh.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTenDV.Text) || string.IsNullOrEmpty(tbxDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (double.TryParse(tbxDonGia.Text, out double a) == true)
                {
                    if (btnThem.Text == "Hủy")
                    {
                        edv.MaDichVu = tbxMaDV.Text;
                        edv.TenDichVu = tbxTenDV.Text;
                        edv.DonGia = double.Parse(tbxDonGia.Text);
                        if (Anh.Image != null)
                        {
                            edv.Anh = ImageToByteArray(Anh.Image);
                        }
                        else
                            edv.Anh = null;
                        cli.ThemDichVu(edv);
                        ClearTextBox();
                        listedv = cli.LayDanhSachDichVu().ToList();
                        dgvDV.DataSource = listedv;
                        Anh.Image = null;
                        dgvDV.ClearSelection();
                        MessageBox.Show("Thêm thành công");
                        tbxMaDV.Text = "";
                        BlockButton();
                        BlockTextBox();
                        ClearTextBox();
                    }
                    else
                    {
                        edv.MaDichVu = tbxMaDV.Text;
                        edv.TenDichVu = tbxTenDV.Text;
                        edv.DonGia = double.Parse(tbxDonGia.Text);
                        if (Anh.Image != null)
                        {
                            edv.Anh = ImageToByteArray(Anh.Image);
                        }
                        else
                            edv.Anh = null;
                        cli.SuaDichVu(edv);
                        listedv = cli.LayDanhSachDichVu().ToList();
                        dgvDV.DataSource = listedv;
                        ClearTextBox();
                        Anh.Image = null;
                        dgvDV.ClearSelection();
                        MessageBox.Show("Sửa thành công");
                        tbxMaDV.Text = "";
                        BlockButton();
                        BlockTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Đơn giá phải nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvDV.SelectedRows.Count > 0)
            {
                if (btnThem.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                }
                if (btnSua.Text == "Hủy")
                {
                    BlockButton();
                    BlockTextBox();
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                }
                btnSua.Enabled = true;
                tbxMaDV.Text = dgvDV.SelectedRows[0].Cells["MaDichVu"].Value.ToString();
                tbxTenDV.Text = dgvDV.SelectedRows[0].Cells["TenDichVu"].Value.ToString();
                tbxDonGia.Text = dgvDV.SelectedRows[0].Cells["DonGia"].Value.ToString();
                eDichVu edv = cli.LayDichVuTheoMa(e.Row.Cells["MaDichVu"].Value.ToString());
                if (edv.Anh == null)
                {
                    Anh.Image = null;
                    return;
                }
                else
                {
                    Image img = byteArrayToImage(edv.Anh);
                    Anh.Image = img;
                }
            }
        }
    }
}
