using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewMvcPractice.Models
{
    public class NewMvcPracticeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}