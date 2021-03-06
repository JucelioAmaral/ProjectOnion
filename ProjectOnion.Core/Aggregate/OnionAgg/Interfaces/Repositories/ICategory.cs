using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories
{
    public interface ICategory
    {
        List<Category> GetCategory();
        Category GetCategoryId(int Id);
        void InsertCategory(Category Description);
        void DeleteCategory(int Id);
        void UpdateCategory(Category Description);
    }
}
