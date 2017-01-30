using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public class IDepartmentDataSource
    {
        public IQueryable<Employee> Employee { get; }
        public IQueryable<Department> Department { get; }
    }
}
