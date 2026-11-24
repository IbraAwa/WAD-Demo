// ===================================================================================
//  CORRECTION — EXO 053 — Coller des textes avec +
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1
        string prenom = "Léa";
        string nom = "Dupont";

        // consigne 2 : le prénom, un espace, puis le nom
        string nomComplet = prenom + " " + nom;
        Console.WriteLine(nomComplet);

        // consigne 3 : sans rien entre les deux → il manque l'espace
        string nomColle = prenom + nom;
        Console.WriteLine(nomColle);

        // a) Le + colle les textes exactement tels qu'ils sont, sans rien ajouter.
        //    Ni "Léa" ni "Dupont" ne contient d'espace : il faut l'ajouter soi-même avec " ".
    }
}
