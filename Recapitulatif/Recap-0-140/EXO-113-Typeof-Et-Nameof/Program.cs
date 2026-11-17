// ===================================================================================
//  EXO 113 — typeof et nameof (slide 126 n°5)
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Obtenir les informations d'un type.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 125 : « L'opérateur « typeof » »
//        slide 126 : « À vous de jouer (exercice) »
//     Démo : WAD-Demo-Operateur/Demos/Is.cs
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Avec typeof, récupère les infos du type int et affiche sur une ligne son nom court
//        (propriété Name) puis son nom complet (propriété FullName), séparés par   / .
//     2. Fais pareil pour string et decimal.
//     3. Déclare une variable   o   de type object qui contient 3.14. Affiche True ou False
//        selon que le type réel de o (méthode GetType) est bien le même que le type double.
//     4. Déclare une variable entière   age   qui vaut 30 et affiche le NOM de cette variable avec nameof.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 113 - typeof et nameof (slide 126 n°5)
//     │ Int32 / System.Int32
//     │ String / System.String
//     │ Decimal / System.Decimal
//     │ True
//     │ age
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     typeof part d'un NOM de type, GetType part d'une VALEUR : les deux donnent un Type
//     qu'on peut comparer. nameof renvoie le nom écrit dans le code, pas la valeur.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 113 - typeof et nameof (slide 126 n°5)");

// ↓↓↓ écris ton code en dessous ↓↓↓


