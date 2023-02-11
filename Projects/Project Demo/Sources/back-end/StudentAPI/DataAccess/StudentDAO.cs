using BusinessObject;

namespace DataAccess
{
    public class StudentDAO
    {
        public static int SaveStudent(StudentModel student)
        {
            try
            {
                using (var context = new StudentDbContext())
                {
                    context.Students.Add(student);
                    var result = context.SaveChanges();
                     return result;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
