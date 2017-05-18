using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using RVHD.Models;
using RVHD.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RVHD.Models.AccountViewModels;

namespace RVHD.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Member> _userManager;
        private readonly SignInManager<Member> _signInManager;
        private readonly ICategories _categoryContext;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;
        private readonly string _externalCookieScheme;

        public HomeController(
            UserManager<Member> userManager,
            SignInManager<Member> signInManager,
            IOptions<IdentityCookieOptions> identityCookieOptions,
            IEmailSender emailSender,
            ISmsSender smsSender,
            ILoggerFactory loggerFactory,
            ICategories cateogoryContext
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _externalCookieScheme = identityCookieOptions.Value.ExternalCookieAuthenticationScheme;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
            _categoryContext = cateogoryContext;
        }
       
        public IActionResult Index()
        {
            ViewData["Category"] = _categoryContext.GetAll();
            return View();
        }
        [Route("/ve-chung-toi")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/lien-he")]
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
