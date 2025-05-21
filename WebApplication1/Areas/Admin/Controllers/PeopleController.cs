using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccessLayer;
using WebApplication1.Models;
using WebApplication1.ViewModels.PersonViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonCreateVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            if(vm.Image.Length*1024*1024>2)
            {
                ModelState.AddModelError("Image", "Image 2 mb-dan cox ola bilmez.");
                    return View(vm);
            }
            if (!vm.Image.Contenttype.Contains("image"))
            {
                ModelState.AddModelError("image", "yalniz sekil formatinda sekil daxil ede bilersiniz.");
            }

        }
       

            
    }
}
