using System;
using System.ComponentModel.DataAnnotations;
using Registro_Tarea1.Validaciones;

namespace Registro_Tarea1.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public string Nombres { get; set; }
        [ValidacionTelefono]
        public string Telefono { get; set; }
        [ValidacionCedula]
        public string Cedula { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public DateTime FechaNacimiento { get; set; }    
    }
}