using AppG2.Model;
using AppG2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2
{
    public partial class frmThongTinSinhVien2 : Form
    {
        List<Student> students;
        Student currentStudent;

        public frmThongTinSinhVien2()
        {
            InitializeComponent();
        }

        private void FrmThongTinSinhVien2_Load(object sender, EventArgs e)
        {
            // Get student lists.
            refreshAll();
        }

        private void ChkListStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStudent = (Student)chkListStudent.SelectedItem;
            showStudent(currentStudent);
        }

        private void ToolBtnUpdate_Click(object sender, EventArgs e)
        {
            getStudent();
            currentStudent = StudentService.Update(currentStudent);
            showStudent(currentStudent);
            refreshAll();
        }

        private void ToolBtnRefresh_Click(object sender, EventArgs e)
        {
            showStudent(currentStudent);
        }

        private void ToolMenuVan_Click(object sender, EventArgs e)
        {
            getStudent();
            currentStudent.Id = 1;
            currentStudent.Major = Model.MAJOR.Van;
            currentStudent = StudentService.AddOrUpdate(currentStudent);
            refreshAll();
            showStudent(currentStudent);
        }

        private void ToolMenuVL_Click(object sender, EventArgs e)
        {
            getStudent();
            currentStudent.Id = 1;
            currentStudent.Major = Model.MAJOR.VatLy;
            currentStudent = StudentService.AddOrUpdate(currentStudent);
            refreshAll();
            showStudent(currentStudent);
        }

        private void ToolMenuCNTT_Click(object sender, EventArgs e)
        {
            getStudent();
            currentStudent.Id = 1;
            currentStudent.Major = Model.MAJOR.CNTT;
            currentStudent = StudentService.AddOrUpdate(currentStudent);
            refreshAll();
            showStudent(currentStudent);
        }

        private void ToolBtnDelete_Click(object sender, EventArgs e)
        {
            StudentService.Delete(currentStudent);
            refreshAll();
        }

        private void refreshAll()
        {
            students = StudentService.GetAll();
            ((ListBox)chkListStudent).DataSource = students;
            ((ListBox)chkListStudent).DisplayMember = "FullName";
            ((ListBox)chkListStudent).ValueMember = "ID";
        }

        private void showStudent(Student student)
        {
            txtID.Text = student.StudentId;
            txtName.Text = student.FullName;
            chkMale.Checked = student.Gender == Model.GENDER.Male;
            dtmBirth.Value = student.DateOfBirth ?? DateTime.Now;

            txtVHCD.Value = student.scoreVHCD ?? 0;
            txtVHHD.Value = student.scoreVHHD ?? 0;

            txtCoHoc.Value = student.scoreCoHoc ?? 0;
            txtQuangHoc.Value = student.scoreQuangHoc ?? 0;
            txtDien.Value = student.scoreDien ?? 0;
            txtHatNhan.Value = student.scoreHatNhan ?? 0;

            txtSQL.Value = student.scoreSQL ?? 0;
            txtCSharp.Value = student.scoreCSharp ?? 0;
            txtPascal.Value = student.scorePascal ?? 0;
        }

        private void getStudent()
        {
            if (currentStudent == null)
                currentStudent = new Student();
            currentStudent.StudentId = txtID.Text;
            currentStudent.FullName = txtName.Text;
            currentStudent.Gender = chkMale.Checked ? Model.GENDER.Male : Model.GENDER.Female;
            currentStudent.DateOfBirth = dtmBirth.Value;

            currentStudent.scoreVHCD = txtVHCD.Value;
            currentStudent.scoreVHHD = txtVHHD.Value;

            currentStudent.scoreCoHoc = txtCoHoc.Value;
            currentStudent.scoreQuangHoc = txtQuangHoc.Value;
            currentStudent.scoreDien = txtDien.Value;
            currentStudent.scoreHatNhan = txtHatNhan.Value;

            currentStudent.scoreSQL = txtSQL.Value;
            currentStudent.scoreCSharp = txtCSharp.Value;
            currentStudent.scorePascal = txtCSharp.Value;
        }
    }
}
