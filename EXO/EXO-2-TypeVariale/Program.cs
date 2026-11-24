/*
 * Sans exécuter le code, notez pour chaque ligne 
 * la valeur et le type qui seront affichés
 *Exécutez ensuite le programme pour vérifier
 *Expliquez chaque différence avec votre prédiction
*/

// il divise deux int ensemble donc pour garder le type en int
// il arrondit a l'unité inférieur
var a = 5 / 3; // 2 - int
Console.WriteLine($"la variable a est de type {a.GetType()}");
Console.WriteLine($"la variable a est {a}");
var b = 5 / 2.0; //2.5 - double
Console.WriteLine();
Console.WriteLine($"la variable b est de type {b.GetType()}");
Console.WriteLine($"la variable b est {b}");
var c = 5f / 2; // 2.5 - float
Console.WriteLine();
Console.WriteLine($"la variable c est de type {c.GetType()}");
Console.WriteLine($"la variable c est {c}");
var d = 10m / 4; // 2.5 - decimal
Console.WriteLine();
Console.WriteLine($"la variable d est de type {d.GetType()}");
Console.WriteLine($"la variable d est {d}");
var e = 5L * 2; // 10 - long
Console.WriteLine();
Console.WriteLine($"la variable e est de type {e.GetType()}");
Console.WriteLine($"la variable e est {e}");

// 'a' transformer en valeur ASCII puis calculé
var f = 'a' + 1;
Console.WriteLine();
Console.WriteLine($"la variable f est de type {f.GetType()}");
Console.WriteLine($"la variable f est {f}");