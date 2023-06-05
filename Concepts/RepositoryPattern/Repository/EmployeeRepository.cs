using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class EmployeeRepository : IGenericRepository<Employee> 
    {
        static readonly List<Employee> employees = new List<Employee>();

        public async Task<Result> SaveData()
        {
            Employee employee = CreateEmployee(1, "Pavan Kumar Pannala");
            employees.Add(employee);
            return await Task.FromResult<Result>(new Result()); 
        }

        public async Task<List<Employee>> GetData()
        {
            return await Task.FromResult<List<Employee>>(employees);
        }

        private Func< int, string, Employee> CreateEmployee = (_ID,_Name) => { return new Employee() { ID=_ID,Name=_Name }; };
    }
}
