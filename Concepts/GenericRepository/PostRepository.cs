using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatterns.GenericRepository.Repository.Contracts;
using DesignPatterns.Models;
using Models;

namespace DesignPatterns.GenericRepository
{
    public class PostsRepository : IDataRepository<Posts, int>
    {
        private readonly static List<Posts> Postss = new List<Posts>();

        public async Task<Posts> GetData()
        {
            await Task.Delay(10000);
            Func<Posts> createPosts = () => { return new Posts() { ID = 1, Name = "My Posts", Desc = "My Desc", UrlLink = "https://google.com" }; };
            return await Task.FromResult(createPosts());
        }

        public async Task<Result<int>> SaveData(Posts Posts)
        {
            await Task.Delay(1000);
            Postss.Add(Posts);
            Func<Result<int>> createResult = () => { return new Result<int>() { Success = true, Value = 10 }; };
            return await Task.FromResult(createResult());


        }
    }
}
