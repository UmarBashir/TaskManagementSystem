using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagementSystem.Models
{
    public class Task
    {
        [Key]
        public Guid TaskID { get; set; }
        
        [Required(ErrorMessage = "* Name is required")]
        public String Name { get; set; }
        [Required(ErrorMessage = "* Description is required")]
        public String Description { get; set; }
        [Display(Name = "Created On")]
        public String CreatedOn { get; set; }
        [Display(Name = "Updated On")]
        public String LastUpdatedOn { get; set; }
    }
}