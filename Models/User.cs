using System;
using System.Collections.Generic;

namespace AU_Hostel_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // Student or Staff
        public string Email { get; set; }
        // Other user-related properties
    }
}