// ===================================================================================
//  EXO 117 — Les patterns and, or, not
//  Récap slides 0 à 140 · PARTIE 6 — Les opérateurs
// ===================================================================================
//
//  🎯 OBJECTIF
//     Écrire des conditions en n'écrivant la variable qu'une seule fois.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slide 132 : « Patterns relationnels et logiques »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Déclare une   note   entière qui vaut 15. Dans un bool   reussi, range le résultat du test
//        « la note est entre 10 et 20 (les deux compris) », en utilisant is et and
//        (la variable note ne doit apparaître qu'UNE fois dans le test). Affiche   Réussi :   puis reussi.
//     2. Déclare une   lettre   (un seul caractère) qui vaut e. Dans un bool   voyelle, range le résultat
//        du test « la lettre est a, e, i, o ou u », avec is et or. Affiche   Voyelle :   puis voyelle.
//     3. Refais le test de l'étape 1, mais cette fois avec l'opérateur && (sans is), pour comparer
//        les deux écritures. Affiche   Réussi (avec &&) :   puis le résultat.
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 117 - Les patterns and, or, not
//     │ Réussi : True
//     │ Voyelle : True
//     │ Réussi (avec &&) : True
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Avec is, on écrit la variable une seule fois, puis les comparaisons à la suite, reliées par
//     and / or. Avec &&, au contraire, il faut répéter la variable dans chaque comparaison.
//     Un caractère s'écrit entre apostrophes simples, pas entre guillemets.
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 117 - Les patterns and, or, not");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


