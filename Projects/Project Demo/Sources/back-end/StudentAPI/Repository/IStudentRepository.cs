using StudentBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IStudentRepository
    {
        public int SaveStudent(StudentModel student);
    }
}
