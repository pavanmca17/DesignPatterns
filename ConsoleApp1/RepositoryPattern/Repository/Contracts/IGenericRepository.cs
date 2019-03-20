using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    interface IGenericRepository<T> where T : class, new()
    {
        Task<Result> SaveData();
        Task<List<T>> GetData();
    }
}
