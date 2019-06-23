using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.Pages
{
    public class CalculatorModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }

        [BindProperty]
        public int Total { get; set; }

        public void OnGet()
        {

        }
    }
}