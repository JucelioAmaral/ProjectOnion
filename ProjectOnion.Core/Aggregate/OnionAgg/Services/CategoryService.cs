using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategory _categoryRepository;
        public CategoryService(ICategory category)
        {
            _categoryRepository = category;
        }

        public List<Category> GetCategory()
        {
            return _categoryRepository.GetCategory();
        }

        public Category GetCategoryId(int Id)
        {
            return _categoryRepository.GetCategoryId(Id);
        }

        public void InsertCategory(Category Description)
        {
            _categoryRepository.InsertCategory(Description);
        }
        public void DeleteCategory(int Id)
        {
            _categoryRepository.DeleteCategory(Id);
        }
        public void UpdateCategory(Category Description)
        {
            _categoryRepository.UpdateCategory(Description);
        }
    }
}
