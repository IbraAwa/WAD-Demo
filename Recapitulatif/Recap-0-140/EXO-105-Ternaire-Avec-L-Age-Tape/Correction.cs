// ===================================================================================
//  CORRECTION — EXO 105 — Ternaire : majeur ou mineur (slide 121 n°3)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : Write (et pas WriteLine) pour taper la réponse sur la même ligne
        Console.Write("Votre âge : ");
        // ReadLine renvoie un string? : le ! dit à C# « ici, ce ne sera pas null »,
        // sinon Visual Studio souligne en vert (avertissement CS8604).
        int age = int.Parse(Console.ReadLine()!);

        // consigne 2 : le ternaire choisit le mot à ranger dans la variable
        string statut = age >= 18 ? "Majeur" : "Mineur";
        Console.WriteLine(statut);
    }
}
