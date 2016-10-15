using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication.Controllers

{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

       /* public string Index()
        {
            return "This is my default action from Controller";
        }*/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

    public string Welcome(string name="Finlay", int numTimes = 55)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");
        }
    }
}