namespace WAD_Demo_Structure_Conditionnelle.Demos
{
    // -- AVEC L'UTILISATEUR --
    // on mélange tout : saisie + TryParse + if...else + && || ( ) + ternaire
    internal static class AvecUtilisateur
    {
        public static void EntreeBoiteDeNuitAvecAgeDiplomeEtVipSaisisDemo()
        {
            Console.WriteLine("-- entrée de la boîte de nuit --");

            Console.WriteLine("Veuillez entrer votre âge");
            int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine("Avez-vous un diplôme ? (false / true)");
            bool.TryParse(Console.ReadLine(), out bool aSonDiplome);

            Console.WriteLine("Es-tu VIP ? (false / true)");
            bool.TryParse(Console.ReadLine(), out bool estVip);

            // si la saisie est incorrecte, TryParse met 0 ou false (donc refusé)
            if (estVip || (age >= 18 && aSonDiplome))
            {
                Console.WriteLine("Autoriser");
            }
            else
            {
                Console.WriteLine("Refuser");
            }
            Console.WriteLine();
        }

        public static void TernaireAvecAgeSaisiDemo()
        {
            Console.WriteLine("-- ternaire avec l'âge saisi --");

            Console.WriteLine("Tape ton âge");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                string statut = age >= 18 ? "Est majeur" : "Est mineur";
                Console.WriteLine(statut);
            }
            else
            {
                Console.WriteLine("Âge incorrect");
            }
            Console.WriteLine();
        }
    }
}
