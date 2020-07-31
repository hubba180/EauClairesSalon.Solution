using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Salon.Controllers
{
  public class StylistController : Controller
  {
    public StylistController()
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Stylists.ToList();
      return View(model);
    }
  }
}