using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smtih_Midterm.Models;

namespace Smtih_Midterm.Controllers
{
    public class HouseController : Controller
    {
        private HouseContext context;

        public HouseController(HouseContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List", "House");
        }
        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            var categories = context.Regions.OrderBy(c => c.RegionId).ToList();

            List<Info> infos;
            if (id == "All")
            {
                infos = context.Infos.OrderBy(p => p.HouseId).ToList();
            }
            else
            {
                infos = context.Infos.Where(p => p.Region.Name == id).OrderBy(p => p.HouseId).ToList();
            }
            ViewBag.Regions = categories;
            ViewBag.SelectCategoryName = id;

            return View(infos);
        }
        public IActionResult Details(int Id)
        {
            var categories = context.Regions.OrderBy(c => c.RegionId).ToList();
            Info info = context.Infos.Find(Id);
            Photos photos = context.Photos.Find(Id);
            string imageFilename1 = photos.Pic1;
            string imageFilename2 = photos.Pic2;
            string imageFilename3 = photos.Pic3;

            ViewBag.Regions = categories;
            ViewBag.ImageFilename1 = imageFilename1;
            ViewBag.ImageFilename2 = imageFilename2;
            ViewBag.ImageFilename3 = imageFilename3;

            return View(info);
        }
    }
}
