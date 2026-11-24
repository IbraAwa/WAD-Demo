// ===================================================================================
//  CORRECTION — EXO 056 — L'interpolation avec $
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        string nom = "Léa";
        int age = 30;

        // consigne 2 : le $ devant les guillemets, les variables entre { }
        Console.WriteLine($"{nom} a {age} ans");

        // consigne 3 : le calcul age + 10 est fait directement entre les { }
        Console.WriteLine($"Dans 10 ans, {nom} aura {age + 10} ans");
    }
}
