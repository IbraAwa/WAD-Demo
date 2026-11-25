//// LES METHODES


//// Deux sortes de méthodes

//// Procédure
//// Void ne return rien
//void Bonjour()
//{
//    Console.WriteLine("Bonjour");
//}


//// Pour invoqué une méthode (l'appeler)

//Bonjour();


//// Fonction

//// Une fonction comme elle return une valeur
//// Elle doit avant son nom avoir le nom du type retourné
//// Dans notre cas une addition return un int
////int Addition(int a, int b)
////{
////    //int result = a + b;

////    //return result;

////    // Moyen plus simple

////    return a + b;
////}
//Console.WriteLine();

//int resultat = Addition(5, 5);
//Console.WriteLine(resultat);


//// une fonction peut comporter plusieurs paramètre
//// Mais à chaque paramètre que vous mettez
//// vous devez les utilisées à chaque fois que vous invoqué votre fonction
//decimal Soustraction(int a, decimal b)
//{
//    return a - b;
//}

//Console.WriteLine("soustraction : ");
//decimal difference = Soustraction(10, 5.00m);
//Console.WriteLine(difference);
//Console.Clear();

////Quan vous écrivez une fonction
//// toujours faire en sorte que tout les chemins du code renvoie une valeur
//string? Signe(int nombre)
//{
//    if(nombre > 0)
//    {
//        return "Positif";
//    }

//    if(nombre < 0)
//    {
//        return "Négatif";
//    }

//    return null;
//}

//// JE veux savoir SI mon nombre 5 est positif ou négatif
//string? signeTrouver = Signe(-9);
//Console.WriteLine(signeTrouver);


//// Utiliation de Coalesce si notre fonction peut renvoyer un null
//string? signeTrouver1 = Signe(0) ?? "Zero est ni négatif ni positif";
//Console.WriteLine(signeTrouver1);

//Console.Clear();
//// Cette fonction va passer le bonjour à quelqu'un en particulier
//// Bonjour Myriam
//// Bonjour Eva
//// Bonjour Lea
//string PasserLeBonjourA(string prenom, string nom)
//{
//    return $"Bonjour {prenom} {nom}";
//}

//string prenom = PasserLeBonjourA("John", "Doe");
//string prenom1 = PasserLeBonjourA("Bernad", "Lechevre");

//Console.WriteLine(prenom);
//Console.WriteLine(prenom1);


//// Des fonction ou procédure ou on peut mettre des paramètre facultative (non obligatoire)
//// Attention un paramètre facultatif doit obligatoirement être en dernier
//string Saluer(string prenom, string formulePolitesse = "Bonjour")
//{
//    return $"{formulePolitesse} {prenom}";
//}


//Saluer(prenom: "Myriam");

//Saluer("Léa");

//Saluer("Clem");

//Saluer("Roi Philippe", "Bonjour majesté");


//Saluer(prenom: "Roi Philippe", formulePolitesse: "Bonjour majesté");


//string Ecrire(
//    string prenom, 
//    string nom, 
//    string phrase1 = "phrase du début", 
//    string phrase2 = "phrase du milieu", 
//    string phrase3 = "phrase de fin")
//{
//    return "Exemple";
//}


//// Vous voulez faire une somme
//// donc vous allez crée une fonction qui fait une addition 

//// Params accepte n'importe quel nombre de paramètre
//int Addition(params int[] nombres)
//{
//    int somme = 0;
//    for (int i = 0; i < nombres.Length; i++)
//    {
//        somme += nombres[i];
//    }

//    return somme;
//}

//int[] nombres = [5, 15, 30];


//int somme = Addition(10, 5, 25);
//Console.WriteLine($"la somme de l'addition est : {somme}");

//Console.Clear();
////string FormerPhrase(params string[] mots)
////{
////    return "";
////}


//// SANS LE REF
//// Le paramètre est bien doublé mais pas la variable global int nombre
////void doubler(int nombre)
////{
////    nombre *= 2;
////}

////int nombre = 10;
////doubler(nombre);
////Console.WriteLine($"la valeur du nombre est : " +
////    $" {nombre}");


//// je garde la ref (référence mémoire) de ma variable passer en paramètre
//// et je la modifie direct à son address 
//void doubler(ref int nombre)
//{
//   nombre *= 2;
//}

//int nombre1 = 10;
//doubler(ref nombre1);
//Console.WriteLine($"la valeur du nombre est : " +
//    $" {nombre1}");

Console.Clear();

// Mot clée : out
// Lui il permet de resortir une valeur après le traitement dans la fonction


// out utilisé dans les try parse
//bool estConverti = int.TryParse("salut", out int resultat);

// Imaginer que vous voulez avoir une méthode qui divise un nombre
// On doit tester si la division est possible et en même temps redonner le nombre diviser
// quand vous utilisez out vous devez absolument lui assigné une valeur avant de sortir de la fonction
bool Division(int a, int b, out decimal result)
{
    result = 0.00m;

    if(a == 0 || b == 0)
    {
        return false;
    }

    result = a / b;

    return true;
}


bool EstDivisible = Division(10, 2, out decimal resultat);

if(EstDivisible)
{
    Console.WriteLine($"ma division donne : {resultat}");
} else
{
    Console.WriteLine("ma division est impossible");
}


// 4 ligne pour la version longue
int multiplication(int a, int b)
{
    return a * b;
}

// 1 ligne pour la version courte
// Si votre logique prend plusieurs ligne version longue obligatoire

int multiplication1(int a, int b) => a * b;

