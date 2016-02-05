using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugManagementSystem.Models
{
    public class Category
    {
        [Required]
        public Int32 CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}