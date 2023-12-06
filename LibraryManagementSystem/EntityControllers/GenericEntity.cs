using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.EntityUtils
{
    public class GenericEntity
    {
        public void CreateEntity<T>(T entity) where T : class
        {
            using (var db = new LibraryContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        public void readEntity<T>(T entity) where T : class
        {
            using (var db = new LibraryContext())
            {
                db.Set<T>().Find(entity);
            }
        }

        public void EditEntity<T>(T entity) where T : class
        {
            using (var db = new LibraryContext())
            {
                db.Set<T>().Update(entity);
                db.SaveChanges();
            }
        }   

        public void DeleteEntity<T>(T entity) where T : class
        {
            using (var db = new LibraryContext())
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public List<T> GetAllEntities<T>() where T : class
        {
            using (var db = new LibraryContext())
            {
                return db.Set<T>().ToList();
            }
        }
    }
}
