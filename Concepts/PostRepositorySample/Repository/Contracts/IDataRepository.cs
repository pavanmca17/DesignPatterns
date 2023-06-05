using System;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    interface IDataRepository<T,T1> where T : class,new() where T1:struct
    {
        Task<T> GetData();
        Task<Result<T1>> SaveData(Post post);
    }
 }


