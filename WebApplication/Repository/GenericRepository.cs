﻿//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApplication.Repository
//{
//    public class GenericRepository<T> : IGenericRepository<T> where T : class
//    {
//        private readonly ApplicationDbContext context;
//        private DbSet<T> entities;
//        string errorMessage = string.Empty;
 
//        public GenericRepository(ApplicationDbContext context)
//        {
//            this.context = context;
//            entities = context.Set<T>();
//        }
//        public IEnumerable<T> GetAll()
//        {
//            return entities.AsEnumerable();
//        }
 
//        public T Get(long id)
//        {
//            return entities.SingleOrDefault(s => s.Id == id);
//        }
//        public void Insert(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Add(entity);
//            context.SaveChanges();
//        }
 
//        public void Update(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            context.SaveChanges();
//        }
 
//        public void Delete(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Remove(entity);
//            context.SaveChanges();
//        }
//        public void Remove(T entity)
//        {
//            if (entity == null)
//            {
//                throw new ArgumentNullException("entity");
//            }
//            entities.Remove(entity);           
//        }

//        public void Save()
//        {
//            context.SaveChanges();
//        }
//    }
//}