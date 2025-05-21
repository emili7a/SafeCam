using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccessLayer;
using WebApplication1.Models;
using WebApplication1.ViewModels.PersonViewModels;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PeopleController(SafeCamDbContext _context) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var People = await _context.People.Select(x => new PersonGetVM() { FullName = x.FullName, ImageUrl = x.ImageUrl, profession = x.profession, Id = x.Id }).ToListAsync();
            return View(People);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
