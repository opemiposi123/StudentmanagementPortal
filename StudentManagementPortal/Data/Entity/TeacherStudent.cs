namespace StudentManagementPortal.Data.Entity
{
    public class TeacherStudent 
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; } 

    }
}
