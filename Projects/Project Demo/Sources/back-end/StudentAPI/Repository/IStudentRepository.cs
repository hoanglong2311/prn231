using BusinessObject;
using System;
namespace Repository
{
    public interface IStudentRepository
    {
        int SaveStudent(StudentModel student);
        List<StudentModel> GetStudents();
        int UpdateStudent(StudentModel student);
        int DeleteStudent(int id);
    }
}
