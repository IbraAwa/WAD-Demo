//// Recapitulatif : variable ; string ; conversion

//// types de variables

//string caractere; // chaine de caractère (phrase, des mots, des chiffres etc..) toujours entre "
//char unCaractère; // UNIQUEMENT un seul caractère
//bool isVrai; // soit true soit false ou une condition
//int nombreEntier; // un entier négatif ou positif entre - 2 150 milliard et + 2 150 milliard environs
//long nombreEntierTresLong; // négatif ou positif mais entre - 9 quintillon et +8 quintillon
//decimal nombrePrecis; // nombre a virugle ultra précis
//float nombrePrecisMaisMoin; // nombre a virugle précis mais moin que deicmal
//double nombreDecimalPasPrecis; // juste nombre a virgule


//// on a le var qui est utilisé pour laisser C# déterminé le type

//var exemple0 = "18"; // C# va le typer en string
//var exemple1 = 18; // C# va le typer en int

//// DISCLAMER
//// Si vous vouliez un long mais que vous mettez un petit chiffre
//// C# va penser que c'est un int


//// Parlons du type string
//// toute variable est convertible avec toString()

//int exempleConversion0 = 18;

//Console.WriteLine(exempleConversion0.ToString());

//bool exempleConversion1 = false;

//Console.WriteLine(exempleConversion1.ToString());


//// un string est immutable
//// une variable non modifiable

//// pourtant$

//string exempleString = "salut";

//exempleString += "ça va ?";

//Console.WriteLine(exempleString);

//// pourquoi ça marche alors que variable immutable ?
//// Car C# crée une copy ou il insère l'ancienne valeur + la nouvelle



//// CONVERSION

//int exempleConversion2 = 18;
//string exempleStringConversion2;

//// convertir une variable en string 
//exempleStringConversion2 = exempleConversion2.ToString();

//// PARSE

//string exempleStringParse = "false";
//bool exempleBoolParse;

//exempleBoolParse = bool.Parse(exempleStringParse);
//// valable pour tout les types sauf string
//// int.Parse()
//// long.Parse()
//// decimal.Parse()
//// etc...


//// Try parse

using System.Runtime.InteropServices.ObjectiveC;

string exempleTryParse = "false";

bool estConverti = bool.TryParse(exempleTryParse, out bool exempleBoolTryParse);

if(estConverti)
{
    Console.WriteLine("Nous avons réussir a convertir");
    Console.WriteLine(exempleBoolTryParse);
} else
{
    Console.WriteLine("nous n'avons pas réussi à convertir");
}


// Convert


int exempleIntConvert = 25;
long exempleStringConvert = Convert.ToInt64(exempleIntConvert);

// unboxing / boxing

// tout est objet

object exempleObjInt = 15;

object exempleObjString = "salut çava";
string exempleString = (string)exempleObjString;

object nouveauObjectString = exempleString;


