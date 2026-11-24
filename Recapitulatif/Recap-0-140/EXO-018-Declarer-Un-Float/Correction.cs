// ===================================================================================
//  CORRECTION — EXO 018 — Déclarer un float
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le suffixe f collé au nombre
        float poidsKg = 2.5f;

        // consigne 2 : afficher avec la variable
        Console.WriteLine($"Poids : {poidsKg} kg");

        // consigne 3 : ERREUR PROVOQUÉE
        // CS0664 : sans suffixe, 1.5 est un double ; il ne peut pas être rangé tel quel
        // dans un float → il faut ajouter le suffixe f (1.5f).
        //float poidsSucre = 1.5;
    }
}
