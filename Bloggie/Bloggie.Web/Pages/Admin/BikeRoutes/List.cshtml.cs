using BloggieToBike.Web.Data;
using BloggieToBike.Web.Models.Domain;
using BloggieToBike.Web.Models.ViewModels;
using BloggieToBike.Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace BloggieToBike.Web.Pages.Admin.BikeRoutes
{
    [Authorize(Roles = "Admin")]
    public class ListModel : PageModel
    {
        private readonly IBikeRouteRepository bikeRouteRepository;

        public List<BikeRoute> BikeRoutes { get; set; }

        public ListModel(IBikeRouteRepository bikeRouteRepository)
        {
            this.bikeRouteRepository = bikeRouteRepository;
        }

        public async Task OnGet()
        {
            var notificationJson = (string)TempData["Notification"];
            if(notificationJson != null)
            {
                ViewData["Notification"] = JsonSerializer.Deserialize<Notification>(notificationJson);
            }

            BikeRoutes = (await bikeRouteRepository.GetAllAsync())?.ToList();
        }
    }
}
