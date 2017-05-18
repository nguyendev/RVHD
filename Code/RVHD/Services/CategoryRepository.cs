using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RVHD.Models.CategoryViewModels;
using RVHD.Data;

namespace RVHD.Services
{
    public class CategoryRepository : ICategories
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryViewModel> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            var categoryDbContext = _context.Category.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1");
            IEnumerable<CategoryViewModel> model = null;
            var categoryEntities = categoryDbContext.Select(x => new CategoryViewModel()
            {
                ID = x.ID,
                CategoryDes = x.CategoryDes,
                CategoryName = x.CategoryName,
                Color = x.Color,
                Icon = x.Icon,
                Slug = x.Slug,
                OrderNo = x.OrderNo,
                ListCategoryItems = _context.CategoryItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Categories_Id == x.ID).ToList()
            });
            model = categoryEntities;
            return model.ToList();
        }

        public Task Update(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
