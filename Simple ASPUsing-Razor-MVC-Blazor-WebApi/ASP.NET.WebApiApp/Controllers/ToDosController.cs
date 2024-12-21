using ASP.NET.WebApiApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.WebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        [HttpGet]
        public IActionResult index()
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


            return Ok(ToDos);
        }


    }
}
