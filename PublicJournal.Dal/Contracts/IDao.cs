using System.Collections.Generic;

namespace PublicJournal.Dal.Contracts
{
    public interface IDao<T>
    {
        void Delete(T entity);

        void Add(T entity);

        void Attach(T entity);

        IEnumerable<T> GetAll();

        void SaveContext();

        
    }
}
