﻿namespace portfolio2.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string? Description { get; set; }
        public int? ProjectId { get; set; }
        public Project? Project { get; set; }
   
    }
}
