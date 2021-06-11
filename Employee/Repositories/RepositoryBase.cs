using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Employee.Repositories
{
    //public abstract class RepositoryBase<T> : IRepository<T> where T : class
    //{
    //    private ApplicationDbContext dataContext;
    //    private DbSet<T> dbset;
    //    IDatabaseFactory databaseFactory;
    //    protected RepositoryBase(IDatabaseFactory dbFactory)
    //    {
    //        this.databaseFactory = dbFactory;
    //        dbset = (DbSet<T>)DataContext.Set<T>();
    //    }
    //    protected ApplicationDbContext DataContext
    //    {
    //        get { return dataContext = databaseFactory.DataContext; }
    //    }
    //    public virtual void Add(T entity)
    //    {
    //        dbset.Add(entity);
    //    }
    //    public virtual void Update(T entity)
    //    {
    //        dbset.Attach(entity);
    //        dataContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //    }
    //    public virtual void Delete(T entity)
    //    {
    //        dbset.Remove(entity);
    //    }
    //    public virtual void Delete(Expression<Func<T, bool>> where)
    //    {
    //        IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
    //        foreach (T obj in objects) dbset.Remove(obj);
    //    }
    //    public virtual T GetById(int id)
    //    {
    //        return dbset.Find(id);
    //    }
    //    public virtual T GetById(string id)
    //    {
    //        return dbset.Find(id);
    //    }
    //    public virtual IQueryable<T> GetAll()
    //    {
    //        return dbset;
    //    }
    //    public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
    //    {
    //        return dbset.Where(where);
    //    }
    //    public T Get(Expression<Func<T, bool>> where)
    //    {
    //        return dbset.Where(where).FirstOrDefault<T>();
    //    }
    //}
}
