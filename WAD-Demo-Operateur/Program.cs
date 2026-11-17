//// === LES OPÉRATEURS ===

//// un opérateur c'est un symbole qui fait une action sur une ou plusieurs valeurs
//// calculer, comparer, ranger une valeur, choisir une valeur...

//// imaginons mon programme gère le panier d'un magasin en ligne

//// chaque type d'opérateur est dans son propre fichier (une static class)
//// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
//// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

//using WAD_Demo_Operateur.Demos;

//// ==============================================
//// ARITHMÉTIQUE  + - * / %          (Arithmetique.cs)
//// ==============================================
//Console.WriteLine("===== ARITHMÉTIQUE =====");
//Arithmetique.AdditionDemo();
//Arithmetique.SoustractionDemo();
//Arithmetique.MultiplicationDemo();
//Arithmetique.DivisionEntreDeuxIntCoupeLaVirguleDemo();
//Arithmetique.DivisionAvecVirguleDemo();
//Arithmetique.ModuloResteDeLaDivisionDemo();
//Arithmetique.ModuloPourSavoirSiPairOuImpairDemo();
//Arithmetique.PrioriteDesOperateursCommeEnMathDemo();

//// ==============================================
//// CONCATÉNATION  +                 (Concatenation.cs)
//// ==============================================
//Console.WriteLine("===== CONCATÉNATION =====");
//Concatenation.ConcatenationDeDeuxStringDemo();
//Concatenation.PiegeConcatenationStringPuisNombresDemo();
//Concatenation.CorrigerLePiegeAvecParenthesesOuInterpolationDemo();

//// ==============================================
//// AFFECTATION  = += -= *= /= %=    (Affectation.cs)
//// ==============================================
//Console.WriteLine("===== AFFECTATION =====");
//Affectation.AffectationSimpleRangeUneValeurDemo();
//Affectation.RaccourciPlusEgalAdditionDemo();
//Affectation.RaccourciMoinsEgalSoustractionDemo();
//Affectation.RaccourciFoisEgalMultiplicationDemo();
//Affectation.RaccourciDiviseEgalDivisionDemo();
//Affectation.RaccourciModuloEgalResteDemo();
//Affectation.PiegeDoubleImprecisAvecLesRaccourcisDemo();
//Affectation.RaccourciPlusEgalAvecStringDemo();

//// ==============================================
//// INCRÉMENTATION  ++ --            (Incrementation.cs)
//// ==============================================
//Console.WriteLine("===== INCRÉMENTATION =====");
//Incrementation.IncrementationAjouteUnDemo();
//Incrementation.DecrementationRetireUnDemo();
//Incrementation.PreIncrementationAugmenteAvantUtilisationDemo();
//Incrementation.PostIncrementationAugmenteApresUtilisationDemo();

//// ==============================================
//// COMPARAISON  == != < > <= >=     (Comparaison.cs)
//// ==============================================
//Console.WriteLine("===== COMPARAISON =====");
//Comparaison.EgalEgalPourComparerDemo();
//Comparaison.DifferentDemo();
//Comparaison.StrictementPlusGrandDemo();
//Comparaison.StrictementPlusPetitDemo();
//Comparaison.PlusGrandOuEgalDemo();
//Comparaison.PlusPetitOuEgalDemo();

//// ==============================================
//// LOGIQUE  && || !                 (Logique.cs)
//// ==============================================
//Console.WriteLine("===== LOGIQUE =====");
//Logique.EtLesDeuxConditionsDoiventEtreVraiesDemo();
//Logique.OuAuMoinsUneConditionDoitEtreVraieDemo();
//Logique.NonInverseLeBoolDemo();
//Logique.PlusieursOperateursMelangesAvecParenthesesDemo();

