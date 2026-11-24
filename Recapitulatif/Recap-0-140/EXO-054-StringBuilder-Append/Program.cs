// ===================================================================================
//  EXO 054 — StringBuilder : construire un texte morceau par morceau
//  Récap slides 0 à 140 · PARTIE 3 — Les types de données
// ===================================================================================
//
//  🎯 OBJECTIF
//     Utiliser un StringBuilder et sa méthode Append.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 85 : « La concaténation de string »
//     Démo : WAD-Demo-String/Demos/AvecStringBuilder.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Tout en haut du fichier (AVANT la ligne Console.WriteLine du titre), ajoute le using
//        qui donne accès à l'espace de noms System.Text (c'est là que vit StringBuilder).
//     2. Crée un nouveau StringBuilder vide, dans une variable sb.
//     3. Avec sa méthode Append, ajoute 3 morceaux l'un après l'autre :
//        "Le Petit Prince", puis " - ", puis "Antoine de Saint-Exupéry".
//     4. Transforme le StringBuilder en vraie string (avec ToString), range-la dans une variable texte
//        et affiche texte.
//
//  💡 INDICE
//     Un StringBuilder est un texte « en chantier » : chaque Append ajoute un morceau à la fin.
//     Ce n'est qu'à la toute fin qu'on le transforme en string pour l'utiliser.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 054 - StringBuilder : construire un texte morceau par morceau
//     │ Le Petit Prince - Antoine de Saint-Exupéry
//     └────────────────────────────────────────────────────────────
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 054 - StringBuilder : construire un texte morceau par morceau");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


