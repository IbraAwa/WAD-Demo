// ===================================================================================
//  LABO 3 — Le concessionnaire automobile
//  Niveau : Normal
// ===================================================================================
//
//  📄 L'ÉNONCÉ COMPLET est dans le fichier ENONCE.md de ce projet (double-clic dessus).
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
// ===================================================================================

using LABO_3_Concessionnaire.Structs;

Console.WriteLine("LABO 3 - Le concessionnaire automobile");

// ↓↓↓ écris ton code en dessous ↓↓↓

// string -> Key (Plaque immatriculation)
// Voiture -> Valeur (Struct)
Dictionary<string, Voiture> stocks = new();

// int -> Key (numéro du vendeur)
// Vendeur -> Valeur (Struct)
Dictionary<int, Vendeur> vendeurs = new();

vendeurs.Add(1, new Vendeur(1, "Marc", 10));
vendeurs.Add(2, new Vendeur(2, "Julie", 10));
vendeurs.Add(3, new Vendeur(3, "Karim", 5));

Console.WriteLine($"{vendeurs.Count} vendeurs");

// Crée une méthode AjouterVoiture()
// Pourquoi ? 
// Car ma méthode Cree() renvoie un null donc parametre dans voitures.add() n'accepte pas

AjouterVoitureInDictionnary("1-GHT-482", "Peugeot", "208", 2019, 85000, 10200m, 12500m, "Essence");
AjouterVoitureInDictionnary("2-KLM-115", "Renault", "Clio", 2021, 32000, 13100m, 15900m, "Essence");
AjouterVoitureInDictionnary("1-DFR-907", "Volkswagen", "Golf", 2016, 160000, 7800m, 9900m, "Diesel");
AjouterVoitureInDictionnary("2-MZA-340", "Toyota", "Yaris", 2022, 18000, 18300m, 21500m, "Hybride");
AjouterVoitureInDictionnary("2-TSL-003", "Tesla", "Model 3", 2023, 12000, 34500m, 38900m, "Electrique");
AjouterVoitureInDictionnary("1-HBX-761", "BMW", "Série 1", 2018, 98000, 14600m, 17400m, "Diesel");
AjouterVoitureInDictionnary("2-ABP-258", "Peugeot", "3008", 2020, 67000, 21200m, 24900m, "Hybride");
AjouterVoitureInDictionnary("1-CVN-624", "Dacia", "Sandero", 2015, 172000, 5300m, 5900m, "Essence");

Console.WriteLine($"{stocks.Count} voitures en stock");


// Notre Concession
Concession concession = new Concession(1, "AwaConcession", stocks, vendeurs);

// Fonctionnalité 1 : afficher le stock
concession.AfficherStock();

//Le vendeur saisit la plaque (format valide et plaque libre), marque, modèle, année, kilométrage, prix d'achat, prix de vente et carburant.
//Contrôles :
//marque et modèle ne peuvent pas être vides ;
//l'année est comprise entre 1990 et l'année actuelle ;
//le kilométrage est positif ou nul ;
//le prix d'achat est strictement positif ;
//le prix de vente est supérieur ou égal au prix d'achat.





void AjouterVoitureInDictionnary(string plaque, string marque, string modele, int annee,
    int kilometrage, decimal prixAchat, decimal prixVente, string carburant)
{
    Voiture? voiture = Voiture.Creer(plaque, marque, modele, annee, kilometrage, prixAchat, prixVente, carburant);
    if (voiture is not null)
    {
        stocks.Add(voiture.Value.PlaqueMajuscule, voiture.Value);
    }
}