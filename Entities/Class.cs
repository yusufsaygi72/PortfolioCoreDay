using System.ComponentModel.DataAnnotations;

namespace PortfolioCoreDay.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}