// ===================================================================================
//  CORRECTION — EXO 113 — typeof et nameof (slide 126 n°5)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : typeof part d'un NOM de type ; Name = nom court, FullName = nom complet
        Console.WriteLine(typeof(int).Name + " / " + typeof(int).FullName);

        // consigne 2 : pareil pour string et decimal
        Console.WriteLine(typeof(string).Name + " / " + typeof(string).FullName);
        Console.WriteLine(typeof(decimal).Name + " / " + typeof(decimal).FullName);

        // consigne 3 : GetType part d'une VALEUR ; 3.14 sans suffixe est un double
        object o = 3.14;
        Console.WriteLine(o.GetType() == typeof(double));

        // consigne 4 : nameof donne le NOM écrit dans le code, pas la valeur (30)
        int age = 30;
        Console.WriteLine(nameof(age));
    }
}
