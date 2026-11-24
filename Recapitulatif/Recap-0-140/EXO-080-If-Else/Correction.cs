// ===================================================================================
//  CORRECTION — EXO 080 — if ... else
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : l'âge
        int age = 15;

        // consigne 2 : une chose si c'est vrai, une AUTRE sinon
        if (age >= 18)
        {
            Console.WriteLine("Majeur");
        }
        else
        {
            Console.WriteLine("Mineur");
        }

        // consigne 3 :
        //    age = 15 -> Mineur
        //    age = 18 -> Majeur  (18 >= 18 est vrai : le = de >= compte)
        //    age = 30 -> Majeur
    }
}
