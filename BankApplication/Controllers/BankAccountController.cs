using Microsoft.AspNetCore.Mvc;

namespace BankApplication.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
