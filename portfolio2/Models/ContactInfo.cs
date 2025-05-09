using System.ComponentModel.DataAnnotations;

namespace portfolio2.Models
{
    public class ContactInfo
    {
        [Key]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}
