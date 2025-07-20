﻿namespace WonderLandAdventures.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal PricePerNight { get; set; }
        public int Rating { get; set; }
    }
}