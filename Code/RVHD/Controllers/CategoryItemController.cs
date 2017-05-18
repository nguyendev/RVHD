using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVHD.Data;
using RVHD.Models.CategoryViewModels;
using RVHD.Services;

namespace RVHD.Controllers
{
    public class CategoryItemController : Controller
    {
        private readonly ICategoryItems _context;

        public CategoryItemController(ICategoryItems context)
        {
            _context = context;
        }
        [Route("/{category}/{categorySub}/")]
        public IActionResult GetAds(string category, string categorySub)
        {
            ViewData["Lastes"] = _context.GetLastes(categorySub);
            ViewData["Random"] = _context.GetRandom(categorySub);
            ViewData["Popular"] = _context.GetPopular(categorySub);
            return View();
        }
    }
}