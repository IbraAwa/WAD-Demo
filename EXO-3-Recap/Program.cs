/*
 * ===================================================================================
 *  EXO 3 — RÉCAPITULATIF : LA CAISSE DE LA LIBRAIRIE « LE GRIMOIRE »
 * ===================================================================================
 *
 *  Tu vas coder, étape par étape, le logiciel de caisse d'une librairie.
 *  Chaque étape reprend une partie du cours (slides 1 à 100) et des démos.
 *  À la fin, ton programme affiche un vrai ticket de caisse.
 *
 *  RÈGLES
 *  ------
 *  - Pas de Google, pas d'IA : tout ce qu'il faut est dans les slides (1 à 100) et dans
 *    les projets de la solution. Chaque étape te dit OÙ REGARDER.
 *  - Tu écris ton code sous chaque bannière « ÉTAPE X » de ce fichier.
 *  - Quand on te demande une RÉPONSE ou une PRÉDICTION : écris-la en commentaire (//).
 *  - Quand on te demande de PROVOQUER UNE ERREUR :
 *      1. écris la ligne,
 *      2. note en commentaire le code de l'erreur (CSxxxx) ou le nom de l'exception,
 *      3. explique pourquoi en une phrase,
 *      4. mets la ligne en commentaire (Ctrl + K, C) pour que le programme compile/tourne.
 *  - Les variables créées dans une étape sont réutilisées dans les suivantes : ne les
 *    supprime pas. C'est normal de retaper tes saisies à chaque exécution.
 *
 *  DIFFICULTÉ : 🟢 facile   🟡 moyen   🔴 plus difficile
 *
 */

Console.WriteLine("EXO 3 - Récapitulatif");


// ===================================================================================
// ÉTAPE 1 — L'écran d'accueil 🟢
// Où regarder : slides 56 à 59 | WAD-Demo/exemplecs.cs
// ===================================================================================
/*
 * 1. Avec DEUX Console.Write, affiche sur UNE SEULE ligne :
 *        Bienvenue à la librairie Le Grimoire
 *    ("Bienvenue à la librairie " avec le 1er Write, "Le Grimoire" avec le 2e),
 *    puis reviens à la ligne vide.
 * 2. Affiche : Appuyez sur une touche pour ouvrir la caisse...
 * 3. Attends que l'utilisateur appuie sur une touche, puis efface la console.
 * 4. Affiche : === CAISSE OUVERTE ===
 *
 * RÉPONSES :
 *  a) Quelle est la différence entre Write et WriteLine ?
 *  b) Pourquoi les textes des points 1 et 2 ne sont-ils plus visibles à la fin ?
 *  c) Quel raccourci clavier génère Console.WriteLine(); ?
 */




// ===================================================================================
// ÉTAPE 2 — Les constantes et les variables de la librairie 🟢
// Où regarder : slides 62 à 68, 75, 76, 81 | WAD-Demo/Program.cs + exemplecs.cs
// ===================================================================================
/*
 * 2.1 CONSTANTES — Déclare 3 constantes (nomme-les comme sur la slide 68) :
 *       - le nom de la librairie : "Le Grimoire"
 *       - le taux de TVA sur les livres : 6 % (donc 0,06)
 *       - le nombre de caisses : 3
 *     Choisis le type de chacune. Pour la TVA, justifie ton choix de type en commentaire
 *     (indice : on va calculer des prix).
 *
 * 2.2 PROVOQUE UNE ERREUR : essaie de changer la valeur du taux de TVA après sa déclaration.
 *
 * 2.3 VARIABLES — Déclare une variable pour chaque information, avec le type LE PLUS ADAPTÉ.
 *     Justifie chaque choix en une ligne de commentaire. Respecte le camelCase.
 *       - le nombre de livres en stock : 1 250
 *       - le chiffre d'affaires depuis l'ouverture, en centimes : 12 500 000 000
 *         (utilise le séparateur de milliers vu en slide 81)
 *       - le prix d'un livre : 19,99 €
 *       - le poids d'un colis en kg : 1,75
 *       - la lettre du rayon : R
 *       - la librairie est ouverte : true/false
 *       - l'âge minimum pour le rayon horreur : 16 (un type qui va de 0 à 255 suffit)
 *     Affiche ensuite toutes ces variables.
 *
 * 2.4 Sur UNE SEULE ligne, déclare et initialise la largeur (120) et la hauteur (200)
 *     d'une étagère (slide 62).
 *
 * 2.5 Déclaration / initialisation / affectation (slide 63) :
 *       a) Déclare « int remise; » SANS valeur et essaie de l'afficher → PROVOQUE UNE ERREUR.
 *       b) Corrige : initialise remise à 0, puis fais une affectation qui lui ajoute 5.
 *       c) Écris à côté de chaque ligne s'il s'agit d'une déclaration, d'une
 *          initialisation ou d'une affectation.
 *
 * 2.6 Déclare « int etagere = 1; » puis « int Etagere = 2; ». Affiche les deux.
 *     RÉPONSE : pourquoi le compilateur ne dit-il rien ?
 *
 * 2.7 var (slide 64) :
 *       a) Déclare avec var : 42, "Tolkien" et 9.99m. Affiche le type de chacune avec GetType().
 *       b) PROVOQUE UNE ERREUR : « var x; »
 *       c) RÉPONSE : une variable déclarée avec var peut-elle ensuite recevoir une valeur
 *          d'un autre type ? Pourquoi ? (teste-le !)
 *
 * 2.8 Le caractère (slide 76) : crée 4 variables char qui valent TOUTES 'A',
 *     écrites de 4 façons différentes. Affiche-les sur une seule ligne.
 */




