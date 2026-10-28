using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BaiTap5_2
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyNguoiDung;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        public class Course
        {
            public string CourseID { get; set; }
            public string CourseName { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            List<Course> listCourses = new List<Course>
            {
                new Course { CourseID = "C01", CourseName = "Lập trình C# WinForms" },
                new Course { CourseID = "C02", CourseName = "Thiết kế Web ASP.NET Core" },
                new Course { CourseID = "C03", CourseName = "Lập trình Python cơ bản" },
                new Course { CourseID = "C04", CourseName = "Cơ sở dữ liệu SQL Server" }
            };

            cboCourse.DataSource = listCourses;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseID";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = mtxtPhone.Text.Trim();
            DateTime birthDate = dtpBirthDate.Value;
            string gender = rdoNam.Checked ? "Nam" : "Nữ";
            string selectedCourse = cboCourse.Text;
            string courseID = cboCourse.SelectedValue?.ToString();

            List<string> skills = new List<string>();
            if (chkTiengAnh.Checked) skills.Add("Tiếng Anh");
            if (chkTinHoc.Checked) skills.Add("Tin học");
            string skillText = skills.Count > 0 ? string.Join(", ", skills) : "Không có";

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Students (Phone, BirthDate, Gender, CourseID, CourseName, Skills) " +
                           "VALUES (@phone, @birthDate, @gender, @courseID, @courseName, @skills)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@birthDate", birthDate);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@courseID", courseID);
                        cmd.Parameters.AddWithValue("@courseName", selectedCourse);
                        cmd.Parameters.AddWithValue("@skills", skillText);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công và đã lưu dữ liệu vào CSDL SQL Server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc lưu CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}