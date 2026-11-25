namespace WAD_Demo_Methode.Demos
{
    // -- SURCHARGE (overload) --
    // plusieurs méthodes peuvent porter le MÊME NOM si leurs paramètres sont différents :
    // - un nombre de paramètres différent
    // - ou des types de paramètres différents
    // C# choisit tout seul la bonne version en regardant les arguments donnés à l'appel
    //
    // vous l'utilisez déjà : Console.WriteLine existe en plein de versions
    // (WriteLine(), WriteLine(string), WriteLine(int), WriteLine(decimal)...)
    //
    // attention : changer SEULEMENT le type de retour ne suffit pas
    //
    // remarque : la surcharge marche dans une class
    // (dans Program.cs, deux méthodes écrites directement ne peuvent pas avoir le même nom)
    internal static class Surcharge
    {
        // ----- les 3 versions de Addition -----

        private static int Addition(int a, int b)
        {
            return a + b;
        }

        private static int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        private static decimal Addition(decimal a, decimal b)
        {
            return a + b;
        }

        // ----- les démos -----

        public static void SurchargeMemeNomParametresDifferentsDemo()
        {
            Console.WriteLine("-- même nom, paramètres différents --");

            // 2 int -> 1re version
            Console.WriteLine($"Addition(2, 3)          = {Addition(2, 3)}");

            // 3 int -> 2e version
            Console.WriteLine($"Addition(2, 3, 4)       = {Addition(2, 3, 4)}");

            // 2 decimal -> 3e version
            Console.WriteLine($"Addition(2.5m, 3.25m)   = {Addition(2.5m, 3.25m)}");
            Console.WriteLine();
        }

        public static void PiegeSurchargeAvecSeulementLeTypeDeRetourDemo()
        {
            Console.WriteLine("-- piège : changer seulement le type de retour --");

            // même nom ET mêmes paramètres que la 1re version, seul le type de retour change -> erreur CS0111
            // à l'appel Addition(2, 3), C# ne pourrait pas savoir laquelle choisir
            // décommenter pour voir l'erreur (à mettre dans la class, à côté des autres Addition)
            //private static long Addition(int a, int b)
            //{
            //    return a + b;
            //}

            Console.WriteLine("règle : pour surcharger, il faut changer les PARAMÈTRES");
            Console.WriteLine();
        }
    }
}
