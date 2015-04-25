using PublicJournal.Dal.Contracts;
using PublicJournal.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicJournal.Dal.Contracts
{
    public interface ICategoryDao:IDao<Category>
    {
        Category GetCategory(int id);
        List<Category> GetListCategories();        
    }
}