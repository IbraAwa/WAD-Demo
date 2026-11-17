// ===================================================================================
//  EXO 056 — L'interpolation avec $
//  Récap slides 0 à 140 · PARTIE 3 — Les types de données
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser la façon préférée de mettre des variables dans un texte : le $.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 86 : « string.Format et interpolation »
//     Démo : WAD-Demo/Demos/AfficherDesVariables.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable texte nom qui contient "Léa" et une variable entière age qui vaut 30.
//     2. Avec une chaîne interpolée (le $), affiche :   Léa a 30 ans
//        Le nom et l'âge doivent venir des variables, pas être écrits en dur.
//     3. On peut aussi faire un calcul directement entre les { } : affiche   Dans 10 ans, Léa aura 40 ans
//        sans créer de nouvelle variable (le 40 doit être calculé à partir de age).
//
//  💡 INDICE
//     Le $ se met juste avant les guillemets ouvrants. Ensuite, tout ce qui est entre { } est évalué
//     par C# (une variable ou un petit calcul) et son résultat est inséré dans le texte.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 056 - L'interpolation avec $
//     │ Léa a 30 ans
//     │ Dans 10 ans, Léa aura 40 ans
//     └────────────────────────────────────────────────────────────
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 056 - L'interpolation avec $");

// ↓↓↓ écris ton code en dessous ↓↓↓


