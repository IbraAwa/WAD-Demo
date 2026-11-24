// ===================================================================================
//  CORRECTION — EXO 094 — Déboguer : les espions
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : une variable entière age qui vaut 70
        int age = 70;

        // consigne 2 : tarifNormal est vrai si age >= 18 ET age < 65, sans if
        // consigne 3 : le point d'arrêt (F9) se met sur la ligne ci-dessous, puis F5.
        //              Le programme s'arrête AVANT d'exécuter cette ligne (elle est surlignée en jaune).
        bool tarifNormal = age >= 18 && age < 65;
        Console.WriteLine("Tarif normal : " + tarifNormal);

        // consigne 4 : on sélectionne   age < 65   puis clic droit > Ajouter un espion,
        //              et pareil pour   age >= 18
        // consigne 5 : valeurs vues dans la fenêtre Espion :
        //    age < 65   → false   (70 n'est pas plus petit que 65)
        //    age >= 18  → true    (70 est bien au moins 18)
        //    true && false donne false : c'est la partie « moins de 65 » qui fait échouer le tarif normal.
        //    Ensuite F5 pour finir : la console affiche   Tarif normal : False
    }
}
