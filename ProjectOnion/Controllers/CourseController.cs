using Microsoft.AspNetCore.Mvc;
using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOnion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public List<Course> GetCourses()
        {
            return _courseService.GetCourse();
        }

        [HttpGet("{id}")]
        public Course GetCourseId(int id)
        {
            return _courseService.GetCourseId(id);
        }
        [HttpPost]
        public IActionResult PostCourse([FromBody] Course NewCourse)
        {
            var result = _courseService.InsertCourse(NewCourse);
            if (result.Success)
            {
                return Ok("Categoria inserida com sucesso");
            }

            if (result.Message != null)
            {
                return BadRequest(new { error = result.Message });
            }
            return StatusCode(500);
        }

        [HttpPut("{id}")]
        public IActionResult PutCourse(int id, [FromBody] Course NewCourse)
        {
            var result = _courseService.UpdateCourse(NewCourse);
            if (result.Success)
            {
                return Created("/Course", result.Object);
            }

            if (result.Message != null)
            {
                return BadRequest(new { error = result.Message });
            }
            return StatusCode(500);
        }

        [HttpDelete("{id}")]
        public void DeleteCourse(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}
