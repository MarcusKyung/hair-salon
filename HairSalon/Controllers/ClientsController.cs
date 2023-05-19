using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                                  .Include(client => client.Stylist)
                                  .OrderBy(client => client.Stylist.StylistName) //added code to order by ascending
                                  .ToList();
      ViewBag.PageTitle = "View All Clients";                     
      return View(model);
    }
  }
}