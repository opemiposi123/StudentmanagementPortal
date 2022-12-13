using StudentManagementPortal.Data.Dtos;
using StudentManagementPortal.Data.Entity;

namespace StudentManagementPortal.Implementation.Service
{
    public interface IStudentService
    {
        Task<CreateEditResponse> Create(CreateStudent request);
        Task<List<StudentDto>> LoadAllStudent(); 
        Task<StudentDto> LoadStudentDetail(Guid id); 
        Task<CreateEditResponse> Update(Guid id, UpdateStudent updateStudentDto);
        Task<CreateEditResponse> Delete(Guid id);
  
    }
}