// ===================================================================================
// ÉTAPE 3 — Les prédictions 🟡
// Où regarder : slides 74, 75, 78 à 81, 85, 95, 96 | EXO-2-TypeVariale
// ===================================================================================
/*
 * Copie le code ci-dessous. SANS L'EXÉCUTER, note pour chaque ligne en commentaire :
 *    la valeur prévue  +  le type prévu
 * Ensuite affiche chaque variable comme ceci :
 *    Console.WriteLine($"{a} : {a.GetType()}");
 * Exécute, compare, et explique chaque différence avec ta prédiction.
 *
 *    var a = 7 / 2;
 *    var b = 7 / 2.0;
 *    var c = 7f / 2;
 *    var d = 7m / 2;
 *    var e = 7L * 3;
 *    var f = 7U;
 *    var g = 'A' + 2;
 *    var h = (char)('A' + 2);
 *    var i = 0b_0000_1010;
 *    var j = 0xFF;
 *    var k = 1_000_000;
 *    var l = 2.5F;
 *    var m = "7" + 2;
 *    var n = 10 / 4 * 4;
 *    var o = 10 / 4.0 * 4;
 *
 * RÉPONSES :
 *  a) GetType() affiche des noms comme System.Int32 : pour CHAQUE type obtenu,
 *     écris le mot-clé C# correspondant (ex : System.Int32 → int).
 *  b) int et Int32, est-ce le même type ? Lequel écrit-on en pratique ?
 *  c) Par défaut, un nombre entier écrit en dur est de quel type ? Et un nombre à virgule ?
 *  d) Pourquoi n et o ne donnent-ils pas le même résultat ?
 */




