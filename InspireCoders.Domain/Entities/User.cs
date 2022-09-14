using InspireCoders.Domain.Common;

namespace InspireCoders.Domain.Entities
{
    public class User : EntityBase
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
    }
}
