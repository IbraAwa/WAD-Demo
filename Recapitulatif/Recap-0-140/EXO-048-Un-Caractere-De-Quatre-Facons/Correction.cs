// ===================================================================================
//  CORRECTION — EXO 048 — Un caractère de quatre façons
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 4 façons d'écrire la lettre A
        char c1 = 'A';          // la lettre directement
        char c2 = 'A';     // code Unicode (4 chiffres hexadécimaux)
        char c3 = '\x41';       // code hexadécimal
        char c4 = (char)65;     // cast : le nombre 65 devient le caractère qui a ce code

        // consigne 2 : les 4 sur une ligne, séparées par un espace
        Console.WriteLine($"{c1} {c2} {c3} {c4}");

        // a) Les 4 affichent la même lettre A : c'est le même caractère, écrit de 4 façons.
        //    Chaque caractère a un numéro (son code). Le code de A est 65 en décimal,
        //    ce qui s'écrit 41 en hexadécimal (4 × 16 + 1 = 65) : d'où A, \x41 et 65.
    }
}
