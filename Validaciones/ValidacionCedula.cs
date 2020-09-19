using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Registro_Tarea1.Validaciones
{
     public class ValidacionCedula : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cadena = value as string;

            if (cadena != null)
            {
                String expresion;
                expresion = @"^\d{3}[- ]?\d{7}[- ]?\d{1}$";
                if (Regex.IsMatch(cadena, expresion))
                {
                    if (Regex.Replace(cadena, expresion, String.Empty).Length == 0)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Cédula no válida");
                    }
                }
                else
                    return new ValidationResult("Cédula no válida");
            }
            return new ValidationResult("Debes poner una Cédula");
        }
    }
}