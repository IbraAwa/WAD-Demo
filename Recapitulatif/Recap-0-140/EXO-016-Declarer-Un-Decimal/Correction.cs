// ===================================================================================
//  CORRECTION — EXO 016 — Déclarer un decimal (pour l'argent)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un point dans le code (pas une virgule) et le suffixe m collé au nombre
        decimal prixBaguette = 1.20m;

        // consigne 2 : à l'écran, la virgule apparaît car le PC est en français
        Console.WriteLine($"Une baguette coûte {prixBaguette} euros");

        // consigne 3 : ERREUR PROVOQUÉE
        // CS0664 : un nombre à virgule écrit sans suffixe est un double ;
        // il ne peut pas être rangé tel quel dans un decimal → il faut ajouter le suffixe m (0.95m).
        //decimal prixCroissant = 0.95;
    }
}
