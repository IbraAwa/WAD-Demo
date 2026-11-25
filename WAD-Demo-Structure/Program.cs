// === LES STRUCTURES (struct) ===

// ce sont des types complexes qui permettent de regrouper
// plusieurs informations sur un objet en particulier

// imaginez un gros carton avec à l'intérieur des petits cartons
// le gros carton peut être une voiture
// avec des petits cartons à l'intérieur où on pourrait avoir la marque, le modèle, l'année, etc.

// struct = le plan (Voiture.cs, Article.cs)
// objet  = une voiture construite avec ce plan (new)
// une struct est un TYPE VALEUR (comme int) : la copier crée une copie indépendante
// (une class, qu'on verra plus tard, est un type référence)

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Structure;
using WAD_Demo_Structure.Demos;

// ==============================================
// CRÉER (instancier)  new / { } / constructeur   (Creer.cs)
// ==============================================
Console.WriteLine("===== CRÉER UNE STRUCT =====");
Creer.InstancierSansConstructeurDemo();
Creer.InstancierPuisRemplirLesProprietesDemo();
Creer.InstancierAvecConstructeurDemo();
Creer.StructAvecPlusieursTypesDemo();
Creer.PiegeNewSansArgumentIgnoreLeConstructeurDemo();

// ==============================================
// TYPE VALEUR  copie / Equals                     (TypeValeur.cs)
// ==============================================
Console.WriteLine("===== TYPE VALEUR =====");
TypeValeur.CopierUneStructCreeUneVoitureIndependanteDemo();
TypeValeur.ComparerDeuxStructsAvecEqualsDemo();

// ==============================================
// LIST DE STRUCTS  List<Voiture> / foreach        (ListeDeStructs.cs)
// ==============================================
Console.WriteLine("===== LIST DE STRUCTS =====");
ListeDeStructs.ListeDeVoituresDemo();
ListeDeStructs.PiegeModifierUneStructDansUneListeDemo();

// ==============================================
// AVEC L'UTILISATEUR                              (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.RepeindreLaVoitureDemo();

// EXERCICE : la struct Article avec saisie de l'utilisateur -> voir Exo-11-Structures-Articles


// On instancie un article avec une autre structure
// Une structure dans une structure
Price price = new(0.50m, "EUR");
Article article = new("Pomme", "Fruit", 15, price);