namespace WAD_Demo_Conversion.Demos
{
    // -- CONVERT --  Convert.ToInt32()  Convert.ToDouble()  Convert.ToDecimal() ...
    // Convert.Methode(ce qu'on veut convertir)
    internal static class AvecConvert
    {
        public static void ConvertToInt32DUnTexteEnNombreDemo()
        {
            Console.WriteLine("-- Convert.ToInt32 --");

            // --int--
            int quantite = Convert.ToInt32("15");
            Console.WriteLine($"quantité '15' convertie en int {quantite}");
            Console.WriteLine();
        }

        public static void ConvertImpossibleSiPasUnNombreValideDemo()
        {
            Console.WriteLine("-- ce que Convert ne sait pas faire --");

            // X impossible car c'est un mot (chaîne de caractères) -> le programme plante
            //int nombreConvert = Convert.ToInt32("salut");

            // impossible de convertir un nombre trop grand en int
            // car il faut le convertir en long
            //int nombreConvert1 = Convert.ToInt32("1500000000000000");
            long nombreConvert1 = Convert.ToInt64("1500000000000000");
            Console.WriteLine($"nombre '1500000000000000' converti en long {nombreConvert1}");

            // impossible de convertir un nombre avec un underscore malgré que C# l'accepte dans le code
            //int nombreConvert2 = Convert.ToInt32("150_000"); // plante
            int nombreConvert2 = 150_000; // ici ça marche : c'est du code, pas du texte
            Console.WriteLine($"150_000 écrit dans le code vaut {nombreConvert2}");
            Console.WriteLine();
        }

        public static void ConvertToDoubleAttentionALaCultureDemo()
        {
            Console.WriteLine("-- Convert.ToDouble et la culture --");

            // conversion d'un nombre en double : attention, ça dépend de la culture de l'ordinateur
            // en français la virgule est ',' -> "15,05" donne 15,05
            // en anglais la virgule est '.'  -> il accepte la conversion mais il ignore la ',' (ça donne 1505 !)
            double poidsColis = Convert.ToDouble("15,05");
            Console.WriteLine($"poids '15,05' converti en double {poidsColis}");
            Console.WriteLine();
        }

        public static void ConvertAvecUneVariableDansLaParentheseDemo()
        {
            Console.WriteLine("-- Convert avec une variable --");

            // dans la parenthèse on peut mettre des variables
            string prixTexte = "11,55";
            decimal prix = Convert.ToDecimal(prixTexte);
            Console.WriteLine($"prix '11,55' converti en decimal {prix}");
            Console.WriteLine();
        }
    }
}
