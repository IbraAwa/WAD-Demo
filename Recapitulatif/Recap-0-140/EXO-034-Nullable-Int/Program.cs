// ===================================================================================
//  EXO 034 — int? : un nombre qui peut être vide
//  Récap slides 0 à 140 · PARTIE 2 — Les variables
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser null : « pas de valeur du tout ».
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 69 : « Les types « Nullable » »
//     Démo : WAD-Demo/Demos/VariableNullable.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Un élève n'a pas encore passé son examen : déclare une variable noteExamen,
//        un entier qui a le droit d'être vide (le type int?). Au départ, elle est vide (null).
//     2. Affiche « Note : » suivi de noteExamen (regarde : rien ne s'affiche après « Note : »).
//     3. L'examen est passé : donne la valeur 15 à noteExamen et affiche à nouveau.
//     4. Déclare une autre variable autreNote, vide elle aussi, mais cette fois avec la forme longue
//        du type : Nullable<int> (c'est EXACTEMENT pareil que int?). Affiche « Autre note : » suivi d'elle.
//     5. PROVOQUE UNE ERREUR : essaie de mettre null dans une variable note de type int normal (sans ?).
//        Note le code, puis mets la ligne en commentaire.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 034 - int? : un nombre qui peut être vide
//     │ Note :
//     │ Note : 15
//     │ Autre note :
//     └────────────────────────────────────────────────────────────
//     (les lignes qui provoquent une erreur doivent être en commentaire)
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 034 - int? : un nombre qui peut être vide");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


