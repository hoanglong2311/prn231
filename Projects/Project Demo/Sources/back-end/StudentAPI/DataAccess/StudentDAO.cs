using BusinessObject;
using StudentBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentDAO
    {
        public static void SaveStudent(StudentModel student)
        {
            try
            {
                using (var context = new StudentDbContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
