using System;
using System.ComponentModel.DataAnnotations;

namespace WonderLandAdventures.Models
{
    public class Booking
    {
        public string Id { get; set; }

        [Required]
        public int HotelId { get; set; }

        [Required]
        [Display(Name = "Check-in Date")]
        public DateTime CheckInDate { get; set; }

        [Required]
        [Display(Name = "Check-out Date")]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [Range(1, 10)]
        [Display(Name = "Number of Guests")]
        public int NumberOfGuests { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string GuestName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}