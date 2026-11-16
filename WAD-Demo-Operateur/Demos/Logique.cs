namespace WAD_Demo_Operateur.Demos
{
    // -- LOGIQUE --  && || !
    internal static class Logique
    {
        public static void EtLesDeuxConditionsDoiventEtreVraiesDemo()
        {
            Console.WriteLine("-- ET (&&) --");

            // && (ET) : les deux doivent être vrai
            int age = 20;
            bool estMembre = false;

            bool peutCommander = age >= 18 && estMembre; // false car pas membre
            Console.WriteLine($"peut commander : {peutCommander}");
            Console.WriteLine();
        }

        public static void OuAuMoinsUneConditionDoitEtreVraieDemo()
        {
            Console.WriteLine("-- OU (||) --");

            // || (OU) : au moins un des deux doit être vrai
            int age = 20;
            bool estMembre = false;

            bool aUneReduc = age < 25 || estMembre; // true car moins de 25 ans
            Console.WriteLine($"a une réduction : {aUneReduc}");
            Console.WriteLine();
        }

        public static void NonInverseLeBoolDemo()
        {
            Console.WriteLine("-- NON (!) --");

            // ! (NON) : inverse le bool, true devient false et inversement
            bool estMembre = false;

            bool estVisiteur = !estMembre; // true
            Console.WriteLine($"est visiteur : {estVisiteur}");
            Console.WriteLine();
        }

        public static void PlusieursOperateursMelangesAvecParenthesesDemo()
        {
            Console.WriteLine("-- mélanger && || ! --");

            // livraison gratuite si : membre OU (majeur ET commande d'au moins 50 euros)
            // les parenthèses rendent l'ordre clair (sinon le && passe avant le ||)
            int age = 20;
            bool estMembre = false;
            double montant = 60;

            bool livraisonGratuite = estMembre || (age >= 18 && montant >= 50); // true
            Console.WriteLine($"livraison gratuite : {livraisonGratuite}");

            // ! devant des parenthèses inverse tout le résultat
            bool livraisonPayante = !(estMembre || (age >= 18 && montant >= 50)); // false
            Console.WriteLine($"livraison payante : {livraisonPayante}");
            Console.WriteLine();
        }
    }
}
