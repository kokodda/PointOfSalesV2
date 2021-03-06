﻿using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNet.OData;

namespace PointOfSalesV2.Repository
{
  public interface  IBase
    {
    }

    public interface IBase<T> : IBase
      where T : class, ICommonData, new()
    {
        Result<T> Add(T entity);
        void AddRange(IEnumerable<T> entities);

        Result<T> Remove(T entity);

        Result<T> Remove(long id);

        Result<T> Update(T entity);

        Result<T> GetAll(string sortExpression = null);

        IPagedList<T> GetPaged(int startRowIndex, int pageSize, string sortExpression = null);
        PageResult<T> GetPagedNew(int startRowIndex, int pageSize, string sortExpression = null);

        Result<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        IEnumerable<TResult> GetAll<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        int GetCount<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null);

        IPagedList<T> GetPaged(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null);

        IPagedList<TResult> GetPaged<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null);

        Result<T> Get(long id);

        Result<T> Get(Guid id);

        TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null);

        bool Exists(long id);

        bool Exists(Func<IQueryable<T>, IQueryable<T>> query, Expression<Func<T, bool>> filter = null);
    }
}