//// ==============================================
//// TERNAIRE  condition ? siVrai : siFaux   (Ternaire.cs)
//// ==============================================
//Console.WriteLine("===== TERNAIRE =====");
//Ternaire.TernaireSimpleDemo();
//Ternaire.TernaireAvecModuloPourPairOuImpairDemo();
//Ternaire.TernaireImbriqueAvecPlusieursConditionsDemo();

//// ==============================================
//// COALESCE  ?? ??=                 (Coalesce.cs)
//// ==============================================
//Console.WriteLine("===== COALESCE =====");
//Coalesce.CoalesceValeurDeSecoursSiNullDemo();
//Coalesce.CoalesceAffectationRemplitSeulementSiNullDemo();

//// ==============================================
//// IS  is, is not                   (Is.cs)
//// ==============================================
//Console.WriteLine("===== IS =====");
//Is.IsNullEtIsNotNullDemo();
//Is.IsPourVerifierLeTypeDemo();

//// ==============================================
//// AVEC L'UTILISATEUR               (AvecUtilisateur.cs)
//// ==============================================
//// demande une saisie à l'utilisateur, décommenter pour tester
////Console.WriteLine("===== AVEC L'UTILISATEUR =====");
////AvecUtilisateur.TotalCommandeSaisieAvecFraisDeLivraisonDemo();



// IS
// traduit par est 
// et compare deux chose
// cheval is animal // TRUE
// 4 is int // TRUE

object o = 4;

if(o is int)
{
    Console.WriteLine("4 est un entier");
}

// passer de type object à type int
Console.WriteLine();

// vérifie si 0 est un entier
// SI c'est le cas
// crée une variable int n 
if(o is int n)
{
    Console.WriteLine($"{n} est un entier");
}

Console.Clear();

int nombreInt = 5;



//if(nombreInt == 5)
//{
//    Console.WriteLine("oui le nombre est égale à 5");
//}


//if(nombreInt is 5)
//{
//    Console.WriteLine("oui le nombre est égale à 5");
//}

//if(nombreInt is >= 4)
//{
//    Console.WriteLine("le nombre est plus grand ou égale à 4");
//}

int noteEleve = 15;

bool reussi = noteEleve is >= 10 and <= 20;
bool reussi1 = noteEleve >= 10 || noteEleve <= 20;

Console.WriteLine(reussi);

char lettre = 'e';

bool voyelle = lettre is 'a' or 'e' or 'é' or 'è' or 'i' or 'o' or 'u' or 'y';
string voyellePhrase = voyelle ? "Oui" : "Non";

Console.WriteLine($"{lettre} est une voyelle ? {voyellePhrase}");

// pattern de propriété
Console.Clear();
string mot = "salute";

if(mot is { Length: >=5})
{
    Console.WriteLine("le mot possède + ou égale à 5 lettre");
} else
{
    Console.WriteLine("dans le else donc faux");
}

// une classe string possède une valeur ("salut") et la longueur du mot ou de la phrase
Console.Clear();
int[] t = [1, 2, 3, 4, 5];

bool commenceParUn = t is [1, ..];
Console.WriteLine($"ma liste commence par 1 ? {commenceParUn}");

bool termineParCinq = t is [.., 5];
Console.WriteLine($"ma liste termine par 5 ? {termineParCinq}");

bool longueurEstCinq = t is [_, _, _, _, _];
Console.WriteLine($"ma liste à une longueur de 5? {longueurEstCinq}");

bool finisParPlusQueTrois = t is [.., < 3];
Console.WriteLine($"dernier élément du tableau plus grand que 3 {finisParPlusQueTrois}");


// AS 

Console.Clear();
object ob = "salut";

// AS
// comme la conversio nest impossible
// je met juste nulle dans
//la variable exemple
int? exemple = ob as int?;

// conversion de ob ("salut") en int mais si ça ne fonctionne pas
// votre programme plante totalement
//int? exemple1 = (int)ob;

// un programme qui plante c'est parfois mieux qu'un bug invisible
// AS peut crée des bug invisible contrairmeent à (int)

