namespace portfolio2.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
