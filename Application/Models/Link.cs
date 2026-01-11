using System.ComponentModel.DataAnnotations;

namespace rest_api_labb.Application.Models
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }
        public required string LinkUrl { get; set; }
    }
}
