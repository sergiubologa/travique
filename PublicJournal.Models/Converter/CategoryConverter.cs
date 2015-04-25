using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PublicJournal.Models.Models;
using PublicJournal.Dal;
using PublicJournal.Dal.Dao;


namespace PublicJournal.Models.Converter
{
    public static class CategoryConverter
    {
        public static CategoryModel ConvertToModel(Category category)
        {
            CategoryModel categoryModel = new CategoryModel()
            {
                Id = category.Id,
                Name = category.Name,
                ImageName = category.ImageName,
                Description = category.Description
            };
            return categoryModel;
        }
    }
}

