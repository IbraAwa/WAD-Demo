// ===================================================================================
//  CORRECTION — EXO 075 — Boxing : ranger dans un object
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : un int
        int quantite = 3;

        // consigne 2 : boxing -> on range l'int dans un object, sans cast
        // (un int EST un object : C# le fait tout seul)
        object boite = quantite;

        // consigne 3 : le contenu de la boîte, puis son vrai type
        Console.WriteLine(boite);
        Console.WriteLine(boite.GetType());   // System.Int32 = le vrai nom de int
    }
}
