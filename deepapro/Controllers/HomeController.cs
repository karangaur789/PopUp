
using deepapro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace deepapro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Employeee> objCatlist = new List<Employeee>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        Employeee obj = new Employeee();

        

        public IActionResult Index()
        {
            Employeee obj = new Employeee();
            obj.id = 1;
            obj.ChkListType = 1;
            obj.NameCheckList = "namechklis1";
            obj.DisplayName = "Kaabdis";
            obj.TaskName = "dsaasdtask";
            obj.Descrription = "aaddDescription";
            obj.Priority = "dasadPro";
            obj.TaskOwner = 1;
            obj.CheckListStaus = true;
            objCatlist.Add(obj);
            return View(objCatlist);
            
        }
      
        public IActionResult Create(Employeee empobj)
        {
            objCatlist.Add(empobj);
           return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}