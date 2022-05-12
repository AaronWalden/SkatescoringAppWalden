using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class Spreadmodel : PageModel
    {
        private readonly ILogger<Spreadmodel> _logger;

        public Spreadmodel(ILogger<Spreadmodel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
