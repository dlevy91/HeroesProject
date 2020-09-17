using System;
using System.ComponentModel.DataAnnotations;

namespace Heroes.Models
{
    public class HeroesModel
    {
        public int id {get; set;}

        [Required(ErrorMessage = "You must enter a name")]
        [Display(Name = "Hero Name")]
        public string heroName {get; set;}

        [Required(ErrorMessage = "You must enter a power")]
        [Display(Name = "Power")]
        public string power {get; set;}

        [Required(ErrorMessage = "You must enter how best to reach you")]
        [Display(Name = "How To Reach")]
        public string howToReach {get; set;}
    }
}