using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPdotNETCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPdotNETCoreApp.Controllers
{
    public class EmployeeController : Controller
    {
        //some default text is changed by me.
        //public IActionResult Index()

        //and then later you commented this out and did something new, below.
        /*
        public string Index()
        {
            //return View();
            return "This string is from the employee controller.";
            //you'll see the return value if you type /employee at the end of your URL
        }
        */

        //the new new thing, much like the default code
        //this looks familiar, from your .net MVC days!
        public ActionResult Index()
        {
            var E = new Employee() { Eid = 1, EmpName = "Mike" };

            return View(E);
            //supposedly you can right click View and you get the option to add a view
            //but I don't get that option, so I'll do it manually in the solution
        }
    }
}