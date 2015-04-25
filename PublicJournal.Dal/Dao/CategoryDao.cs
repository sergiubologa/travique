using PublicJournal.Dal.Contracts;
using PublicJournal.Dal.Dao;
using PublicJournal.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace PublicJournal.Dal.Dao
{
    public class CategoryDao : AbstractDao<Category>, ICategoryDao
    {
        public CategoryDao(IObjectContext objectContext)
            : base(objectContext)
        {
        }

        public Category GetCategory(int id)
        {
            var query = from obj in _objectSet 
                        where obj.Id == id                        
                        select obj;           
            return query.SingleOrDefault();
        }

        public List<Category> GetListCategories()
        {
            var query = from obj in _objectSet                        
                        select obj;
            return query.ToList();
        }              
    }
}
