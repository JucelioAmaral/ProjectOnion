using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Services
{
    public class CategoryAndCourseService : ICategoryAndCourseService
    {

        private readonly ICategoryAndCourse _categoryAndCourseRepository;
        public CategoryAndCourseService(ICategoryAndCourse category)
        {
            _categoryAndCourseRepository = category;
        }
        public List<CategoryAndCourse> CategoryAndCourse()
        {
            return _categoryAndCourseRepository.CategoryAndCourse();
        }
    }
}
