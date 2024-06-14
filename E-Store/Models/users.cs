using System.ComponentModel.DataAnnotations;

namespace E_Store.Models
{
    public class users
    {
        [Key]
        public int usr_id { get; set; }

        [Required]
        public string usr_name { get; set; }

        [Required]
        public string usr_email { get; set; }

        [Required]
        public string usr_password { get; set; }

        [Required]
        [StringLength(1)]
        public string gender { get; set; }
    }
}
