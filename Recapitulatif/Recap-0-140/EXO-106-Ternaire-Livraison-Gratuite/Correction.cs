// ===================================================================================
//  CORRECTION — EXO 106 — Ternaire : la livraison gratuite (slide 121 n°4)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : de l'argent → decimal.Parse
        Console.Write("Montant de la commande : ");
        // le ! évite l'avertissement CS8604 (ReadLine renvoie un string? qui pourrait être null)
        decimal montant = decimal.Parse(Console.ReadLine()!);

        // consigne 2 : gratuit à partir de 50 (50 compris → >=), sinon 4,95
        decimal frais = montant >= 50 ? 0 : 4.95m;

        // consigne 3 : montant + frais, suivi de « euros »
        decimal total = montant + frais;
        Console.WriteLine("Total à payer : " + total + " euros");
    }
}
