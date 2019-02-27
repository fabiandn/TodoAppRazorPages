using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoApp.Pages
{
    public class IndexModel : BasePageModel
    {
        public IndexModel()
        {
            this.Title = "Index";
        }
        
        public void OnGet()
        {

        }
    }
}