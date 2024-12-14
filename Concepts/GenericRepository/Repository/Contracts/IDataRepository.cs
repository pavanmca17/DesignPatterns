
using Models;
using System.Threading.Tasks;

namespace DesignPatterns.GenericRepository.Repository.Contracts
{
    interface IDataRepository<T, T1> where T : class, new() where T1 : struct
    {
        Task<T> GetData();
        Task<Result<T1>> SaveData(Posts Posts);
    }
}


