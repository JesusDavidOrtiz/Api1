using Api1.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Api1.Entidades
{   
    public class Productos
    {
        [Key]
        [Required(ErrorMessage = "{0} es requerido")]
        public int Codigo { get; set; }


        [Required(ErrorMessage ="{0} es requerido")]
        public string Descripción { get; set; }


        [Required(ErrorMessage = "{0} es requerido")]
        public bool Estado { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Fecha_fabricación { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string Fecha_validez { get; set; }
        public int Cod_proveedor { get; set; }
        public string Descripción_proveedor { get; set; }
        public string TelefonoProveedor { get; set; }

        internal Task<bool> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal ActionResult Select(Func<object, ProductosDTO> p)
        {
            throw new NotImplementedException();
        }
    }
}
