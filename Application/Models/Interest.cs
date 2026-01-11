using System.ComponentModel.DataAnnotations;

namespace rest_api_labb.Application.Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }
        [StringLength(100)]
        public required string InterestName { get; set; }
        public required string InterestDescription { get; set; }
    }
}
