using LABO_3_Concessionnaire.Enums;
using LABO_3_Concessionnaire.Utils;

namespace LABO_3_Concessionnaire.Structs;

internal class Concession
{
    public int Numero;
    public string Nom;

    public Dictionary<string, Voiture> Stocks;
    public Dictionary<int, Vendeur> Vendeurs;

    public Concession(int numero, string nom, Dictionary<string, Voiture> stocks, Dictionary<int, Vendeur> vendeurs)
    {
        Numero = numero;
        Nom = nom;
        Stocks = stocks;
        Vendeurs = vendeurs;
    }

    public void Add()
    {
        Plaque plaque = AjouterVoitureQuestion.DemanderPlaque(Stocks);
        string marque = AjouterVoitureQuestion.DemanderString("Marque ? : ");
        string modele = AjouterVoitureQuestion.DemanderString("Modèle ? : ");
        int annee = AjouterVoitureQuestion.DemanderInt("Année du véhicule ? : ", DateTime.Now.Year, 1990);
        int kilometrage = AjouterVoitureQuestion.DemanderInt("Kilométrage ? : ", 600_000);

        //je met rien dans le paramètre min car déjà valeur par défaut 0
        decimal prixAchat = AjouterVoitureQuestion.DemanderDecimal("Prix d'achat ? : ", true);

        // minimum prix d'achat car prix de vente toujoursp plus haut que prix d'achat
        decimal prixVente = AjouterVoitureQuestion.DemanderDecimal("Prix de vente ? : ", false, prixAchat);
        Carburant carburant = AjouterVoitureQuestion.DemanderCarburant();

        Voiture voiture = new Voiture(
            plaque,
            plaque.Immatriculation.ToUpper(),   // clé normalisée en majuscules
            marque,
            modele,
            annee,
            kilometrage,
            prixAchat,
            prixVente,
            carburant
        );

        Stocks.Add(voiture.PlaqueMajuscule, voiture);
        Console.WriteLine($"Voiture {voiture.PlaqueMajuscule} ajoutée au stock");
    }

    public void AfficherStock()
    {
        Console.WriteLine();
        Console.WriteLine($"===== {Nom.ToUpper()} — STOCK =====");

        // {valeur,-12} -> aligné à gauche sur 12 caractères (texte)
        // {valeur,8}   -> aligné à droite sur 8 caractères (nombres)
        // Pourquoi ? toutes les colonnes tombent les unes sous les autres
        Console.WriteLine($"{"Plaque",-12}{"Marque",-13}{"Modèle",-12}{"Année",5}{"Km",10}  {"Carburant",-12}{"Prix",14}");

        int nombreEnStock = 0;
        foreach (KeyValuePair<string, Voiture> stock in Stocks)
        {
            Voiture voiture = stock.Value;

            // Une voiture vendue reste dans le dictionnaire (plaque prise)
            // mais elle ne fait plus partie du stock -> on la saute
            if (voiture.EstVendue)
            {
                continue;
            }

            // Les étiquettes s'ajoutent à la fin de la ligne
            // une voiture peut avoir les deux en même temps
            string etiquettes = "";
            if (voiture.Kilometrage > 150_000)
            {
                etiquettes += " [KM ÉLEVÉ]";
            }

            if (voiture.EstReprise)
            {
                etiquettes += " [REPRISE]";
            }

            Console.WriteLine($"{stock.Key,-12}{voiture.Marque,-13}{voiture.Modele,-12}{voiture.Annee,5}{voiture.Kilometrage,10:N0}  {voiture.Carburant,-12}{voiture.PrixVente,12:N2} €{etiquettes}");
            nombreEnStock++;
        }

        Console.WriteLine($"{nombreEnStock} voiture(s) en stock");
    }
}