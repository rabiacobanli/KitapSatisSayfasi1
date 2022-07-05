using Microsoft.AspNetCore.Mvc;
using KitapSatisSayfasi.Data;
using KitapSatisSayfasi.Models;
namespace KitapSatisSayfasi.Controllers
{
    public class KitapController : Controller
    {
        ApplicationDbContext _db;
        public KitapController(ApplicationDbContext db)
        {
            _db=db;
          // db.Database.EnsureDeleted();//Önce database varsa sil
          // db.Database.EnsureCreated();//sonra ekle
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
