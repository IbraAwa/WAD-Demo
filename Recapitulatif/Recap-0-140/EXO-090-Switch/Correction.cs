// ===================================================================================
//  CORRECTION — EXO 090 — Le switch
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le jour
        int jour = 3;

        // consigne 2 : un case par jour, chacun se termine par break
        switch (jour)
        {
            case 1:
                Console.WriteLine("Lundi");
                break;
            case 2:
                Console.WriteLine("Mardi");
                break;
            case 3:
                Console.WriteLine("Mercredi");
                break;
            case 4:
                Console.WriteLine("Jeudi");
                break;
            case 5:
                Console.WriteLine("Vendredi");
                break;
            case 6:
                Console.WriteLine("Samedi");
                break;
            case 7:
                Console.WriteLine("Dimanche");
                break;
            // consigne 3 : aucun case ne correspond
            default:
                Console.WriteLine("Jour inconnu");
                break;
        }

        // consigne 4 :
        //    jour = 3 -> Mercredi
        //    jour = 7 -> Dimanche
        //    jour = 9 -> Jour inconnu  (on passe dans le default)
    }
}
