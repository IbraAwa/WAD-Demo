// ===================================================================================
//  EXO 071 — Le bug des 24 % au lieu de 25 %
//  Récap slides 0 à 140 · PARTIE 4 — Les conversions
// ===================================================================================
//
//  🎯 OBJECTIF
//     Reproduire un vrai bug causé par la division entière.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 95 : « Conversions explicites : le problème »
//        slide 96 : « Pourquoi 24 % et pas 25 % ? »
//     Démo : WAD-Demo-Conversion/Demos/ConversionExplicite.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Sur 8 commandes, 2 sont livrées. Déclare deux variables entières : nbCommandes (8) et nbLivrees (2).
//     2. Calcule le pourcentage de commandes livrées dans une variable entière pct, dans CET ordre précis :
//        d'abord 100 divisé par le nombre de commandes, puis le résultat multiplié par le nombre de livrées.
//     3. Affiche pct suivi d'un espace et du signe %.
//     4. Lance. Le bon résultat est 25 % : explique en commentaire, étape par étape, pourquoi on a 24 %.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 071 - Le bug des 24 % au lieu de 25 %
//     │ 24 %
//     └────────────────────────────────────────────────────────────
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 071 - Le bug des 24 % au lieu de 25 %");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


