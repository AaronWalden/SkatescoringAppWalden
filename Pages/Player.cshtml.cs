﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkatingScoringApp.Pages
{
    public class PlayerModel : PageModel
    {
        private readonly ILogger<PlayerModel> _logger;

        public PlayerModel(ILogger<PlayerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
