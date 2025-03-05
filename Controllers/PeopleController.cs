using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical2_u23708795.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult PeopleView()
        {
            List<Models.People> students = new List<Models.People>();
            {
                students.Add(new Models.People { StudentNumber = 23708795, FirstName = "John", LastName = "Doe", Email = "john.doe@tuks.co.za", MyLink = "~/HTML/Person3Page.html" });
                students.Add(new Models.People { StudentNumber = 12345678, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@tuks.co.za", MyLink = "~/HTML/Person2Page.html" });
                students.Add(new Models.People { StudentNumber = 01234567, FirstName = "Jose", LastName = "Edu", Email = "jose@tuks.co.za", MyLink = "~/HTML/Person1Page.html" });
                students.Add(new Models.People { StudentNumber = 18345689, FirstName = "Jeff", LastName = "Rizal", Email = "jeff@gmail.com", MyLink = "~/HTML/Person4Page.html" });
                students.Add(new Models.People { StudentNumber = 28658477, FirstName = "Andres", LastName = "Bonifacio", Email = "Andres@gmail.com", MyLink = "~/HTML/Person5Page.html" });


                return View(students);
            }
        }

  
        
    }
}