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



// Car le Do While, fait l'action puis regarde si il continue 
// il fait une logique puis regarde si la condition est vrai dans le while

using Exo_11_Structures_Articles;

List<Article> articles = new();

// Piège du Do..While... 
// le While ne connait pas les variables qui sont dans le DO
// Donc obligé d'initialiser ma variable continuer en-dehors de la boucle

bool continuer = true;
do
{
    // Méthode qui crée l'article
    // pour aérer le code
    // si vous bloquez passer au exerccie dans le slide numéro 194
    // ou aux exercices récap
    // quand c'est fait passer au exercice dans le slide numéro 194

    Console.WriteLine("Crée votre article");
    Console.Write("Nom de l'article ? ");
    string nom = Console.ReadLine();
    Console.Write("Catégorie de l'article ? ");
    string categorie = Console.ReadLine();
    Console.Write("Nombe en stock ? ");
    int stock = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Emballage emballage = Emballage.CreerEmballage();
    // Crée l'objet article
    Article article = new(nom, categorie, stock, emballage);

    articles.Add(article);

    Console.WriteLine("Veux-tu rajouter un autre article ? (True/False)");
    continuer = bool.Parse(Console.ReadLine());


} while (continuer);


foreach (Article article in articles)
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"Article : {article.Nom}");
    Console.WriteLine($"Catégorie : {article.Categorie}");
    Console.WriteLine($"Nombre en stock : {article.Stock}");
    Console.WriteLine("il est dans un emballage qui est décrit comme tel :");
    Console.WriteLine($"couleur emballage : {article.Emballage.Couleur}");
    Console.WriteLine($"emballage en vrac ? : {article.Emballage.Vrac}");
    Console.WriteLine($"matière de l'emballage : {article.Emballage.Matiere}");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine();
}

// soit la méthode dans le fichier ou vous allez appeler la méthode
// Ou alors dans emballage mais il faut mettre les deux mot clée
// public (pour que tout le monde voit la méthode)
// static (pour appeler la méthode sans crée d'emballage avant)
//Emballage CreerEmballage()
//{
//    Console.WriteLine("Création d'emballage");
//    Console.WriteLine("Quel couleur est votre emballage ?");
//    string couleur = Console.ReadLine();
//    Console.WriteLine("Est-il en vrac ? (true/false");
//    bool vrac = bool.Parse(Console.ReadLine());
//    Console.WriteLine("De quel matière est l'emballage");
//    string matiere = Console.ReadLine();

//    return new Emballage(couleur, vrac, matiere);
//}