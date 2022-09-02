namespace InspireCoders.Application.Features.Forums.ViewModels
{
    public class AddForumVm
    {
        public string Name { get; set; }
        public int MaximumForumSize { get; set; }
        public int NumberofStudents { get; set; }
        public string CourseCode { get; set; }
        public string FacilitatorCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
