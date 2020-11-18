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

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmSoDoPhongChieu : Form
    {
        eXuatChieu xclay;
        List<eGheNgoi> lghe;
        List<eGheNgoi> lgheChon;
        PhongChieuClient qlpc;
        List<eVe> lstVe;
        frmVe main;
        public List<eVe> lstVeChon;
        eHoaDon hoadontam;

        public frmSoDoPhongChieu()
        {
            InitializeComponent();
        }

        public frmSoDoPhongChieu(frmVe frmVe, eXuatChieu xc, eHoaDon hoadon)
        {
            InitializeComponent();
            xclay = xc;
            main = frmVe;
            qlpc = new PhongChieuClient();
            lghe = qlpc.LayDanhSachGheNgoiTheoPhong(xclay.MaPhong).ToList();
            lgheChon = new List<eGheNgoi>();
            lstVe = new List<eVe>();
            lstVeChon = new List<eVe>();
            hoadontam = hoadon;
        }

        private void frmSoDoPhongChieu_Load(object sender, EventArgs e)
        {
            DatSuKienChoLabl();
            setmau(lghe);
            tbxGiaVe.Text = xclay.GiaVe.ToString();
            tbxPhongChieu.Text = qlpc.LayPhongChieuTheoMa(xclay.MaPhong).TenPhong;
            tbxRapChieu.Text = "3 Blue Cinema, 12, Nguyen Van Bao Street, 4 Ward, Go Vap District, Ho Chi Minh City";
            tbxSuatChieu.Text = xclay.ThoiDiem.Value.ToString();
            tbxThanhTien.Text = 0.ToString();
            tbxThongTinPhim.Text = qlpc.TimPhimTheoMa(xclay.MaPhim).TenPhim;
            ePhim phimlay = qlpc.TimPhimTheoMa(xclay.MaPhim);
            Image img;
            if (phimlay.Poster == null)
            {
                pictureBox1.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.cinema;
                return;
            }
            else
            {
                img = Image.FromStream(new MemoryStream(phimlay.Poster));
                pictureBox1.Image = img;
            }
            
        }

        private void DatSuKienChoLabl()
        {
            for (int j = 0; j < 10; j++)
            {
                string vt = "";
                switch (j)
                {
                    case 0:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "A" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 1:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "B" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 2:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "C" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 3:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "D" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "E" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 5:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "F" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 6:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "G" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 7:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "H" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 8:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "I" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                    case 9:
                        for (int k = 0; k < 15; k++)
                        {
                            vt = "J" + (k + 1).ToString();
                            foreach (Control lbl in groupSoDoPhong.Controls)
                            {
                                if (lbl.Name.Equals(vt))
                                {
                                    lbl.MouseClick += new MouseEventHandler(MouseClicklbl);
                                    break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void taoGhe(Label lbl)
        {
            eGheNgoi ghechon = new eGheNgoi();
            ghechon.Hang = lbl.Text.Substring(0, 1);
            if (lbl.Text.Length == 2)
            {
                ghechon.So = lbl.Text.Substring(1, 1);
            }
            else
            {
                ghechon.So = lbl.Text.Substring(1, 2);
            }
            if (lgheChon.Count == 4)
            {

                for (int i = 0; i < lgheChon.Count; i++)
                {
                    if (ghechon.Hang.Equals(lgheChon[i].Hang) && ghechon.So.Equals(lgheChon[i].So))
                    {
                        lgheChon.RemoveAt(i);
                        return;
                    }
                }
                lgheChon.RemoveAt(0);
                lgheChon.Add(ghechon);
            }
            else
            {
                for (int i = 0; i < lgheChon.Count; i++)
                {
                    if (ghechon.Hang.Equals(lgheChon[i].Hang) && ghechon.So.Equals(lgheChon[i].So))
                    {
                        lgheChon.RemoveAt(i);
                        return;
                    }
                }
                lgheChon.Add(ghechon);
            }
        }

        private void MouseClicklbl(object sender, MouseEventArgs e)
        {

            if ((sender as Label).BackColor == Color.Red)
            {
                MessageBox.Show("Ghe da co nguoi ngoi");
                return;
            }
            setmau(lghe);
            taoGhe((sender as Label));
            tbxGheNgoi.Text = "";
            for (int i = 0; i < lgheChon.Count; i++)
            {
                string s = lgheChon[i].Hang + lgheChon[i].So;
                tbxGheNgoi.Text += s + " ";
            }
            foreach (eGheNgoi ghe in lgheChon)
            {
                foreach (Control lbl in groupSoDoPhong.Controls)
                {
                    string vt = ghe.Hang + ghe.So;
                    if (lbl.Name.Equals(vt))
                    {
                        lbl.BackColor = Color.GreenYellow;
                        break;
                    }
                }
            }
            tbxThanhTien.Text = (lgheChon.Count * xclay.GiaVe).ToString();
            if (lgheChon.Count > 0)
            {
                btnTiepTheo.Enabled = true;
            }
            else
            {
                btnTiepTheo.Enabled = false;
            }
        }

        void setmau(List<eGheNgoi> lghe)
        {
            foreach (eGheNgoi gheNgoi in lghe)
            {
                string vt = gheNgoi.Hang + gheNgoi.So;
                if (gheNgoi.TrangThai.Equals("Có"))
                {
                    foreach (Control lbl in groupSoDoPhong.Controls)
                    {
                        if (lbl.Name.Equals(vt))
                        {
                            lbl.BackColor = Color.BlueViolet;
                        }
                    }
                }
                else
                {
                    foreach (Control lbl in groupSoDoPhong.Controls)
                    {
                        if (lbl.Name.Equals(vt))
                        {
                            lbl.Enabled = false;
                            lbl.BackColor = Color.DarkGray;
                        }
                    }
                }
                lstVe = qlpc.LayDanhSachVeTheoXuatChieu(xclay.MaXuat).ToList();
                if (lstVe.Count > 0)
                {
                    foreach (eVe eve in lstVe)
                    {
                        foreach (Control lbl in groupSoDoPhong.Controls)
                        {
                            if (lbl.Name.Equals(eve.VitriGhe))
                            {
                                lbl.Enabled = false;
                                lbl.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            foreach (eGheNgoi ghe in lgheChon)
            {
                eVe vetam = new eVe();
                string vt = ghe.Hang + ghe.So;
                vetam.MaHoaDon = hoadontam.MaHoaDon;
                vetam.MaXuat = xclay.MaXuat;
                vetam.VitriGhe = vt;
                lstVeChon.Add(vetam);
            }
            main.GoNext();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            main.GoBack();
        }
    }
}
