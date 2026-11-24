// ===================================================================================
//  EXO 029 — var : laisser C# deviner le type
//  Récap slides 0 à 140 · PARTIE 2 — Les variables
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser var et vérifier le type que C# a choisi avec GetType().
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 64 : « Laisser le compilateur déduire le type »
//        slide 74 : « C# ou CTS ? »
//     Démo : WAD-Demo/Demos/NomDesVariables.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare avec var (sans écrire de type) trois variables :
//            nombre qui vaut 42,   nom qui contient le texte Léa,   prix qui vaut 9.99m (avec le m)
//     2. AVANT de lancer : écris en commentaire le type que C# va choisir pour chacune.
//     3. Affiche le type de chaque variable avec GetType(), une variable par ligne.
//     4. Lance et compare avec ta prédiction.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 029 - var : laisser C# deviner le type
//     │ System.Int32
//     │ System.String
//     │ System.Decimal
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     GetType() affiche le « vrai nom » du type : System.Int32 pour int, System.String pour string...
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 029 - var : laisser C# deviner le type");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


