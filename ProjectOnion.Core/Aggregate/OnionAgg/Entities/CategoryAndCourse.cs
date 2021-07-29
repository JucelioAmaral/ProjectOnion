using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Entities
{
    public class CategoryAndCourse
    {
        [FromQuery(Name = "Id")]
        public int Id { get; set; }
        [FromQuery(Name = "Description")]
        public string Description { get; set; }
        public List<Course> Courses { get; set; }
    }
}
