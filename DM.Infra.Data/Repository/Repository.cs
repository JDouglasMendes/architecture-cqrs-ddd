﻿using DM.Domain.Contracts;
using DM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly InfraDataContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public Repository(InfraDataContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public virtual void Add(TEntity obj) => DbSet.Add(obj);        
        public virtual TEntity GetById(Guid id) => DbSet.Find(id);        
        public virtual IQueryable<TEntity> GetAll() => DbSet;        
        public virtual void Update(TEntity obj) => DbSet.Update(obj);       
        public virtual void Remove(Guid id) => DbSet.Remove(DbSet.Find(id));       
        public int SaveChanges() => Db.SaveChanges();        
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