// ===================================================================================
// ÉTAPE 4 — Le client : lire les saisies et les convertir 🟡
// Où regarder : slides 58, 89 à 93 | WAD-Demo-Conversion (Convert, Parse, TryParse) | EXO-1
// ===================================================================================
/*
 * 4.1 Demande le prénom puis le nom du client. La question et la réponse doivent être
 *     sur la MÊME ligne (ex : « Votre prénom : Léa »). Quel type pour ces variables ? Pourquoi ?
 *
 * 4.2 Demande l'âge et convertis-le avec int.Parse.
 *     Exécute 3 fois et note ce qui se passe quand tu tapes :
 *        30        abc        99999999999
 *     (note le nom de chaque exception). Puis mets cette version en commentaire.
 *
 * 4.3 Redemande l'âge, cette fois avec int.TryParse — MANIÈRE 1 de la démo
 *     (le résultat de TryParse est rangé dans une variable bool).
 *     Si la conversion échoue, affiche « Âge invalide ».
 *     RÉPONSE : quelle valeur contient la variable de l'âge après un échec ? (slide 93)
 *
 * 4.4 Demande le nombre de livres achetés (quantité) avec int.TryParse — MANIÈRE 2
 *     (la variable est déclarée AVANT l'appel de TryParse).
 *
 * 4.5 Demande le numéro de carte bancaire (16 chiffres, sans BE, ex : 1234567812345678)
 *     avec TryParse — MANIÈRE 3 (TryParse directement dans le if).
 *     RÉPONSE : pourquoi un int ne convient pas ici ? Quel type as-tu choisi ?
 *
 * 4.6 La classe Convert : pour chaque ligne, PRÉDIS le résultat puis affiche-le.
 *        Convert.ToInt32("42")
 *        Convert.ToDouble("3,14")
 *        Convert.ToDouble("3.14")      ← attention à la culture de ta machine (slide 89)
 *        Convert.ToInt32(9.7)
 *        Convert.ToBoolean(1)
 *        Convert.ToBoolean(0)
 *     PROVOQUE UNE ERREUR : Convert.ToInt32("abc")
 *
 * 4.7 Dans l'autre sens (slide 89) : transforme en string l'âge, le prix d'un livre
 *     (avec 2 décimales grâce à "N2") et la variable « librairie ouverte ».
 *     Range chaque résultat dans une variable string et affiche-les entre crochets [ ].
 *
 * RÉPONSE : Convert, Parse, TryParse… laquelle est la plus propre pour une saisie
 *           utilisateur ? Pourquoi ?
 */




// ===================================================================================
// ÉTAPE 5 — Les valeurs qui peuvent être nulles 🟡
// Où regarder : slides 58, 69, 70 | WAD-Demo/Program.cs (variable nullable, nullable sur int)
// ===================================================================================
/*
 * 5.1 Déclare un int nullable « numeroFidelite » initialisé à null.
 *     Demande : « Numéro de carte de fidélité (laissez vide si vous n'en avez pas) : »
 *     Si la saisie se convertit en int (TryParse), range la valeur dans numeroFidelite.
 *
 * 5.2 Avec HasValue et Value, affiche « Carte fidélité n° ... » ou « Pas de carte fidélité ».
 *
 * 5.3 Sans if, affiche :
 *        - numeroFidelite.GetValueOrDefault()
 *        - numeroFidelite ?? -1
 *     RÉPONSE : quelle différence entre les deux ?
 *
 * 5.4 Déclare une variable « pointsBonus » nullable en écrivant la FORME LONGUE (slide 69).
 *
 * 5.5 PROVOQUE UNE ERREUR : déclare un int? qui vaut null et affiche son .Value.
 *     Note le nom de l'exception.
 *
 * 5.6 Demande un surnom au client (string?).
 *       a) Écris « int longueur = surnom.Length; » : note le code de l'AVERTISSEMENT
 *          (souligné en vert/jaune).
 *       b) Corrige avec l'opérateur ?. (slide 70) et affiche la longueur.
 *       c) RÉPONSE : si tu appuies juste sur Entrée sans rien taper, la longueur vaut-elle
 *          null ou 0 ? Teste et explique pourquoi.
 *
 * 5.7 Écris « string nomObligatoire = null; » : note le code de l'avertissement et corrige.
 *     Utilise ensuite UNE FOIS l'opérateur ! sur ton surnom.
 *     RÉPONSE : que dit-on au compilateur avec ! ? Pourquoi faut-il être prudent ?
 */




