// ===================================================================================
//  EXO 041 — Type référence : on copie l'adresse
//  Récap slides 0 à 140 · PARTIE 3 — Les types de données
// ===================================================================================
//
//  🎯 OBJECTIF
//     Voir qu'en copiant une liste, les deux variables pointent sur la MÊME liste.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 77 : « Les types référence »
//     Démo : WAD-Demo/Demos/TypeValeurEtReference.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Crée une liste de textes maListe qui contient pain et lait.
//        (Les List seront vues plus tard : le type s'écrit List<string>, on la crée avec new
//        et on peut mettre les éléments de départ directement entre accolades { }.)
//     2. Déclare une deuxième variable listeDuColoc du même type et donne-lui maListe
//        (PAS une nouvelle liste : la variable maListe elle-même).
//     3. En passant par listeDuColoc, ajoute café à la liste (avec la méthode Add).
//     4. AVANT de lancer : prédis en commentaire ce que contient maListe.
//     5. Affiche le contenu de maListe sur une ligne, les éléments séparés par une virgule et
//        un espace : utilise string.Join pour ça.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 041 - Type référence : on copie l'adresse
//     │ pain, lait, café
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Compare avec l'exercice 40 : un int (type valeur) se copie, une List (type référence) se partage.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 041 - Type référence : on copie l'adresse");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


