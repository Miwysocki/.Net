using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BMI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty ]
        public Person user { get; set; }
        [BindProperty(SupportsGet = true)]
        public float bmi { get; set; }
        public void OnGet()
        {

        }
                 
        public  IActionResult OnPost()
        {
            user.height = float.Parse(Request.Form["height"]);
            user.weight = float.Parse(Request.Form["weight"]);

            if (ModelState.IsValid == false)
            {
                return Page();
            }

            if (Request.Form["Male"] == "on") user.gender = "Male";
            if (Request.Form["Female"] == "on") user.gender = "Female";
            if (Request.Form["Other"] == "on") user.gender = "Other";
            if (Request.Form["unit"] == "centimeters") user.height = user.height / 100;
            bmi = user.weight / (user.height * user.height);

            return RedirectToPage("/Result", new { user.fname, user.lname,  user.mail,  user.age ,user.gender,bmi});//
        }
        
    }
}
