// ===================================================================================
//  CORRECTION — EXO 054 — StringBuilder : construire un texte morceau par morceau
// ===================================================================================

// consigne 1 : le using se place tout en haut du fichier.
// Dans Program.cs, il faut l'écrire AVANT la ligne Console.WriteLine du titre ;
// ici, il est en haut de Correction.cs pour que la correction compile.
using System.Text;

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 2 : un StringBuilder vide
        StringBuilder sb = new StringBuilder();

        // consigne 3 : chaque Append ajoute un morceau à la fin
        sb.Append("Le Petit Prince");
        sb.Append(" - ");
        sb.Append("Antoine de Saint-Exupéry");

        // consigne 4 : ToString transforme le « texte en chantier » en vraie string
        string texte = sb.ToString();
        Console.WriteLine(texte);
    }
}
