using System.ComponentModel.DataAnnotations;

namespace rest_api_labb.Application.Models
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }
        public required string LinkUrl { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public int InterestId { get; set; }
        public Interest Interest { get; set; } = null!;
    }
}
