// === LES CONVERSIONS ===

// une conversion c'est transformer une valeur d'un type vers un autre type
// ex : le texte "42" tapé par l'utilisateur -> le nombre 42 pour pouvoir calculer

// imaginons mon programme gère les commandes d'un magasin en ligne

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Conversion.Demos;

// ==============================================
// VERS UN STRING  ToString()        (VersString.cs)
// ==============================================
Console.WriteLine("===== VERS UN STRING =====");
VersString.ToStringTransformeNimporteQuelTypeEnTexteDemo();

// ==============================================
// CONVERT  Convert.ToInt32() ...    (AvecConvert.cs)
// ==============================================
Console.WriteLine("===== CONVERT =====");
AvecConvert.ConvertToInt32DUnTexteEnNombreDemo();
AvecConvert.ConvertImpossibleSiPasUnNombreValideDemo();
AvecConvert.ConvertToDoubleAttentionALaCultureDemo();
AvecConvert.ConvertAvecUneVariableDansLaParentheseDemo();

// ==============================================
// PARSE  int.Parse()                (AvecParse.cs)
// ==============================================
Console.WriteLine("===== PARSE =====");
AvecParse.ParseTransformeUnTexteEnNombreDemo();
AvecParse.PiegeParsePlanteSiCeNestPasUnNombreDemo();

// ==============================================
// TRYPARSE  int.TryParse(..., out ...)   (AvecTryParse.cs)
// ==============================================
Console.WriteLine("===== TRYPARSE =====");
AvecTryParse.PremiereManiereOutIntDansLaParentheseDemo();
AvecTryParse.DeuxiemeManiereVariableDeclareeAvantDemo();
AvecTryParse.TroisiemeManiereDirectementDansLeIfDemo();
AvecTryParse.TryParseQuiRateNePlantePasDemo();

// ==============================================
// CONVERSION IMPLICITE  (C# le fait tout seul)   (ConversionImplicite.cs)
// ==============================================
Console.WriteLine("===== CONVERSION IMPLICITE =====");
ConversionImplicite.IntVersLongSansRisqueDemo();
ConversionImplicite.LongVersIntInterditDemo();
ConversionImplicite.CharVersIntDonneLeCodeAsciiDemo();

// ==============================================
// CONVERSION EXPLICITE  (on doit le demander)    (ConversionExplicite.cs)
// ==============================================
Console.WriteLine("===== CONVERSION EXPLICITE =====");
ConversionExplicite.PiegeDivisionEntreIntDonneUnMauvaisPourcentageDemo();
ConversionExplicite.ConvertToDecimalPourLeBonPourcentageDemo();
ConversionExplicite.CastSurUnSeulNombreOuSurToutLeCalculDemo();
ConversionExplicite.CastCoupeLaVirguleSansArrondirDemo();
ConversionExplicite.MathRoundPourArrondirDemo();

// ==============================================
// BOXING / UNBOXING  object         (BoxingUnboxing.cs)
// ==============================================
Console.WriteLine("===== BOXING / UNBOXING =====");
BoxingUnboxing.BoxingRangerDansUnObjectDemo();
BoxingUnboxing.UnboxingIlFautPreciserLeTypeDemo();
BoxingUnboxing.PiegeUnboxingVersLeMauvaisTypePlanteDemo();

// ==============================================
// AVEC L'UTILISATEUR  Parse / TryParse sur ReadLine   (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.ParseSansVerifierPlanteSiLUtilisateurTapeDuTexteDemo();
//AvecUtilisateur.TryParseVerifieLaSaisieDeLUtilisateurDemo();
