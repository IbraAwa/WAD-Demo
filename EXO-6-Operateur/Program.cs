// 1

//Raccourcis: double total = 0;
//Ajouter trois articles (12,50 ; 7,99; 20) avec +=, appliquer 10 % de 
//remise avec *=, afficher le total

using System.Reflection.Metadata;

double total = 0;
double articleUn = 12.50;
double articleDeux = 7.99;
double articleTrois = 20;

total += articleUn;
total += articleDeux;
total += articleTrois;

// total += articleUn + articleDeux + articleTrois
//double remise = total * 0.10;
//total -= remise;

total *= 0.90; // total - remise
Console.WriteLine($"le total est de {total}");


//Incrémentation: partir de int commandes = 0;,
//ajouter 3 commandes avec ++, en annuler une 
//avec --. Puis prédire les valeurs de int a = commandes++;
//et int b = ++commandes;, et vérifier

int commandes = 0;
commandes++;
commandes++;
commandes++;
commandes--;
// je suis à 2 commandes
Console.WriteLine(commandes);

// quand on fait une post incrémentation
// on rajoute une commande et ensuite on l'affecte à la variable
int a = commandes++; // post incrémentation -> commande devient 3
Console.WriteLine($"la valeur de a est {a} et nombre de commande {commandes}");

// quand on fait une pré incrémentation
// on l'affecte dans la variable et ensuite on rajoute une commande
int b = ++commandes; // pré incrémentation
Console.WriteLine($"la valeur de b est {b} et nombre de commande {commandes}");


Console.WriteLine("Continuer exercice ternaire");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("ternaire");
// TERNAIRE

// Ternaire: demander l’âge, afficher « Majeur » ou « Mineur »
// + ou égale à 18ans => majeur
// strictement - que 18ans => mineur

//Console.WriteLine("Taper votre âge");
//int ageChoisi = int.Parse(Console.ReadLine());


//// -------------CONDITION(ageChoisi >= 18) ? SIVRAI(Majeur) : SIFAUX(Mineur)
//string status = ageChoisi >= 18 ? "Majeur" : "Mineur";
//Console.WriteLine(status);



// Ternaire: demander le montant d’une commande.
// Livraison gratuite à partir de 50 €, sinon 4,95 € 
//de frais. Afficher le total à payer

Console.WriteLine("Quel est le montant de votre commande ?");
decimal montantCommande = decimal.Parse(Console.ReadLine()); //60

//bool EstLivrerAvecFrais = montantCommande < 50 ? false : true;
bool EstLivrerAvecFrais = montantCommande < 50; // 60 < 50 => false
// estLivrerAvecFrais = false

// if(false)
if(EstLivrerAvecFrais)
{
    montantCommande += 4.95m;
    Console.WriteLine($"le montant total avec frais est {montantCommande}");
} else
{
    Console.WriteLine($"le montant total de votre commande est {montantCommande}");
}

//5 Ternaire : deman}der un nombre et afficher « pair » ou « impair »

Console.WriteLine();
Console.Clear();
Console.WriteLine("Donne un nombre");
int nb = int.Parse(Console.ReadLine());
string result = nb % 2 == 0 ? "Est pair" : "Est Impaire";

Console.WriteLine($"le nombre {nb} {result}");