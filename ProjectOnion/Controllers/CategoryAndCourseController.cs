using Microsoft.AspNetCore.Components.Routing;
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
    public class CategoryAndCourseController
    {
        private readonly ICategoryAndCourseService _categoryAndCourseService;
        public CategoryAndCourseController(ICategoryAndCourseService categoryAndCourseService)
        {
            _categoryAndCourseService = categoryAndCourseService;
        }
        [HttpGet]
        public List<CategoryAndCourse> GetCategories()
        {
            return _categoryAndCourseService.CategoryAndCourse();
        }
    }
}
