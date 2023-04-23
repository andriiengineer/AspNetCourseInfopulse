using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HW4.Pages
{
    public class MyHobbies : PageModel
    {

        public List<Hobby> Hobbies = new List<Hobby>()
        {
            new Hobby
            {
                Id = 1,
                Name = "Cooking",
                Desciption = "This hobby involves preparing and cooking food. It can range from simple meals to complex dishes, and can involve different techniques and ingredients.",
                Involved = InvolvementLevel.Low
            },
            new Hobby
            {
                Id = 2,
                Name = "Car",
                Desciption = "This hobby involves a love of automobiles. It can include working on cars, collecting cars, attending car shows, and even driving cars on racetracks.",
                Involved = InvolvementLevel.High
            },
            new Hobby
            {
                Id = 3,
                Name = "Mobile development",
                Desciption = "This hobby involves the creation of mobile apps for smartphones and tablets. It includes designing and developing mobile apps, testing them, and deploying them to app stores.",
                Involved = InvolvementLevel.Medium
            }
        };

        private readonly ILogger<MyHobbies> _logger;

        public MyHobbies(ILogger<MyHobbies> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}