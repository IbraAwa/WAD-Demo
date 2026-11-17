// ===================================================================================
//  EXO 094 — Déboguer : les espions
//  Récap slides 0 à 140 · PARTIE 5 — Les conditions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Regarder le résultat d'une condition pendant que le programme est arrêté.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 52 : « Les espions »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable entière age qui vaut 70.
//     2. Calcule un booléen tarifNormal, vrai si l'âge est d'au moins 18 ET de moins de 65
//        (la même règle qu'à l'EXO 083), sans if. Affiche-le après le texte   Tarif normal :
//     3. Mets un point d'arrêt (F9) sur la ligne qui calcule tarifNormal et lance avec F5.
//     4. Dans ta condition, sélectionne avec la souris la partie « moins de 65 »,
//        clic droit > Ajouter un espion. Fais pareil pour la partie « au moins 18 ».
//     5. Note en commentaire la valeur des deux espions, puis F5 pour finir.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 094 - Déboguer : les espions
//     │ Tarif normal : False
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     La fenêtre Espion apparaît en bas pendant le débogage. Ctrl+Alt+I ouvre la fenêtre Exécution immédiate.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 094 - Déboguer : les espions");

// ↓↓↓ écris ton code en dessous ↓↓↓


