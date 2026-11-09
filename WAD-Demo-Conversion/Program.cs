

// pour transformer une variable en string

// toString() est disponible pour tout les types
using System.Runtime.InteropServices.ObjectiveC;

int ageString1 = 15;
string ageString2 = ageString1.ToString();

// CONVERT

// --int--
//X impossible car c'est un mot (chaine de caractère)
//int nombreConvert = Convert.ToInt32("salut")
int nombreConvert = Convert.ToInt32("15");
Console.WriteLine($"nombre '15' convertit en int {nombreConvert}");

// impossible de convertir un nombre trop grand en int
// car il faut le convertir en long
//int nombreConvert1 = Convert.ToInt32("1500000000000000");
//Console.WriteLine($"nombre '15_000' convertit en int {nombreConvert1}");

//impossible de convertir un nombre avec un underscore malgré que C# l'accepte
//int nombreConvert1 = Convert.ToInt32("150_000");

// conversion un nombre en double attention selon culture de l'ordinateur
// il accepte la conversion mais il tronque la ','
double nombreDoubleConvert = Convert.ToDouble("15,05");
Console.WriteLine($"nombre '15.05' convertit en double {nombreDoubleConvert}");

Console.WriteLine();
// Convert.Methode(ce qu'on veut convertir)
// dans la parenthese on peut mettre des variables
string nombreDecimal = "11,55";
decimal nombreDecimalConvert = Convert.ToDecimal(nombreDecimal);
Console.WriteLine($"prix '11,55' convertit en decimal {nombreDecimalConvert}");

// -- Parse --

int nombreParse = int.Parse("42");
Console.WriteLine($"parse 42 en nombre {nombreParse}");

// manière de convertir une donnée reçu par l'utilisateur sans le vérifié
// problème sa crash si il nous envoie une chaine de caractère
//Console.WriteLine("Veuillez écrire votre age");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"votre age est {age}");

// manière de convertir avec sa vérification (tryParse)

// première manière : 

//Console.WriteLine("Veuillez écrire votre age");
//bool ConversionReussi = int.TryParse(Console.ReadLine(), out int age);
//if(ConversionReussi)
//{
//    Console.WriteLine($"Votre conversion est réussi : {age}");
//} else
//{
//    Console.WriteLine("Conversion non réussi");
//}

// deuxieme manière :

//Console.WriteLine("Veuillez écrire votre age");
//int age;
//// age = 18
//bool ConversionReussi = int.TryParse(Console.ReadLine(), out age);
//if (ConversionReussi)
//{
//    Console.WriteLine($"Votre conversion est réussi : {age}");
//}
//else
//{
//    Console.WriteLine("Conversion non réussi");
//}

//// 3eme manière

//if (int.TryParse(Console.ReadLine(), out int age))
//{
//    Console.WriteLine($"Votre conversion est réussi : {age}");
//} else
//{
//    Console.WriteLine($"Votre conversion est rater");
//}

// -- CONVERSION IMPLICITE --

//conversion implicite possible
// car jamais un int dépassera la valeur maximal ou minimal du long
int quantite = 3;
long stock = quantite;

// conversion implicite interdit long dont int
// car possibilité qu'un jour le long deviennent trop grand pour le int
//long quantite1 = 3_000;
//int stock1 = quantite1;

// conversion implicite possible
// car C# va transformer le char en une valeur ascii
char letter = 'a';
int letter_nombre = letter;

// -- CONVERSION EXPLICITE --


// sans conversion C# implicitment donne un entier alors qu'on attend
// un nombre a virgule
//int nbCommandes = 8;
//int nbLivrees = 2;
//int pct = 100 / nbCommandes * nbLivrees;
//Console.WriteLine($"{pct} %");
//24 % au lieu de 25 % !

// besoin de conversion explicite
int nbCommandes = 8;
int nbLivres = 2;
decimal pct = Convert.ToDecimal(100) / Convert.ToDecimal(nbCommandes) * Convert.ToDecimal(nbLivres);
Console.WriteLine($"{pct} %");
// 24 % au lieu de 25 % !


// conversion explicit avec un cast
Console.WriteLine();
Console.WriteLine();
//(int) s'applique au nombre juste après donc ici à 100f
int pct1 = (int)100f / nbCommandes * nbLivres;
Console.WriteLine($"{pct1} %");

//(int) s'applique à tout le calcule
int pct2 = (int)(100f/ nbCommandes * nbLivres);
Console.WriteLine($"{pct2} %");


// CAST explicite : arrondit

// mon (int) donc cast explicite à couter la virgule il ne l'a pas arrondit
int nombre = (int)9.99;
Console.WriteLine($"le nombre est {nombre}");
Console.WriteLine();

// si on veut arrondit il faut utiliser Math.Round()
// qui arrondit a son plus proche entier
decimal nombreDecimal1 = 9.50m;

int nombreArrondi = (int)Math.Round(nombreDecimal1);
Console.WriteLine($"le nombre arrondi est {nombreArrondi}");


// Boxing / unboxing 

// tout est objet dans C#
// string c'est objet
// int c'est objet
// class Voiture est objet

// boxing on passe d'un type précis à imprécis donc on s'n fiche
// car int est objet de toute manière
// comme une voiture est un véhicule de toute manière
int nombreBoxing = 3;
object nombreBoxer = nombreBoxing;


//unboxing on passe d'un type imprécis à un type précis donc
// on doit le dire à C#
// comme un véhicule on ne sait pas si c une voiture, camion, vélo ou autre
// on doit le précisé à la personne
object nombreUnboxing = 15;
double nombreUnboxer = (double)nombreUnboxing;