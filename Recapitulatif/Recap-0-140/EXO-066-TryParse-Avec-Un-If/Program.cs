// ===================================================================================
//  EXO 066 — TryParse avec un if
//  Récap slides 0 à 140 · PARTIE 4 — Les conversions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Réagir différemment si la conversion a réussi ou raté.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 93 : « La méthode TryParse »
//     Démo : WAD-Demo-Conversion/Demos/AvecTryParse.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Sans retour à la ligne, affiche : Votre âge :
//        Puis lis la réponse au clavier dans une variable texte saisie (qui a le droit d'être null).
//     2. Avec un if / else et int.TryParse (comme à la slide 93) :
//          - si saisie se convertit bien en entier : affiche l'âge + 10 ;
//          - sinon : affiche   Pas un nombre
//     3. Lance deux fois : tape 30, puis relance et tape abc.
//
//  💡 INDICE
//     TryParse renvoie true ou false : son appel peut donc servir DIRECTEMENT de condition au if.
//     Le nombre récupéré grâce à out est ensuite utilisable à l'intérieur du bloc du if.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 066 - TryParse avec un if
//     │ Votre âge : 30      ← (c'est toi qui tapes 30 puis Entrée)
//     │ 40
//     └────────────────────────────────────────────────────────────
//     (les ← ne s'affichent pas : ils montrent ce que TU fais au clavier)
//     (avec les valeurs de départ de l'énoncé)
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 066 - TryParse avec un if");

// ↓↓↓ écris ton code en dessous ↓↓↓


