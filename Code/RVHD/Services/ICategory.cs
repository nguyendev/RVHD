using RVHD.Models.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVHD.Services
{
    public interface ICategories
    {
        Task<CategoryViewModel> Get(int? id);
        bool Exists(int id);
        List<CategoryViewModel> GetAll();
        Task Add(CategoryViewModel model);
        Task Update(CategoryViewModel model);
        Task Delete(int id);
    }
}
