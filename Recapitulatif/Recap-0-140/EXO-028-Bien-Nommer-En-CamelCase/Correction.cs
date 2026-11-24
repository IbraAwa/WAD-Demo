// ===================================================================================
//  CORRECTION — EXO 028 — Bien nommer ses variables (camelCase)
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 et 2 : les 4 noms corrigés en camelCase, avec le type adapté

        // NOMCLIENT → nomClient (pas tout en majuscules)
        string nomClient = "Dupont";

        // Prenom_client → prenomClient (pas de majuscule au début, pas de _)
        string prenomClient = "Léa";

        // nombredecommandes → nombreDeCommandes (une majuscule au début de chaque nouveau mot)
        int nombreDeCommandes = 3;

        // EstMembre → estMembre (la 1re lettre en minuscule)
        bool estMembre = true;

        // consigne 3 : la phrase avec les 4 variables
        Console.WriteLine($"{prenomClient} {nomClient} a passé {nombreDeCommandes} commandes (membre : {estMembre})");
    }
}
