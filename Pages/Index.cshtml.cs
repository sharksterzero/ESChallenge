using ESChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace ESChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        [RegularExpression(@"^\d{1,4}(\.\d{1,4})?(\.\d{1,4})?$",
         ErrorMessage = "Software version must follow this format: [major version].[minor version].[patch] " +
            "Each number part may not exceed four digits.")]
        public string VersionInput { get; set; }

        public IActionResult OnPost()
        {
            if (String.IsNullOrEmpty(VersionInput))
            {
                return Page();
            }

            if (Regex.IsMatch(VersionInput, @"^\d{1,4}(\.\d{1,4})?(\.\d{1,4})?$"))
            {
                var version = VersionInput.Contains('.') ? new Version(VersionInput) : new Version(VersionInput + ".0");

                ViewData["Software"] = SoftwareManager.GetAllSoftware().Where(x => new Version(x.Version).CompareTo(version) > 0);
            }

            return Page();
        }
    }
}