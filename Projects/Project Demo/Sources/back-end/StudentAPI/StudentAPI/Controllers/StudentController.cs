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
        
        /// <summary>
        /// update student
        /// </summary>
        /// <returns></returns>
        [HttpPut("Update")]
        public IActionResult UpdateStudent(StudentModel student)
        {
            try
            {
                var studentTmp = repository.GetStudentById(student.ID);
                if (studentTmp == null)
                {
                    return NotFound("Can not find student");
                }
                else
                {
                    repository.UpdateStudent(student);
                    return Ok("Update student successfully");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
