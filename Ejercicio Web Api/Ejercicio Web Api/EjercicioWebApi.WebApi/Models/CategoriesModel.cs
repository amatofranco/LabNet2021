using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjercicioWebApi.WebApi.Models
{
    public class CategoriesModel
    {
        public int? CategoryId { get; set; }

        [Required (ErrorMessage ="Ingrese un nombre")]
        [StringLength(15, ErrorMessage = "El maximo de caracteres es 15")]

        public string CategoryName { get; set; }


        [Required(ErrorMessage = "Ingrese una descripcion")]
        [StringLength(15, ErrorMessage = "El maximo de caracteres es 15")]

        public string CategoryDescription { get; set; }


    }
}