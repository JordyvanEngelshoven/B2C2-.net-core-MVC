using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace B2C2_.net_core_MVC.Models
{
    public class Camera
    {
        [Key]
        public int CameraId { get; set; }

        public string CameraMerk { get; set; }

        public string CameraType { get; set; }

        public int CameraRichting { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Latitude { get; set; }

        [Microsoft.Build.Framework.Required]
        public string Longitude { get; set; }

        [Microsoft.Build.Framework.Required]
        public string GeplaatstDoor { get; set; } 
    }
}
