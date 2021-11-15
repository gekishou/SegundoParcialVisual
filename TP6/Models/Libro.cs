using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TP6.Models
{
    public class Libro
    {
        [Key] //clave primaria
        public int IdLibro { get; set; }
        [Required] //todos los campos son requeridos
        public String Titulo { get; set; }
        [Required]
        public String Isbn { get; set; }
        [Required]
        public String Autor { get; set; }

        [Required]
        public String Lugar { get; set; }
        [Required]
        public int Paginas { get; set; }
        [Required]
        public int Edicion { get; set; }
        [Required]
        public String Editorial { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

    }

}
