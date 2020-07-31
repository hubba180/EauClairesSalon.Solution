using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Salon.Controllers
{
  public class ClientController : Controllers
  {
  private readonly SalonContext _db;
    public ClientController()
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Clients.ToList();
      return View(model);
    }
  }
}