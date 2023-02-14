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
        /// Get list student
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public IActionResult GetListStudent()
        {
            return Ok(repository.GetStudents());
        }

        /// <summary>
        /// Get student by id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("id")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(repository.GetStudentById(id));
        }
        
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
        
        /// <summary>
        /// Delete student
        /// </summary>
        /// <returns></returns>
        [HttpDelete("id")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var studentTmp = repository.GetStudentById(id);
                if (studentTmp == null)
                {
                    return NotFound("Can not find student");
                }
                else
                {
                    repository.DeleteStudent(id);
                    return Ok("Delete student successfully");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
