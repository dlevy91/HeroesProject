using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Heroes.Models;
using Heroes.DAO;

namespace Heroes.Controllers
{
    public class HeroesController : Controller
    {
        private readonly HeroDbContext _context;
        public HeroesController(HeroDbContext context)
        {
            _context = context;
        }
// ---------------------------------------------------------------------
        public IActionResult Index()
        {
            return View();
        }
// ---------------------------------------------------------------------

        public IActionResult DisplayAllHeroes()
        {
            return View(_context);
        }

        public IActionResult DisplayHero(int heroID)
        {
            HeroesModel foundHero = _context.heroes.FirstOrDefault(h => h.id == heroID);
            if(foundHero != null)
            {
            return View(foundHero);
            }
            else{
                return Content($"No Hero with the ID of {heroID}....are you a Villain trying to learn our secrets?");
            }

        }
// ---------------------------------------------------------------------
        public IActionResult AddHero(HeroesModel newHero)
        {
            if(ModelState.IsValid)
            {
            _context.heroes.Add(newHero);
            _context.SaveChanges();
            return RedirectToAction("DisplayAllHeroes");
            }
            else{
                return View("AddHeroForm", newHero);
            }
        }

        public IActionResult AddHeroForm()
        {
            return View();
        }

// ---------------------------------------------------------------------
        public IActionResult UpdateHero(HeroesModel updateHero)
        {
            HeroesModel foundHero = _context.heroes.FirstOrDefault(h => h.id == updateHero.id);
            if(foundHero != null)
            {
                if(ModelState.IsValid)
                {
                    foundHero.heroName = updateHero.heroName;
                    foundHero.power = updateHero.power;
                    foundHero.howToReach = updateHero.howToReach;
                    _context.SaveChanges();
                    return RedirectToAction("DisplayAllHeroes");
                }
                else{
                    return View("UpdateHeroForm", updateHero);
                }
            }
            else{
                return Content($"No Hero with that ID...are you trying to change history Villain?");
            }
        }

        public IActionResult UpdateHeroForm(int heroID)
        {
            HeroesModel foundHero = _context.heroes.FirstOrDefault(h => h.id == heroID);
            if(foundHero != null)
            {
                return View(foundHero);
            }
            else{
               return Content($"No Hero with that ID...are you trying to change history Villain?"); 
            }
        }
// ---------------------------------------------------------------------
        public IActionResult DeleteHero(int heroID)
        {
            HeroesModel foundHero = _context.heroes.FirstOrDefault(h => h.id == heroID);
            if(foundHero != null)
            {
                _context.Remove(foundHero);
                _context.SaveChanges();
                return RedirectToAction("DisplayAllHeroes");
            }
            else{
                return Content($"Someone is trying to erase our memories...");
            }
        }

        public IActionResult DeleteHeroConf(int heroID)
        {
            HeroesModel foundHero = _context.heroes.FirstOrDefault(h => h.id == heroID);
            if(foundHero != null)
            {
                return View(foundHero);
            }
            else{
                return Content($"Someone is trying to erase our memories...");
            }
        }
// ---------------------------------------------------------------------


    }
}