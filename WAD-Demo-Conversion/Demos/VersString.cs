namespace WAD_Demo_Conversion.Demos
{
    // -- VERS UN STRING --  ToString()
    internal static class VersString
    {
        public static void ToStringTransformeNimporteQuelTypeEnTexteDemo()
        {
            Console.WriteLine("-- ToString() --");

            // pour transformer une variable en string
            // ToString() est disponible pour tous les types
            int quantite = 15;
            string quantiteTexte = quantite.ToString(); // 15 -> "15"

            bool estLivree = true;
            string estLivreeTexte = estLivree.ToString(); // true -> "True"

            Console.WriteLine($"quantité : {quantiteTexte}, livrée : {estLivreeTexte}");
            Console.WriteLine();
        }
    }
}
