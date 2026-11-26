using LABO_1_Caisse_Enregistreuse.structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABO_1_Caisse_Enregistreuse.Methodes;

internal class Affichage
{
    public static void AfficherCatalogue(Dictionary<int, Produit> produits)
    {
        Console.WriteLine();
        Console.WriteLine("================");
        Console.WriteLine("Les produits");
        Console.WriteLine("================");
        Console.WriteLine();
        foreach (KeyValuePair<int, Produit> produit in produits)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Code produit : {produit.Key}");
            Console.WriteLine($"Nom du produit : {produit.Value.Nom}");
            Console.WriteLine($"Catégorie du produit :{produit.Value.Categorie}");
            Console.WriteLine($"Prix du produit : {produit.Value.Prix:N2} EUR");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
        Console.WriteLine("==========================================================");
    }

    public static void AfficherMenu()
    {
        Console.WriteLine("===== LE PETIT MARCHÉ =====");
        Console.WriteLine("1. Nouveau client");
        Console.WriteLine("2. Afficher le catalogue");
        Console.WriteLine("3. Réapprovisionner un produit");
        Console.WriteLine("4. Ajouter un produit au catalogue");
        Console.WriteLine("5. Rapport de la journée");
        Console.WriteLine("0. Fermer la caisse");
        Console.WriteLine();
    }
}
