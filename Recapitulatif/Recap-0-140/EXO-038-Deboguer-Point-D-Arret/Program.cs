// ===================================================================================
//  EXO 038 — Déboguer : point d'arrêt et variables locales
//  Récap slides 0 à 140 · PARTIE 2 — Les variables
// ===================================================================================
//
//  🎯 OBJECTIF
//     Arrêter le programme sur une ligne et regarder les valeurs des variables.
//
//  📖 OÙ REGARDER
//     PDF « C# · Les fondements (C# 14) » :
//        slides 47 à 51 : « Les raccourcis courants » ... « Les variables locales »
//     Démo : — (pas de démo pour ce point, tout est dans la slide)
//
//  ✏️ CONSIGNES (une par une, dans l'ordre)
//     1. Écris un petit programme de 4 lignes :
//            - déclare une variable entière stock qui vaut 10 ;
//            - on vend 3 articles : retire 3 au stock (en remettant le résultat dans stock) ;
//            - on reçoit une livraison : ajoute 5 au stock (même principe) ;
//            - affiche « Stock final : » suivi du stock.
//     2. Clique dans la marge grise à gauche de ta PREMIÈRE ligne (la déclaration de stock),
//        ou place-toi dessus et appuie sur F9 : un rond rouge apparaît.
//     3. Lance avec F5 : le programme s'arrête, une flèche jaune montre la PROCHAINE ligne exécutée.
//     4. Appuie sur F10 pour avancer d'une ligne. Regarde la fenêtre « Variables locales » en bas.
//     5. Note en commentaire la valeur de stock après CHAQUE ligne.
//     6. Appuie sur F5 pour finir le programme (ou Maj+F5 pour l'arrêter).
//
//  🖥️ QUAND TU LANCES, TU DOIS VOIR :
//     ┌────────────────────────────────────────────────────────────
//     │ EXO 038 - Déboguer : point d'arrêt et variables locales
//     │ Stock final : 12
//     └────────────────────────────────────────────────────────────
//
//  💡 INDICE
//     Si tu ne vois pas « Variables locales » : menu Déboguer > Fenêtres > Variables locales
//     (seulement PENDANT que le programme est arrêté sur le point d'arrêt).
//
//  ▶️ POUR LANCER : clic droit sur ce projet > « Définir comme projet de démarrage », puis F5
//  ✅ CORRECTION : le fichier Correction.cs de ce projet (regarde-le seulement après avoir essayé !)
// ===================================================================================

Console.WriteLine("EXO 038 - Déboguer : point d'arrêt et variables locales");

// ✅ CORRECTION : pour voir la correction s'exécuter, enlève les // devant la ligne ci-dessous (Ctrl+K puis Ctrl+U)
//Correction.Lancer();

// ↓↓↓ écris ton code en dessous ↓↓↓


