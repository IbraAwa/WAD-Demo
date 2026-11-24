// ===================================================================================
//  CORRECTION — EXO 021 — Choisir le bon type
// ===================================================================================

internal static class Correction
{
    public static void Lancer()
    {
        // consigne 1 et 3 : une variable par information, avec le pourquoi du type

        // string : un titre, c'est du texte
        string titre = "Titanic";

        // int : une année est un nombre entier (pas de virgule)
        int annee = 1997;

        // double : une durée en heures peut avoir une virgule (ce n'est pas de l'argent)
        double dureeHeures = 3.25;

        // decimal : c'est de l'argent → decimal (précis), avec le suffixe m
        decimal prixTicket = 11.50m;

        // char : la salle est désignée par UNE SEULE lettre
        char salle = 'C';

        // bool : la réponse est oui ou non (ici non → false)
        bool estEn3D = false;

        // consigne 2 : une information par ligne
        Console.WriteLine($"Titre : {titre}");
        Console.WriteLine($"Année : {annee}");
        Console.WriteLine($"Durée : {dureeHeures} heures");
        Console.WriteLine($"Prix : {prixTicket} euros");
        Console.WriteLine($"Salle : {salle}");
        Console.WriteLine($"En 3D : {estEn3D}");
    }
}
