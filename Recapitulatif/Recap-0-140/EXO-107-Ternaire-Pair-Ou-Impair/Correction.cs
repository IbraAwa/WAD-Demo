// ===================================================================================
//  CORRECTION — EXO 107 — Ternaire : pair ou impair (slide 121 n°5)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        Console.Write("Un nombre : ");
        // le ! évite l'avertissement CS8604 (ReadLine renvoie un string? qui pourrait être null)
        int nombre = int.Parse(Console.ReadLine()!);

        // consigne 2 : un nombre pair a un reste de 0 quand on le divise par 2
        string parite = nombre % 2 == 0 ? "pair" : "impair";

        // consigne 3
        Console.WriteLine(nombre + " est " + parite);
    }
}
