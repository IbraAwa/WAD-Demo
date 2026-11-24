// ===================================================================================
//  CORRECTION — EXO 049 — Un string ne se modifie pas
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        string titre = "Harry Potter";

        // consigne 2 : ToUpper() crée un NOUVEAU texte en majuscules... qu'on ne range nulle part
        titre.ToUpper();

        // consigne 3 : prédiction → « Harry Potter », toujours en minuscules.
        // Un string est immuable : ToUpper() ne modifie pas titre, il renvoie un nouveau texte,
        // et comme on ne l'a pas gardé, il est perdu.
        Console.WriteLine(titre);

        // consigne 4 : cette fois on range le nouveau texte dans une variable
        string titreMajuscules = titre.ToUpper();
        Console.WriteLine(titreMajuscules);

        // consigne 5 : += crée un nouveau texte (titre + la suite) et le remet dans titre
        titre += " à l'école des sorciers";
        Console.WriteLine(titre);
    }
}
