// === RÉCAPITULATIF : variable ; string ; conversion ===

// on reprend en bref tout ce qu'on a vu dans les démos Variables, String et Conversion

// imaginons mon programme gère la fiche d'un étudiant

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Recap1.Demos;

// ==============================================
// TYPES DE VARIABLES  + var         (TypesDeVariables.cs)
// ==============================================
Console.WriteLine("===== TYPES DE VARIABLES =====");
TypesDeVariables.TousLesTypesDeBaseDemo();
TypesDeVariables.VarLaisseCSharpDeterminerLeTypeDemo();
TypesDeVariables.PiegeVarAvecUnPetitNombrePensantAvoirUnLongDemo();

// ==============================================
// LE TYPE STRING                    (ChaineDeCaracteres.cs)
// ==============================================
Console.WriteLine("===== LE TYPE STRING =====");
ChaineDeCaracteres.ToStringMarcheSurToutesLesVariablesDemo();
ChaineDeCaracteres.StringImmuableMaisLePlusEgalMarcheQuandMemeDemo();

// ==============================================
// CONVERSION  ToString Parse TryParse Convert   (Conversion.cs)
// ==============================================
Console.WriteLine("===== CONVERSION =====");
Conversion.ToStringConvertitEnStringDemo();
Conversion.ParseConvertitUnStringDemo();
Conversion.TryParseConvertitSansPlanterDemo();
Conversion.ConvertDUnTypeVersUnAutreDemo();

// ==============================================
// BOXING / UNBOXING  object         (BoxingUnboxing.cs)
// ==============================================
Console.WriteLine("===== BOXING / UNBOXING =====");
BoxingUnboxing.BoxingToutEstObjetDemo();
BoxingUnboxing.UnboxingAvecUnCastDemo();
