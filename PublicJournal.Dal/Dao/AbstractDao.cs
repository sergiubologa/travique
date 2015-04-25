using PublicJournal.Dal.Contracts;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace PublicJournal.Dal.Dao
{
    public class AbstractDao<T> : IDao<T> where T :class
    {
        protected IObjectContext _objectContext;
        protected ObjectSet<T> _objectSet;

        public AbstractDao(IObjectContext objectContext)
        {
            _objectContext = objectContext;
            _objectSet = objectContext.CreateObjectSet<T>();
        }

        /// <summary>
        /// Delete enetity from context
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            _objectSet.DeleteObject(entity);
        }

        /// <summary>
        /// Add newly created entity to current context 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(T entity)
        {
            _objectSet.AddObject(entity);
        }

        /// <summary>
        /// Attach an entity to the context
        /// </summary>
        /// <param name="entity"></param>
        public void Attach(T entity)
        {
            _objectSet.Attach(entity);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _objectSet;
        }

        public void SaveContext()
        {
            _objectContext.SaveChanges();
        }
    }
}
