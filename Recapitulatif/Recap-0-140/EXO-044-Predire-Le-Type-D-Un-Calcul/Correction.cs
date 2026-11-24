// ===================================================================================
//  CORRECTION — EXO 044 — Prédire le type d'un calcul (exercice slide 80)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 et 2 : prédictions (valeur et type)
        var a = 5 / 2;     // 2    int     : int / int → int, la partie après la virgule est perdue
        var b = 5 / 2.0;   // 2,5  double  : 2.0 est un double, donc le calcul se fait en double
        var c = 5f / 2;    // 2,5  float   : 5f est un float, donc le calcul se fait en float
        var d = 10m / 4;   // 2,5  decimal : 10m est un decimal, donc le calcul se fait en decimal
        var e = 5L * 2;    // 10   long    : 5L est un long, donc le résultat est un long
        var f = 'a' + 1;   // 98   int     : un char dans un calcul devient son code (a = 97), 97 + 1 = 98

        // consigne 3 : la valeur, « : », puis le type
        Console.WriteLine($"{a} : {a.GetType()}");
        Console.WriteLine($"{b} : {b.GetType()}");
        Console.WriteLine($"{c} : {c.GetType()}");
        Console.WriteLine($"{d} : {d.GetType()}");
        Console.WriteLine($"{e} : {e.GetType()}");
        Console.WriteLine($"{f} : {f.GetType()}");

        // consigne 4 : les pièges les plus fréquents
        // - a : on s'attend à 2,5 mais on obtient 2 → deux int donnent un int (division entière).
        // - f : on s'attend à 'b' mais on obtient 98 → le + transforme le char en int (son code).
        // Règle : dans un calcul, le résultat prend le type le plus « grand » des deux valeurs.
    }
}
