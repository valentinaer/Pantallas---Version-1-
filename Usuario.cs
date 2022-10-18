using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TP
{
    static class Usuario
    {
        internal static string PedirEntero(string campo, int min, int max, string valor)
        {
            
            if (int.TryParse(valor, out int result))
            { 
                if (result >= min && result <= max)
                {
                    return "";
                }
                else
                {
                    return $"El valor {campo} está fuera del rango [{min} .. {max}]. Inténtalo de nuevo. \n";
                }
            }
            else
            {
                return $"{campo} No es un valor entero válido. Inténtalo de nuevo. \n";
            }
        }

        internal static string PedirLongitudFija(string campo, int longitud, string text)
        {
            if (text.Length == longitud)
            {
                return "";
            }
            else
            {
                return $"El valor {campo} debe tener una longitud de {longitud} caracteres. Inténtalo de nuevo. \n";
            }
        }

        internal static string PedirVacio(string campo, string text)
        {
            if(text == "")
            {
                return $"{campo} es un campo vacio. Inténtalo de nuevo. \n";
            }
            else
            {
                return "";
            }
            
        }
    }
}