// ===================================================================================
// ÉTAPE 6 — Les calculs du panier 🔴
// Où regarder : slides 67, 94 à 98 | WAD-Demo-Conversion (implicite, explicite, cast, Math.Round)
//               WAD-Demo/Program.cs (portée des variables, decimal vs double)
// ===================================================================================
/*
 * 6.1 CONVERSIONS IMPLICITES
 *       a) Calcule le total HT = prix d'un livre × quantité (étape 4) dans un decimal.
 *          RÉPONSE : quelle variable a été convertie automatiquement, et en quoi ?
 *       b) Range le nombre de livres en stock (int) dans une variable long.
 *       c) Range la lettre du rayon (char) dans une variable int et affiche-la.
 *          RÉPONSE : que représente le nombre affiché ?
 *
 * 6.2 CONVERSION EXPLICITE
 *       a) PROVOQUE UNE ERREUR : range le chiffre d'affaires (long) dans un int.
 *       b) Corrige avec un cast (int) et affiche le résultat.
 *          RÉPONSE : le nombre affiché est absurde. Pourquoi ?
 *
 * 6.3 LA TVA : calcule le montant de TVA (total HT × taux) et le total TTC. Affiche-les.
 *
 * 6.4 LE POURCENTAGE : sur ses 8 dernières commandes, le client en a récupéré 3.
 *     On veut afficher le pourcentage de commandes récupérées (le vrai résultat est 37,5 %).
 *     Fais les 5 versions ci-dessous. Pour chacune, PRÉDIS puis affiche :
 *       V1 : tout en int :                         100 / nbCommandes * nbRecuperees
 *       V2 : cast sur le premier nombre :          (int)100f / nbCommandes * nbRecuperees
 *       V3 : cast sur tout le calcul :             (int)(100f / nbCommandes * nbRecuperees)
 *       V4 : arrondi à l'unité la plus proche avec Math.Round
 *       V5 : résultat exact en decimal (avec Convert.ToDecimal, comme dans la démo)
 *     RÉPONSES : pourquoi V1 donne-t-elle 36 ? Pourquoi V2 et V3 sont-elles différentes ?
 *
 * 6.5 LE PIÈGE DE L'ARRONDI : prédis puis affiche :
 *        (int)2.5
 *        Math.Round(2.5)
 *        Math.Round(3.5)
 *        Convert.ToInt32(9.99)
 *        Convert.ToInt32(2.5)
 *     RÉPONSE : explique le résultat de Math.Round(2.5) et de Convert.ToInt32(2.5).
 *
 * 6.6 POINTS DE FIDÉLITÉ : si le client a une carte de fidélité (étape 5), il gagne
 *     total TTC / 2 points, arrondi à l'unité la plus proche (les ,5 vers le haut).
 *     Sinon, il gagne 0 point. Range le résultat dans un int.
 *
 * 6.7 POURQUOI DECIMAL POUR L'ARGENT ? Affiche :
 *        0.1 + 0.2
 *        0.1m + 0.2m
 *        0.1 + 0.2 == 0.3
 *     RÉPONSE : explique avec tes mots (relis les commentaires de la démo sur double et decimal).
 *
 * 6.8 LA PORTÉE : si le total HT est >= 50, déclare DANS le bloc du if une variable
 *     string cadeau = "Marque-page offert" et affiche-la.
 *     PROVOQUE UNE ERREUR : affiche cadeau APRÈS l'accolade fermante du if.
 */




// ===================================================================================
// ÉTAPE 7 — Valeur ou référence ? 🟡
// Où regarder : slides 73, 77, 82 | WAD-Demo/Program.cs (type référence ou valeur)
// ===================================================================================
/*
 * Pour chaque cas : PRÉDIS en commentaire ce qui va s'afficher, PUIS exécute.
 *
 * 7.1  int stockA = 5;
 *      int stockB = stockA;
 *      stockB = 10;
 *      → affiche stockA.
 *
 * 7.2  int[] commandeA = { 3, 5, 8 };
 *      int[] commandeB = commandeA;
 *      commandeB[0] = 99;
 *      → affiche commandeA[0].
 *
 * 7.3  Crée deux listes séparément, avec le même contenu :
 *         List<string> panier1 = new() { "Dune", "Le Hobbit" };
 *         List<string> panier2 = new() { "Dune", "Le Hobbit" };
 *      → affiche le résultat de panier1 == panier2.
 *      Crée ensuite « List<string> panier3 = panier1; »
 *      → affiche panier1 == panier3.
 *      Fais « panier3[0] = "Fondation"; » → affiche panier1[0].
 *
 * RÉPONSES :
 *  a) Explique les résultats de 7.1, 7.2 et 7.3 avec les mots « valeur », « référence » et « copie ».
 *  b) string est un type référence. Pourtant :
 *         string s1 = "Dune";
 *         string s2 = s1;
 *         s2 = "Fondation";
 *     s1 vaut toujours "Dune". Teste-le, puis explique pourquoi (indice : slide 82).
 */




