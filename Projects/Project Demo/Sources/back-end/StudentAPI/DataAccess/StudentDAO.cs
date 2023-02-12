using BusinessObject;

namespace DataAccess
{
    public class StudentDAO
    {
        //get list students
        public static List<StudentModel> GetStudents()
        {
            var students = new List<StudentModel>();
            try
            {
                using (var context = new StudentDbContext())
                {
                    students = context.Students.ToList();
                    return students;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
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
            }4
        }
        
        public static int UpdateStudent(StudentModel student)
        {
            try
            {
                using (var context = new StudentDbContext())
                {
                    context.Students.Update(student);
                    var result = context.SaveChanges();
                    return result;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public static int DeleteStudent(int id)
        {
            try
            {
                using (var context = new StudentDbContext())
                {
                    var student = context.Students.Find(id);
                    context.Students.Remove(student);
                    var result = context.SaveChanges();
                    return result;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public static StudentModel GetStudentById(int id)
        {
            try
            {
                using (var context = new StudentDbContext())
                {
                    var student = context.Students.Find(id);
                    return student;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
