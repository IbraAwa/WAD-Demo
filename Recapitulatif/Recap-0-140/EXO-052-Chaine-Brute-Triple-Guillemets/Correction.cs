// ===================================================================================
//  CORRECTION — EXO 052 — La chaîne brute avec trois guillemets
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : chaîne brute """ ... """ : les guillemets du texte s'écrivent normalement.
        // Les espaces placés avant les """ de fermeture sont retirés de chaque ligne,
        // donc { et } se retrouvent tout à gauche et "nom" garde ses 4 espaces de décalage.
        string json = """
            {
                "nom": "Léa",
                "ville": "Namur"
            }
            """;

        // consigne 2
        Console.WriteLine(json);

        // consigne 3 : $ devant la chaîne brute → la variable entre { } est remplacée par sa valeur
        string nom = "Léa";
        Console.WriteLine($"""Bonjour "{nom}" !""");
    }
}
