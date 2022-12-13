using StudentManagementPortal.Data.Database;
using StudentManagementPortal.Data.Dtos;
using StudentManagementPortal.Data.Entity;

namespace StudentManagementPortal.Implementation.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetById(Guid id);
        Student GetByAdmissionNo(string admissionNo);
        Student GetByIdOrAdmissionNo(Guid id, string admissionNo);
        Task<List<StudentDto>> GetAllStudentDto();
        Task<StudentDto?> LoadStudentDetailAsync(Guid id);

    }
}
