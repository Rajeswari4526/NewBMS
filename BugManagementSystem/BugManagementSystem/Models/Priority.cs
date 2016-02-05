using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugManagementSystem.Models
{
    public class Priority
    {
        [Required]
        public Int32 PriorityID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}