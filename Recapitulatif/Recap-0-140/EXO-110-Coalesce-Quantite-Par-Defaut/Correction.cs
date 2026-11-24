// ===================================================================================
//  CORRECTION — EXO 110 — Coalesce : une quantité de 1 par défaut (slide 126 n°2)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : de l'argent → decimal ; une quantité qui peut être vide → int?
        decimal prixUnitaire = 2.50m;
        int? quantite = null;
        // test de la consigne 3 : avec 4, on voit   Total : 10,00 euros
        // int? quantite = 4;

        // consigne 2 : si quantite est null, on prend 1
        decimal total = prixUnitaire * (quantite ?? 1);

        // consigne 3
        Console.WriteLine("Total : " + total + " euros");
    }
}
