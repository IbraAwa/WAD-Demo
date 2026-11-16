namespace WAD_Demo_Operateur
{
    // -- AVEC L'UTILISATEUR --
    internal static class AvecUtilisateur
    {
        // on mélange tout : TryParse + opérateurs + ternaire
        public static void TotalCommandeSaisieAvecFraisDeLivraisonDemo()
        {
            Console.WriteLine("-- total d'une commande saisie --");

            Console.WriteLine("Montant de votre commande ?");
            if (double.TryParse(Console.ReadLine(), out double montant))
            {
                double frais = montant >= 50 ? 0 : 4.95;
                montant += frais;
                Console.WriteLine($"Total à payer : {montant} euros");
            }
            else
            {
                Console.WriteLine("Montant incorrect");
            }
            Console.WriteLine();
        }
    }
}
