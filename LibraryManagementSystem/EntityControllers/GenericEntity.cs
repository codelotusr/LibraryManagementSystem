﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Exceptions;

namespace LibraryManagementSystem.EntityUtils
{
    public class GenericEntity
    {
        private readonly LibraryContext _db;

        public GenericEntity(LibraryContext db)
        {
            _db = db;
        }

        public async Task CreateEntityAsync<T>(T entity) where T : class
        {
            try
            {
                _db.Set<T>().Add(entity);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new EntityOperationException("Error creating entity.", ex);
            }
        }

        public async Task<T> ReadEntityAsync<T>(object key) where T : class
        {
            try
            {
                return await _db.Set<T>().FindAsync(key);
            }
            catch (Exception ex)
            {
                throw new EntityOperationException("Error reading entity.", ex);
            }
        }

        public async Task UpdateEntityAsync<T>(T entity) where T : class
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new EntityOperationException("Error updating entity.", ex);
            }
        }
        public async Task DeleteEntityAsync<T>(T entity) where T : class
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var entry = db.Entry(entity);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Set<T>().Attach(entity);
                    }

                    db.Set<T>().Remove(entity);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new EntityOperationException("Error deleting entity.", ex);
            }
        }


        public async Task<List<T>> GetAllEntitiesAsync<T>() where T : class
        {
            try
            {
                return await _db.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new EntityOperationException("Error getting all entities.", ex);
            }
        }
    }
}
