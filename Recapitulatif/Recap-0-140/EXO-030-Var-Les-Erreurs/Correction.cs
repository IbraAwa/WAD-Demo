// ===================================================================================
//  CORRECTION — EXO 030 — Les erreurs avec var
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : ERREUR PROVOQUÉE
        // CS0818 : les variables implicitement typées doivent être initialisées.
        // Sans valeur, C# n'a rien pour deviner le type : var a TOUJOURS besoin d'une valeur.
        //var x;

        // consigne 2 : avec une valeur, C# devine int
        var nombre = 42;
        Console.WriteLine(nombre);

        // consigne 3 : ERREUR PROVOQUÉE
        // CS0029 : impossible de convertir implicitement le type 'string' en 'int'.
        // nombre a été créé comme un int : son type ne changera plus jamais, il ne peut pas recevoir du texte.
        //nombre = "quarante-deux";

        // a) « Fortement typé » veut dire que la variable a UN type précis, choisi une fois pour toutes
        //    au moment de la déclaration (ici int, deviné grâce à 42). var ne veut pas dire
        //    « n'importe quel type » : c'est juste C# qui écrit le type à ta place.
    }
}
