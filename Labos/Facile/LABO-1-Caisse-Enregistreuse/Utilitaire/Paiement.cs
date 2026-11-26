using LABO_1_Caisse_Enregistreuse.structures;

namespace LABO_1_Caisse_Enregistreuse.Methodes;

internal struct Paiement
{
    public static bool fairePayerClient(decimal totalAPayer)
    {
        decimal montantDonnerParClient = Demande.DemanderMontant($"vous devez payer un total de {totalAPayer:2N}");
        Console.WriteLine($"Montant donner par le client {montantDonnerParClient}");
        totalAPayer -= montantDonnerParClient;

        while (totalAPayer != 0)
        {
            if (totalAPayer > 0)
            {
                montantDonnerParClient = Demande.DemanderMontant($"Montant insuffisant, il manque {totalAPayer:2N}");
                Console.WriteLine($"Montant donner par le client {montantDonnerParClient}");
                totalAPayer -= montantDonnerParClient;
            }
            else if (totalAPayer < 0)
            {
                decimal montantRenduAuClient = Demande.DemanderMontant($"Monnaie à rendre  {totalAPayer}");
                totalAPayer += montantRenduAuClient;
            }
        }

        Console.WriteLine("Merci et à bientôt au Petit Marché !");
        return true;
    }

    public static decimal AfficherTicket(Dictionary<int, Produit> produits, Dictionary<int, int> paniers)
    {
        Console.WriteLine("==== TICKET ====");
        decimal total = 0;
        foreach (var panier in paniers)
        {
            bool produitExistant = produits.TryGetValue(panier.Key, out Produit produit);

            if (produitExistant)
            {
                decimal sousTotal = panier.Value * produit.Prix;
                Console.WriteLine($"{panier.Value} * {produit.Nom} = {sousTotal}");
                total += sousTotal;
            }
            else
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("PRODUIT INEXISTANT DANS PANIER");
            }
        }
        Console.WriteLine("----------------------");
        Console.WriteLine($"TOTAL : {total}");
        return total;
    }

}
