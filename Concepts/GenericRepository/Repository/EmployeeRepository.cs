using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace GenericRepository
{
    public class EmployeeRepository : IGenericRepository<Employee> 
    {
        static readonly List<Employee> employees = new List<Employee>();

        public void SaveData(Employee employee)
        {
           employees.Add(employee);          
        }

        public async Task<List<Employee>> GetData()
        {
            return await Task.FromResult(employees);
        }
        
        
    }
}
