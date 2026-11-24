// ===================================================================================
//  CORRECTION — EXO 115 — is avec une variable (pattern matching)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 19.99 sans suffixe est un double
        object prix = 19.99;

        // consigne 2 : si prix est un double, il est rangé directement dans valeur (déjà en double)
        if (prix is double valeur)
        {
            Console.WriteLine("C'est un prix : " + valeur);
        }

        // consigne 3 : type ET condition dans le même test. On prend un AUTRE nom (montant) :
        // la variable valeur du premier if existe encore ici, on ne peut pas la redéclarer.
        if (prix is double montant && montant > 10)
        {
            Console.WriteLine("C'est cher !");
        }
    }
}
