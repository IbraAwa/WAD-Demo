// ===================================================================================
//  CORRECTION — EXO 093 — Pair ou impair avec les moitiés (slide 111)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la question et la saisie
        Console.Write("Un nombre : ");
        int nombre = int.Parse(Console.ReadLine()!);

        // consigne 2 : int / int -> division ENTIÈRE (la partie après la virgule est perdue)
        int moitie = nombre / 2;

        // consigne 3 : si moitie + moitie redonne le nombre, rien n'a été perdu -> pair
        if (moitie + moitie == nombre)
        {
            Console.WriteLine("Le nombre est pair");
        }
        else
        {
            Console.WriteLine("Le nombre est impair");
        }

        // consigne 4 :
        //    10 -> 10 / 2 = 5, et 5 + 5 = 10 : on retrouve 10     -> Le nombre est pair
        //     7 ->  7 / 2 = 3, et 3 + 3 = 6  : on ne retrouve pas 7 -> Le nombre est impair
    }
}
