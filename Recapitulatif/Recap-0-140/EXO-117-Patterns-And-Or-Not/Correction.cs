// ===================================================================================
//  CORRECTION — EXO 117 — Les patterns and, or, not
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : note n'est écrite qu'une seule fois, les comparaisons sont reliées par and
        int note = 15;
        bool reussi = note is >= 10 and <= 20;
        Console.WriteLine("Réussi : " + reussi);

        // consigne 2 : un char s'écrit entre apostrophes ; les valeurs sont reliées par or
        char lettre = 'e';
        bool voyelle = lettre is 'a' or 'e' or 'i' or 'o' or 'u';
        Console.WriteLine("Voyelle : " + voyelle);

        // consigne 3 : avec &&, il faut répéter la variable dans chaque comparaison
        bool reussiAvecEt = note >= 10 && note <= 20;
        Console.WriteLine("Réussi (avec &&) : " + reussiAvecEt);
    }
}
