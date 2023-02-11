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
        public IActionResult SaveStudent(StudentModel p)
        {
            repository.SaveStudent(p);
            return NoContent();
        }
    }
}
