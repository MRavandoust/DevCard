using DevCard_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_project.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "Taxi", "Online Taxi rservation dens la ville","project-1.jpg", "Uber" ),
                new Project(2, "ZoodFood", "Online Food rservation dens la ville","project-2.jpg", "Zagres" ),
                new Project(3, "Les écoles", "Système de gestion scolaire","project-3.jpg", "MONOP" ),
                new Project(4, "Vaisseau spatial", "Programme de gestion des vaisseaux spatiaux","project-4.jpg", "NASA" ),

            };
            return View("Projects", projects);
        }
    }
}
