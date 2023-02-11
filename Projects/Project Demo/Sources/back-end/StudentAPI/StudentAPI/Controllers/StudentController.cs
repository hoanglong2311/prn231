using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace StudentAPI.Controllers
{
    [Route("api/student")]
    public class StudentController : Controller
    {
        private IStudentRepository repository = new StudentRepository();

        
        //Post: ProductsController/Products
        [HttpPost]
        [Route("save")]
        public int SaveStudent(StudentModel p)
        {
            return repository.SaveStudent(p);
        }
    }
}
