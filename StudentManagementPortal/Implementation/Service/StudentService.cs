using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data.Database;
using StudentManagementPortal.Data.Dtos;
using StudentManagementPortal.Data.Entity;
using StudentManagementPortal.Implementation.Repository;

namespace StudentManagementPortal.Implementation.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ApplicationDbContext _dbContext;

        public StudentService(ApplicationDbContext dbContext, IStudentRepository studentRepository)
        {
            _dbContext = dbContext;
            _studentRepository = studentRepository;
        }

        public async Task<CreateEditResponse> Create(CreateStudent request)
        {
            try
            {   
                string code =  Helper.GenerateCode();
                var student = new Student()
                {
                    Id = new Guid(),
                    AddmissionNumber = code,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    MiddleName = request.MiddleName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Password = request.Password,
                    Gender = request.Gender,
                    DateJoined = DateTime.Now,
                    DateOfBirth = request.DateOfBirth
                };

                var findEmployee =   _studentRepository.GetByIdOrAdmissionNo(student.Id, student.AddmissionNumber);

                if (findEmployee == null)
                {
                    _dbContext.Students.Add(student);
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    return new CreateEditResponse(false,
                                              "",
                                              "No such student exist..");
                }

            }
            catch (Exception ex)
            {
                return new CreateEditResponse(false,
                                             "",
                                             "Something Went wrong..");
            }

            return new CreateEditResponse(true,
                                              "",
                                              "Student Record successfully created..");

        }

        public async Task<CreateEditResponse> Delete(Guid id)
        {
          
            var deleteStudent =  _studentRepository.GetById(id);

            if (deleteStudent == null)
            {
                return new CreateEditResponse(false,
                                             "",
                                              "No such student exists");
            }

           
            try
            {
                 _dbContext.Students.Remove(deleteStudent);
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return new CreateEditResponse(false,
                                              "",
                                              "Could not delete student..");
            }

            return new CreateEditResponse(true,
                                          "CMS-02",
                                          "The Student was successfully deleted");
        }

        public async Task<List<StudentDto>> LoadAllStudent()
        {
            return await _studentRepository.GetAllStudentDto();
           
        } 

        public async Task<StudentDto> LoadStudentDetail(Guid id)
        {
            return await _studentRepository.LoadStudentDetailAsync(id);
        }

        public async Task<CreateEditResponse> Update(Guid id, UpdateStudent request)
        {
            DateTime modified = DateTime.Now;
            try
            {
                var std = _studentRepository.GetById(id);

                if (std != null)
                {
                    std.ModifiedDate = modified;
                    std.ModifiedBy = "Admin";
                    std.FirstName = request.FirstName;
                    std.LastName = request.LastName;
                    std.MiddleName = request.MiddleName;
                    std.Gender = request.Gender;
                    std.PhoneNumber = request.PhoneNumber;
                    std.Email = request.Email;

                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    return new CreateEditResponse(false,
                                                 "",
                                                 "No such student exist");
                }
            }
            catch(Exception ex)
            {
                return new CreateEditResponse(false,
                                                 "",
                                                 "Something went wrong");
            }
            return new CreateEditResponse(true,
                                                 "",
                                                 "Student Successfully Updated");

        }

    
    }
}
