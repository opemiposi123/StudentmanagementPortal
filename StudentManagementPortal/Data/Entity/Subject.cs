namespace StudentManagementPortal.Data.Entity
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<StudentSubject> StudentCourses = new HashSet<StudentSubject>();
    }
}
