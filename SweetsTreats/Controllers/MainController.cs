using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetsTreats.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace SweetsTreats.Controllers
{
  public class MainController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}