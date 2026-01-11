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

        public ICollection<Person> People { get; set; } = new List<Person>(); //N:M relationsship with Person
        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}
