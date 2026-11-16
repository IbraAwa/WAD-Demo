//// === LES OPÉRATEURS ===

//// un opérateur c'est un symbole qui fait une action sur une ou plusieurs valeurs
//// calculer, comparer, ranger une valeur, choisir une valeur...

//// imaginons mon programme gère le panier d'un magasin en ligne

//// chaque type d'opérateur est dans son propre fichier (une static class)
//// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
//// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

//using WAD_Demo_Operateur;

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



//// COALESCE

//// Il regarde la valeur de gauche si elle est nulle elle choisi la valeur de droite
//int? nombreNullCoalesce = null;

//// il regarde a gauche si valeur null on prend 5
//int nombreCoalesce = nombreNullCoalesce ?? 5;

// COALESCE 
// renvoie la première variable qui à une valeur (non null)

// J'ai 4 informations de mon utilisateur
// email / numéro portable / numéro fixe / teams

// mon client me dit 
// j'ai pas forcément toutes ses information
// mais j'en au moin une
// mes ordres préférence pour les informations
// 1) email
// 2) numéro portable
// 3) teams
// 4) numéro fixe

// COALESCE PREND LA PREMIERE NON NULL ET L'AFFECTE A LA VARIABLE
string? email = "ibrahim@hotmail.be";
string? numeroPortable = "+32475615151";
string? teams = "bstorm@teams.be";
string numeroFixe = "+32470606060";

string infoARenvoyer = email ?? numeroPortable ?? teams ?? numeroFixe;

Console.WriteLine($"l'info de votre user est {infoARenvoyer}");


//-----

Console.WriteLine("Taper votre prénom");
string? prenom = Console.ReadLine(); // prenom = ""

//si la valeur dans la parenthèse
// est null ou vide ou avec des espaces vide tu renvoie true
if(string.IsNullOrWhiteSpace(prenom))
{
    prenom = null;
}

// COALESCE va affecter la valeur maxence que si le prénom est null
// Il affecte une valeur uniquement si c'est null
// si la valeur est vide ou avec des espaces il n'affecte rien
prenom ??= "Maxence";

// prenom ??= "Maxence" équivaut à :
//if(prenom == null)
//{
//    prenom = "Maxence";
//}

Console.WriteLine($"Le prénom est : {prenom}");


// opérateur typeof

Type t = typeof(long);

Console.WriteLine($"{t.FullName} et namespace = {t.Namespace}");