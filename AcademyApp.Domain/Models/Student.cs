

using AcademyApp.Domain.Models.Common;

namespace AcademyApp.Domain.Models
{
    public class Student : BaseEntity
    {
        public int Age { get; set; }
        public string Name { get; set; } 
    public string Surname { get; set; }
    public Group Group { get; set; }
}
}
