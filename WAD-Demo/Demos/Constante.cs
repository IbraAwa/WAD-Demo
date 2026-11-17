namespace WAD_Demo.Demos
{
    // -- LES CONSTANTES --  const
    internal static class Constante
    {
        public static void ConstPourUneValeurQuiNeChangeJamaisDemo()
        {
            Console.WriteLine("-- const --");

            // écrire une constante quand la valeur ne change jamais ou quasi jamais
            // convention : une constante s'écrit en PascalCase (majuscule à chaque mot, même le premier)
            const decimal TauxTva = 0.21m; // la TVA en Belgique : 21 %

            decimal prixHorsTva = 100m;
            decimal prixTvac = prixHorsTva + prixHorsTva * TauxTva;
            Console.WriteLine($"prix TVA comprise : {prixTvac} euros"); // 121

            // TauxTva = 0.06m; // ERREUR : on ne peut pas changer la valeur d'une constante
            Console.WriteLine();
        }
    }
}
