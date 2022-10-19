using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupoB_TP
{
    static class Usuario
    {
        public static string DNI = "12345678";
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
                    return $"Debe ingresar un valor {campo} mayor a {min} y menor a {max}]. \n";
                }
            }
            else
            {
                return $"Debe ingresar un valor de {campo} Numerico. \n";
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
                return $"El valor {campo} debe tener una longitud de {longitud} caracteres. \n";
            }
        }

        internal static string PedirVacio(string campo, string text)
        {
            if(text == "")
            {
                return $"El {campo} no puede estar Vacio . \n";
            }
            else
            {
                return "";
            }
            
        }
    }
}

