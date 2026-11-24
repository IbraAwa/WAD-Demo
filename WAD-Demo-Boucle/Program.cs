
//// FOR
//// on l'utilise quand
//// on est sur combien de fois on va répéter l'action exactement
//// quand on veut aller chercher dans un tableau un élément via son index

////  initilialiseur  condition  itérateur
//for(int i = 0      ; i < 5    ; i++)
//{
//    Console.WriteLine($"je suis au numéro {i}");
//}

//Console.Clear();

//// exemple 
//// Je suis un pilote de F1 et je veux faire 5 tours de circuit
//// pour notre compétition il doit faire 5 tour de circuit

////int tourFaitDuCircuit = 5;
////for(int i = 0; i <= 5; i++)
////{
////    Console.WriteLine($"Mon pilote est au {i}eme tour");
////}

//int tourFaitDuCircuit = 5;
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Mon pilote est au {i}eme tour");
//}

//Console.Clear();

//// EXEMPLE lancement d'une fuséee
//// crée un décompte de 10 -> 0 pour lancer notre fuséé
//int compter = 10;

//Console.WriteLine("Départ de la fusée dans...");
//for(int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//Console.Clear();
//// choisir le nombre de fois qu'on va répéter la boucle
////Console.WriteLine("A partir de quel nombre voulez-vous decompter ?");
////int nombreACompter = int.Parse(Console.ReadLine());

////Console.WriteLine($"Vous avez choisis de decompter de {nombreACompter} jusqu'a 0");
////for(int i = nombreACompter; i >= 0; i--)
////{
////    Console.WriteLine(i);
////}

//Console.WriteLine("A partir de quel nombre voulez-vous decompter ?");
//int nombreACompter = int.Parse(Console.ReadLine());

//Console.WriteLine("Et jusqu'a quel nombre voulez-vous qu'on decompte ?");
//int nombreFini = int.Parse(Console.ReadLine());
//Console.WriteLine();

//Console.WriteLine($"Vous avez choisis de decompter de {nombreACompter} jusqu'a {nombreFini}");
//for(int i = nombreACompter; i >= nombreFini; i--)
//{
//    Console.WriteLine(i);
//}


// WHILE
// WHILE est utilisé quand on compte pas forcément quelque chose
// WHILE peut-être utilisé pour une condition autre qu'un chiffre


// EXEMPLE 
// Je veux que mon enfant apprenne à dire "bonjour"
// tant qu'il ne dit pas bonjour je continue à lui demander de le dire
//Console.Clear();
//Console.WriteLine("Chère enfant peux-tu dire 'bonjour'");
//string demanderUnBonjour = Console.ReadLine();

//while(demanderUnBonjour != "bonjour")
//{
//    Console.WriteLine("Non ce n'est pas comme ça qu'on dit bonjour...dit 'bonjour'");
//    demanderUnBonjour = Console.ReadLine();
//}
//Console.WriteLine();
//Console.WriteLine("Merci d'avoir dit bonjour");

// DO WHILE
// EFFECTUE l'action PUIS REGARDE LA CONDITION

// Menu et il doit prendre absolument des frites dans notre menu
// Tant qu'il ne prend pas de frite on continue à lui demander
//Console.Clear();
//string choixUtilisateur;
//do
//{
//    Console.WriteLine("Que veux-tu dans ton menu ?");
//    choixUtilisateur = Console.ReadLine();
//} while (choixUtilisateur != "frite");


// FOREACH
// récupère la valeur d'un élément dans une liste
// attention il ne récupère pas l'index

string[] fruitLegumes = ["Pomme", "Poire", "Banane", "Brocoli", "Tomate", "Haricot"];

foreach(string fruitLegume in fruitLegumes)
{
    Console.WriteLine(fruitLegume);
}

int[] noteEleves = [12, 15, 18, 9, 7, 2, 12, 10];

foreach(int noteEleve in noteEleves)
{
    if(noteEleve >= 10)
    {
        Console.WriteLine($"vous avez réussi avec la note de {noteEleve}");
    } else
    {
        Console.WriteLine($"vous avez échoué avec la note de {noteEleve} ");
    }
}