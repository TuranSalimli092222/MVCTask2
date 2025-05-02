using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTask2.DAL;
using MVCTask2.Models;

namespace MVCTask2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Doctor> Doctors;

            Doctors = _context.Doctors.Include(d => d.Department).ToList();
            return View(Doctors);
        }
    }
}
