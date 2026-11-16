//// === LES STRUCTURES CONDITIONNELLES ===

//// IF..ELSE...

//// imaginons mon programme gère une boite de nuit
//// et on veut regarder si la personne est mineur ou non avant
//// de la laisser rentrée 

//using System.ComponentModel.Design;

//Console.WriteLine("Veuillez entrer votre âge");
//int age = int.Parse(Console.ReadLine());


//// DANS LE CAS OU SI mon utilisateur est majeur c'est okay
////if(age >= 18)
////{
////    Console.WriteLine("Vous pouvez rentrer");
////} else
////{
////    Console.WriteLine("Vous ne pouvez pas rentrer");
////}

//Console.WriteLine("Avez-vous un diplome ? (false / true)");
//bool aSonDiplome = bool.Parse(Console.ReadLine());

//// faut être majeur ET avoir un diplome
//// le ET en C# = &&
//// Les deux condition doivent être vrai donc
//// il doit avoir + de 18ans et en même temps
//// son diplome
////if (age >= 18 && aSonDiplome)
////{
////    Console.WriteLine("Entrer");
////} else
////{
////    Console.WriteLine("Refuser");
////}

//// Si l'user à soit sont diplome ou soit plus de 18ans il rentre
//// en C# le OR = ||
//// soit tu as + de 18 donc tu peux rentrer
//// soit tu as ton diplome donc tu peux rentrer
//// ou alors tu as les deux en même temps
//if(age >= 18 || aSonDiplome)
//{
//    Console.WriteLine("Rentre");
//} else
//{
//    Console.WriteLine("Dégage");
//}


//// Nous intégrons dans notre boite de nuit le status VIP
//// VIP permet de rentrer peut importe l'âge ou si il possède diplome
//// Si il n'est pas VIP
//// il doit avoir l'un ou l'autre donc 
//// il doit être majeur et avoir son diplome

//Console.WriteLine("Es-tu vip ?");
//bool estVip = bool.Parse(Console.ReadLine());

//// estVip(true) || (17 && false)
//if(estVip || (age >= 18 && aSonDiplome))
//{
//    Console.WriteLine("Autoriser");
//} else
//{
//    Console.WriteLine("Accepter");
//}

// IF...ELSE IF..ELSE


using System.Threading.Channels;

int noteEleve = 2;

if(noteEleve >= 18)
{
    Console.WriteLine("Mention très bien");
} else if(noteEleve >= 16)
{
    Console.WriteLine("Mention bien");
} else if(noteEleve >= 14)
{
    Console.WriteLine("Mention");
} else if(noteEleve >= 10)
{
    Console.WriteLine("Réussi sans mention");
} else
{
    Console.WriteLine("Rater");
}

//if (noteEleve >= 18)
//{
//    Console.WriteLine("Mention très bien");
//} 

//if(noteEleve > 16)
//{
//    Console.WriteLine("Mention bien");
//}


// SWITCH 

Console.Clear();
int jour = 4;

// moin verbeux que le if else
// mais attention
// pas de condition complexe dans les case
// il compare une valeur à une autre
switch (jour)
{
    case 1: Console.WriteLine("Lundi");
        break;
    case 2: Console.WriteLine("Mardi");
        break;
    case 3: Console.WriteLine("Mercredi");
        break;
    case 4: Console.WriteLine("Jeudi");
        break;
    case 5: Console.WriteLine("Vendredi");
        break;
    case 6: Console.WriteLine("Samedi");
        break;
    case 7: Console.WriteLine("Dimanche");
        break;
    default:
        Console.WriteLine("Jour de la semaine incorrect");
        break;
}


// affectue une valeur dans 'jourString'
// selon une condition
string jourString = jour switch
{
    1 => "lundi",
    2 => "mardi",
    3 => "mercredi",
    4 => "jeudi",
    5 => "vendredi",
    _ => "Jour incorrect"
};


// opérateur ternaire
Console.WriteLine("Tape ton âge ");
int age = int.Parse(Console.ReadLine());

//               condition ? SIVRAI : SIFAUX
bool estMajeur = age >= 18 ? true : false;

//               condition ? SIVRAI : SIFAUX
string status = age >= 18 ? "Est majeur" : "Est Mineur";


// COALESCE