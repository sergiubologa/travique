using PublicJournal.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Dal
{
    public class PublicJournalDataContext : ObjectContext, IObjectContext, IDisposable
    {
        public PublicJournalDataContext()
            : base("name= TraviqueEntities", "TraviqueEntities")
            {
                this.ContextOptions.LazyLoadingEnabled = true;
            }
    }
}
