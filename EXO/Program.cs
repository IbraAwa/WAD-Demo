// 1
//Calculer les 25 premiers nombres de la suite de Fibonacci

//// Fibonacci
//// prendre les deux derniers nombre obtenu et les additionner

//// 0 + 1 = 1
//// 1 + 1 = 2
//// 1 + 2 = 3
//// 2 + 3 = 5
//// 3 + 5 = 8
//// 5 + 8 = 13

//int compteur = 0;
//int dernierResultat = 0;
//int avantDernierResultat = 1;

//while(compteur < 25)
//{
//    //  1         =   0                  +         1
//    int resultat = avantDernierResultat + dernierResultat;
//    avantDernierResultat = dernierResultat;
//    dernierResultat = resultat;

//    Console.WriteLine(resultat);

//    compteur++;
//}

// FACTORIELLE
// !5 = factorielle de 5 qui donne
// 5 * 4 * 3 * 2 * 1 = 120

//Console.WriteLine("choisir un nombre pour votre factoriel");
//int factoriel = int.Parse(Console.ReadLine());
//int resultat = 1;

//for (int i = 2; i <= factoriel; i++)
//{
//    resultat *= i;
//    Console.WriteLine($"resultat({resultat} = {factoriel} * {i})");
//    Console.WriteLine();
//}

//Console.WriteLine(resultat);


// Grâce à une boucle « for », calculer les x premiers nombres premiers

// nombre premier est un nombre
// qui à deux et uniquement deux diviseur distinct qui est 1 et lui même
// 0 et 1 ne sont pas premier


Console.WriteLine("Jusqu'a quel nombre inclus voulez-vous afficher si premier ou non ?");
int nombreDePremier = int.Parse(Console.ReadLine());
bool premierTrouver = false;


for (int nombreActuel = 0; nombreActuel <= nombreDePremier; nombreActuel++)
{
    // TOUT LES NOMBRES SANS EXCEPTION SONT DIVISIBLE PAR UN
    // VERIFIER SI YA PAS UN AUTRE NOMBRE QUE 1 ET LUI MEME QUI DIVISE
    for(int diviseur = 2; diviseur < nombreActuel; diviseur++)
    {
        if(nombreActuel % diviseur == 0)
        {
            Console.WriteLine($"le nombre actuel {nombreActuel} est pas premier car");
            Console.WriteLine($"il est divisible par {diviseur}");
            premierTrouver = false;
            break;
        }

        premierTrouver = true;
    }

    if( premierTrouver)
    {
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine($"le nombre {nombreActuel} est premier");
        Console.WriteLine("==========================================");
        Console.WriteLine();
    }
}