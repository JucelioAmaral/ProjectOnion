using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Entities
{
    public class Course
    {
        [FromQuery(Name = "Id")]
        public int Id { get; set; }

        [FromQuery(Name = "SubjectDescription")]
        [Required]
        public string SubjectDescription { get; set; }

        [FromQuery(Name = "StartDate")]
        [Required]
        public DateTime StartDate { get; set; }

        [FromQuery(Name = "EndDate")]
        [Required]
        public DateTime EndDate { get; set; }

        [FromQuery(Name = "NumberStudents")]
        public int NumberStudents { get; set; }

        [FromQuery(Name = "IdCategory")]
        public int IdCategory { get; set; }

        [FromQuery(Name = "Category")]
        public string Category { get; set; }
    }
}
