using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace B2C2_.net_core_MVC.Models
{
    public class Foto
    {
        [Key]
        public int FotoId { get; set; }

        [Microsoft.Build.Framework.Required]
        public string FotoLink { get; set; }

        [Microsoft.Build.Framework.Required]
        public int FotoGeplaatstDoor { get; set; }
    }
}
