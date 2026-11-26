// ===================================================================================
//  LABO 1 — La caisse enregistreuse
//  Niveau : Facile
// ===================================================================================
//
//  📄 L'ÉNONCÉ COMPLET est dans le fichier ENONCE.md de ce projet (double-clic dessus).
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
// ===================================================================================

using LABO_1_Caisse_Enregistreuse.Enums;
using LABO_1_Caisse_Enregistreuse.Methodes;
using LABO_1_Caisse_Enregistreuse.structures;

Console.WriteLine("LABO 1 - La caisse enregistreuse");
Console.WriteLine();

// ↓↓↓ écris ton code en dessous ↓↓↓

Dictionary<int, Produit> produits = new()
{
    { 1, new Produit(1, "Pomme", 0.50m, Categorie.Fruit) },
    { 2, new Produit(2, "Banane", 0.35m, Categorie.Fruit) },
    { 3, new Produit(3, "Carotte", 0.20m, Categorie.Legume) },
    { 4, new Produit(4, "Tomate", 0.80m, Categorie.Legume) },
    { 5, new Produit(5, "Eau 1,5 L", 0.90m, Categorie.Boisson) },
    { 6, new Produit(6, "Jus d'orange", 2.40m, Categorie.Boisson) },
    { 7, new Produit(7, "Chips",1.95m, Categorie.Snack) },
    { 8, new Produit(8, "Chocolat", 2.20m, Categorie.Snack) }
};

// Console.WriteLine(produits.Count); => Montre le nombre d'élément dans le dictionnaire
List<Vente> ventes = new();

Affichage.AfficherCatalogue(produits);

// KEY (code article), Value (quantité)

int choix;

do
{
    Affichage.AfficherMenu();
    choix = Demande.demandeEntierEntre("Ton choix ? (0 à 5)", 0, 5);

    switch (choix)
    {
        case 1:
            Vente vente = PasserEnCaisse(produits, ventes.Count + 1);
            if (vente.MontantPaye > 0)
            {
                ventes.Add(vente);
            }
            break;

        case 2:
            Affichage.AfficherCatalogue(produits);
            break;

        case 3:
        case 4:
        case 5:
            Console.WriteLine("Pas encore fait...");
            break;

        case 0:
            break;
    }

    if (choix != 0)
    {
        Console.WriteLine();
        Console.WriteLine("Appuie sur une touche pour revenir au menu...");
        Console.ReadKey();
        Console.Clear();
    }

} while (choix != 0);

static Vente PasserEnCaisse(Dictionary<int, Produit> produits, int numeroTicket)
{
    Dictionary<int, int> paniers = new Dictionary<int, int>();
    int code = 0;
    do
    {
        code = Demande.DemanderEntier("Code du produit ? (0 pour terminer)");
        bool produitRecu = produits.TryGetValue(code, out Produit produit);

        if (produitRecu)
        {
            int quantite = Demande.DemanderEntier("Quantité à ajouté ?");

            if (paniers.ContainsKey(produit.Code))
            {
                paniers[produit.Code] += quantite;
                Console.WriteLine();
                Console.WriteLine($"vous avez rajouté {quantite} {produit.Nom}");
                Console.WriteLine($"vous avez donc {paniers[produit.Code]} {produit.Nom} au total");
                Console.WriteLine();
            }
            else
            {
                paniers[produit.Code] = quantite;
                Console.WriteLine();
                Console.WriteLine($"votre panier contient un nouveau article : {quantite} {produit.Nom}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Code inconnu !");
        }

    } while (code != 0);

    if(paniers.Count <= 0 )
    {
        Console.WriteLine("Panier vide");
        return new Vente(numeroTicket, 0, 0, 0);
    }

    decimal totalAchat = Paiement.AfficherTicket(produits, paniers);

    decimal remise = Calcule.CalculerRemise(ref totalAchat);

    bool clientAPayer = Paiement.fairePayerClient(totalAchat);

    return new Vente(numeroTicket, paniers.Count,  remise, totalAchat);
}
