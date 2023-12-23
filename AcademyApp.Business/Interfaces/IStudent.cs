


using AcademyApp.Domain.Models;

namespace AcademyApp.Business.Interfaces
{
    public interface IStudent
    {
        List<Student> GetAll();
        List<Student> GetAll(string name);
        List<Student> GetAll(int age);
        Student Get(int Id);
        Student Delete(int Id);
        Student Update(int Id,Student student, string groupName);
        Student Create(Student student, string groupName);


    }
}
