using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Entities
{
    public class Category
    {
        [FromQuery(Name = "Id")]
        [Required]
        public int Id { get; set; }

        [FromQuery(Name = "Description")]
        [Required]
        public string Description { get; set; }
    }
}
