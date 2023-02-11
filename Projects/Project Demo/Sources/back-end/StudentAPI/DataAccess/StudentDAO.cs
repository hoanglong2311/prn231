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
                     return context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
