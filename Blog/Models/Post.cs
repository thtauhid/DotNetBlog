namespace Blog.Models
{
    public class Post
    {
        public Post()
        {
            
        }

        public string? OwnerID { get; set; } = System.Security.Claims.ClaimsPrincipal.Current?.Identity?.Name;


        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;


    }
}
