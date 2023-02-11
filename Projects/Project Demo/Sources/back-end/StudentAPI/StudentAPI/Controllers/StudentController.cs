using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : Controller
    {
        private IStudentRepository repository = new StudentRepository();


        /// <summary>
        /// Create a document
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("save")]
        public int SaveStudent(StudentModel p)
        {
            return repository.SaveStudent(p);
        }
    }
}
