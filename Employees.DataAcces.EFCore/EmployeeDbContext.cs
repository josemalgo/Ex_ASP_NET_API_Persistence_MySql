using Employees.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Employees.DataAcces.EFCore
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
    }
}
