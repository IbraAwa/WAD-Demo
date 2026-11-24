//// LES STRUCTURES

//// Ce sont des types complexe qui permettent
//// d'avoir des informations supplémentaire sur un objet en particulier

//// imaginer un gros carton avec à l'intérieur des petit carton
//// le gros carton peut être une voiture
//// avec des mini carton à l'intérieur où on pourrait avoir la marque, modèle, année etc..


//using DEMO;

//// Crée mon objet voiture en mettant directement les valeur dans ses propriété
//Voiture voiture1 = new()
//{
//    Marque = "BMW",
//    Couleur = "Rouge"
//};

//// La voiture2 va prendre les caractèristiques de la voiture 1
//Voiture voiture2 = voiture1;
//// Aucun changement dans voiture 1 car voiture2 est indépendant (type valeur)
//voiture2.Marque = "Honda";

//Console.WriteLine($"la couleur de la voiture 1 est {voiture1.Couleur}");

//Console.WriteLine("Avec quel couleur voulez-vous repeindre votre voiture ?");

//// Vous pouvez réaffecter une nouvel valeur dans la propriété d'une voiture
//string newCouleur = Console.ReadLine();
//voiture1.Couleur = newCouleur;
//Console.WriteLine();
//Console.WriteLine($"vous avez changer de couleur vous êtes passé au {voiture1.Couleur}");
//Console.WriteLine();

////// Crée mon objet
////Voiture voiture2 = new();

//////ensuite insérer dans ses propriétés une valeur
////voiture2.Marque = "Mercedes";
////voiture2.Couleur = "Vert";



//// Créez dans un fichier une struct 'Article' qui aura comme propriétés :
//// - Nom
//// - Categorie (fruit, légume, snack ou autre...)
//// - NombreStock (la quantité disponible en stock)

//// Exemple d'un article :
//// Nom = "Pomme"
//// Categorie = "Fruit"
//// NombreStock = 15

//// Vous demanderez à l'utilisateur (via Console.ReadLine) de créer ses articles :
//// - demander un nom, une catégorie et un nombre en stock
//// - les ajouter dans une collection (List<...>)
//// Quand l'utilisateur a créé tous les articles dont il a besoin,
//// les afficher un par un.
