//// See https://aka.ms/new-console-template for more information

//// ===================================================
//// AFFICHER ET LIRE DANS LA CONSOLE
//// ===================================================

//// Toujours utiliser le WriteLine (il revient à la ligne après le texte)
//Console.WriteLine("Salut, je suis un WriteLine");

//// Write écrit sans revenir à la ligne
////Console.Write("Salut, je suis un Write");

//// Astuce : taper "cw" puis Tab (ou Entrée) génère Console.WriteLine();
//Console.WriteLine("On peut écrire Console.WriteLine juste en tapant cw puis Tab");

//// WriteLine : écrire dans la console
////Console.WriteLine("Tapez votre prénom");

//// ReadLine : lire dans la console ce que l'utilisateur a écrit (jusqu'à Entrée)
////Console.ReadLine();

//Console.WriteLine("Fin de programme");

//// Clear efface tout ce qui a été affiché dans la console avant son appel
//Console.Clear();

//// Ce texte s'affiche car il est écrit après l'appel de la méthode Clear
//Console.WriteLine("J'apparais après le Clear car je suis après l'appel de la méthode");

//Console.WriteLine();
//// ===================================================
//// LES COMMENTAIRES
//// ===================================================

//// Commentaire sur une ligne

///*
// Commentaire
// sur
// plusieurs
// lignes
//*/


//// ===================================================
//// LES VARIABLES
//// ===================================================

//// --- Les types de variables ---

//// string : une chaîne de caractères (du texte)
//string prenom = "Marco";

//// int : nombre entier entre environ -2 milliards et +2 milliards
////int age = 19;

//// long : nombre entier entre environ -9 trillions et +9 trillions
//// (9 suivi de 18 chiffres)
//long compteBancaire = 56146454615;

//// decimal : nombre à virgule le plus précis (28-29 chiffres significatifs)
//// Calculs exacts en base 10 : à utiliser pour l'argent
//// Le suffixe m est obligatoire
//decimal prix1 = 0.00m;

//// double : nombre à virgule par défaut en C# (15-17 chiffres significatifs)
//// Rapide, mais de petites erreurs d'arrondi possibles (0.1 + 0.2 != 0.3)
//double prix2 = 0.00;

//// float : nombre à virgule le moins précis (6-9 chiffres significatifs)
//// Prend moins de mémoire (jeux, graphisme, gros tableaux)
//// Le suffixe f est obligatoire
//float prix3 = 0.00f;

//// bool : un booléen, ne peut valoir que true (vrai) ou false (faux)
//bool estMajeur = true;
//bool estMineur = false;


//// --- Le nom des variables ---

//// Les variables sont sensibles à la casse (majuscules / minuscules) :
//// il faut exactement le même nom pour que C# les considère comme la même variable.
//// Ici, ce sont donc 3 variables différentes :
//int age = 20;
//int Age = 25;
//int AGE = 35;

//// Erreur de compilation : la variable AGE existe déjà, on ne peut pas la redéclarer
//// int AGE = 40;

//// Convention en C# : les variables locales s'écrivent en camelCase
//// (première lettre en minuscule, puis une majuscule à chaque nouveau mot)
//// ex : prenom, compteBancaire, estMajeur

//// Mauvais exemple : nOm fonctionne, mais ne respecte pas la convention
//string nOm = "";

//// On peut changer la valeur d'une variable déjà déclarée (sans remettre le type)
//nOm = "salut";

//// -- Déclarer une variable --
//// Type Identifiant = valeur;
//// Identifiant = nom de la variable

//string exempleVariable = "Salut"; // Variable en camelCase
//// (minuscule pour la première lettre, puis une majuscule à chaque nouveau mot)


//// var permet de ne pas préciser le type : c'est C# qui le déduit à partir de la valeur
//// Attention : très déconseillé
//// Ça reste fortement typé
//var exempleVariable2 = 15;



//// -- Variable nullable --

//string surnom1;

//string surnom2 = "";

//// Le '?' permet de dire qu'une variable peut être nulle
//string? surnom3 = "salut";

//// Nullable<int> => int? grâce au sucre syntaxique
//int? ageNullable;

//// Exemple général sur les variables

//Console.WriteLine("Pouvez-vous écrire votre prénom s'il vous plaît ?");
//string? prenomChoice = Console.ReadLine();
//Console.WriteLine("Pouvez-vous écrire votre nom s'il vous plaît ?");
//string? nomChoice = Console.ReadLine();

//Console.WriteLine("Votre prénom est : " + prenomChoice + " " + nomChoice);
//Console.WriteLine();
//// La favorite, très utilisée (interpolation de chaîne)
//Console.WriteLine($"Votre prénom est {prenomChoice} {nomChoice}");
//Console.WriteLine();
//// Utilisée pour les logs
//Console.WriteLine("Votre prénom est {0} {1}", prenomChoice, nomChoice);


// -- porté des variables --

//int a = 15;

//if (a <= 100)
//{
//    int b = 10;
//    Console.WriteLine($"valeur de a est {a}");
//    Console.WriteLine($"valeur de b est {b}");

//}

//Console.WriteLine($"la valeur de a est {a}");
//Console.WriteLine($"la valeur de b est {b}");

// ---constante---

// écrire une constante quand la valeur ne change jamais ou casi jamais
const decimal prix_constante = 10.50m;


// ---nullable sur int---

int? nombre = 50;

// attention on ne vérifie pas si il y'a bien une valuer dans la variable
// si pas de valeur cela peut casser
Console.WriteLine(nombre.Value);

if(nombre.HasValue)
{
    // on est sur que la variable n'est pas nulle elle à une valeur
    Console.WriteLine(nombre.Value);
}

// -- type référence ou valeur --

// un type qui est de type valeur
// quand on comapre les deux 
// le langage va comaprer les deux valeur

int nombre1 = 50;
int nombre2 = 50;

if(nombre1 == nombre2)
{
    Console.WriteLine("les nombres sont égaux");
}

List<int> list_nombre1 = new List<int>
{
    1, 2, 3, 4 , 5
};

List<int> list_nombre2 = new List<int>
{
    1, 2, 3, 4 , 5
};

if(list_nombre1 == list_nombre2)
{
    Console.WriteLine("la liste est pareille");
} else
{
    Console.WriteLine("la liste n'est pas pareille");
}

// mettre une référence dans une autre référence

List<int> list_nombre3 = new List<int>
{
    1, 2, 3, 4 , 5
};

List<int> list_nombre4 = list_nombre3;

if(list_nombre3 == list_nombre4)
{
    Console.WriteLine("c'est pareil");
} else
{
    Console.WriteLine("ce n'est pas pareil");
}

// -- type littérale--

// les nombre à virgule


// quand une variable est de type decimal 
// mettre un 'm' après le nombre
decimal nombreVirgule = 15.50m;

// quand une variable est de type double
// mettre un 'D' après le nombre
// mais non obligatoire
double nombreVirugleDouble1 = 16.25;
double nombreVirguleDouble2 = 16.25D;

// quand une variable est de type float
// mettre un 'F' après le nombre
float nombreVirugleFloat = 16.25f;

// de même pour les nombre non a virgule

// si vous crée une variable avec un petit nombre 
// susceptible de devenir un trop gros nombre
// mettre 'L' après le nombre le fait devenir long
var numeroBancaire = 1515155L;