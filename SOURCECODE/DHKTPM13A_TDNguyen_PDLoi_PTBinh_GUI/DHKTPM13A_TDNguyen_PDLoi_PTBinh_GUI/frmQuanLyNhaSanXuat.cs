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
    public partial class frmQuanLyNhaSanXuat : Form
    {
        PhongChieuClient cli;
        List<eNhaSanXuat> listensx;
        eNhaSanXuat ensx;
        public frmQuanLyNhaSanXuat()
        {
            InitializeComponent();
            cli = new PhongChieuClient();
            listensx = new List<eNhaSanXuat>();
            ensx = new eNhaSanXuat();
        }

        void customDataGridView()
        {
            dgvNSX.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNSX.ReadOnly = true;
            dgvNSX.AutoResizeColumns();
            dgvNSX.Columns["MaNSX"].HeaderText = "Mã Nhà sản xuất";
            dgvNSX.Columns["MaNSX"].DisplayIndex = 0;
            dgvNSX.Columns["TenNSX"].HeaderText = "Tên Nhà sản xuất";
            dgvNSX.Columns["TenNSX"].DisplayIndex = 1;
            dgvNSX.Columns["QuocGia"].HeaderText = "Quốc gia";
        }

        void loadtoDataGridView()
        {
            dgvNSX.DataSource = listensx;
            customDataGridView();
            dgvNSX.Refresh();
        }

        void BlockTextBox()
        {
            tbxMaNSX.ReadOnly = true;
            tbxTenNSX.ReadOnly = true;
            tbxQuocGia.ReadOnly = true;
        }

        void UnBlockTexBox()
        {
            tbxMaNSX.ReadOnly = true;
            tbxTenNSX.ReadOnly = false;
            tbxQuocGia.ReadOnly = false;
        }

        void BlockButton()
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }

        void ClearTextBox()
        {
            tbxTenNSX.Text = "";
            tbxQuocGia.Text = "";
        }

        private void frmQuanLyNhaSanXuat_Load(object sender, EventArgs e)
        {
            listensx = cli.LayDanhSachNhaSanXuat().ToList();
            loadtoDataGridView();
            BlockTextBox();
            BlockButton();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                ClearTextBox();
                UnBlockTexBox();
                tbxMaNSX.Text = cli.PhatSinhMaNSX();
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                dgvNSX.ClearSelection();
            }
            else
            {
                tbxMaNSX.Text = "";
                ClearTextBox();
                BlockTextBox();
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                dgvNSX.ClearSelection();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                btnSua.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                UnBlockTexBox();
            }
            else
            {
                BlockTextBox();
                btnSua.Text = "Sửa";
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTenNSX.Text) || string.IsNullOrEmpty(tbxQuocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnThem.Text == "Hủy")
                {
                    ensx.MaNSX = tbxMaNSX.Text;
                    ensx.TenNSX = tbxTenNSX.Text;
                    ensx.QuocGia = tbxQuocGia.Text;
                    cli.ThemNhaSanXuat(ensx);
                    ClearTextBox();
                    listensx = cli.LayDanhSachNhaSanXuat().ToList();
                    dgvNSX.DataSource = listensx;
                    dgvNSX.ClearSelection();
                    MessageBox.Show("Thêm thành công");
                    tbxMaNSX.Text = "";
                    BlockButton();
                    BlockTextBox();
                    ClearTextBox();
                }
                else
                {
                    ensx.MaNSX = tbxMaNSX.Text;
                    ensx.TenNSX = tbxTenNSX.Text;
                    ensx.QuocGia = tbxQuocGia.Text;
                    cli.SuaNhaSanXuat(ensx);
                    listensx = cli.LayDanhSachNhaSanXuat().ToList();
                    dgvNSX.DataSource = listensx;
                    ClearTextBox();
                    dgvNSX.ClearSelection();
                    MessageBox.Show("Sửa thành công");
                    tbxMaNSX.Text = "";
                    BlockButton();
                    BlockTextBox();
                }
            }
        }

        private void dgvNSX_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvNSX.SelectedRows.Count > 0)
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
                tbxMaNSX.Text = dgvNSX.SelectedRows[0].Cells["MaNSX"].Value.ToString();
                tbxTenNSX.Text = dgvNSX.SelectedRows[0].Cells["TenNSX"].Value.ToString();
                tbxQuocGia.Text = dgvNSX.SelectedRows[0].Cells["QuocGia"].Value.ToString();
            }
        }
    }
}
