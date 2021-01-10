using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC_ProjectCourse.Models;

namespace SalesWebMVC_ProjectCourse.Data
{
    public class SalesWebMVC_ProjectCourseContext : DbContext
    {
        public SalesWebMVC_ProjectCourseContext (DbContextOptions<SalesWebMVC_ProjectCourseContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC_ProjectCourse.Models.Department> Department { get; set; }
    }
}
