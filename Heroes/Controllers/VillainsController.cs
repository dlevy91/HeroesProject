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
    public class VillainsController : Controller
    {
        private readonly HeroDbContext _context;
        public VillainsController(HeroDbContext context)
        {
            _context = context;
        }
// ---------------------------------------------------------------------
        public IActionResult DisplayAllVillains()
        {
            return View(_context);
        }

        public IActionResult DisplayVillain(int villainID)
        {
            VillainsModel foundVillain = _context.villains.FirstOrDefault(v => v.id == villainID);
            if(foundVillain != null)
            {
            return View(foundVillain);
            }
            else{
                return Content($"No Villain with the ID of {villainID}....are you a Hero trying to learn our secrets?");                
            }

        }
// ---------------------------------------------------------------------

                public IActionResult AddVillain(VillainsModel newVillain)
        {
            if(ModelState.IsValid)
            {
            _context.villains.Add(newVillain);
            _context.SaveChanges();
            return RedirectToAction("DisplayAllVillains");
            }
            else{
                return View("AddVillainForm", newVillain);
            }
        }

        public IActionResult AddVillainForm()
        {
            return View();
        }

// ---------------------------------------------------------------------

                public IActionResult UpdateVillain(VillainsModel updateVillain)
        {
            VillainsModel foundVillain = _context.villains.FirstOrDefault(v => v.id == updateVillain.id);
            if(foundVillain != null)
            {
                if(ModelState.IsValid)
                {
                    foundVillain.villainName = updateVillain.villainName;
                    foundVillain.power = updateVillain.power;
                    foundVillain.howToReach = updateVillain.howToReach;
                    _context.SaveChanges();
                    return RedirectToAction("DisplayAllVillains");
                }
                else{
                    return View("UpdateVillainForm", updateVillain);
                }
            }
            else{
                return Content($"No Villain with that ID...are you trying to change history Hero?");
            }
        }

        public IActionResult UpdateVillainForm(int villainID)
        {
            VillainsModel foundVillain = _context.villains.FirstOrDefault(v => v.id == villainID);
            if(foundVillain != null)
            {
                return View(foundVillain);
            }
            else{
               return Content($"No Villain with that ID...are you trying to change history Hero?"); 
            }
        }
// ---------------------------------------------------------------------
        public IActionResult DeleteVillain(int villainID)
        {
            VillainsModel foundVillain = _context.villains.FirstOrDefault(v => v.id == villainID);
            if(foundVillain != null)
            {
                _context.Remove(foundVillain);
                _context.SaveChanges();
                return RedirectToAction("DisplayAllVillains");
            }
            else{
                return Content($"Someone is trying to erase our memories...");
            }
        }

        public IActionResult DeleteVillainConf(int villainID)
        {
            VillainsModel foundVillain = _context.villains.FirstOrDefault(v => v.id == villainID);
            if(foundVillain != null)
            {
                return View(foundVillain);
            }
            else{
                return Content($"Someone is trying to erase our memories...");
            }
        }
// ---------------------------------------------------------------------
    }
}
    
