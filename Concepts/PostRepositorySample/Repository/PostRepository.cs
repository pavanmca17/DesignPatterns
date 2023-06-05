using GenericRepositorySample;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericRepositorySample
{
    public class PostRepository : IDataRepository<Post,int>
    {
        private readonly static List<Post> posts = new List<Post>();

        public async Task<Post> GetData()
        {
            await Task.Delay(10000);
            Func<Post> createPost = () => { return new Post() {ID=1,Name="My Post",Desc="My Desc",UrlLink="https://google.com" }; };
            return await Task.FromResult<Post>(createPost());
        }

        public async Task<Result<int>> SaveData(Post post)
        {
            await Task.Delay(1000);
            posts.Add(post);
            Func<Result<int>> createResult = () => { return new Result<int>() { Success = true, Value = 10 }; };
            return await Task.FromResult<Result<int>>(createResult());


        }
    }
}
