
////// 0 + 1 = 1
////// 1 + 1 = 2
////// 1 + 2 = 3 
////// 3 + 2 = 5
////// 5 + 3 = 8
////// Additionner les deux derniés résultat obtenu
////// Calculer les 25 premiers nombres de la suite de Fibonacci

////int compteur = 0;
////int dernierResultat = 1;
////int avantDernierResultat = 0;

////Console.WriteLine("1");
////while(compteur < 25)
////{
////    int resultat = avantDernierResultat + dernierResultat;
////    Console.WriteLine($"resultat({resultat}) = {avantDernierResultat} + {dernierResultat}");
////    // 1 + 2 = 3 
////    // 3 + 2 = 5
////    // 5 + 3 = 8
////    avantDernierResultat = dernierResultat;
////    dernierResultat = resultat;
////    Console.WriteLine(resultat);
////    compteur++;
////}

//// Calculer la factorielle d’un nombre entré au clavier 

//// !5 => factorielle de 5 
//// 5 * 4 * 3 * 2 * 1 
//// !8 => 8 * 7 * 6 *5 *4 *3 *2 *1 
//// !4 => 4 * 3 *2 * 1

////Console.WriteLine("Quel factorielle veux-tu calculé ?");
////int factoriel = int.Parse(Console.ReadLine());
////int result = 1;

////for(int i = 1; i <= factoriel; i++)
////{ 
////    // result = result * i
////    result *= i;
////    Console.WriteLine();
////}

////Console.WriteLine($"le resultat de la factoriel de {factoriel} est {result}");


////Grâce à une boucle « for », calculer les x premiers nombres premiers

//// un nombre premeier c'est quand 
//// il possède deux division distinct qui est par 1 et par lui même
//// 1 => pas premier car pas deux division distinct
//// 2 => premier car divisible par 1 et lui même
//// 3 => premier car divisible par 1 et lui même


//Console.WriteLine("Quel sont les X premier nombre premier que tu veux calculé ?");
//int nombrePremier = int.Parse(Console.ReadLine());
//bool nombrePremierTrouver = false;

//// si nombrePremier est 10
//// je regarde si le nombreActuel ou on vérifie si c'est un premier ou non est égale
//// nombrePremeir ou plus petit
//// si plus petit on continue a vérifier le nombre suivant
//for (int nombreActuel = 1; nombreActuel <= nombrePremier; nombreActuel++)
//{
//    // tout les nombres entier sont divisible par 1
//    // tout les nombres entier sont divisible par eux même
//    // je dois regarde si mon nombreActuel n'est pas divisible par autre chose
//    // que 1 ou lui même
//    for (int diviseur = 2; diviseur < nombreActuel; diviseur++)
//    {
//        if(nombreActuel % diviseur == 0)
//        {
//            Console.WriteLine($"le nombre {nombreActuel} est divisible par {diviseur}");
//            Console.WriteLine($"Donc {nombreActuel} n'est pas premier");
//            nombrePremierTrouver = false;
//            break;
//        }

//        nombrePremierTrouver = true;
//    }

//    if(nombrePremierTrouver == true)
//    {
//        Console.WriteLine();
//        Console.WriteLine("================================================");
//        Console.WriteLine($"le nombre {nombreActuel} est un nombre premier");
//        Console.WriteLine("================================================");
//        Console.WriteLine( );
//    }
//}


///* 

// Afficher les nombres de 1 à 100, en suivant ces règles :
//un multiple de 3 s’affiche « Fizz » ;
//un multiple de 5 s’affiche « Buzz » ;
//un multiple de 3 et de 5 s’affiche « FizzBuzz » ;
//tous les autres nombres s’affichent tels quels.
// */


//// Si mon nombre est un multiple de 3

//int nombre = 3;
//if (nombre % 5 == 0 & nombre % 3 == 0)
//{

//}
//else if (nombre % 5 == 0)
//{

//}
//else if (nombre % 3 == 0);


int noteEleve = 13;


// si note eleve entre 16 et 20 => mention très bien
// si note eleve entre 13 et 15 => mention bien
// si note eleve +  ou égale à  10 => réussi
