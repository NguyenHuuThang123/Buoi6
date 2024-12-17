using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF1.Model;

namespace EF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dvgStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dvgStudent.Rows.Add();
                dvgStudent.Rows[index].Cells[0].Value = item.StudentID;
                dvgStudent.Rows[index].Cells[1].Value = item.FullName;
                dvgStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dvgStudent.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<Student> studentList = db.Students.ToList();
                if (studentList.Any(s => s.StudentID == txtStudentID.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStudent = new Student
                {
                    StudentID = txtStudentID.Text,
                    FullName = txtName.Text,
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtAverageScore.Text)
                };

                db.Students.Add(newStudent);
                db.SaveChanges();

                BindGrid(db.Students.ToList());

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<Student> students = db.Students.ToList();
                var student = students.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
                if (student != null)
                {
                    if (students.Any(s => s.StudentID == txtStudentID.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    student.FullName = txtName.Text;
                    student.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtAverageScore.Text);
                    // Cập nhật sinh viên lưu vào CSDL
                    db.SaveChanges();
                    // Hiển thị lại danh sách sinh viên
                    BindGrid(db.Students.ToList());
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: (ex. Message)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<Student> studentList = db.Students.ToList();
                // Tìm kiếm sinh viên có tổn tại trong CSDL hay không
                var student = studentList.FirstOrDefault(s => s.StudentID == txtStudentID.Text);

                if (student != null)
                {
                    // Xoá sinh viên khỏi CSDL
                    db.Students.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.Students.ToList());

                    MessageBox.Show("Sinh viên đã được xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
            }
            MessageBox.Show($"Lỗi khi cập nhật dữ liệu: [ex.Message)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
