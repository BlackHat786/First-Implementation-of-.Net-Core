using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Models
{
    public class EmployeeDetailsContext : DbContext
    {
        //This class is where our dbcontext sits. we first create a constructor and parse through a parameter DbContextOptions
        
        public EmployeeDetailsContext (DbContextOptions<EmployeeDetailsContext> options)
            : base(options)
        {
        }
        //We then add our dbset from our model that we have created
        public DbSet<EmployeeDetails.Models.Employee> Employee { get; set; }
    }
}
