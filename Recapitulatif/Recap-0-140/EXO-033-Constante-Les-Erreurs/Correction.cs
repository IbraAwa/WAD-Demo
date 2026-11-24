// ===================================================================================
//  CORRECTION — EXO 033 — Les erreurs avec une constante
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : pour de l'argent, on prend le type decimal (avec le suffixe m)
        const decimal PrixEntree = 11.50m;
        Console.WriteLine($"Prix d'entrée : {PrixEntree} euros");

        // consigne 2 : ERREUR CS0131 « La partie gauche d'une assignation doit être une variable,
        // une propriété ou un indexeur ».
        // Une constante n'est PAS une variable : sa valeur est fixée pour toujours, on ne peut plus la changer.
        // PrixEntree = 12m;

        // consigne 3 : ERREUR CS0145 « Un champ const nécessite une valeur ».
        // Une constante doit recevoir sa valeur tout de suite, sur la ligne où on la déclare.
        // const int Annee;
    }
}
