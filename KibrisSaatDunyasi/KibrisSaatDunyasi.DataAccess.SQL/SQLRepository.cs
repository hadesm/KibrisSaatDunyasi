using KibrisSaatDunyasi.Core.Contracts;
using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.DataAccess.SQL
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal DataContext context;
        internal DbSet<T> dbSET;

        public SQLRepository(DataContext context)
        {
            this.context = context;
            this.dbSET = context.Set<T>();
        }
        public IQueryable<T> Collection()
        {
            return dbSET;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(string Id)
        {
            var t = Find(Id);
            if (context.Entry(t).State == EntityState.Detached)
                dbSET.Attach(t);

            dbSET.Remove(t);
        }

        public T Find(string Id)
        {
          
            return dbSET.Find(Id);

        }

        public void Insert(T t)
        {
            dbSET.Add(t);
        }

        public void Update(T t)
        {
            dbSET.Attach(t);
            context.Entry(t).State = EntityState.Modified;
        }
    }
}
