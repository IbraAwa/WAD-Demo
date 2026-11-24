// ===================================================================================
//  EXO 112 — Coalesce et affectation ??= (slide 126 n°4)
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Créer quelque chose SEULEMENT s'il n'existe pas encore.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 124 : « Coalesce et affectation ??= »
//        slide 126 : « À vous de jouer (exercice) »
//     Démo : WAD-Demo-Operateur/Demos/Coalesce.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare un   panier   : une liste de textes (List<string>) qui a le droit d'être null.
//        Au départ, il est null.
//     2. Avec l'opérateur ??=, crée une nouvelle liste vide dans le panier SEULEMENT s'il est null.
//     3. Ajoute l'article   pain   dans le panier (méthode Add).
//     4. Refais exactement la même chose qu'à l'étape 2. Prédis : le panier est-il remplacé par un vide ?
//     5. Affiche   Nombre d'articles :   suivi du nombre d'éléments du panier (propriété Count),
//        puis, sur la ligne suivante, le contenu du panier séparé par des virgules (string.Join).
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 112 - Coalesce et affectation ??= (slide 126 n°4)
//     │ Nombre d'articles : 1
//     │ pain
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     ??= n'affecte la valeur de droite que si la variable est null. Si elle contient déjà
//     quelque chose, il ne se passe rien.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 112 - Coalesce et affectation ??= (slide 126 n°4)");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


