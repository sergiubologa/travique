using PublicJournal.Bll.Contracts;
using PublicJournal.Dal.Dao;
using PublicJournal.Models.Models;
using PublicJournal.Dal.Contracts;
using PublicJournal.Models.Converter;
using PublicJournal.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PublicJournal.Bll.Bus
{
    public class CategoryBus : ICategoryBus
    {
        private ICategoryDao _iCategoryDao;

        public CategoryBus(ICategoryDao iCategoryDao)
        {
            _iCategoryDao = iCategoryDao;
        }

        public CategoryModel GetCategory(int id)
        {
            Category category = _iCategoryDao.GetCategory(id);
            return CategoryConverter.ConvertToModel(category);
        }

        public List<CategoryModel> GetListCategories()
        {
            List<Category> listCategories = _iCategoryDao.GetListCategories();
            return listCategories.Select(x => CategoryConverter.ConvertToModel(x)).ToList();
        }
    }
}
