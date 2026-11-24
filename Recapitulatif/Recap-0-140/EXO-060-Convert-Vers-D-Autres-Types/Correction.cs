// ===================================================================================
//  CORRECTION — EXO 060 — Convert vers double, bool, et l'arrondi
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le TEXTE "3,14" (virgule, car le PC est en français) devient le double 3,14
        double nombre = Convert.ToDouble("3,14");
        Console.WriteLine(nombre);

        // consigne 2 : prédiction → 10. Convert.ToInt32 ARRONDIT au plus proche (il ne coupe pas).
        // (Dans le code, 9.7 s'écrit avec un point.)
        int entier = Convert.ToInt32(9.7);
        Console.WriteLine(entier);

        // consigne 3 : 1 devient True, 0 devient False (tout nombre différent de 0 donne True)
        bool vrai = Convert.ToBoolean(1);
        bool faux = Convert.ToBoolean(0);
        Console.WriteLine(vrai);
        Console.WriteLine(faux);
    }
}
