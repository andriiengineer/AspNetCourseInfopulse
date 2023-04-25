using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW5.Models
{
    public class Friend
    {
        [Required]
        [DisplayName("Frined ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        [DisplayName("Friend Name")]
        public string Name { get; set; }

        [StringLength(25)]
        [DisplayName("Place where your friend lives")]
        public string Place { get; set; }
    }
}
