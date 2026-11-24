// ===================================================================================
//  EXO 121 — L'opérateur as
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Convertir sans planter : as donne null si ça ne marche pas.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 134 : « L'opérateur « as » »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une variable   o   de type object qui contient le texte   Bonjour.
//     2. Avec as, convertis o en string dans une nouvelle variable (qui a le droit d'être null),
//        puis affiche-la.
//     3. Avec as, essaie maintenant de convertir o en entier « nullable » (un int qui accepte null).
//        Affiche ensuite True ou False selon que le résultat est null (avec is).
//     4. PROVOQUE UNE ERREUR : essaie d'utiliser as pour convertir o en int normal (qui n'accepte
//        PAS null). Note le code d'erreur, puis mets la ligne en commentaire.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 121 - L'opérateur as
//     │ Bonjour
//     │ True
//     └────────────────────────────────────────────────────────────
//     (les lignes qui provoquent une erreur doivent être en commentaire)
//
//  💡 INDICE
//     Quand la conversion est impossible, as ne plante pas : il renvoie null. Demande-toi donc
//     ce qui se passe si le type de destination n'a pas le droit de valoir null.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 121 - L'opérateur as");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


