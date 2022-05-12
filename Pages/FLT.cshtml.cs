using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class FLTmodel : PageModel
    {
        private readonly ILogger<FLTmodel> _logger;

        public FLTmodel(ILogger<FLTmodel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
