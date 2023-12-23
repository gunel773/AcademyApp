using AcademyApp.DataContext.Interfaces;
using AcademyApp.Domain.Models;


namespace AcademyApp.DataContext.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                DbContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                DbContext.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student Get(Predicate<Student> filter)
        {
            return DbContext.Students.Find(filter);
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {

            return filter==null? DbContext.Students:DbContext.Students.FindAll(filter);
            //if (filter == null) 
            //{
            //    return DbContext.Students;
            //}else
            //{
            //    return DbContext.Students.FindAll(filter);  
            //}
           
        }

        public bool Update(Student entity)
        {
            try
            {
                var existStudent = Get(s => s.Id == entity.Id);
                existStudent = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
