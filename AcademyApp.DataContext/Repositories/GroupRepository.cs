using AcademyApp.DataContext.Interfaces;
using AcademyApp.Domain.Models;


namespace AcademyApp.DataContext.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                DbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                DbContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(Predicate<Group> filter)
        {
            return DbContext.Groups.Find(filter);
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {

            return filter == null ? DbContext.Groups : DbContext.Groups.FindAll(filter);
            //if (filter == null) 
            //{
            //    return DbContext.Groups;
            //}else
            //{
            //    return DbContext.Groups.FindAll(filter);  
            //}

        }

        public bool Update(Group entity)
        {
            try
            {
                var existGroup = Get(s => s.Id == entity.Id);
                existGroup = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
