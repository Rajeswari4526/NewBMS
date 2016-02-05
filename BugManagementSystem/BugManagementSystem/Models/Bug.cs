using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugManagementSystem.Models
{
    public class Bug
    {
        [Required]
        public Int32 BugID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public string AssignedTo { get; set; }
        [Required]
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}