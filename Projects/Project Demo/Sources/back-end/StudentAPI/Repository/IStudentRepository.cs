using BusinessObject;
using System;
namespace Repository
{
    public interface IStudentRepository
    {
        int SaveStudent(StudentModel student);
    }
}
