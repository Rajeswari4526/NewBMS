using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugManagementSystem.Models
{
    public class Status
    {
        [Required]
        public Int32 StatusID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}