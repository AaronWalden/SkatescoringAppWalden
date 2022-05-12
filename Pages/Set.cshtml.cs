using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class Setmodel : PageModel
    {
        private readonly ILogger<Setmodel> _logger;

        public Setmodel(ILogger<Setmodel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
