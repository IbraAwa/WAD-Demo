// ===================================================================================
//  EXO 111 — Coalesce en chaîne : le premier numéro dispo (slide 126 n°3)
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Enchaîner plusieurs ?? pour prendre la première valeur non null.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 123 : « L'opérateur coalesce ?? »
//        slide 126 : « À vous de jouer (exercice) »
//     Démo : WAD-Demo-Operateur/Demos/Coalesce.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare deux numéros de téléphone (des textes qui ont le droit d'être null) :
//        telPro   est vide (null) au départ,   telPerso   vaut   0470 12 34 56.
//     2. Affiche   Numéro à appeler :   suivi du premier numéro disponible : d'abord le pro,
//        sinon le perso, et si aucun des deux n'existe, le texte   Aucun numéro.
//        Fais-le en une seule expression en enchaînant plusieurs ??.
//     3. Teste avec les deux à null, puis avec les deux remplis.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 111 - Coalesce en chaîne : le premier numéro dispo (slide 126 n°3)
//     │ Numéro à appeler : 0470 12 34 56
//     └────────────────────────────────────────────────────────────
//     (avec les valeurs de départ de l'énoncé)
//
//  💡 INDICE
//     Les ?? se lisent de gauche à droite : on prend la première valeur qui n'est pas null.
//     L'ordre dans lequel tu écris les valeurs est donc l'ordre de préférence.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 111 - Coalesce en chaîne : le premier numéro dispo (slide 126 n°3)");

// ↓↓↓ écris ton code en dessous ↓↓↓


