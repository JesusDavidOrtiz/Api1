using System;
using System.ComponentModel.DataAnnotations;

namespace Api1.DTOs
{
    public class ProductosDTO
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Descripción { get; set; }
        public bool Estado { get; set; }
        public string Fecha_fabricación { get; set; }
        public string Fecha_validez { get; set; }
        public int Cod_proveedor { get; set; }
        public string Descripción_proveedor { get; set; }
        public string TelefonoProveedor { get; set; }

    }
}
