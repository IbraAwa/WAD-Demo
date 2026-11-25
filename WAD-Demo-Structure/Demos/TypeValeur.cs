namespace WAD_Demo_Structure.Demos
{
    // -- UNE STRUCT EST UN TYPE VALEUR --
    // comme int, double, bool... la variable contient directement l'objet
    // donc quand on la met dans une autre variable, on fait une COPIE
    // (une List ou une class, c'est un type référence : on copie l'adresse, voir WAD-Demo/Demos/TypeValeurEtReference.cs)
    internal static class TypeValeur
    {
        public static void CopierUneStructCreeUneVoitureIndependanteDemo()
        {
            Console.WriteLine("-- copier une struct = copie indépendante --");

            Voiture voiture1 = new("BMW", "Rouge");

            // la voiture2 va prendre les caractéristiques de la voiture1 (une COPIE)
            Voiture voiture2 = voiture1;

            // aucun changement dans voiture1 car voiture2 est indépendante (type valeur)
            voiture2.Marque = "Honda";

            Console.WriteLine($"voiture1 : {voiture1.Marque}"); // BMW
            Console.WriteLine($"voiture2 : {voiture2.Marque}"); // Honda
            Console.WriteLine();
        }

        public static void ComparerDeuxStructsAvecEqualsDemo()
        {
            Console.WriteLine("-- comparer deux structs avec Equals --");

            Voiture voitureMarco = new("BMW", "Rouge");
            Voiture voitureLea = new("BMW", "Rouge");

            // attention : == ne marche PAS sur une struct (erreur de compilation)
            // décommenter pour voir l'erreur
            //if (voitureMarco == voitureLea) { }

            // Equals compare le CONTENU (propriété par propriété) car c'est un type valeur
            if (voitureMarco.Equals(voitureLea))
            {
                Console.WriteLine("les voitures sont pareilles"); // celle-ci !
            }
            else
            {
                Console.WriteLine("les voitures ne sont pas pareilles");
            }
            Console.WriteLine();
        }
    }
}
