using System;
using System.ComponentModel.DataAnnotations;

namespace WonderLandAdventures.Models
{
    public class TicketPurchase
    {
        public int Id { get; set; }

        [Required]
        public int TicketId { get; set; }

        [Required]
        [Range(1, 10)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Visit Date")]
        public DateTime VisitDate { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string CustomerName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}