// ===================================================================================
// ÉTAPE 8 — Boxing et unboxing 🟡
// Où regarder : slides 77, 94, 99 | WAD-Demo-Conversion (Boxing / unboxing)
// ===================================================================================
/*
 * 8.1 Range la quantité (étape 4) dans une variable object nommée boite.
 *     Affiche boite et boite.GetType(). RÉPONSE : c'est du boxing ou de l'unboxing ?
 * 8.2 Ressors la valeur de la boîte dans un int.
 * 8.3 PROVOQUE UNE ERREUR : « int q2 = boite; »
 * 8.4 PROVOQUE UNE ERREUR (à l'exécution cette fois) : « long l = (long)boite; »
 * 8.5 Trouve comment obtenir un long à partir de la boîte SANS crash.
 *     Indice : il faut 2 conversions → la règle de la slide 99 + celle de la slide 94.
 * 8.6 Crée 3 variables object qui contiennent : un texte, 3.5m et true.
 *     Affiche le type de chacune. RÉPONSE : pourquoi object peut-il tout contenir ?
 */




// ===================================================================================
// ÉTAPE 9 — Les chaînes de caractères 🔴
// Où regarder : slides 57, 76, 82 à 86 | WAD-Demo-String | WAD-Demo/Program.cs (exemple général)
// ===================================================================================
/*
 * 9.1 IMMUABILITÉ : string titre = "Le Hobbit"; puis ajoute " (édition collector)" avec +=.
 *     RÉPONSE : la chaîne "Le Hobbit" a-t-elle été modifiée ? Que s'est-il passé en mémoire ?
 *
 * 9.2 VERBATIM : le dossier des tickets est  C:\Grimoire\tickets\2026
 *       a) écris-le dans une variable SANS @ (avec les échappements),
 *       b) écris-le dans une autre variable AVEC @,
 *       c) affiche les deux.
 *     Avec @, affiche aussi :  La devise : "Un livre, un monde"
 *
 * 9.3 Avec une chaîne @, affiche l'adresse de la librairie sur 3 lignes :
 *        Le Grimoire
 *        Rue des Livres 12
 *        5000 Namur
 *
 * 9.4 CHAÎNE BRUTE (slide 84) : avec $""" , affiche :  Merci "Léa" pour votre achat !
 *     (le prénom vient de la saisie de l'étape 4, les guillemets doivent s'afficher)
 *
 * 9.5 LES 3 FAÇONS DE CONCATÉNER (slides 57, 85, 86) : affiche « Léa Dupont a 30 ans »
 *     (avec les vraies saisies) de 3 façons :
 *       - avec l'opérateur +
 *       - avec le format composite {0} {1}... directement dans Console.WriteLine
 *       - avec l'interpolation $
 */




// ===================================================================================
// ÉTAPE 10 — LE TICKET DE CAISSE FINAL 🔴
// Où regarder : tout ce qui précède | WAD-Demo-String (StringBuilder) | slide 85
// ===================================================================================
/*
 * Construis tout le ticket dans un StringBuilder (n'oublie pas le using de la démo),
 * puis affiche-le en une seule fois avec ToString().
 *
 * CONTRAINTES :
 *  - utiliser au moins une fois l'enchaînement .Append(...).Append(...) (slide 85)
 *  - le nom de la librairie et le taux de TVA viennent de tes CONSTANTES
 *  - les montants sont formatés avec N2 ou C, et alignés (ex : {totalHt,10:N2})
 *  - le taux de TVA s'affiche en pourcentage (0,06 → 6)
 *  - la ligne fidélité affiche « aucune » si le client n'a pas de carte
 *    (utilise l'opérateur ?? ou HasValue)
 *  - la dernière ligne contient le chemin @ de l'étape 9.2
 *  - utiliser des \t ou \n au moins une fois
 *
 * EXEMPLE ATTENDU (Léa Dupont, 30 ans, 3 livres, carte de fidélité 4521) :
 *
 *    ==============================
 *    LE GRIMOIRE
 *    ==============================
 *    Client    : Léa Dupont (30 ans)
 *    Carte     : 1234567812345678
 *    ------------------------------
 *    Livres    : 3
 *    Prix      :      19,99
 *    Total HT  :      59,97
 *    TVA 6 %   :       3,60
 *    Total TTC :    63,57 €
 *    ------------------------------
 *    Fidélité  : n° 4521 - 32 points
 *    Ticket enregistré dans : C:\Grimoire\tickets\2026
 *    ==============================
 *
 * RÉPONSE : pourquoi utilise-t-on StringBuilder plutôt que + pour construire un long texte ?
 */




