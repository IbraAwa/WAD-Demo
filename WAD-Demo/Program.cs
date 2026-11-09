// See https://aka.ms/new-console-template for more information

// ===================================================
// AFFICHER ET LIRE DANS LA CONSOLE
// ===================================================

// Toujours utiliser le WriteLine (il revient à la ligne après le texte)
Console.WriteLine("Salut, je suis un WriteLine");

// Write écrit sans revenir à la ligne
//Console.Write("Salut, je suis un Write");

// Astuce : taper "cw" puis Tab (ou Entrée) génère Console.WriteLine();
Console.WriteLine("On peut écrire Console.WriteLine juste en tapant cw puis Tab");

// WriteLine : écrire dans la console
//Console.WriteLine("Tapez votre prénom");

// ReadLine : lire dans la console ce que l'utilisateur a écrit (jusqu'à Entrée)
//Console.ReadLine();

Console.WriteLine("Fin de programme");

// Clear efface tout ce qui a été affiché dans la console avant son appel
Console.Clear();

// Ce texte s'affiche car il est écrit après l'appel de la méthode Clear
Console.WriteLine("J'apparais après le Clear car je suis après l'appel de la méthode");

Console.WriteLine();
// ===================================================
// LES COMMENTAIRES
// ===================================================

// Commentaire sur une ligne

/*
 Commentaire
 sur
 plusieurs
 lignes
*/


// ===================================================
// LES VARIABLES
// ===================================================

// --- Les types de variables ---

// string : une chaîne de caractères (du texte)
string prenom = "Marco";

// int : nombre entier entre environ -2 milliards et +2 milliards
//int age = 19;

// long : nombre entier entre environ -9 trillions et +9 trillions
// (9 suivi de 18 chiffres)
long compteBancaire = 56146454615;

// decimal : nombre à virgule le plus précis (28-29 chiffres significatifs)
// Calculs exacts en base 10 : à utiliser pour l'argent
// Le suffixe m est obligatoire
decimal prix1 = 0.00m;

// double : nombre à virgule par défaut en C# (15-17 chiffres significatifs)
// Rapide, mais de petites erreurs d'arrondi possibles (0.1 + 0.2 != 0.3)
double prix2 = 0.00;

// float : nombre à virgule le moins précis (6-9 chiffres significatifs)
// Prend moins de mémoire (jeux, graphisme, gros tableaux)
// Le suffixe f est obligatoire
float prix3 = 0.00f;

// bool : un booléen, ne peut valoir que true (vrai) ou false (faux)
bool estMajeur = true;
bool estMineur = false;


// --- Le nom des variables ---

// Les variables sont sensibles à la casse (majuscules / minuscules) :
// il faut exactement le même nom pour que C# les considère comme la même variable.
// Ici, ce sont donc 3 variables différentes :
int age = 20;
int Age = 25;
int AGE = 35;

// Erreur de compilation : la variable AGE existe déjà, on ne peut pas la redéclarer
// int AGE = 40;

// Convention en C# : les variables locales s'écrivent en camelCase
// (première lettre en minuscule, puis une majuscule à chaque nouveau mot)
// ex : prenom, compteBancaire, estMajeur

// Mauvais exemple : nOm fonctionne, mais ne respecte pas la convention
string nOm = "";

// On peut changer la valeur d'une variable déjà déclarée (sans remettre le type)
nOm = "salut";

// -- déclarer notre variable
// Type Identifiant = valeur
// Identifiant/Nom variable

string exempleVariable = "Salut"; // Variable camelcase
// (minusucule pour la premiere lettre et chaque nouveau mot une majuscule)


// var permet de ne pas précisé le type c'est C# qui déduit le typage via la valeur
// Attention : très déconseillé
// ça reste fortement typé
var exempleVariable2 = 15;



// -- variable nullable --

string surnom1;

string surnom2 = "";

// le '?' permet de dire qu'une variable peut être nulle
string? surnom3 = "salut";

// nullable<int> =>  int? grâce au suc syntaxique
int? ageNullable;

// exemple générale variable

Console.WriteLine("Pouvez-vous écrire votre prénom silvouplait");
string? prenomChoice = Console.ReadLine();
Console.WriteLine("Pouvez-vous écrire votre nom silvouplait");
string? nomChoice = Console.ReadLine();

Console.WriteLine("votre prénom est : " + prenomChoice + " " + nomChoice);
Console.WriteLine();
// la favorite beaucoup utilisé
Console.WriteLine($"Votre prénom est {prenomChoice} {nomChoice}");
Console.WriteLine();
// utilisé pour des log
Console.WriteLine("Votre prénom est {0} {1}", prenomChoice, nomChoice);


// Crée une application console
// Dans cette application console
// demandé le prénom, nom, age, numéro bancaire
// Affiché ensuite la fiche de l'utilisateur
// affiché tout les info qu'il a écrit
