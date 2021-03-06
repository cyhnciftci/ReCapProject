﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (CarRentalDataBaseContext context = new CarRentalDataBaseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (CarRentalDataBaseContext context = new CarRentalDataBaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (CarRentalDataBaseContext context = new CarRentalDataBaseContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (CarRentalDataBaseContext context = new CarRentalDataBaseContext())
            {
                return filter == null ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
                
            }
        }

        public List<Product> GetAllById(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (CarRentalDataBaseContext context = new CarRentalDataBaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
