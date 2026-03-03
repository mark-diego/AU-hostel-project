using System;

namespace AU_hostel_project.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public string Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Preferences { get; set; }
    }
}