using System;
using Server.Inerfaces;

namespace Server.Entities
{
    public class User : IEntityMarker
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }
    }
}