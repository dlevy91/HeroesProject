using System;
using System.ComponentModel.DataAnnotations;

namespace Heroes.Models
{
    public class VillainsModel
    {
        public int id {get; set;}

        [Required(ErrorMessage = "You must enter a name")]
        [Display(Name = "Villain Name")]
        public string villainName {get; set;}

        [Required(ErrorMessage = "You must enter a power")]
        [Display(Name = "Power")]
        public string power {get; set;}

        [Required(ErrorMessage = "You must enter how best to reach you")]
        [Display(Name = "How To Reach")]
        public string howToReach {get; set;}
    }
}