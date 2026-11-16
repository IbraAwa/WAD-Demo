
// Exercice conversion

// 1

//Console.WriteLine("Taper le premier nombre");
//int nombreUn = int.Parse(Console.ReadLine());

//Console.WriteLine("Taper le deuxieme nombre");
//int nombreDeux = int.Parse(Console.ReadLine());

//int resultat = nombreUn + nombreDeux;

//Console.WriteLine($"le resultat est {resultat}");

// 2
//Console.WriteLine();
//Console.WriteLine("EXERCIE 2");
//Console.WriteLine();
//Console.WriteLine("Taper le premier nombre");
//bool nombreUnEstConverti = int.TryParse(Console.ReadLine(), out int nombreUnConverti);

//Console.WriteLine("Taper le deuxieme nombre");
//bool nombreDeuxEstConverti = int.TryParse(Console.ReadLine(), out int nombreDeuxConverti);

//if(nombreUnEstConverti && nombreDeuxEstConverti)
//{
//    int somme = nombreUnConverti + nombreDeuxConverti;
//    Console.WriteLine($"la somme est {somme}");
//} 
//else
//{
//    Console.WriteLine("l'une des deux conversions a échoué");
//}

// autre manière de faire

Console.WriteLine("Taper le premier nombre");
string nombreUn = Console.ReadLine();
int nombreUnConverti;
bool nombreUnEstConverti = int.TryParse(nombreUn, out nombreUnConverti);

Console.WriteLine("Taper le deuxieme nombre");
string nombreDeux = Console.ReadLine();
int nombreDeuxConverti;
bool nombreDeuxEstConverti = int.TryParse(nombreDeux, out nombreDeuxConverti);

if(nombreUnEstConverti && nombreDeuxEstConverti)
{
    int result = nombreUnConverti + nombreDeuxConverti;
    Console.WriteLine($"le resultat est {result}");
} else
{
    Console.WriteLine("il y'a un problème");
}