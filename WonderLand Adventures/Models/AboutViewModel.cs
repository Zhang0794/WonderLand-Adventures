using System.Collections.Generic;

namespace WonderLandAdventures.Models
{
    public class AboutViewModel
    {
        public List<Employee> Employees { get; set; }
        public Founder Founder { get; set; }
        public List<HistoryItem> History { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public string ParkHistory { get; set; }
    }



    public class Founder
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
    }

    public class HistoryItem
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class TeamMember
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
    }
}