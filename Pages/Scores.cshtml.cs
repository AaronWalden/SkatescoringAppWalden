using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class ScoresModel : PageModel
    {
        private readonly ILogger<ScoresModel> _logger;

        public ScoresModel(ILogger<ScoresModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
