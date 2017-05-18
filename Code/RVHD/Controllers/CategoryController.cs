using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RVHD.Data;
using RVHD.Services;

namespace RVHD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategories _repository;

        public CategoryController(ICategories context)
        {
            _repository = context;
        }

        // GET: WebManager/Categories
        [Route("/danh-muc")]
        public IActionResult Index()
        {
            ViewData["Category"] = _repository.GetAll();
            return View();
        }
    }
}