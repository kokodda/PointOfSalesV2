using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNet.OData;
using PointOfSalesV2.Entities;

namespace PointOfSalesV2.Repository
{
    public abstract class Base<T, U> : IBase<T>
          where T : class, ICommonData, new()
          where U : DbContext
    {
        protected readonly U _Context;
        private readonly DbSet<T> _DbSet;

        public Base(U context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
        }

        public virtual T Add(T entity)
        {
            _Context.Set<T>().Add(entity);

            _Context.SaveChanges();

            return entity;
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().AddRange(entities);

            _Context.SaveChanges();


        }

        public virtual void Remove(T entity)
        {
            _DbSet.Attach(entity);
            _Context.Entry<T>(entity).State = EntityState.Deleted;

            _Context.SaveChanges();
        }

        public virtual void Remove(long id)
        {
            T entity = _DbSet.Find(id);

            _Context.Entry<T>(entity).State = EntityState.Deleted;
            _Context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            _DbSet.Attach(entity);
            _Context.Entry<T>(entity).State = EntityState.Modified;

            _Context.SaveChanges();

            return entity;
        }

        public virtual IEnumerable<T> GetAll(string sortExpression = null)
        {
            return _DbSet.AsNoTracking().OrderBy(sortExpression).ToList();
        }

        public virtual IPagedList<T> GetPaged(int startRowIndex, int pageSize, string sortExpression = null)
        {
            return new PagedList<T>(_DbSet.AsNoTracking(), startRowIndex, pageSize);
        }

        public virtual PageResult<T> GetPagedNew(int startRowIndex, int pageSize, string sortExpression = null)
        {
            return new PageResult<T>(_DbSet, new Uri("https://localhost:44383/api/products/2/2"), _DbSet.Count());
        }

        public virtual IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.ToArray().ToList();
        }

        public virtual IEnumerable<TResult> GetAll<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.ToArray().ToList();
        }

        public int GetCount<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            return transform(query).Count();
        }

        public virtual IPagedList<T> GetPaged(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return new PagedList<T>(sortedResults, startRowIndex, pageSize);
        }

        public virtual IPagedList<TResult> GetPaged<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return new PagedList<TResult>(sortedResults, startRowIndex, pageSize);
        }

        public virtual T Get(long id)
        {
            return _DbSet.Find(id);
        }

        public virtual T Get(Guid id)
        {
            return _DbSet.Find(id);
        }

        public virtual TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet : _DbSet.Where(filter);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.FirstOrDefault();
        }
        public virtual bool Exists(long id)
        {
            return _DbSet.Find(id) != null;
        }

        public virtual bool Exists(Func<IQueryable<T>, IQueryable<T>> selector, Expression<Func<T, bool>> filter = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var result = selector(query);

            return result.Any();
        }
    }
}
