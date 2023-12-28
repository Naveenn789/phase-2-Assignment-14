using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppData.Models;

namespace WebAppData.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext (DbContextOptions<CourseContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppData.Models.Course> Course { get; set; } = default!;
    }
}
