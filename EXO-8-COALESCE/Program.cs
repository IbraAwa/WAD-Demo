/* 
 pérateurs vus : coalesce ??, coalesce et affectation ??=, typeof.
1
?? : déclarer string? surnom = null; et afficher le surnom, ou « Pas de surnom » s’il est null
2 ?? : une ligne de commande a un prix unitaire et une quantité int? quantite = null;. Calculer le total 
avec une quantité de 1 par défaut
3 ?? : déclarer string? telPro et string? telPerso, puis afficher le premier numéro disponible, sinon « 
Aucun numéro »
4 ??= : List<string>? panier = null; Créer le panier avec ??=, y ajouter un article, refaire ??= et vérifier 
que l’article est toujours là
5 typeof : afficher le Name et le FullName de typeof(int), typeof(string) et typeof(decimal), puis 
tester si object o = 3.14; est un double avec GetType()
 */


// 1
//?? : déclarer string? surnom = null;
//et afficher le surnom, ou « Pas de surnom » s’il est null

// affectation avec coalesce
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using System.Threading.Channels;

string? surnom = null;

// regarde si surnom est null si il l'est applique la variable
// sinon ne l'applique pas
surnom ??= "Pas de surnom";

Console.WriteLine(surnom);

// 2
//?? : une ligne de commande a un prix unitaire
//et une quantité int? quantite = null;. Calculer le total 
//avec une quantité de 1 par défaut

decimal ligneCommandePrix = 25.50m;
int? quantite = null; // si quantite null alors quantite == 1

// COALESCE il regarde de gauche à droite
// si la valeur de gauche est null je prend la valeur de droite
decimal total = (quantite * ligneCommandePrix) ?? ligneCommandePrix;

Console.WriteLine(total);
Console.Clear();
//3
//?? : déclarer string? telPro et string? telPerso,
//puis afficher le premier numéro disponible, sinon « Aucun numéro »

string? telPro = null;
string? telPerso = null;

string contact = telPro ?? telPerso ?? "Aucun numéro";
Console.WriteLine(contact);

//4
//??= : List<string>? panier = null;
//Créer le panier avec ??=, y ajouter un article, refaire ??= et vérifier 
//que l’article est toujours là


/// EXERCICE A CHANGER

List<string>? articles = null;
articles ??= new List<string>(); // créée 
articles.Add("unicorn ice cream");

List<string> panier = null;
panier ??= articles;

Console.WriteLine($"{panier[0]}");

Console.Clear();
// 5
// typeof : afficher le Name et le FullName de typeof(int),
// typeof(string) et typeof(decimal), puis 
//tester si object o = 3.14; est un double avec GetType()

Type typeInt = typeof(int);

Console.WriteLine($"nom du int est {typeInt.Name} et son nom complet est {typeInt.FullName}");


Console.WriteLine();
Type typeString = typeof(string);
Console.WriteLine($"nom du string est {typeString.Name} et son nom complet est {typeString.FullName}");

Console.WriteLine();
Type typeDecimal = typeof(decimal);
Console.WriteLine($"nom du decimal est {typeDecimal.Name} et son nom complet est {typeDecimal.FullName}");

Console.Clear();


// Avec is, afficher « entier » pour chaque valeur qui est un int

object?[] valeurs =[42, "Bonjour", 3.14, null, -5, 'A', 150];
foreach (object? v in valeurs)
{
    if(v is int)
    {
        Console.WriteLine($"la valeur {v} est un entier");
        Console.WriteLine();

        bool petit = v is < 10;
        bool moyen = v is >= 10 and <= 99;
        bool grand = v is > 99;

        string grandeurNombre = (petit, moyen, grand) switch
        {
            (true, false, false) => "petit",
            (false, true, false) => "nombre",
            (false, false, true) => "grand"
        };

        Console.WriteLine($"la grandeur de l'entier est {grandeurNombre}");
    }

    if(v is int nombre)
    {
        nombre *= 2;
        Console.WriteLine($"le double est {nombre} ");
        Console.WriteLine();
    }

    switch (v)
    {
        case int entier when entier >= 0:
            Console.WriteLine("entier positif");
            break;
        case int:
            Console.WriteLine("entier négatif");
            break;
        case string s:
            Console.WriteLine($"texte de {s.Length} lettres");
            break;
        case double or decimal or float:
            Console.WriteLine("décimal");
            break;
        case null:
            Console.WriteLine("vide");
            break;
        default:
            Console.WriteLine("autre");
            break;
    }

    string? texte = v as string;

    if(texte is not null)
    {
        Console.WriteLine($"le texte est {texte}");
    }

}