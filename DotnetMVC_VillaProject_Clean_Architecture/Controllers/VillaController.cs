using Microsoft.AspNetCore.Mvc;
using Villa.Domain.Entities;
using Villa.Infrastructure.Data;

namespace DotnetMVC_VillaProject_Clean_Architecture.Controllers
{

    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var villas=_db.Villas.ToList();
            return View(villas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VillaTable obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("name", "The description cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Villas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Villa");
            }
            return View();

        }
        public IActionResult Update(int villaId)
        {
            VillaTable obj=_db.Villas.FirstOrDefault(u=>u.Id==villaId);
            if(obj== null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(VillaTable obj)
        {
            if (ModelState.IsValid && obj.Id > 0)
            {

                _db.Update(obj);
                _db.SaveChanges();
               TempData["success"] = "The villa has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int villaId)
        {
            VillaTable? obj = _db.Villas.FirstOrDefault(u => u.Id == villaId);
            if(obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(VillaTable obj)
        {
            VillaTable? objFromDb = _db.Villas.FirstOrDefault(u=>u.Id==obj.Id);
            if (objFromDb is not null)
            {
                _db.Villas.Remove(objFromDb);   
                _db.SaveChanges();
                TempData["success"] = "The villa has been Deleted successfully.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The villa could not be deleted.";
            return View();
        }


    }
}
