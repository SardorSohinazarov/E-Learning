using E_Learning.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCoursesAsync()
        {
            return Ok(new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "C# (CSharp)",
                    Description = "C# tili va uning afzalliklari haqida va c# yordamida .NET muhitida web ilovalar ishlab chiqishni o'rganamiz.",
                    PhotoPath = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png",
                },
                new Course()
                {
                    Id = 2,
                    Name = "Blazor",
                    Description = ".NET ning Blazor frameworki yordamida web UI ilovalar qurishni o'rganamiz.",
                    PhotoPath = "https://upload.wikimedia.org/wikipedia/commons/d/d0/Blazor.png",
                },
                new Course()
                {
                    Id = 3,
                    Name = "C# (CSharp)",
                    Description = ".NET ning MAUI frameworki yordamida Mobile va Desktop ilovalar qurishni o'rganamiz.",
                    PhotoPath = "https://res.cloudinary.com/practicaldev/image/fetch/s--AfyjCwg8--/c_imagga_scale,f_auto,fl_progressive,h_1080,q_auto,w_1080/https://dev-to-uploads.s3.amazonaws.com/uploads/articles/8t7d1l3c6s14czmwuknl.png",
                },
            });
        }
    }
}
