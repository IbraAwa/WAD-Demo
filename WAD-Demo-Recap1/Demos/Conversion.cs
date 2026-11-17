namespace WAD_Demo_Recap1.Demos
{
    // -- CONVERSION --  ToString  Parse  TryParse  Convert
    internal static class Conversion
    {
        public static void ToStringConvertitEnStringDemo()
        {
            Console.WriteLine("-- ToString --");

            int age = 18;
            string ageTexte;

            // convertir une variable en string
            ageTexte = age.ToString();
            Console.WriteLine($"âge en texte : {ageTexte}");
            Console.WriteLine();
        }

        public static void ParseConvertitUnStringDemo()
        {
            Console.WriteLine("-- Parse --");

            string estBoursierTexte = "false";
            bool estBoursier;

            estBoursier = bool.Parse(estBoursierTexte);
            // valable pour tous les types sauf string
            // int.Parse()
            // long.Parse()
            // decimal.Parse()
            // etc...
            Console.WriteLine($"est boursier : {estBoursier}");
            Console.WriteLine();
        }

        public static void TryParseConvertitSansPlanterDemo()
        {
            Console.WriteLine("-- TryParse --");

            string estBoursierTexte = "false";

            bool estConverti = bool.TryParse(estBoursierTexte, out bool estBoursier);

            if (estConverti)
            {
                Console.WriteLine("Nous avons réussi à convertir");
                Console.WriteLine(estBoursier);
            }
            else
            {
                Console.WriteLine("Nous n'avons pas réussi à convertir");
            }
            Console.WriteLine();
        }

        public static void ConvertDUnTypeVersUnAutreDemo()
        {
            Console.WriteLine("-- Convert --");

            int nombreEtudiants = 25;
            long nombreEtudiantsLong = Convert.ToInt64(nombreEtudiants);
            Console.WriteLine($"nombre d'étudiants en long : {nombreEtudiantsLong}");
            Console.WriteLine();
        }
    }
}
