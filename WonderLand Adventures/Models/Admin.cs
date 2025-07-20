using System.ComponentModel.DataAnnotations;

namespace WonderLandAdventures.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "管理员ID")]
        public string AdminId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "姓名")]
        public string Name { get; set; }
    }
}