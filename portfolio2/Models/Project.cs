namespace portfolio2.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<string> technology { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Link? link { get; set; }
    }
}
