namespace WAD_Demo.Demos
{
    // -- LA PORTÉE DES VARIABLES --  { }
    // une variable n'existe que dans les accolades { } où elle a été créée
    internal static class Portee
    {
        public static void VariableCreeeDansDesAccoladesNExistePasDehorsDemo()
        {
            Console.WriteLine("-- portée des variables --");

            int age = 20; // créée en dehors du if : existe partout dans la méthode

            if (age >= 18)
            {
                string message = "Bienvenue"; // créée dans le if : existe seulement dans le if
                Console.WriteLine($"valeur de age est {age}");
                Console.WriteLine($"valeur de message est {message}");
            }

            Console.WriteLine($"la valeur de age est {age}");

            // ERREUR : message n'existe plus en dehors des { } du if
            //Console.WriteLine($"la valeur de message est {message}");
            Console.WriteLine();
        }
    }
}
