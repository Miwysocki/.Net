using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMI
{
    public class ResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string fname { get; set; }
        [BindProperty (SupportsGet = true)]
        public string lname { get; set; }
        [BindProperty(SupportsGet = true)]
        public string mail{ get; set; }
        [BindProperty(SupportsGet = true)]
        public int age{ get; set; }
        [BindProperty(SupportsGet = true)]
        public float weight{ get; set; }
        [BindProperty(SupportsGet = true)]
        public float height { get; set; }
        [BindProperty(SupportsGet = true)]
        public string gender { get; set; }
        [BindProperty(SupportsGet = true)]
        public float bmi { get; set; }

        public void OnGet()
        {
            //bmi = weight / (height * height);

        }
    }
}