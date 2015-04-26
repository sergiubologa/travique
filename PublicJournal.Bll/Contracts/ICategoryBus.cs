using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicJournal.Models.Models;

namespace PublicJournal.Bll.Contracts
{
    public interface ICategoryBus
    {
        CategoryModel GetCategory(int id);
        List<CategoryModel> GetListCategories();
    }
}


 