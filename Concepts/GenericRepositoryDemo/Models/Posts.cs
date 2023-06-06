
namespace GenericRepository
{
    public class Posts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string UrlLink { get; set; }

        public string GetPostsDetails()
        {
            return $"ID is {ID} and Name is {Name} and Desc is {Desc}";
        }

               
    }
}
