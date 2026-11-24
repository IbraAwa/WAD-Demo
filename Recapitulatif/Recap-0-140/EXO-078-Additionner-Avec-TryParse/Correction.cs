// ===================================================================================
//  CORRECTION — EXO 078 — Additionner deux nombres avec TryParse (slide 100)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le premier nombre, on garde le bool
        Console.Write("Premier nombre : ");
        bool reussi1 = int.TryParse(Console.ReadLine(), out int nombre1);

        // consigne 2 : pareil pour le deuxième
        Console.Write("Deuxième nombre : ");
        bool reussi2 = int.TryParse(Console.ReadLine(), out int nombre2);

        // consigne 3 : && -> vrai seulement si les DEUX conversions ont réussi
        if (reussi1 && reussi2)
        {
            Console.WriteLine($"{nombre1} + {nombre2} = {nombre1 + nombre2}");
        }
        else
        {
            Console.WriteLine("Un des deux n'est pas un nombre");
        }

        // consigne 4 : si on tape abc, le programme NE PLANTE PLUS :
        //    TryParse renvoie false, on passe dans le else et on affiche   Un des deux n'est pas un nombre
    }
}
