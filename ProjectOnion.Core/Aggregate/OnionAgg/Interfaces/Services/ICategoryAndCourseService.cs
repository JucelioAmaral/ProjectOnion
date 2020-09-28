using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services
{
    public interface ICategoryAndCourseService
    {
        List<CategoryAndCourse> CategoryAndCourse();
    }
}
