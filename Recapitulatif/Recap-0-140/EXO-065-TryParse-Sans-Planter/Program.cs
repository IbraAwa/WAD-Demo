// ===================================================================================
//  EXO 065 — TryParse : convertir sans planter
//  Récap slides 0 à 140 · PARTIE 4 — Les conversions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser TryParse : il dit si ça a marché (true/false) au lieu de planter.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 93 : « La méthode TryParse »
//     Démo : WAD-Demo-Conversion/Demos/AvecTryParse.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable texte saisie1 qui contient "25".
//     2. Essaie de la convertir en entier avec int.TryParse :
//          - garde la réponse « ça a marché ou pas » dans une variable booléenne reussi1 ;
//          - récupère le nombre converti dans une variable age1, grâce au mot-clé out.
//     3. Affiche reussi1 et age1 comme dans le résultat attendu ci-dessous.
//     4. Fais la même chose avec une variable saisie2 qui contient "vingt-cinq"
//        (variables reussi2 et age2), et affiche.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 065 - TryParse : convertir sans planter
//     │ Réussi : True, âge : 25
//     │ Réussi : False, âge : 0
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     TryParse reçoit deux choses : le texte à convertir, et (après le mot out) la variable où il doit
//     ranger le nombre. Tu peux déclarer cette variable directement à cet endroit, avec son type.
//     TryParse renvoie true ou false ; si la conversion rate, la variable vaut 0.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 065 - TryParse : convertir sans planter");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


