namespace Absher.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public ICollection<Post> Blogs { get; set; }
    }
}
