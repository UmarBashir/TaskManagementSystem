using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskManagementSystem.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> tasks { get; set; }
       
    }
}