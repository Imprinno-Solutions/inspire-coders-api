using InspireCoders.Domain.Common;

namespace InspireCoders.Domain.Entities
{
    public class Forum : EntityBase
    {
        public string Name { get; set; }
        public string NumberofStudents { get; set; }
        public Course Course { get; set; }
        public Facilitator Facilitator { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
