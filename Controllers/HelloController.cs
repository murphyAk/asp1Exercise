using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace asp1.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        //GET: /<controllers>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<form method = 'post' action='/helloworld/'>" 
                + "<input type = 'text' name = 'name' />" 
                + "<input type = 'submit' value = 'Greet Me!' />" 
                + "<select name='language'> <option>English</option> <option>French</option> <option>Spanish</option> <option>Czech</option> <option>German</option> </select>"
                + "</form>";
            return Content(html, "text/html");
        }


        // GET
        //[HttpGet("welcome/{name?}")]
        [HttpPost]
        [Route("/helloworld/")]
        public IActionResult CreateMessage(string name = "World", string language = "English")
        {
            if(language == "French")
            {
                return Content("<h1>Bonjour, " + name + "! </h1>", "text / html");
            }
            if (language == "Spanish")
            {
                return Content("<h1>Hola, " + name + "! </h1>", "text / html");
            }
            if (language == "Czech")
            {
                return Content("<h1>Ahoj, " + name + "! </h1>", "text / html");
            }            
            if (language == "German")
            {
                return Content("<h1>Hallo, " + name + "! </h1>", "text / html");
            }
            else
            {
                return Content("<h1>Hello, " + name + "! </h1>", "text / html");
            }
        }
    }
}
