using ecommerce.Common.Entities;
using ecommerce.Web.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ecommerce.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddOrEdit(User user)
        {
            if (user.IdUser == 0)
            {
                _context.Add(user);
            }
            else
            {
                _context.Update(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
