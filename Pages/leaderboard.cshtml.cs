using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class leadermodel : PageModel
    {
        private readonly ILogger<leadermodel> _logger;

        public leadermodel(ILogger<leadermodel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
