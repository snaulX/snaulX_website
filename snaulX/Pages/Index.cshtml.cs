using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace snaulX.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Lang { get; set; }

        //public string ContentFileName { get; set; }

        public virtual void OnGet()
        {

        }

        public virtual void OnPost()
        {

        }
    }
}
