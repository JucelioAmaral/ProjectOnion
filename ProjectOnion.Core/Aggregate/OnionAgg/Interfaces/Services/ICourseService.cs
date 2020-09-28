using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services
{
    public interface ICourseService
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        ResponseObject<Course> InsertCourse(Course NewCourse);
        void DeleteCourse(int Id);
        ResponseObject<Course> UpdateCourse(Course NewCourse);
    }
}
