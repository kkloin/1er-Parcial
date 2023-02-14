    class ROT13
    {
        static void Main(string[] args) 
        // Inicio del programa. Le pide al ususario que ingrese el texto a descifrar, e invoca a la funcion DescifradoROT13.
        {
        string _textoCifrado;

            Console.WriteLine("Bienvenido al Sistema de Descifrado ROT13.");
            Console.WriteLine("======================================== \n");
            Console.WriteLine("El sistema de cifrado ROT13 es un cifrado por sustitucion simple que reemplaza cada letra del mensaje original por la letra que se encuentra 13 posiciones mas adelante en el alfabeto. \n");
            Console.WriteLine("Ingrese la cadena codificada con ROT13. El mensaje debe estar en letras mayusculas: ");

            _textoCifrado = Console.ReadLine();

        // Valida si la entrada recibida no esta vacia y si las letras son solo mayusuculas. Si es asi, procede a ejecutar todo bien. Sino, lanza un mensaje de error.
        if (!string.IsNullOrEmpty(_textoCifrado) && LetrasMayusculas(_textoCifrado))
            {
                Console.WriteLine("El mensaje descifrado es: ");
                Console.WriteLine(DescifradoROT13 (_textoCifrado));
            }
            else
            {
                Console.WriteLine("El mensaje ingresado no es valido y/o dejaste la entrada vacia. Solamente puedes ingresar letras mayusculas.");
            }

            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();

        }

    // Funcion LetrasMayusculas
        static bool LetrasMayusculas(string textoCifrado)
        {
            foreach (char _mayuscula in textoCifrado)
            {
                if (char.IsLower(_mayuscula))
                {
                    return false;
                }
            }
            return true;
        }
    // Funcion DescifradoROT13.
         static string DescifradoROT13 (string textoCifrado)
        {
            char[] textoDescifrado = textoCifrado.ToCharArray();

            for (int i = 0; i < textoCifrado.Length; i++)
            {
                if (textoCifrado[i] >= 'A' && textoCifrado[i] <= 'Z')
                {
                    textoDescifrado[i] = (char)((textoCifrado[i] - 'A' + 13) % 26 + 'A');
                }
                else
                {
                    textoDescifrado[i] = textoCifrado[i];
                }
            }
            return new string(textoDescifrado);
        }
    }