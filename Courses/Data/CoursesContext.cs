using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courses.Models.DataModels;

namespace Courses.Data
{
    public class CoursesContext : DbContext
    {
        public CoursesContext (DbContextOptions<CoursesContext> options)
            : base(options)
        {
        }

        public DbSet<Courses.Models.DataModels.User> User { get; set; }
    }
}
