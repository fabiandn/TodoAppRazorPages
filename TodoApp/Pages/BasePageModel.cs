using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoApp.Pages
{
    public class BasePageModel : PageModel
    {
        [ViewData]
        public string Title { get; protected set; }
        
    }
}