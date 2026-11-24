// ===================================================================================
//  CORRECTION — EXO 077 — Additionner deux nombres avec Parse (slide 100)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le premier nombre
        Console.Write("Premier nombre : ");
        int nombre1 = int.Parse(Console.ReadLine()!);

        // consigne 2 : le deuxième nombre
        Console.Write("Deuxième nombre : ");
        int nombre2 = int.Parse(Console.ReadLine()!);

        // consigne 3 : l'addition, tout vient des variables
        int somme = nombre1 + nombre2;
        Console.WriteLine($"{nombre1} + {nombre2} = {somme}");

        // consigne 4 : si on tape abc, le programme PLANTE avec une System.FormatException :
        //    "abc" n'est pas un nombre, int.Parse ne sait pas le convertir.
        //    Le calcul ne s'affiche jamais.
    }
}
