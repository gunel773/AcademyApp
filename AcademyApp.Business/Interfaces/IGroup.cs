using AcademyApp.Domain.Models;
using System.Drawing;

namespace AcademyApp.Business.Interfaces
{
    public interface IGroup
    {
        List<Group> GetAll();
        List<Group> GetAll(int size);
        Group Get(int size);
        Group Get(string name);
        Group Create(Group group);
        Group Delete(int Id);
        Group Update(int Id,Group group);
        
       
    }
}
