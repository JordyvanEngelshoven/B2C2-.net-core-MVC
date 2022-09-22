using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace B2C2_.net_core_MVC.Models
{
    public class Gebruiker
    {
        [Key]
        public int GebruikerID { get; set; }

        [Microsoft.Build.Framework.Required]
        public string GebruikerNaam { get; set; }

        [Microsoft.Build.Framework.Required]
        public DateTime AanmaakDatum { get; set; } = DateTime.Now;

        [Microsoft.Build.Framework.Required]
        public DateTime GeboorteDatum { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Wachtwoord { get; set; }

        [Microsoft.Build.Framework.Required]
        public string EmailAdres { get; set; }

    }

}
