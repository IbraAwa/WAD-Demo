// ===================================================================================
//  CORRECTION — EXO 066 — TryParse avec un if
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 : la question, puis la saisie (string? car ReadLine peut renvoyer null)
        Console.Write("Votre âge : ");
        string? saisie = Console.ReadLine();

        // consigne 2 : l'appel à TryParse sert directement de condition
        if (int.TryParse(saisie, out int age))
        {
            // la conversion a réussi : age contient le nombre
            Console.WriteLine(age + 10);
        }
        else
        {
            Console.WriteLine("Pas un nombre");
        }

        // consigne 3 :
        //    tape 30  -> affiche 40
        //    tape abc -> affiche Pas un nombre   (et le programme ne plante pas)
    }
}
