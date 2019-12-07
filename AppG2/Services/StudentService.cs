using AppG2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = AppG2.Model.DbContext;

namespace AppG2.Services
{
    public class StudentService
    {
        public static List<Student> ReadFileData(string pathDataFile, string idUser)
        {
            if (File.Exists(pathDataFile))
            {
                List<Student> listStudent = new List<Student>();
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                //foreach (var lines in listLines)
                //{
                //    var rs = lines.Split(new char[] { ',' });
                //    Student Student = new Student
                //    {
                //        Id = Guid.NewGuid().ToString(),
                //        Name = rs[0],
                //        Phone = rs[1],
                //        Email = rs[2],
                //        IdUser = idUser
                //    };
                //    listStudent.Add(Student);
                //}
                return listStudent;
            }
            else
            {
                return null;
            }

        }

        public static void ReadFile(string pathDataFile, string idUser)
        {
            if (File.Exists(pathDataFile))
            {
                List<Student> listStudent = new List<Student>();
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                //foreach (var lines in listLines)
                //{                  
                //    var rs = lines.Split(new char[] { ',' });
                //    Student Student = new Student
                //    {
                //        Id = Guid.NewGuid().ToString(),
                //        Name = rs[0],
                //        Phone = rs[1],
                //        Email = rs[2],
                //        IdUser = idUser
                //    };
                //    listStudent.Add(Student);
                //    var context = new DbContext();
                //    context.Students.Add(Student);
                //    context.SaveChanges();
                //}

            }
            
        }
        public static List<Student> GetAll()
        {
            return new DbContext().Students.ToList();
        }
        public static Student Get(string id)
        {
            return new DbContext().Students.Where(s => s.StudentId.Equals(id)).FirstOrDefault();
        }
        public static void Delete(Student student)
        {
            using (var db = new DbContext())
            {
                var deleteStudent = db.Students.Find(student.Id);
                db.Students.Remove(deleteStudent);
                db.SaveChanges();
                return ;
            }
        }

        public static Student Update(Student student)
        {
            using (var db = new DbContext())
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return db.Students.Find(student.Id);
            }
        }

        public static Student AddOrUpdate(Student student)
        {
            using (var db = new DbContext())
            {
                if (db.Students.Any(e => e.StudentId == student.StudentId))
                    db.Entry(student).State = EntityState.Modified;
                else
                {
                    db.Students.Add(student);
                }
                db.SaveChanges();
                return db.Students.FirstOrDefault(s=> s.StudentId == student.StudentId);
            }
        }
    }
}
