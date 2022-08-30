using InspireCoders.Domain.Common;

namespace InspireCoders.Domain.Entities
{
    public class Facilitator : EntityBase
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public Course Course { get; set; }
        public string Phone { get; set; }
    }
}
