// ===================================================================================
//  CORRECTION — EXO 041 — Type référence : on copie l'adresse
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : une liste de textes, créée avec new, avec ses éléments de départ entre { }
        List<string> maListe = new List<string> { "pain", "lait" };

        // consigne 2 : on ne crée PAS de nouvelle liste : on copie l'ADRESSE de maListe
        List<string> listeDuColoc = maListe;

        // consigne 3 : on ajoute café en passant par listeDuColoc
        listeDuColoc.Add("café");

        // consigne 4 : prédiction → maListe contient pain, lait ET café.
        // Une List est un type référence : maListe et listeDuColoc pointent sur la MÊME liste.
        // Ajouter par l'une, c'est ajouter dans la liste que l'autre voit aussi.

        // consigne 5 : string.Join colle les éléments en mettant ", " entre chacun
        Console.WriteLine(string.Join(", ", maListe));
    }
}
