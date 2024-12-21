using ASP.NET.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.MVC.Controllers
{
    public class ToDosController : Controller
    {
        public IActionResult Index()
        {

           var ToDos = new List<ToDo>()
                {
                new ToDo()
                {
                    Id=0,
                    Description="First To To",
                    IsCompleted=true
                },
                new ToDo()
                {
                    Id=1,
                    Description="Second To To",
                    IsCompleted=true
                },
                new ToDo()
                {
                    Id=2,
                    Description="Third To To",
                    IsCompleted=true
                },
                new ToDo()
                {
                    Id=3,
                    Description="Fourth To To",
                    IsCompleted=true
                },
                new ToDo()
                {
                    Id=4,
                    Description="Fifth To To",
                    IsCompleted=true
                }
            };


            return View(ToDos);
        }
    }



}
