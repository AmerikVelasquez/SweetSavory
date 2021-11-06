using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetSavory.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetSavory.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SweetSavoryContext _db;
    private readonly UserManager <ApplicationUser> _userManager;
    public TreatsController(UserManager <ApplicationUser> userManager, SweetSavoryContext db)
    {
      _userManager = userManager; 
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }
  }
}