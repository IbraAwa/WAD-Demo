// ===================================================================================
//  CORRECTION — EXO 034 — int? : un nombre qui peut être vide
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : int? = un entier qui a le droit d'être vide (null)
        int? noteExamen = null;

        // consigne 2 : null ne s'affiche pas : il n'y a rien après « Note : »
        Console.WriteLine($"Note : {noteExamen}");

        // consigne 3 : l'examen est passé, la variable reçoit une vraie valeur
        noteExamen = 15;
        Console.WriteLine($"Note : {noteExamen}");

        // consigne 4 : Nullable<int> est la forme longue de int? (c'est exactement le même type)
        Nullable<int> autreNote = null;
        Console.WriteLine($"Autre note : {autreNote}");

        // consigne 5 : ERREUR CS0037 « Impossible de convertir null en 'int' parce qu'il s'agit
        // d'un type valeur non-nullable ».
        // Un int normal (sans ?) contient TOUJOURS un nombre : il ne peut pas être vide.
        // int note = null;
    }
}
