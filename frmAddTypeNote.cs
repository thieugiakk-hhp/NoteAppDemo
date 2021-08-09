using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteAppDemo.Class;
namespace NoteAppDemo
{
    public partial class frmAddTypeNote : Form
    {
        DataTable tableTypeNote;
        public frmAddTypeNote()
        {
            InitializeComponent();
        }

        private void frmAddTypeNote_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvShowTypeNote.ForeColor = Color.Black; //Set màu chữ trong DataGridView

            //Chạy lệnh SQL lấy dữ liệu vào DataGridView
            string sqlCommand = "SELECT IDTYPE, TYPENAME, DATE FROM DBO.TYPENOTE";
            tableTypeNote = Class.GetDataToTable.Get(sqlCommand);
            dgvShowTypeNote.DataSource = tableTypeNote;

            //Format các cột trong bảng
            dgvShowTypeNote.Columns[0].HeaderText = "STT";
            dgvShowTypeNote.Columns[1].HeaderText = "Tên";
            dgvShowTypeNote.Columns[2].HeaderText = "Ngày tạo";
            dgvShowTypeNote.Columns[0].Width = 50;
            dgvShowTypeNote.Columns[1].Width = 125;
            dgvShowTypeNote.Columns[2].Width = 100;

            //Cài đặt không cho người dùng thay đổi dữ liệu hay kích thước bảng
            dgvShowTypeNote.AllowUserToAddRows = false;
            dgvShowTypeNote.AllowUserToResizeRows = false;

            dgvShowTypeNote.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvShowTypeNote_Click(object sender, EventArgs e)
        {
            txtNameType.Text = dgvShowTypeNote.CurrentRow.Cells["TYPENAME"].Value.ToString(); //Lấy dữ liệu từ bảng vào Textbox
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameType.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên của loại ghi chú!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameType.Focus();

                return;
            }

            string sqlCommand = "SELECT TYPENAME FROM DBO.TypeNote WHERE TYPENAME = N'" + txtNameType.Text.Trim() + "'";

            if (Class.Functions.DuplicateCheck(sqlCommand))
            {
                MessageBox.Show("Loại ghi chú này đã có, hãy chọn trong bảng hoặc thêm một loại mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameType.Focus();

                return;
            }

            int tblTypeNotesRow = dgvShowTypeNote.Rows.Count;

            string sqlAdd = "INSERT INTO DBO.TYPENOTE (IDTYPE, TYPENAME) VALUES ('" + (tblTypeNotesRow + 1) + "', N'" + txtNameType.Text + "')";
            Class.Functions.RunSQL(sqlAdd);

            LoadDataGridView();

            txtNameType.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idCurrentRow = dgvShowTypeNote.CurrentRow.Cells[0].Value.ToString();
            int totalRow = dgvShowTypeNote.Rows.Count;

            if (tableTypeNote.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNameType.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn loại cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE DBO.TYPENOTE WHERE IDTYPE = " + idCurrentRow + "";
                Functions.RunSQL(sqlDelete);

                for (int i = int.Parse(idCurrentRow) + 1; i <= totalRow; i++)
                {
                    string sqlUpdate = "UPDATE DBO.TYPENOTE SET IDTYPE = IDTYPE - 1 WHERE IDTYPE = " + i + "'";
                }

                LoadDataGridView();

                txtNameType.Text = "";
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}