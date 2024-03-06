using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace G2_Investigacion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Validar un número de teléfono (formato internacional)
            string phoneNumber = "+1234567890";
            bool isValidPhoneNumber = Regex.IsMatch(phoneNumber, @"^\+(?:[0-9] ?){6,14}[0-9]$");
            Console.WriteLine("Número de teléfono válido: " + isValidPhoneNumber);

            // Validar una URL de sitio web
            string url = "https://www.example.com";
            bool isValidUrl = Regex.IsMatch(url, @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$");
            Console.WriteLine("URL de sitio web válida: " + isValidUrl);

            // Validar una dirección de correo electrónico
            string email = "example@example.com";
            bool isValidEmail = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Console.WriteLine("Dirección de correo electrónico válida: " + isValidEmail);

            // Validar un código postal (EE. UU.)
            string zipCode = "12345";
            bool isValidZipCode = Regex.IsMatch(zipCode, @"^\d{5}(-\d{4})?$");
            Console.WriteLine("Código postal válido: " + isValidZipCode);

            // Validar una fecha (formato YYYY-MM-DD)
            string date = "2024-03-06";
            bool isValidDate = Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$");
            Console.WriteLine("Fecha válida: " + isValidDate);
        }
    }
}
