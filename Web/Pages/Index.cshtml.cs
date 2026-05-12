using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Web.Repositories;
using Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace nIKernel.Pages
{
    [Authorize] // Garante que apenas usuários logados acessem a página inicial (Home)
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}