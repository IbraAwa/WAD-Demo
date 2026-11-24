// ===================================================================================
//  EXO 078 — Additionner deux nombres avec TryParse (slide 100)
//  Récap slides 0 à 140 · PARTIE 4 — Les conversions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Le même programme, mais qui ne plante jamais.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 100 : « À vous de jouer (exercice) »
//     Démo : WAD-Demo-Conversion/Demos/AvecTryParse.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Demande le premier nombre et convertis-le avec int.TryParse (garde le bool dans une variable).
//     2. Fais pareil pour le deuxième.
//     3. Si les DEUX conversions ont réussi : affiche l'addition.
//        Sinon : affiche   Un des deux n'est pas un nombre
//     4. Relance et tape abc : que se passe-t-il cette fois ?
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 078 - Additionner deux nombres avec TryParse (slide 100)
//     │ Premier nombre : 12      ← (c'est toi qui tapes 12 puis Entrée)
//     │ Deuxième nombre : 30      ← (c'est toi qui tapes 30 puis Entrée)
//     │ 12 + 30 = 42
//     └────────────────────────────────────────────────────────────
//     (les ← ne s'affichent pas : ils montrent ce que TU fais au clavier)
//     (avec les valeurs de départ de l'énoncé)
//
//  💡 INDICE
//     Pour vérifier que « les deux ont réussi », combine tes deux bool avec l'opérateur && (ET) :
//     la condition n'est vraie que si les deux sont vrais (le && est expliqué à l'exercice 83).
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 078 - Additionner deux nombres avec TryParse (slide 100)");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


