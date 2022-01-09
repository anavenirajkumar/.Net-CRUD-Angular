
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks; // Task is Handle  Everything is "Asynchronous"

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository // Student Interface
    {
        Task<List<Student>> GetStudentsAsync(); // Asynchronous => Task and GetStudents"Async"
        Task<Student> GetStudentAsync(Guid studentId);//Asynchronous
        Task<List<Gender>>GetGendersAsync();//Asynchronous
        // If user is EXISTS
        Task<bool> Exists(Guid studentId);//Asynchronous
        Task<Student> UpdateStudent(Guid studentId, Student request);//Asynchronous
        Task<Student> DeleteStudent(Guid studentId);//Asynchronous
        Task<Student> AddStudent(Student request);//Asynchronous
        Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl);//Asynchronous
    }
}
