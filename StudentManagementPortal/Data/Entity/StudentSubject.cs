namespace StudentManagementPortal.Data.Entity
{
    public class StudentSubject
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid TeacherId { get; set; }
        public Subject Subjects { get; set; }
    }
}
