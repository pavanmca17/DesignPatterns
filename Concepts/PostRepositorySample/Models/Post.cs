using System;

namespace GenericRepositorySample
{
    public class Post 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string UrlLink { get; set; }

        public String GetPostDetails()
        {
            return $"ID is {ID} and Name is {Name} and Desc is {Desc}";
        }

               
    }
}
