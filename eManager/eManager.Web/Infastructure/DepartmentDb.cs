using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using eManager.Domain;

namespace eManager.Web.Infastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        public DepartmentDb() :base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }  //put in place so the entety framework can access Employees and Departments
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }

    }
}