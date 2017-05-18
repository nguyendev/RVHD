using RVHD.Models.CategoryViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVHD.Services
{
    public interface ICategoryItems
    {
        Task<CategoryItemViewModel> Get(int? id);
        bool Exists(int id);
        Task<List<CategoryItemViewModel>> GetAll();
        List<CategoryItemViewModel> GetLastes(string slug);
        List<CategoryItemViewModel> GetPopular(string slug);

        List<CategoryItemViewModel> GetRandom(string slug);
        Task Add(CategoryItemViewModel model);
        Task Update(CategoryItemViewModel model);
        Task Delete(int id);
    }
}
