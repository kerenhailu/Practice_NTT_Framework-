using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice_NTT_Framework.Models
{
    public class Company
    {
        [Required]
        public int Id { get; set; }
        public string NameCompany { get; set; }
        public string City { get; set; }
    }
}