using DataAccess;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
     public class StudentRepository : IStudentRepository
    {
        public int SaveStudent(StudentModel student)
        {
            return StudentDAO.SaveStudent(student);
        }

        public List<StudentModel> GetStudents()
        {
            return StudentDAO.GetStudents();
        }

        public int UpdateStudent(StudentModel student)
        {
            return StudentDAO.UpdateStudent(student);
        }

        public int DeleteStudent(int id)
        {
            return StudentDAO.DeleteStudent(id);
        }

        public StudentModel GetStudentById(int id)
        {
            return StudentDAO.GetStudentById(id);
        }
    }
}
