namespace WAD_Demo_Methode.Demos
{
    // -- PARAMÈTRES FACULTATIFS (optionnels) ET ARGUMENTS NOMMÉS --
    // un paramètre facultatif a une VALEUR PAR DÉFAUT (= "...")
    // si on ne donne pas l'argument à l'appel, c'est la valeur par défaut qui est utilisée
    //
    //   static string Saluer(string prenom, string formulePolitesse = "Bonjour")
    //                        obligatoire    facultatif
    //
    // attention : les paramètres facultatifs doivent OBLIGATOIREMENT être placés en dernier
    //
    // argument nommé = on écrit le nom du paramètre suivi de : à l'appel  ->  Saluer(prenom: "Myriam")
    // - le code est plus lisible
    // - on peut donner les arguments dans l'ordre qu'on veut
    // - on peut "sauter" un paramètre facultatif
    internal static class ParametreFacultatif
    {
        // ----- les fonctions utilisées dans les démos -----

        private static string Saluer(string prenom, string formulePolitesse = "Bonjour")
        {
            return $"{formulePolitesse} {prenom}";
        }

        private static string Ecrire(
            string prenom,
            string nom,
            string phraseDebut = "Bonjour",
            string phraseMilieu = "j'espère que tu vas bien",
            string phraseFin = "à bientôt")
        {
            return $"{phraseDebut} {prenom} {nom}, {phraseMilieu}, {phraseFin} !";
        }

        // ----- les démos -----

        public static void ParametreFacultatifDemo()
        {
            Console.WriteLine("-- paramètre facultatif --");

            // formulePolitesse n'est pas donné -> "Bonjour" par défaut
            Console.WriteLine(Saluer("Léa"));
            Console.WriteLine(Saluer("Clem"));

            // formulePolitesse est donné -> il remplace la valeur par défaut
            Console.WriteLine(Saluer("Roi Philippe", "Bonjour Majesté"));
            Console.WriteLine();
        }

        public static void ArgumentsNommesDemo()
        {
            Console.WriteLine("-- arguments nommés --");

            // on précise à quel paramètre correspond chaque argument
            Console.WriteLine(Saluer(prenom: "Myriam"));
            Console.WriteLine(Saluer(prenom: "Roi Philippe", formulePolitesse: "Bonjour Majesté"));

            // avec les noms, l'ordre n'a plus d'importance
            Console.WriteLine(Saluer(formulePolitesse: "Salut", prenom: "Eva"));
            Console.WriteLine();
        }

        public static void PlusieursParametresFacultatifsDemo()
        {
            Console.WriteLine("-- plusieurs paramètres facultatifs --");

            // les 3 phrases ont une valeur par défaut
            Console.WriteLine(Ecrire("John", "Doe"));

            // on change seulement la 1re phrase (dans l'ordre, pas besoin de nom)
            Console.WriteLine(Ecrire("John", "Doe", "Salut"));

            // je veux changer SEULEMENT la phrase de fin, sans toucher aux 2 autres
            // sans argument nommé, je devrais réécrire phraseDebut et phraseMilieu
            // avec un argument nommé, je saute directement à phraseFin
            Console.WriteLine(Ecrire("John", "Doe", phraseFin: "bon week-end"));
            Console.WriteLine();
        }

        public static void PiegeParametreFacultatifPasEnDernierDemo()
        {
            Console.WriteLine("-- piège : facultatif pas en dernier --");

            // un paramètre facultatif placé AVANT un paramètre obligatoire -> erreur CS1737
            // "les paramètres facultatifs doivent apparaître après tous les paramètres obligatoires"
            // décommenter pour voir l'erreur
            //static string SaluerMalEcrit(string formulePolitesse = "Bonjour", string prenom)
            //{
            //    return $"{formulePolitesse} {prenom}";
            //}

            Console.WriteLine("règle : d'abord les paramètres obligatoires, ensuite les facultatifs");
            Console.WriteLine();
        }
    }
}
