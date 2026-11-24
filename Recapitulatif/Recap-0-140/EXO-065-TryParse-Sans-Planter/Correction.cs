// ===================================================================================
//  CORRECTION — EXO 065 — TryParse : convertir sans planter
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le texte à convertir
        string saisie1 = "25";

        // consigne 2 : TryParse renvoie true/false, et range le nombre dans age1 grâce à out
        bool reussi1 = int.TryParse(saisie1, out int age1);

        // consigne 3 : affichage
        Console.WriteLine($"Réussi : {reussi1}, âge : {age1}");

        // consigne 4 : un texte qui n'est pas un nombre
        string saisie2 = "vingt-cinq";
        bool reussi2 = int.TryParse(saisie2, out int age2);
        // pas de plantage : TryParse renvoie simplement false, et age2 vaut 0
        Console.WriteLine($"Réussi : {reussi2}, âge : {age2}");
    }
}
