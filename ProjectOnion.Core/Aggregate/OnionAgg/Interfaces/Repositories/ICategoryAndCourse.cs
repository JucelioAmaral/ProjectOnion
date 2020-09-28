using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories
{
    public interface ICategoryAndCourse
    {
        List<CategoryAndCourse> CategoryAndCourse();
    }
}
