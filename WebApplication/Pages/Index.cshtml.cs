using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferenceWCF;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            var wcfClient = new WcfClient();
            medias = await wcfClient.GetAllMediaAsync();
        }
        public List<Media> medias { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
    }
}
