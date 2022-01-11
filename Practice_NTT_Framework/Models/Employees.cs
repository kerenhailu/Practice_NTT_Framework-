using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice_NTT_Framework.Models
{
    public class Employees
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        [Required]
        public string NameClass { get; set; }


    }
}