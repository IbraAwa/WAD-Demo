// Enumeration c'est quoi
// c'est une liste pré définis qui sert de type
// et qui vous permet d'empêcher un utilisateur de mettre autre chose comme valeur
// que les valeurs que vous avez définis et empêche aussi les faute d'orthographe

// imaginer que vous êtes un concessionnaire de voiture


//Carburant carburant = Carburant.Electrique;

//if(carburant is Carburant.Diesel)
//{
//    Console.WriteLine("c'est du diesel");
//} 
//else if(carburant is Carburant.Electrique)
//{
//    Console.WriteLine("C'est du electrique");
//}
//else if(carburant is Carburant.Essence)
//{
//    Console.WriteLine("c'est de l'essence");
//}

// Comparaison par int
//Carburant carburant = Carburant.Electrique;

//if((int)carburant == 2)
//{
//    Console.WriteLine("carburant est électrique");
//}

//Carburant carburant = Carburant.Electrique;

//if ((int)carburant == 3)
//{
//    Console.WriteLine("carburant est électrique");
//}

string rechercheCarburant = "dieSel";
if(Carburant.Electrique.ToString().ToLower() == rechercheCarburant.ToLower())
{
    Console.WriteLine("Carburant est du diesel");
}
public enum Carburant
{
    Essence = 1,
    Diesel = 2,
    Electrique = 3,
}