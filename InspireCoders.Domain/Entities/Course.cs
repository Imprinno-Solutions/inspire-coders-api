using InspireCoders.Domain.Common;

namespace InspireCoders.Domain.Entities
{
    public class Course : EntityBase
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
    }
}
