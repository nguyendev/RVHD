using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RVHD.Models;
using RVHD.Data;
using RVHD.Models.CategoryViewModels;

namespace RVHD.Services
{
    public class CategoryItemsRepository : ICategoryItems
    {
        protected readonly ApplicationDbContext _context;

        public CategoryItemsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Add(CategoryItemViewModel model)
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

        public Task<CategoryItemViewModel> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryItemViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CategoryItemViewModel> GetLastes(string slug)
        {
            var categoryDbContext = _context.CategoryItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Slug == slug);
            IEnumerable<CategoryItemViewModel> model = null;
            var itemEntities = categoryDbContext.Select(x => new CategoryItemViewModel()
            {
                ID = x.ID,
                Ci_Des = x.Ci_Des,
                Ci_Name = x.Ci_Name,
                Icon = x.Icon,
                //Color = x.
                Slug = x.Slug,
                OrderNo = x.OrderNo,
                ListCategorySubItems = _context.CategorySubItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Cs_Id == x.ID).ToList(),
                ListAds = _context.Ads.OrderBy(p=>p.Publish_DT).Where(p => p.Auth_status == "1" && p.CategoriesItemId == x.ID).ToList(),
            });
            model = itemEntities;
            return model.ToList();
        }

        public List<CategoryItemViewModel> GetPopular(string slug)
        {
            var categoryDbContext = _context.CategoryItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Slug == slug);
            IEnumerable<CategoryItemViewModel> model = null;
            var itemEntities = categoryDbContext.Select(x => new CategoryItemViewModel()
            {
                ID = x.ID,
                Ci_Des = x.Ci_Des,
                Ci_Name = x.Ci_Name,
                Icon = x.Icon,
                //Color = x.
                Slug = x.Slug,
                OrderNo = x.OrderNo,
                ListCategorySubItems = _context.CategorySubItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Cs_Id == x.ID).ToList(),
                ListAds = _context.Ads.OrderBy(p => p.Publish_DT).Where(p => p.Auth_status == "1" && p.CategoriesItemId == x.ID).ToList(),
            });
            model = itemEntities;
            return model.ToList();
        }

        public List<CategoryItemViewModel> GetRandom(string slug)
        {
            var categoryDbContext = _context.CategoryItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Slug == slug);
            IEnumerable<CategoryItemViewModel> model = null;
            var itemEntities = categoryDbContext.Select(x => new CategoryItemViewModel()
            {
                ID = x.ID,
                Ci_Des = x.Ci_Des,
                Ci_Name = x.Ci_Name,
                Icon = x.Icon,
                //Color = x.
                Slug = x.Slug,
                OrderNo = x.OrderNo,
                ListCategorySubItems = _context.CategorySubItems.OrderBy(p => p.OrderNo).Where(p => p.Auth_status == "1" && p.Cs_Id == x.ID).ToList(),
                ListAds = _context.Ads.Where(p => p.Auth_status == "1" && p.CategoriesItemId == x.ID).ToList(),
            });
            model = itemEntities;
            return model.ToList();
        }

        public Task Update(CategoryItemViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
