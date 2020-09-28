using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories
{
    public interface ICourse
    {
        List<Course> GetCourse();
        Course GetCourseId(int Id);
        void InsertCourse(Course NewCourse);
        void DeleteCoursey(int Id);
        void UpdateCourse(Course NewCourse);
        bool GetCourseValidationDate(Course NewCourse);
    }
}
