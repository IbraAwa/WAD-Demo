// ===================================================================================
//  EXO 115 — is avec une variable (pattern matching)
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Tester le type ET créer la variable en une seule fois.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 129 : « Pattern matching : type pattern »
//        slide 136 : « Indice — is, pattern matching et as »
//     Démo : WAD-Demo-Operateur/Demos/Is.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable   prix   de type object qui contient 19.99.
//     2. Avec is, teste si prix est un double ET récupère-le en même temps dans une nouvelle
//        variable (sans faire de conversion à part). Si oui, affiche   C'est un prix :   suivi de cette valeur.
//     3. Dans un deuxième if, teste en une seule condition que prix est un double ET que
//        ce double dépasse 10. Si oui, affiche   C'est cher !
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 115 - is avec une variable (pattern matching)
//     │ C'est un prix : 19,99
//     │ C'est cher !
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Avec is, on peut écrire un nom de variable juste après le type : si le test réussit,
//     cette variable existe déjà avec le bon type. On peut ensuite l'utiliser dans la suite
//     de la même condition. Attention : deux variables ne peuvent pas porter le même nom.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 115 - is avec une variable (pattern matching)");

// ↓↓↓ écris ton code en dessous ↓↓↓


