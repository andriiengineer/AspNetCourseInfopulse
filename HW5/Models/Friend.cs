using System.ComponentModel.DataAnnotations;

namespace HW5.Models
{
    public class Friend
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        public string Name { get; set; }

        [StringLength(25)]
        public string Place { get; set; }
    }
}
