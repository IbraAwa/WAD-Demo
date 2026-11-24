// demander à l'utilisateur d'encoder un nombre (int)

Console.WriteLine("Veuillez écrire un nombre");
int nombreChoisi  = int.Parse(Console.ReadLine()); // 10

//Si la somme des deux moitiés de celui-ci redonne le nombre, afficher « Le nombre est pair », sinon « 
//Le nombre est impair »

// PAIR  est un nombre divisible par 2
// impar est un nombre non divisible par 2

// 10 / 2 = 5
int moitier = nombreChoisi / 2;
int verification = moitier + moitier;

// (5 + 5) == 10
// 10 == 10
if(verification == nombreChoisi)
{
    Console.WriteLine("le nombre est pair");
} else
{
    Console.WriteLine("le nombre est impaire");
}