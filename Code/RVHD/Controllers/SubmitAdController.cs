using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RVHD.Models;
using Microsoft.AspNetCore.Authorization;
using RVHD.Data;
using RVHD.Models.AdsViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RVHD.Controllers
{
    [Authorize]
    public class SubmitAdController : Controller
    {
        // GET: /<controller>/
        private readonly SignInManager<Member> _signInManager;
        private readonly ApplicationDbContext _context;
        public SubmitAdController(SignInManager<Member> signInManager, ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _context = context;
        }
        [Route("/dang-tin")]
        public IActionResult Index(int? category, int? categoryItem)
        {
            List<Categories> Category = new List<Categories>();
            Category = _context.Category.ToList();
            ViewBag.Category = Category;
            ViewBag.CategoryItem = "";
            if (category != null)
            {
                List<CategoryItems> CategoryItem = new List<CategoryItems>();
                CategoryItem = _context.CategoryItems.Where(p => p.Categories_Id == category).ToList();
                ViewBag.CategoryItem = CategoryItem;
            }
            return View();
        }
        [HttpGet]
        [Route("/dang-tin-moi/buoc-1")]
        public IActionResult SelectCategory(CategoryViewModel model, int? category, int? categoryItem)
        {  
            if (category != null)
            {
                List<Categories> Category = new List<Categories>();
                Category = _context.Category.ToList();
                ViewData["Category"] = new SelectList(Category, "ID", "CategoryName", model.CategoriesId);
                List<CategoryItems> CategoryItem = new List<CategoryItems>();
                CategoryItem = _context.CategoryItems.Where(p => p.Categories_Id == category).ToList();
                ViewData["CategoryItem"] = new SelectList(CategoryItem, "ID", "Ci_Name",model.CategoriesItemId);
                List<CategorySubItems> CategorySubItem = new List<CategorySubItems>();
                CategorySubItem = _context.CategorySubItems.Where(p => p.Cs_Id == categoryItem).ToList();
                ViewData["CategorySubItem"] = new SelectList(CategorySubItem, "ID", "Ci_Name", model.CategoriesSubItemId);
            }
            else
            {
                List<Categories> Category = new List<Categories>();
                Category = _context.Category.ToList();
                ViewData["Category"] = new SelectList(Category, "ID", "CategoryName");
                List<CategoryItems> CategoryItem = new List<CategoryItems>();
                CategoryItem = _context.CategoryItems.ToList();
                ViewData["CategoryItem"] = new SelectList(CategoryItem,"ID", "Ci_Name");
                List<CategorySubItems> CategorySubItem = new List<CategorySubItems>();
                CategorySubItem = _context.CategorySubItems.Where(p => p.Cs_Id == categoryItem).ToList();
                ViewData["CategorySubItem"] = new SelectList(CategorySubItem, "ID", "Ci_Name");
            }
            
            return View(model);
        }
        [HttpPost]
        [Route("/dang-tin-moi/buoc-1")]
        [ValidateAntiForgeryToken]
        public IActionResult SelectCategory([Bind("CategoriesId,CategoriesItemId,CategoriesSubItemId")] CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Session["customer"]
                return View("SelectPrice", new PriceViewModel { CategoriesId = model.CategoriesId, CategoriesItemId = model.CategoriesItemId, CategoriesSubItemId = model.CategoriesSubItemId });
            }
            return View(model);
        }
       

        [HttpPost]
        [Route("/dang-tin-moi/buoc-2")]
        
        [ValidateAntiForgeryToken]
        public IActionResult SelectPrice([Bind("AdTitle,AdDes,AdPrice,AdOldPrice")] PriceViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View("SelectOther", new AdsViewModel { CategoriesId = model.CategoriesId, CategoriesItemId = model.CategoriesItemId, CategoriesSubItemId = model.CategoriesSubItemId, AdTitle = model.AdTitle, AdPrice = model.AdPrice, AdOldPrice = model.AdOldPrice, AdDes = model.AdDes });
            }
            return View(model);
        }
        [HttpPost]
        [Route("/dang-tin-moi/buoc-3")]
        public IActionResult SelectOther(AdsViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}
