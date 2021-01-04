using DemoApp.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Entities
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int ContactId { set; get; }
       
        [Required]
        [MaxLength(200)]
        public string ContactName { set; get; }

        [Required]
        [MaxLength(200)]
        public string ContactEmail { set; get; }

        [Required]
        [MaxLength(200)]
        public string ContactPhoneNumber { set; get; }
        
        [Required]
        public string ContactMessage { set; get; }
        public Status Status { set; get; }
    }
}
