namespace WAD_Demo_Operateur.Demos
{
    // -- COALESCE --  ?? ??=
    // donne une valeur de secours quand une variable est null
    internal static class Coalesce
    {
        public static void CoalesceValeurDeSecoursSiNullDemo()
        {
            Console.WriteLine("-- coalesce (??) --");

            // le ? après le type autorise la variable à être null (vu dans le récap)
            string? codePromo = null;

            //                   siPasNull ?? siNull
            string codeAffiche = codePromo ?? "aucun code";
            Console.WriteLine($"code promo : {codeAffiche}"); // aucun code

            int? numeroFidelite = 1234;
            int numeroAffiche = numeroFidelite ?? -1;
            Console.WriteLine($"numéro fidélité : {numeroAffiche}"); // 1234 car pas null
            Console.WriteLine();
        }

        public static void CoalesceAffectationRemplitSeulementSiNullDemo()
        {
            Console.WriteLine("-- coalesce affectation (??=) --");

            // ??= range la valeur SEULEMENT si la variable est null
            // codePromo ??= "BIENVENUE"  c'est  codePromo = codePromo ?? "BIENVENUE"
            string? codePromo = null;
            codePromo ??= "BIENVENUE"; // était null -> devient "BIENVENUE"
            codePromo ??= "NOEL";      // n'est plus null -> ne change pas
            Console.WriteLine($"code promo : {codePromo}"); // BIENVENUE
            Console.WriteLine();
        }
    }
}
