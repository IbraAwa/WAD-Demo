// === LES MÉTHODES ===

// une méthode est un BLOC DE CODE qui porte un NOM
// on l'écrit une fois, et on peut l'invoquer (l'appeler) autant de fois qu'on veut
// -> on évite de répéter le même code, et le programme est découpé en petits morceaux lisibles

// il existe deux sortes de méthodes :
// procédure -> FAIT une action, ne renvoie rien           -> void
// fonction  -> CALCULE quelque chose et renvoie le résultat -> int, string, bool... + return

// vocabulaire :
// déclarer   = écrire la méthode (son nom, ses paramètres, son code)
// invoquer   = appeler la méthode : son nom + ()
// paramètre  = la variable dans la déclaration          static int Addition(int a, int b)
// argument   = la valeur donnée à l'appel               Addition(5, 10)

// chaque sous-chapitre est dans son propre fichier (une static class)
// chaque méthode montre UNE seule chose, son nom dit ce qu'elle montre
// static = pas besoin de faire un new, on appelle directement NomDeLaClasse.Methode()

using WAD_Demo_Methode.Demos;

// ==============================================
// PROCÉDURE  void, ne renvoie rien               (Procedure.cs)
// ==============================================
Console.WriteLine("===== PROCÉDURE =====");
Procedure.DeclarerEtInvoquerUneProcedureDemo();
Procedure.InvoquerUneProcedurePlusieursFoisDemo();
Procedure.ProcedureAvecUnParametreDemo();
Procedure.ProcedureAvecPlusieursParametresDemo();
Procedure.PiegeUneVariableDeLaMethodeNExistePasDehorsDemo();
Procedure.PiegeUneProcedureNeRenvoieRienDemo();

// ==============================================
// FONCTION  type de retour + return              (Fonction.cs)
// ==============================================
Console.WriteLine("===== FONCTION =====");
Fonction.DeclarerEtInvoquerUneFonctionDemo();
Fonction.UtiliserLeResultatDirectementDemo();
Fonction.FonctionAvecDesParametresDeTypesDifferentsDemo();
Fonction.TousLesCheminsDoiventRenvoyerUneValeurDemo();
Fonction.FonctionQuiPeutRenvoyerNullAvecCoalesceDemo();
Fonction.FonctionQuiRenvoieUnTexteDemo();
Fonction.ReturnArreteLaMethodeDemo();
Fonction.PiegeOublierDeRecupererLeResultatDemo();

// ==============================================
// PARAMÈTRES FACULTATIFS ET ARGUMENTS NOMMÉS  = valeur par défaut / nom:   (ParametreFacultatif.cs)
// ==============================================
Console.WriteLine("===== PARAMÈTRES FACULTATIFS =====");
ParametreFacultatif.ParametreFacultatifDemo();
ParametreFacultatif.ArgumentsNommesDemo();
ParametreFacultatif.PlusieursParametresFacultatifsDemo();
ParametreFacultatif.PiegeParametreFacultatifPasEnDernierDemo();

// ==============================================
// PARAMS  autant d'arguments qu'on veut          (Params.cs)
// ==============================================
Console.WriteLine("===== PARAMS =====");
Params.ParamsAutantDArgumentsQuOnVeutDemo();
Params.ParamsAvecUnTableauDemo();
Params.ParamsAvecUnParametreAvantDemo();
Params.PiegeParamsPasEnDernierDemo();

// ==============================================
// REF  modifier la variable d'origine            (Ref.cs)
// ==============================================
Console.WriteLine("===== REF =====");
Ref.SansRefLaVariableNeChangePasDemo();
Ref.AvecRefLaVariableEstModifieeDemo();
Ref.EchangerDeuxVariablesAvecRefDemo();
Ref.PiegeRefLesErreursDemo();

// ==============================================
// OUT  faire sortir une valeur en plus du return  (Out.cs)
// ==============================================
Console.WriteLine("===== OUT =====");
Out.OutDansTryParseDemo();
Out.OutDivisionDemo();
Out.OutRenvoyerPlusieursValeursDemo();
Out.PiegeDivisionEntiereDansLaMethodeDemo();
Out.PiegeOutPasRempliDemo();

// ==============================================
// VERSION COURTE  =>                             (VersionCourte.cs)
// ==============================================
Console.WriteLine("===== VERSION COURTE =====");
VersionCourte.VersionLongueEtVersionCourteDemo();
VersionCourte.FonctionsCourtesDemo();
VersionCourte.ProcedureCourteDemo();

// ==============================================
// SURCHARGE  même nom, paramètres différents     (Surcharge.cs)
// ==============================================
Console.WriteLine("===== SURCHARGE =====");
Surcharge.SurchargeMemeNomParametresDifferentsDemo();
Surcharge.PiegeSurchargeAvecSeulementLeTypeDeRetourDemo();

// ==============================================
// AVEC L'UTILISATEUR                             (AvecUtilisateur.cs)
// ==============================================
// demande une saisie à l'utilisateur, décommenter pour tester
//Console.WriteLine("===== AVEC L'UTILISATEUR =====");
//AvecUtilisateur.AdditionnerDeuxNombresSaisisDemo();
//AvecUtilisateur.DiviserDeuxNombresSaisisDemo();
//AvecUtilisateur.SaluerAvecUneFormuleFacultativeDemo();
