using Microsoft.Build.Framework;

namespace B2C2_.net_core_MVC.Models
{
    public class Beheerder : Gebruiker
    {
        [Required]
        public int IsBeheerder { get; set; }    
    }
}
