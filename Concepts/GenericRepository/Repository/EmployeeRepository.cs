﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    public class EmployeeRepository : IGenericRepository<Employee> 
    {
        static readonly List<Employee> employees = new List<Employee>();

        public void SaveData()
        {
            Employee employee = CreateEmployee(1, "Employee");
            employees.Add(employee);          
        }

        public async Task<List<Employee>> GetData()
        {
            return await Task.FromResult(employees);
        }
        
        private Func<int, string, Employee> CreateEmployee = (_ID,_Name) => { return new Employee() { ID=_ID,Name=_Name }; };
    }
}
