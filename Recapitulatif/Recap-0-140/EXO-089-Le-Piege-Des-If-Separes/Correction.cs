// ===================================================================================
//  CORRECTION — EXO 089 — Le piège des if séparés
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la note
        int note = 17;

        // consigne 2 : 3 if SÉPARÉS -> chaque if est testé, quoi qu'il arrive aux autres
        Console.WriteLine("-- mauvaise manière --");
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }

        // consigne 3 : avec else if -> C# s'arrête au premier cas vrai
        Console.WriteLine("-- bonne manière --");
        if (note >= 16)
        {
            Console.WriteLine("Très bien");
        }
        else if (note >= 14)
        {
            Console.WriteLine("Bien");
        }
        else if (note >= 10)
        {
            Console.WriteLine("Réussi");
        }

        // consigne 4 :
        //    mauvaise manière : 3 lignes (17 est >= 16, ET >= 14, ET >= 10 : les trois if sont vrais)
        //    bonne manière    : 1 seule ligne (dès que « Très bien » est trouvé, les else if sont sautés)
    }
}
