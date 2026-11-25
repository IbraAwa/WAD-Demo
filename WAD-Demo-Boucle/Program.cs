// === LES BOUCLES ===

// une boucle permet de RÉPÉTER du code plusieurs fois sans le réécrire
// for, while, do while, foreach (+ break et continue)

// lequel choisir ?
// for      -> on sait combien de fois on répète / on a besoin de l'index
// while    -> on répète TANT QU'une condition est vraie (peut ne jamais s'exécuter)
// do while -> pareil, mais s'exécute AU MOINS une fois
// foreach  -> on parcourt chaque élément d'une collection (sans index)

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Boucle.Demos;

// ==============================================
// FOR  initialiseur ; condition ; itérateur      (For.cs)
// ==============================================
Console.WriteLine("===== FOR =====");
For.ForCompterDe0A4Demo();
For.ForToursDeCircuitF1Demo();
For.PiegeUnTourEnTropAvecInferieurOuEgalDemo();
For.ForDecompteFuseeDemo();
For.ForParcourirUnTableauAvecLIndexDemo();
For.PiegeIndexEnDehorsDuTableauDemo();

// ==============================================
// WHILE  tant que...                             (While.cs)
// ==============================================
Console.WriteLine("===== WHILE =====");
While.WhileRemplirLeReservoirDemo();
While.WhileConditionFausseDesLeDepartDemo();
While.PiegeBoucleInfinieDemo();

// ==============================================
// DO WHILE  au moins une fois                    (DoWhile.cs)
// ==============================================
Console.WriteLine("===== DO WHILE =====");
DoWhile.DoWhileServirDesClientsDemo();
DoWhile.DoWhileSExecuteAuMoinsUneFoisDemo();

// ==============================================
// FOREACH  chaque élément d'une collection        (Foreach.cs)
// ==============================================
Console.WriteLine("===== FOREACH =====");
Foreach.ForeachFruitsEtLegumesDemo();
Foreach.ForeachNotesReussiOuEchoueDemo();
Foreach.ForeachCalculerLaMoyenneDemo();
Foreach.PiegeForeachEnLectureSeuleDemo();

// ==============================================
// BREAK ET CONTINUE                              (BreakEtContinue.cs)
// ==============================================
Console.WriteLine("===== BREAK ET CONTINUE =====");
BreakEtContinue.BreakTrouverLePremierEchecDemo();
BreakEtContinue.ContinueIgnorerLesEchecsDemo();

// ==============================================
// AVEC L'UTILISATEUR                             (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.DecompterEntreDeuxNombresSaisisDemo();
//AvecUtilisateur.DireBonjourAvecWhileDemo();
//AvecUtilisateur.MenuAvecFritesDoWhileDemo();
