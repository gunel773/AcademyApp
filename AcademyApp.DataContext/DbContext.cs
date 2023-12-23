

using AcademyApp.Domain.Models;

namespace AcademyApp.DataContext
{
    public static class DbContext
    {
        public  static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new ();
            Groups = new ();
        }
    }
}
