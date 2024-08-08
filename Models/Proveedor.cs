using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class Proveedor
    {
        [Key]
        public string IdProveedor { get; set; }

        public string NombreProveedor { get; set; }

        public string DireccionProveedor { get; set; }

        public string TelefonoProveedor { get; set; }

        public string CorreoProveedor { get; set; }
    }
}