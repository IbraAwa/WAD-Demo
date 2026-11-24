// ===================================================================================
//  CORRECTION — EXO 008 — ReadKey : attendre une seule touche
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : le message
        Console.WriteLine("Appuie sur n'importe quelle touche...");

        // consigne 2 : pause jusqu'à ce qu'on appuie sur UNE touche (pas besoin d'Entrée)
        Console.ReadKey();

        // consigne 3 : ReadKey affiche la touche et le curseur reste juste après elle,
        //              donc on revient à la ligne sans rien afficher
        Console.WriteLine();

        // consigne 4 : la suite
        Console.WriteLine("Touche reçue !");

        // a) ReadKey attend UNE SEULE touche : le programme continue dès qu'on l'appuie.
        //    ReadLine attend toute une ligne : on peut taper plusieurs caractères,
        //    et le programme ne continue que quand on appuie sur Entrée.
    }
}
