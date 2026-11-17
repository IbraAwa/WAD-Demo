// ===================================================================================
//  EXO 074 — Arrondir avec Math.Round
//  Récap slides 0 à 140 · PARTIE 4 — Les conversions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Arrondir correctement un nombre à virgule.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 98 : « Le cast coupe, il n'arrondit pas »
//     Démo : WAD-Demo-Conversion/Demos/ConversionExplicite.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Arrondis 9.44 avec Math.Round, transforme le résultat en entier avec un cast (int), et affiche-le.
//        Fais pareil avec 9.99.
//     2. Convertis 9.99 en entier avec Convert.ToInt32 et affiche le résultat.
//     3. PIÈGE : arrondis 2.5 avec Math.Round et affiche le résultat.
//        Puis arrondis de nouveau 2.5, mais en donnant à Math.Round un deuxième paramètre :
//        l'option AwayFromZero de MidpointRounding (« s'éloigner de zéro »). Affiche le résultat.
//
//  💡 INDICE
//     Math.Round renvoie toujours un nombre à virgule (un double), même quand il n'y a plus de décimales :
//     c'est pour ça qu'il faut encore le transformer en int.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 074 - Arrondir avec Math.Round
//     │ 9
//     │ 10
//     │ 10
//     │ 2
//     │ 3
//     └────────────────────────────────────────────────────────────
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 074 - Arrondir avec Math.Round");

// ↓↓↓ écris ton code en dessous ↓↓↓


