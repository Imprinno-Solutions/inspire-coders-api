﻿using InspireCoders.Domain.Common;

namespace InspireCoders.Domain.Entities
{
    public class Forum : EntityBase
    {
        public string Name { get; set; }
        public int MaximumForumSize { get; set; }
        public int NumberofStudents { get; set; }
        public string CourseCode { get; set; }
        public Course Course { get; set; }
        public string FacilitatorCode { get; set; }
        public Facilitator Facilitator { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
