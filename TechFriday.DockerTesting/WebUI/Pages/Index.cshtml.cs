using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            try
            {
                ViewData["Message"] = "Welcome to TechFriday..";
                //using (var client = new HttpClient())
                //{
                //    var request = new HttpRequestMessage();
                //    request.RequestUri = new Uri("http://techfriday.dockertesting/WeatherForecast");
                //    var response = await client.SendAsync(request);
                //    ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
                //}
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
