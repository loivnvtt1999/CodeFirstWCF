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
    public partial class frmQuanLyPhongChieu_Ghe : Form
    {
        List<ePhongChieu> listphong;
        List<eGheNgoi> lghe;
        eGheNgoi ghechon;
        PhongChieuClient client;

        public frmQuanLyPhongChieu_Ghe()
        {
            InitializeComponent();
            client = new PhongChieuClient();
            ghechon = new eGheNgoi();
        }

        private void frmQuanLyPhongChieu_Ghe_Load(object sender, EventArgs e)
        {
            LoadDatatoTreeView();
            DatSuKienChoLabl();
        }

        private void MouseClicklbl(object sender, MouseEventArgs e)
        {
            setmau(lghe);
            (sender as Label).BackColor = Color.GreenYellow;
            taoGhe((sender as Label));
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
                            foreach (Control lbl in groupPanel2.Controls)
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
            ghechon = new eGheNgoi();
            ghechon.Hang = lbl.Text.Substring(0, 1);
            if (lbl.Text.Length == 2)
            {
                ghechon.So = lbl.Text.Substring(1, 1);
            }
            else
            {
                ghechon.So = lbl.Text.Substring(1, 2);
            }
        }

        void setmau(List<eGheNgoi> lghe)
        {
            foreach (eGheNgoi gheNgoi in lghe)
            {
                string vt = gheNgoi.Hang + gheNgoi.So;
                if (gheNgoi.TrangThai.Equals("Có"))
                {
                    foreach (Control lbl in groupPanel2.Controls)
                    {
                        if (lbl.Name.Equals(vt))
                        {
                            lbl.BackColor = Color.BlueViolet;
                        }
                    }
                }
                else
                {
                    foreach (Control lbl in groupPanel2.Controls)
                    {
                        if (lbl.Name.Equals(vt))
                        {
                            lbl.BackColor = Color.DarkGray;
                        }
                    }
                }
            }
        }

        private void LoadDatatoTreeView()
        {
            trePhong.Nodes.Clear();
            listphong = client.LayDanhSachPhongChieu().ToList();
            foreach (ePhongChieu pc in listphong)
            {
                TreeNode tn = new TreeNode(pc.TenPhong);
                tn.Tag = pc.MaPhong;
                trePhong.Nodes.Add(tn);
            }
            trePhong.SelectedNode = trePhong.Nodes[0];
        }

        private void trePhong_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lghe = client.LayDanhSachGheNgoiTheoPhong(trePhong.SelectedNode.Tag.ToString()).ToList();
            setmau(lghe);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ghechon != null)
            {
                client.CapNhatTrangThaiGhe(ghechon, trePhong.SelectedNode.Tag.ToString());
                lghe = client.LayDanhSachGheNgoiTheoPhong(trePhong.SelectedNode.Tag.ToString()).ToList();
                setmau(lghe);
                ghechon = null;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vị trí!");
            }
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmThemPhong frmthem = new frmThemPhong();
            frmthem.ShowDialog();
            if (frmthem.DialogResult == DialogResult.OK)
            {
                TreeNode newnode = new TreeNode(frmthem.ePC.TenPhong);
                listphong = client.LayDanhSachPhongChieu().ToList();
                newnode.Tag = frmthem.ePC.MaPhong;
                trePhong.Nodes.Add(newnode);
                trePhong.SelectedNode = newnode;
                newnode.EnsureVisible();
            }
        }
    }
}
