// ===================================================================================
//  CORRECTION — EXO 026 — L'erreur CS0165 : variable sans valeur
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : déclarée, mais pas encore de valeur
        int compteur;

        // consigne 2 et 3 : ERREUR PROVOQUÉE
        // CS0165 : utilisation d'une variable locale non assignée 'compteur'.
        // La boîte existe, mais elle est vide : C# refuse d'afficher quelque chose qui n'a pas de valeur.
        //Console.WriteLine(compteur);

        // consigne 4 : on lui donne une valeur, et là on peut l'afficher
        compteur = 0;
        Console.WriteLine(compteur);
    }
}
