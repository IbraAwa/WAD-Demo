// ===================================================================================
//  CORRECTION — EXO 092 — L'expression switch
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le jour
        int jour = 7;

        // consigne 2 : chaque cas associe une valeur à un résultat avec =>
        //    or -> accepte 6 OU 7,   _ -> tous les autres cas
        string nomJour = jour switch
        {
            1 => "Lundi",
            2 => "Mardi",
            3 => "Mercredi",
            4 => "Jeudi",
            5 => "Vendredi",
            6 or 7 => "Week-end",
            _ => "Autre jour"
        };   // c'est une affectation : point-virgule après l'accolade

        // consigne 3 : affichage
        Console.WriteLine(nomJour);
    }
}
