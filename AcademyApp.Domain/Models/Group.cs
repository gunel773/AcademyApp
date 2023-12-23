

using AcademyApp.Domain.Models.Common;

namespace AcademyApp.Domain.Models
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public int MaxSize { get; set; }
        public int MyProperty { get; set; }
    }
}
