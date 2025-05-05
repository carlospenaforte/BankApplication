using Microsoft.AspNetCore.Mvc;
using BankApplication.Models;
using BankApplication.Data;

namespace BankApplication.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly DataContext _context;
        public BankAccountController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var account = new BankAccountModel()
            {
                Id_Account = 1,
                Amount = 1000.00,
                Id_User = 1,

            };
            return View();
        }
    }
}
