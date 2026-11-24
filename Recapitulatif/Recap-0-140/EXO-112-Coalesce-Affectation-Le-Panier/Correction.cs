// ===================================================================================
//  CORRECTION — EXO 112 — Coalesce et affectation ??= (slide 126 n°4)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : une liste de textes qui a le droit d'être null
        List<string>? panier = null;

        // consigne 2 : panier est null → ??= y range une nouvelle liste vide
        panier ??= new List<string>();

        // consigne 3
        panier.Add("pain");

        // consigne 4 : prédiction : NON, le panier n'est pas remplacé.
        //    Il n'est plus null (il contient déjà la liste avec « pain »), donc ??= ne fait rien.
        panier ??= new List<string>();

        // consigne 5
        Console.WriteLine("Nombre d'articles : " + panier.Count);
        Console.WriteLine(string.Join(", ", panier));
    }
}
