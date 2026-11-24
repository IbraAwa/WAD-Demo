// === LES COLLECTIONS ===

// une collection c'est une variable qui range PLUSIEURS valeurs
// tableau    -> taille fixe, accès par index
// List       -> taille dynamique, accès par index
// Dictionary -> paires clé -> valeur, accès par clé

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Collection.Demos;

// ==============================================
// TABLEAU  int[]  new  { }  [ ]  ..   (Tableau.cs)
// ==============================================
Console.WriteLine("===== TABLEAU =====");
Tableau.InitialiserAvecUneTailleDemo();
Tableau.ValeurParDefautDesCasesDemo();
Tableau.InsererAvecLIndexQuiCommenceAZeroDemo();
Tableau.PiegeIndexEnDehorsDuTableauPlanteDemo();
Tableau.LireUneCaseAvecSonIndexDemo();
Tableau.ParcourirAvecForPourAvoirLIndexDemo();
Tableau.ParcourirAvecForeachPourLireDemo();
Tableau.InitialiserAvecDesValeursAccoladesDemo();
Tableau.InitialiserAvecDesCrochetsDemo();
Tableau.SpreadPourFusionnerDeuxTableauxDemo();
Tableau.AppendNeModifiePasLeTableauDemo();
Tableau.SpreadPourAjouterUneValeurDemo();

// ==============================================
// LIST  Add  Remove  Insert ...       (Liste.cs)
// ==============================================
Console.WriteLine("===== LIST =====");
Liste.InitialiserUneListeDemo();
Liste.AddAjouteUneValeurDemo();
Liste.AddRangeAjoutePlusieursValeursDemo();
Liste.ListeAccepteLesDoublonsDemo();
Liste.InsertAjouteAUnIndexPrecisDemo();
Liste.RemoveRetireLaPremiereValeurTrouveeDemo();
Liste.RemoveAtRetireAUnIndexPrecisDemo();
Liste.RemoveRangeRetirePlusieursValeursDemo();
Liste.LireEtModifierAvecLIndexDemo();
Liste.ContainsEtIndexOfPourChercherDemo();
Liste.ClearVideLaListeDemo();

// ==============================================
// DICTIONARY  clé -> valeur           (Dictionnaire.cs)
// ==============================================
Console.WriteLine("===== DICTIONARY =====");
Dictionnaire.InitialiserUnDictionnaireDemo();
Dictionnaire.ParcourirAvecKeyEtValueDemo();
Dictionnaire.CrochetsCreeOuRemplaceLaValeurDemo();
Dictionnaire.PlusEgalAjouteALaValeurDemo();
Dictionnaire.PiegeAddPlanteSiLaCleExisteDejaDemo();
Dictionnaire.PiegeLireUneCleQuiNExistePasPlanteDemo();
Dictionnaire.ContainsKeyPourVerifierAvantDeLireDemo();
Dictionnaire.TryGetValueVerifieEtLitEnUneFoisDemo();
Dictionnaire.RemoveRetireUneCleDemo();

// ==============================================
// AVEC L'UTILISATEUR                  (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.RemplirUnTableauDeNotesSaisiesDemo();
//AvecUtilisateur.RemplirUneListeJusquaFinDemo();
