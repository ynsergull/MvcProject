using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
   public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAdd(Category category)
        {
            if(category.CategoryName == "" || category.CategoryName.Length<=3 ||
               category.CategoryDescription == "" || category.CategoryName.Length>=51)
            {
                //hata
            }
            else
            {
                repo.Insert(category);
            }
        }
    }
}
