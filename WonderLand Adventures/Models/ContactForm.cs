using System.ComponentModel.DataAnnotations;

namespace WonderLandAdventures.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email or phone number")]
        [Display(Name = "Contact Information")]
        public string ContactInfo { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Your Feedback or Question")]
        public string Message { get; set; }
    }
}