using System.ComponentModel.DataAnnotations;

namespace rest_api_labb.Application.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [StringLength(50)]
        public required string FirstName { get; set; } 
        [StringLength(50)]
        public required string LastName { get; set; }
        [StringLength(25)] 
        public required string PhoneNumber { get; set; }
    }
}
