﻿using System.Linq.Expressions;

namespace ITBlog.DataAccess.RepositoryFolder
{
    public partial interface IRepository<T> where T : class, new()
    {
        /// <summary>
        /// Get Entities by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(Guid id);

        /// <summary>
        /// Get All Information of entities
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// To Insert Entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// To Insert Entities
        /// </summary>
        /// <param name="entities"></param>
        void Insert(IEnumerable<T> entities);

        /// <summary>
        /// To Update Entity
        /// </summary>
        /// <param name="entity"></param>
        int Update(T entity);

        /// <summary>
        /// Update Entities
        /// </summary>
        /// <param name="entities"></param>
        void Update(IEnumerable<T> entities);

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Delete Entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<T> entities);

        /// <summary>
        /// To make linq oparation in datas
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        /// To Query Filter
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includedProperties"></param>
        /// <returns></returns>
        List<T> Query(Expression<Func<T, bool>> predicate, string includedProperties);

    }
}
