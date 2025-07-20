namespace WonderLandAdventures.Models
{
    public class ParkStatistics
    {
        public int DailyVisitors { get; set; }
        public int WeeklyVisitors { get; set; }
        public int MonthlyVisitors { get; set; }
        public int TicketsSoldToday { get; set; }
        public decimal HotelOccupancyRate { get; set; }
    }
}