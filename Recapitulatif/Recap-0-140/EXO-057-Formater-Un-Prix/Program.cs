// ===================================================================================
//  EXO 057 — Formater un prix : N2, C et l'alignement
//  Récap slides 0 à 140 · PARTIE 3 — Les types de données
// ===================================================================================
//
//  🎯 OBJECTIF
//     Afficher un nombre joliment : 2 chiffres après la virgule, en euros, aligné.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 86 : « string.Format et interpolation »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable prix qui vaut 1234,5 (c'est de l'argent : choisis le type adapté).
//     2. Dans une chaîne interpolée, affiche prix avec le format N2
//        (2 chiffres après la virgule et séparateur de milliers).
//     3. Affiche prix avec le format C (C = currency = monnaie).
//     4. Déclare une variable nom qui contient "Léa". Affiche-la entre crochets [ ], dans une zone
//        de 10 caractères alignée à DROITE. Puis affiche-la de nouveau entre crochets, dans une zone
//        de 10 caractères alignée à GAUCHE.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 057 - Formater un prix : N2, C et l'alignement
//     │ 1 234,50
//     │ 1 234,50 €
//     │ [       Léa]
//     │ [Léa       ]
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Le résultat dépend de la langue de ton PC : en français 1 234,50 €, en anglais 1,234.50.
//     Dans les { }, le format se place après deux-points ( : ) et la largeur après une virgule ( , ).
//     Une largeur positive aligne à droite, une largeur négative aligne à gauche.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 057 - Formater un prix : N2, C et l'alignement");

// ↓↓↓ écris ton code en dessous ↓↓↓


