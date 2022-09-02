namespace InspireCoders.Application.Features.Forums.ViewModels
{
    public class GetForumsVm
    {
        public string Name { get; set; }
        public string FacilitatorFirstName { get; set; }
        public string FacilitatorLastName { get; set; }
        public string FacilitatorCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }
        public int MaximumForumSize { get; set; }
        public int NumberofStudents { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
