// Avec is, afficher « entier » pour chaque valeur qui est un int

using static System.Net.Mime.MediaTypeNames;

object?[] valeurs =[42, "Bonjour", 3.14, null, -5, 'A', 150];
foreach (object? v in valeurs)
{
    if(v is int)
    {
        Console.WriteLine("le v est entier");
    }

    // Avec le pattern matching if (v is int n), afficher le double de 
    // chaque entier

    if(v is int n)
    {
        int total = n * 2;
        Console.WriteLine($"le double est {total}");
    }

    //Avec un switch : afficher « entier positif », « entier négatif », « 
    //texte de X lettres », « décimal », « vide » (null) ou « autre »

    switch (v)
    {
        case int nombre when nombre > 0:
            Console.WriteLine("le nombre est positif");
        break;
        case int nombre when nombre < 0:
            Console.WriteLine("le nombre est négatif");
        break;
        case double or decimal or float:
            Console.WriteLine("le nombre est une décimal");
        break;
        case null:
            Console.WriteLine("valeur est null");
        break;
        default:
            Console.WriteLine("autre");
        break;
    }

    // Avec as, récupérer les string et afficher leur longueur

    string? texte = v as string; // soit je converti et affecte mon texte dans la variable soit null
    if(texte is not null)
    {
        Console.WriteLine($"votre texte est {texte}");
    }

    //Avec un pattern relationnel : pour chaque entier, afficher « 
    //petit » (< 10), « moyen » (10 à 99) ou « grand »

    int? nombreValeur = v as int?;
    bool petit = v is < 10;
    bool moyen = v is >= 10 and <= 99;
    bool grand = v is > 99;

    string textGrandeurNombre = (petit, moyen, grand) switch
    {
        (true, false, false) => "Votre nombre est petit",
        (false, true, false) => "Votre nombre est moyen",
        (false, false, true) => "votre nombre est grand",
        _ => "Probleme vous n'avez pas un nombre"
    };

    Console.WriteLine(textGrandeurNombre);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}