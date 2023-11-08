using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BaiTapWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QuanLyNhanVien QLNV;

        private int CHECKPHAI()
        {
            if(comboBox_PHAI.SelectedIndex == 0)
            {
                return 1;
            }
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_QLNV.DataSource = modify.DT("Select * from NHANVIEN");
            }
            catch(SqlException ex)
            {
                DialogResult error = MessageBox.Show("Không lấy được dữ liệu", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while(error == DialogResult.Retry) 
                {
                    Form1_Load(sender, e);
                }
            }
        }

        private void comboBox_MNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_MNV.SelectedIndex == 0)
            {
                txt_HT.Text = "Bùi Thúy Vũ";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "322 Nguyễn Thái Học";
                txt_LUONG.Text = "25000";
                txt_MNQL.Text = "987";
                txt_PHG.Text = "4";
            }
            if (comboBox_MNV.SelectedIndex == 1)
            {
                txt_HT.Text = "Lê Thị Nhân";
                comboBox_PHAI.SelectedIndex = 1;
                txt_DC.Text = "291 Hồ Văn Huê";
                txt_LUONG.Text = "43000";
                txt_MNQL.Text = "888";
                txt_PHG.Text = "4";
            }
            if (comboBox_MNV.SelectedIndex == 2)
            {
                txt_HT.Text = "Nguyễn Kim Hà";
                comboBox_PHAI.SelectedIndex = 1;
                txt_DC.Text = "638 Nguyễn Văn Cừ";
                txt_LUONG.Text = "40000";
                txt_MNQL.Text = "888";
                txt_PHG.Text = "5";
            }
            if (comboBox_MNV.SelectedIndex == 3)
            {
                txt_HT.Text = "Nguyễn Mạnh Hùng";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "975 Lê Lai";
                txt_LUONG.Text = "38000";
                txt_MNQL.Text = "333";
                txt_PHG.Text = "5";
            }
            if (comboBox_MNV.SelectedIndex == 4)
            {
                txt_HT.Text = "Nguyễn Thanh Tùng";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "731 Trần Hưng Đạo";
                txt_LUONG.Text = "30000";
                txt_MNQL.Text = "333";
                txt_PHG.Text = "5";
            }
            if (comboBox_MNV.SelectedIndex == 5)
            {
                txt_HT.Text = "Trần Hồng Quang";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "980 Lê Hồng Phong";
                txt_LUONG.Text = "25000";
                txt_MNQL.Text = "987";
                txt_PHG.Text = "4";
            }
            if (comboBox_MNV.SelectedIndex == 6)
            {
                txt_HT.Text = "Trần Thanh Tâm";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "543 Mai Thị Lựu";
                txt_LUONG.Text = "25000";
                txt_MNQL.Text = "333";
                txt_PHG.Text = "5";
            }
            if (comboBox_MNV.SelectedIndex == 7)
            {
                txt_HT.Text = "Vương Ngọc Quỳnh";
                comboBox_PHAI.SelectedIndex = 1;
                txt_DC.Text = "450 Trưng Vương";
                txt_LUONG.Text = "55000";
                txt_MNQL.Text = "";
                txt_PHG.Text = "1";
            }
            if (comboBox_MNV.SelectedIndex == 8)
            {
                txt_HT.Text = "Trần Quốc Hưng";
                comboBox_PHAI.SelectedIndex = 0;
                txt_DC.Text = "1 Tạ Quang Bữu";
                txt_LUONG.Text = "25000";
                txt_MNQL.Text = "";
                txt_PHG.Text = "2";
            }
        }

        private void txt_LUONG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }

        private void XoaTextBox()
        {
            comboBox_MNV.SelectedIndex = -1;
            txt_HT.Text = "";
            comboBox_PHAI.SelectedIndex = -1;
            txt_DC.Text = "";
            txt_LUONG.Text = "";
            txt_MNQL.Text = "";
            txt_PHG.Text = "";
        }

        private bool CheckBox()
        {
            if(comboBox_MNV.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(txt_LUONG.Text=="")
            {
                MessageBox.Show("Mời bạn nhập số tiền lương", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void ValueTxtBox()
        {
            string _MNV = comboBox_MNV.Text;
            string _HT = txt_HT.Text;
            string _DC = txt_DC.Text;
            double _LUONG = double.Parse(txt_LUONG.Text);
            string _MNQL = txt_MNQL.Text;
            int _PHG = int.Parse(txt_PHG.Text);
            QLNV = new QuanLyNhanVien(_MNV, _HT, _DC, _LUONG, _MNQL, _PHG);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckBox())
            {
                ValueTxtBox();
                string query = "Insert into NHANVIEN Values ('" + QLNV.MNV + "',N'" + QLNV.HT + "'," + CHECKPHAI() + ",N'"
                    + QLNV.DC + "'," + QLNV.LUONG + ",'" + QLNV.MNQL + "'," + QLNV.PHG + ")";
                try
                {
                    if(MessageBox.Show("Bạn có muốn thêm vào không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm " + QLNV.HT + " thành công", "Thông báo");
                        Form1_Load(sender, e);
                    }
                }
                catch(SqlException ex)
                {
                    DialogResult error = MessageBox.Show("Thêm thất bại\n Bạn có muốn thử lại?", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (error == DialogResult.Retry) 
                    {
                        btn_Them_Click(sender, e);
                    }
                }
                XoaTextBox();
            }

        }

        private void dgv_QLNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_MNV.SelectedItem = dgv_QLNV.CurrentRow.Cells[0].Value.ToString().Trim();
            txt_HT.Text = dgv_QLNV.CurrentRow.Cells[1].Value.ToString().Trim();
            comboBox_PHAI.SelectedItem = dgv_QLNV.CurrentRow.Cells[2].Value.ToString().Trim();
            txt_DC.Text = dgv_QLNV.CurrentRow.Cells[3].Value.ToString().Trim();
            txt_LUONG.Text = dgv_QLNV.CurrentRow.Cells[4].Value.ToString().Trim();
            txt_MNQL.Text = dgv_QLNV.CurrentRow.Cells[5].Value.ToString().Trim();
            txt_PHG.Text = dgv_QLNV.CurrentRow.Cells[6].Value.ToString().Trim();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckBox())
            {
                ValueTxtBox();
                String query = "Update NHANVIEN set [HO_TEN] = N'" + QLNV.HT + "', [PHAI] =" + CHECKPHAI() + ", [DIA_CHI] =N'" + QLNV.DC
                    + "', [LUONG] = " + QLNV.LUONG + ", [MA_NQL] = '" + QLNV.MNQL + "', [PHONG]  = " + QLNV.PHG
                    + "\tWhere  [MA_NV] ='" + QLNV.MNV + "'";
                try
                {
                    if(MessageBox.Show("Bạn có muốn sửa không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thông tin nhân viên " + QLNV.MNV + " thành công\nMời tiếp tục thao tác", "Thông báo");
                        Form1_Load(sender, e);
                    }    
                }
                catch(SqlException ex)
                {
                    DialogResult error = MessageBox.Show("Sửa thất bại\nBạn có muốn thao tác lại?", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (error == DialogResult.Retry) 
                    {
                        btn_Sua_Click(sender, e);
                    }
                }
                XoaTextBox();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(CheckBox())
            {
                ValueTxtBox();
                String query = "Delete From NHANVIEN where [MA_NV] = '" + QLNV.MNV + "'";
                try
                {
                    if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xoá thành công\nMời bạn tiếp tục thao tác", "Thông báo");
                        Form1_Load(sender, e);
                    }    
                }
                catch (SqlException ex)
                {
                    DialogResult error = MessageBox.Show("Xoá thất bại\nBạn có muốn thử lại?", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if(error == DialogResult.Retry)
                    {
                        btn_Xoa_Click(sender, e);
                    }
                }
                XoaTextBox();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string rowfilter = string.Format("{0} like '{1}'", "HO_TEN", "*" + txt_TK.Text + "*");
            (dgv_QLNV.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
        }

        private void comboBox_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_SapXep.SelectedIndex == 0)
            {
                this.dgv_QLNV.Sort(this.dgv_QLNV.Columns["HO_TEN"],ListSortDirection.Ascending);
            }
            else
            {
                this.dgv_QLNV.Sort(this.dgv_QLNV.Columns["PHONG"], ListSortDirection.Ascending);
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Lưu lại";
            saveFileDialog1.Filter = "Text file|*.txt |PDF file|*.pdf |All file|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < dgv_QLNV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_QLNV.Columns.Count; j++)
                    {
                        writer.Write("\t" + dgv_QLNV.Rows[i].Cells[j].Value.ToString() + "\t");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("=============================================================================================================================================================================================================================");
                }
                writer.Close();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu lại!");
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport rp = new FormReport();
            rp.ShowDialog();
        }


        /*private void txt_TK_TextChanged(object sender, EventArgs e)
        {
            string HOTEN = txt_HT.Text.Trim();
            if(HOTEN =="")
            {
                Form1_Load(sender, e);
            }
            else
            {
                string query = "Select * from NHANVIEN where [HO_TEN] like N'%" + HOTEN + "%'";
                try
                {
                    //dgv_QLNV.DataSource = modify.DT(query);
                        modify.Command(query);
                        Form1_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không tìm thấy kết quả,Thông báo");
                }
            }
        }*/
    }
}
