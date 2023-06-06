using GenericRepository.Models;
using System.Threading.Tasks;

namespace GenericRepository
{
    interface IDataRepository<T,T1> where T : class,new() where T1:struct
    {
        Task<T> GetData();
        Task<Result<T1>> SaveData(Posts Posts);
    }
 }


