using Microsoft.AspNetCore.Mvc;
using SweetsTreats.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace SweetsTreats.Controllers
{
    public class HomeController : Controller
    {
      private readonly SweetsTreatsContext _db;

      public HomeController(SweetsTreatsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Treats = _db.Treats.ToList();
        ViewBag.Flavors = _db.Flavors.ToList();
        return View();
      }

    }
}