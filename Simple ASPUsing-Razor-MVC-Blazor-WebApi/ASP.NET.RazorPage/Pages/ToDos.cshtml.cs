using ASP.NET.RazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET.RazorPage.Pages
{
    public class ToDosModel : PageModel
    {
        public List<ToDo> ToDos { get; set; } = [];
        public void OnGet()
        {
            ToDos = new List<ToDo>()
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



        }
    }
}
