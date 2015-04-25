using System;
using System.Data.Entity.Core.Objects;

namespace PublicJournal.Dal.Contracts
{
    public interface IObjectContext : IDisposable
    {
        ObjectSet<T> CreateObjectSet<T>() where T : class;
        ObjectResult<T> ExecuteFunction<T>(string functionName, params ObjectParameter[] parameters);
        ObjectQuery<T> CreateQuery<T>(string queryString, params ObjectParameter[] parameters);
        ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters);
        int SaveChanges();
    }
}
