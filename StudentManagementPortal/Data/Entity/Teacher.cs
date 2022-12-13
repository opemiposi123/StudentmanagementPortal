using StudentManagementPortal.Data.Enum;

namespace StudentManagementPortal.Data.Entity
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<TeacherStudent> TeacherStudents = new HashSet<TeacherStudent>();
    }
}
