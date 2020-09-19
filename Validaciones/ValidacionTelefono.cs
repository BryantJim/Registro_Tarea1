using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Registro_Tarea1.Validaciones
{
     public class ValidacionTelefono : ValidationAttribute
    {
        public String Message { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cadena = value as string;

            if (cadena != null)
            {
                String expresion;
                expresion = @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$";
                if (Regex.IsMatch(cadena, expresion))
                {
                    if (Regex.Replace(cadena, expresion, String.Empty).Length == 0)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Teléfono no válido");
                    }
                }
                else
                    return new ValidationResult("Teléfono no válido");
            }
            return new ValidationResult("Debes poner un teléfono");
        }
    }
}