using StudentManagementPortal.Data.Enum;
using StudentManagementPortal.Migrations;
using System.Reflection;

namespace StudentManagementPortal.Data.Entity
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddmissionNumber { get; set; } 
        public string Password { get; set; } 
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; } 
        public string PhoneNumber { get; set; } 
        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new HashSet<TeacherStudent>();
        public ICollection<StudentSubject> StudentSubject { get; set; } = new HashSet<StudentSubject>();
    }
}
