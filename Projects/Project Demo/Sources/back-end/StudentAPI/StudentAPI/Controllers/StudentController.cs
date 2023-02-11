using Microsoft.AspNetCore.Mvc;
using Repository;

namespace StudentAPI.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository repository = new StudentRepository();
        //Get: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => repository.GetProducts();

        //Post: ProductsController/Products
        [HttpPost]
        public IActionResult PostProduct(Product p)
        {
            repository.SaveProduct(p);
            return NoContent();
        }
    }
}
