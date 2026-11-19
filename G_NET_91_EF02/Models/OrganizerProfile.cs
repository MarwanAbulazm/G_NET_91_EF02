using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EF02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
    }
}