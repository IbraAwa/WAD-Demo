// === LES VARIABLES ===

// une variable c'est une boîte avec un nom dans laquelle on range une valeur
// le type de la variable dit ce qu'on a le droit de ranger dedans (du texte, un nombre, vrai/faux...)

// imaginons mon programme gère la fiche des clients d'un magasin

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo.Demos;

// ==============================================
// AFFICHER ET LIRE DANS LA CONSOLE  WriteLine Write Clear   (AfficherEtLire.cs)
// ==============================================
Console.WriteLine("===== AFFICHER DANS LA CONSOLE =====");
AfficherEtLire.WriteLineEcritPuisRevientALaLigneDemo();
AfficherEtLire.WriteEcritSansRevenirALaLigneDemo();
AfficherEtLire.AstuceCwPuisTabDemo();
// Clear efface tout ce qui a été affiché avant lui, décommenter pour tester
//AfficherEtLire.ClearEffaceLaConsoleDemo();

// ==============================================
// LES COMMENTAIRES  //  /* */       (Commentaires.cs)
// ==============================================
Console.WriteLine("===== LES COMMENTAIRES =====");
Commentaires.CommentaireSurUneLigneDemo();
Commentaires.CommentaireSurPlusieursLignesDemo();
Commentaires.CommenterDuCodePourNePasLExecuterDemo();

// ==============================================
// LES TYPES DE VARIABLES  string int long decimal double float bool   (TypesDeVariables.cs)
// ==============================================
Console.WriteLine("===== LES TYPES DE VARIABLES =====");
TypesDeVariables.StringPourDuTexteDemo();
TypesDeVariables.IntPourUnNombreEntierDemo();
TypesDeVariables.LongPourUnTresGrandNombreEntierDemo();
TypesDeVariables.DecimalPourLArgentDemo();
TypesDeVariables.DoublePourUnNombreAVirguleParDefautDemo();
TypesDeVariables.PiegeDoubleImprecisAvecZeroVirguleUnPlusZeroVirguleDeuxDemo();
TypesDeVariables.FloatLeMoinsPrecisDemo();
TypesDeVariables.BoolVraiOuFauxDemo();

// ==============================================
// LE NOM DES VARIABLES  déclarer, casse, camelCase, var   (NomDesVariables.cs)
// ==============================================
Console.WriteLine("===== LE NOM DES VARIABLES =====");
NomDesVariables.DeclarerUneVariableTypeIdentifiantValeurDemo();
NomDesVariables.SensibleALaCasseMajusculeMinusculeDemo();
NomDesVariables.ConventionCamelCaseDemo();
NomDesVariables.ChangerLaValeurSansRemettreLeTypeDemo();
NomDesVariables.VarLaisseCSharpDevinerLeTypeDemo();

// ==============================================
// AFFICHER DES VARIABLES  +  $""  {0}   (AfficherDesVariables.cs)
// ==============================================
Console.WriteLine("===== AFFICHER DES VARIABLES =====");
AfficherDesVariables.ConcatenationAvecLePlusDemo();
AfficherDesVariables.InterpolationLaFavoriteDemo();
AfficherDesVariables.FormatAvecDesNumerosPourLesLogsDemo();

// ==============================================
// VARIABLE NULLABLE  string?  int?  (VariableNullable.cs)
// ==============================================
Console.WriteLine("===== VARIABLE NULLABLE =====");
VariableNullable.NonInitialiseeVideOuNullDemo();
VariableNullable.IntNullableEstUnRaccourciDeNullableIntDemo();
VariableNullable.ValueSansVerifierPeutPlanterDemo();
VariableNullable.HasValuePourVerifierAvantDUtiliserDemo();

// ==============================================
// LA PORTÉE DES VARIABLES  { }      (Portee.cs)
// ==============================================
Console.WriteLine("===== LA PORTÉE DES VARIABLES =====");
Portee.VariableCreeeDansDesAccoladesNExistePasDehorsDemo();

// ==============================================
// LES CONSTANTES  const             (Constante.cs)
// ==============================================
Console.WriteLine("===== LES CONSTANTES =====");
Constante.ConstPourUneValeurQuiNeChangeJamaisDemo();

// ==============================================
// TYPE VALEUR OU TYPE RÉFÉRENCE     (TypeValeurEtReference.cs)
// ==============================================
Console.WriteLine("===== TYPE VALEUR OU TYPE RÉFÉRENCE =====");
TypeValeurEtReference.TypeValeurCompareLesValeursDemo();
TypeValeurEtReference.TypeReferenceCompareLAdresseDemo();
TypeValeurEtReference.MettreUneReferenceDansUneAutreReferenceDemo();
TypeValeurEtReference.PiegeModifierUneReferenceModifieLesDeuxDemo();

// ==============================================
// LES TYPES LITTÉRAUX  m D f L      (TypesLitteraux.cs)
// ==============================================
Console.WriteLine("===== LES TYPES LITTÉRAUX =====");
TypesLitteraux.DecimalAvecLeSuffixeMDemo();
TypesLitteraux.DoubleAvecLeSuffixeDFacultatifDemo();
TypesLitteraux.FloatAvecLeSuffixeFDemo();
TypesLitteraux.LongAvecLeSuffixeLDemo();

// ==============================================
// AVEC L'UTILISATEUR  ReadLine      (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.ReadLineLitCeQueLUtilisateurTapeDemo();
//AvecUtilisateur.PrenomEtNomSaisisAffichesDeTroisFaconsDemo();
