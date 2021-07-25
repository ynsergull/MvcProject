using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.Repositories
{
    public interface ICategoryDal:IRepository<Category>
    {
        List<Category> List();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
