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
    }
}
