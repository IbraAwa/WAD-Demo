// ===================================================================================
//  CORRECTION — EXO 038 — Déboguer : point d'arrêt et variables locales
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le petit programme de 4 lignes

        // consigne 2 : le point d'arrêt (rond rouge, F9) se met sur CETTE ligne.
        // consigne 3 : avec F5, le programme s'arrête AVANT d'exécuter cette ligne (flèche jaune dessus) :
        //              dans « Variables locales », stock vaut encore 0 (la ligne n'a pas encore été exécutée).
        int stock = 10;      // après F10 : stock = 10
        stock = stock - 3;   // après F10 : stock = 7   (on a vendu 3 articles)
        stock = stock + 5;   // après F10 : stock = 12  (on a reçu une livraison de 5)
        Console.WriteLine($"Stock final : {stock}");   // stock = 12 (cette ligne affiche, elle ne change rien)

        // consigne 4 et 5 : à chaque F10, la flèche jaune descend d'une ligne et la valeur qui vient
        //                    de changer s'affiche en rouge dans la fenêtre « Variables locales ».
        // consigne 6 : F5 pour terminer le programme (ou Maj+F5 pour l'arrêter tout de suite).
    }
}
