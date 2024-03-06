namespace G2_Investigacion2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
         * try-catch:
         * y-catch se utiliza para manejar excepciones en C#. 
         * En un bloque try, puedes colocar código que puede lanzar una excepción. 
         * Si ocurre una excepción dentro del bloque try, el flujo del programa se desvía al 
         * bloque catch, donde puedes manejar la excepción.
         * El bloque catch permite capturar la excepción y manejarla de alguna manera, 
         * como mostrar un mensaje de error o tomar medidas correctivas.
         * El bloque try-catch no garantiza que se ejecute un código específico después 
         * de manejar la excepción.
         */
            try
            {
                int divisor = 0;
                int resultado = 10 / divisor; // Esto lanzará una excepción de división por cero
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió una excepción: " + ex.Message);
            }

            // Este código se ejecutará después del bloque catch, pero no hay garantía de que se ejecute en todos los casos.
            Console.WriteLine("Fin del programa try-catch.");

            /*try-catch-finally:
            *try-catch-finally es similar a try-catch, pero agrega un bloque finally. 
            *el bloque finally se ejecutará siempre, ya sea que ocurra una excepción o no.
            *se utiliza para limpiar recursos u ejecutar código que debe ejecutarse independientemente 
            *de si ocurre una excepción o no.
            *el bloque finally es opcional, pero es útil para la limpieza de recursos.
            */

            try
            {
                int divisor = 0;
                int resultado = 10 / divisor; // Esto lanzará una excepción de división por cero
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió una excepción: " + ex.Message);
            }
            finally
            {
                // Este código se ejecutará independientemente de si se lanzó una excepción o no.
                Console.WriteLine("Finalizando recursos...");
            }

            Console.WriteLine("Fin del programa try-catch-finally.");

        }
    }
}