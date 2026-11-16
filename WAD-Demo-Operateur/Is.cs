namespace WAD_Demo_Operateur
{
    // -- IS --  is, is not
    // pose une question sur une valeur et donne un bool (true ou false)
    internal static class Is
    {
        public static void IsNullEtIsNotNullDemo()
        {
            Console.WriteLine("-- is null / is not null --");

            string? codePromo = null;

            // même chose que == null et != null, mais se lit comme une phrase
            bool pasDeCode = codePromo is null;   // true
            bool aUnCode = codePromo is not null; // false
            Console.WriteLine($"pas de code : {pasDeCode}, a un code : {aUnCode}");
            Console.WriteLine();
        }

        public static void IsPourVerifierLeTypeDemo()
        {
            Console.WriteLine("-- is pour vérifier le type --");

            // object peut contenir n'importe quel type
            // is permet de demander "est-ce que c'est un int ?"
            object valeur = 42;

            Console.WriteLine($"est un int : {valeur is int}");       // true
            Console.WriteLine($"est un string : {valeur is string}"); // false
            Console.WriteLine();
        }
    }
}
