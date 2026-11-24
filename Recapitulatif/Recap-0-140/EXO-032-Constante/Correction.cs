// ===================================================================================
//  CORRECTION — EXO 032 — Les constantes (const)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 3 constantes, avec le mot-clé const et un nom en PascalCase
        const double TauxTva = 0.21;          // dans le code, la virgule s'écrit avec un point
        const int JoursParSemaine = 7;
        const string Ecole = "BStorm";

        // consigne 2 : on affiche les trois valeurs, une par ligne
        // (à l'écran, 0.21 s'affiche 0,21 car le PC est réglé en français)
        Console.WriteLine($"TVA : {TauxTva}");
        Console.WriteLine($"Jours par semaine : {JoursParSemaine}");
        Console.WriteLine($"École : {Ecole}");
    }
}
