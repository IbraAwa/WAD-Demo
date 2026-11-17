// ===================================================================================
//  EXO 118 — switch avec des comparaisons (mention et âge)
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser >= et < directement dans une expression switch.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 132 : « Patterns relationnels et logiques »
//        slide 136 : « Indice — is, pattern matching et as »
//     Démo : WAD-Demo-Operateur/Demos/Ternaire.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une   note   entière qui vaut 15. Avec une expression switch, range dans une variable
//        la mention correspondante :
//            16 ou plus        → Très bien
//            14 ou plus        → Bien
//            10 ou plus        → Réussi
//            tout le reste     → Échec
//     2. Affiche la mention.
//     3. Déclare un   age   entier qui vaut 34 et fais pareil avec une autre expression switch :
//            moins de 18       → mineur
//            moins de 65       → adulte
//            tout le reste     → senior
//        Affiche le résultat.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 118 - switch avec des comparaisons (mention et âge)
//     │ Bien
//     │ adulte
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Dans une expression switch, chaque branche peut commencer par une comparaison (>=, <).
//     Les branches sont testées dans l'ordre et la PREMIÈRE qui correspond gagne :
//     réfléchis bien à l'ordre dans lequel tu les écris. Le _ attrape « tout le reste ».
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 118 - switch avec des comparaisons (mention et âge)");

// ↓↓↓ écris ton code en dessous ↓↓↓


