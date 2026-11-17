// ===================================================================================
//  EXO 119 — switch sur le type d'une valeur
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Réagir différemment selon que la valeur est un int, un double ou null.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 130 : « Pattern matching avec switch »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable   valeur   de type object qui a le droit d'être null, et qui vaut 3.5.
//     2. Avec une instruction switch (des case) sur le type de valeur, prévois 4 cas,
//        dans cet ordre :
//            - c'est un int ET il est négatif   (utilise le mot-clé when)
//            - c'est un int (les autres entiers)
//            - c'est un double                  → affiche   Décimal   suivi de la valeur
//            - c'est null
//        Pour les autres cas, choisis un message clair (ou reprends ceux de la slide 130),
//        en affichant aussi la valeur quand il y en a une.
//     3. Teste avec 3.5, puis -5, puis 42, puis null.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 119 - switch sur le type d'une valeur
//     │ Décimal 3,5
//     └────────────────────────────────────────────────────────────
//     (avec les valeurs de départ de l'énoncé)
//
//  💡 INDICE
//     Dans un case, on peut tester un type ET créer une variable de ce type en même temps
//     (comme avec is). when ajoute une condition en plus sur cette variable.
//     L'ordre compte : le cas le plus précis doit passer avant le cas général.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 119 - switch sur le type d'une valeur");

// ↓↓↓ écris ton code en dessous ↓↓↓