// ===================================================================================
// ÉTAPE 11 — Le débogage 🟡
// Où regarder : slides 47 à 53
// ===================================================================================
/*
 * Pas de code ici : réponds en commentaire sous chaque question.
 *
 * 11.1 Mets un point d'arrêt (F9) sur la ligne qui calcule le total HT (étape 6.1)
 *      et lance en mode débogage. Dans la fenêtre « Variables locales » :
 *        a) quels sont la valeur et le type de la quantité et du prix ?
 *        b) que vaut le total HT AVANT que la ligne soit exécutée ? Pourquoi ?
 * 11.2 Avance d'une instruction (pas à pas principal). Quel raccourci ?
 *      Comment Visual Studio te montre-t-il que la valeur du total HT vient de changer ?
 * 11.3 Ajoute un espion sur l'expression : prix × quantité × taux de TVA.
 *      Quelle valeur affiche-t-il ?
 * 11.4 Ouvre la fenêtre Exécution immédiate (quel raccourci ?) et évalue :
 *        Math.Round(2.5)        100 / 8 * 3
 * 11.5 Transforme ton point d'arrêt en point d'arrêt CONDITIONNEL : il ne doit s'arrêter
 *      que si la quantité est supérieure à 5. Teste avec 2 livres, puis avec 10 livres.
 *      Que se passe-t-il dans chaque cas ?
 * 11.6 Fais glisser la flèche jaune une ligne plus haut et ré-exécute la ligne.
 *      Les variables ont-elles retrouvé leur ancienne valeur ? (slide 49)
 * 11.7 Quelle est la différence entre F10, F11 et Maj + F11 ?
 * 11.8 Pendant le débogage, change le texte d'un Console.WriteLine et applique-le avec
 *      le rechargement à chaud. Quel raccourci ? Le programme a-t-il redémarré ?
 * 11.9 Quel raccourci arrête le débogage ? Et lequel lance le programme SANS débogage ?
 */



// ===================================================================================
// ÉTAPE 12 — Quiz de compréhension 🟡
// Où regarder : slides 5 à 7, 23, 24, 34, 58, 65 à 67, 70, 73, 75, 77
// ===================================================================================
/*
 * Réponds en commentaire.
 *
 *  12.1 Ouvre le fichier EXO-3-Recap.csproj de ce projet.
 *       a) Quelle version de .NET ce projet cible-t-il ? Est-ce une LTS ou une STS ?
 *          Combien de temps est-elle supportée ?
 *       b) À quoi servent <ImplicitUsings> et <Nullable> ?
 *  12.2 Ce Program.cs n'a pas de méthode Main. Comment le programme sait-il par où démarrer ?
 *  12.3 Ouvre WAD-Demo.slnx : quelle est la différence entre une solution et un projet ?
 *  12.4 Cite les 5 catégories de types du CTS et dis pour chacune si c'est un type valeur
 *       ou référence.
 *  12.5 Quels sont les deux seuls types référence prédéfinis en C# ?
 *       Pourquoi string est-il le seul type référence qu'on peut mettre dans un const ?
 *  12.6 Lis ce code SANS l'exécuter :
 *
 *         class Livre
 *         {
 *             int pages;
 *             string titre = "Champ";
 *
 *             void Afficher()
 *             {
 *                 string titre = "Locale";
 *                 int chapitres;
 *                 Console.WriteLine(pages);        // ligne A
 *                 Console.WriteLine(titre);        // ligne B
 *                 Console.WriteLine(this.titre);   // ligne C
 *                 Console.WriteLine(chapitres);    // ligne D
 *             }
 *         }
 *
 *       a) Quelle ligne ne compile pas ? Avec quel code d'erreur ? Pourquoi ?
 *       b) Qu'affichent les 3 autres lignes ? Explique la ligne A.
 *       c) Quelle est la différence entre un champ et une variable locale ?
 *  12.7 Pourquoi Console.ReadLine() retourne-t-il un string? et pas un string ?
 */