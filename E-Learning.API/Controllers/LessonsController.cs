using E_Learning.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLesson(int id)
        {
            return Ok(new Lesson()
            {
                Id = new Random().Next(1, 1000),
                Name = ".Net nima?",
                Description = @".NET is a free, cross-platform, open source developer platform for building many different types of applications.
                        With .NET, you can use multiple languages, editors, and libraries to build for web, mobile, desktop, games, IoT, and more.",

                YoutubeVideoPath = "https://youtu.be/0hijEaQYEtU?si=9J4Y3ELm3iLiE7Ml",
                Contents = new List<Content>
                {
                    new Content()
                    {
                        Id = new Random().Next(1,100),
                        Title = @"Languages",
                        Description = @"You can write .NET apps in C#, F#, or Visual Basic.
                                        C# is a simple, modern, object-oriented, and type-safe programming language.
                                        F# is a programming language that makes it easy to write succinct, robust, and performant code.
                                        Visual Basic is an approachable language with a simple syntax for building type-safe, object-oriented apps.",
                        ImagePath = "https://dotnet.microsoft.com/static/images/redesign/shared/languages.svg"
                    },
                    new Content()
                    {
                        Id = new Random().Next(1,100),
                        Title = "Cross Platform",
                        Description = @"Whether you're working in C#, F#, or Visual Basic, your code will run natively on any compatible operating system. You can build many types of apps with .NET. Some are cross-platform, and some target a specific set of operating systems and devices.",
                        ImagePath = "https://dotnet.microsoft.com/static/images/redesign/learn/what-is-dotnet/cross-platform.svg"
                    },
                    new Content()
                    {
                        Id = new Random().Next(1,100),
                        Title = "Libraries",
                        Description = @"To extend functionality, Microsoft and others maintain a healthy .NET package ecosystem.
                                        NuGet is a package manager built specifically for .NET that contains over 100,000 packages.",
                        ImagePath = "https://dotnet.microsoft.com/static/images/redesign/learn/what-is-dotnet/packages.svg"
                    },
                    new Content()
                    {
                        Id = new Random().Next(1,100),
                        Code = @"
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(""Hello, World!"");
    }
}
",
                        Title = "Hello World Dasturi",
                        Description = @"Birinchi .net appingiz",
                    },
                },
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetLessonAsync()
        {
            return Ok(new List<LessonDTO>{
                new LessonDTO()
                {
                    Id = 1,
                    Name = ".Net ga kirish"
                },
                new LessonDTO()
                {
                    Id = 2,
                    Name = "C# da o'zgaruvchilar"
                },
                new LessonDTO()
                {
                    Id = 3,
                    Name = "C# operatorlar"
                },
                new LessonDTO()
                {
                    Id = 4,
                    Name = "If Shart operator"
                },
                new LessonDTO()
                {
                    Id = 5,
                    Name = "Switch Tanlash operatori"
                },
                new LessonDTO()
                {
                    Id = 6,
                    Name = "For takrorlash sikli"
                },
                new LessonDTO()
                {
                    Id = 7,
                    Name = "While(),Do While() takrorlash sikli"
                },
                new LessonDTO()
                {
                    Id = 8,
                    Name = "C# String funksiyalari"
                },
                new LessonDTO()
                {
                    Id = 9,
                    Name = "C# Array"
                },
                new LessonDTO()
                {
                    Id = 10,
                    Name = "C# Funksiya"
                },
            });
        }
    }
}
