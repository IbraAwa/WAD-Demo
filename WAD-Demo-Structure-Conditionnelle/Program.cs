// === LES STRUCTURES CONDITIONNELLES ===

// une structure conditionnelle permet d'exécuter du code SEULEMENT si une condition est vraie
// if...else, if...else if...else, switch, ternaire

// imaginons mon programme gère une boîte de nuit
// et on veut regarder si la personne est mineure ou non avant
// de la laisser rentrer

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Structure_Conditionnelle.Demos;

// ==============================================
// IF...ELSE  && || ( )              (IfElse.cs)
// ==============================================
Console.WriteLine("===== IF...ELSE =====");
IfElse.IfElseMajeurPeutRentrerDemo();
IfElse.IfAvecEtLesDeuxConditionsDoiventEtreVraiesDemo();
IfElse.IfAvecOuAuMoinsUneConditionDoitEtreVraieDemo();
IfElse.IfAvecVipEtParenthesesDemo();

// ==============================================
// IF...ELSE IF...ELSE               (IfElseIfElse.cs)
// ==============================================
Console.WriteLine("===== IF...ELSE IF...ELSE =====");
IfElseIfElse.MentionSelonLaNoteDemo();
IfElseIfElse.PiegePlusieursIfSeparesAuLieuDeElseIfDemo();

// ==============================================
// SWITCH  case / default / switch expression   (Switch.cs)
// ==============================================
Console.WriteLine("===== SWITCH =====");
Switch.SwitchJourDeLaSemaineDemo();
Switch.SwitchExpressionRangeUneValeurDemo();

// ==============================================
// TERNAIRE  condition ? siVrai : siFaux   (Ternaire.cs)
// ==============================================
Console.WriteLine("===== TERNAIRE =====");
Ternaire.TernaireMajeurOuMineurDemo();

// COALESCE : voir la démo des opérateurs (WAD-Demo-Operateur/Demos/Coalesce.cs)

// ==============================================
// AVEC L'UTILISATEUR                (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.EntreeBoiteDeNuitAvecAgeDiplomeEtVipSaisisDemo();
//AvecUtilisateur.TernaireAvecAgeSaisiDemo();
