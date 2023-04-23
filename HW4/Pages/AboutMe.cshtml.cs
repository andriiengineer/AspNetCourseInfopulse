using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HW4.Pages
{
    public class AboutMe : PageModel
    {
        private readonly ILogger<AboutMe> _logger;

        public AboutMe(ILogger<AboutMe> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}