using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces;
using ProjectOnion.Core.Aggregate.OnionAgg.Entities;

namespace ProjectOnion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public List<Category> GetCategories()
        {
            return _categoryService.GetCategory();
        }

        [HttpGet("{id}")]
        public Category GetCategoryId(int id)
        {
            return _categoryService.GetCategoryId(id);
        }

        [HttpPost]
        public void PostCategory([FromBody] Category Description)
        {
            _categoryService.InsertCategory(Description);
        }

        [HttpPut("{id}")]
        public void PutCategory(int id, [FromBody] Category Description)
        {
            _categoryService.UpdateCategory(Description);
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _categoryService.DeleteCategory(id);
        }
    }
}
