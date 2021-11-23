using System;
using System.Linq;
using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository 
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Category category)
        {
            var objfromdb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if(objfromdb != null)
            {
                objfromdb.Name = category.Name;
                _db.SaveChanges();
            }
           
        }
    }
}
