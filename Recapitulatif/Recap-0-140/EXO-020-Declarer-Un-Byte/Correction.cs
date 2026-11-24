// ===================================================================================
//  CORRECTION — EXO 020 — Déclarer un byte (de 0 à 255)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : 12 est bien entre 0 et 255, il tient dans un byte
        byte ageDuChat = 12;
        Console.WriteLine($"Mon chat a {ageDuChat} ans");

        // consigne 2 : ERREUR PROVOQUÉE
        // CS0031 : la valeur constante '300' ne peut pas être convertie en 'byte'.
        // Un byte va seulement de 0 à 255 : 300 ne rentre pas dedans.
        //byte tropGrand = 300;
    }
}
