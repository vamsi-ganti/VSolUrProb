using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace VSolUrProb.Models
{

    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("Vamsi")
        {
        }
        public DbSet<Department> DepartmentTable { get; set; }
        public DbSet<Employee> EmployeeTable { get; set; }
    }
}