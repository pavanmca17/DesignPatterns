using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepository
{
    interface IGenericRepository<T> where T : class, new()
    {
        void SaveData(T obj);
        Task<List<T>> GetData();
    }
}
