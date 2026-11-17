# Récapitulatif — slides 0 à 140

Exercices de révision du PDF « C# · Les fondements (C# 14) », des slides 0 à 140 (de « Premier programme » jusqu'à
« Ordre de priorité des opérateurs »). Les boucles (slide 142 et suivantes) ne sont pas encore couvertes.

## Comment travailler

- **Un exercice = un projet console.** Fais-les dans l'ordre : chaque exercice ajoute UNE petite marche.
- **Pour lancer un exercice** : clic droit sur son projet > *Définir comme projet de démarrage*, puis **F5**.
- **L'énoncé est en haut de `Program.cs`** : objectif, slide et démo où regarder, consignes, et ce que tu dois voir à l'écran.
- **Tu écris ton code sous la ligne** `// ↓↓↓ écris ton code en dessous ↓↓↓`.
- **Quand on te demande une réponse ou une prédiction** : écris-la en commentaire (`//`).
- **Quand on te demande de PROVOQUER UNE ERREUR** :
  1. écris la ligne ;
  2. passe la souris sur le soulignement rouge et note le code de l'erreur (`CSxxxx`) ou le nom de l'exception en commentaire ;
  3. mets la ligne en commentaire (**Ctrl+K puis Ctrl+C**) pour que le programme compile et tourne.
- **La correction** est dans `Correction.cs`, dans chaque projet (elle n'est pas compilée). Regarde-la seulement après avoir essayé.


## PARTIE 1 — La console

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 001 | Afficher un message avec WriteLine | 56 | `WAD-Demo/Demos/AfficherEtLire.cs` |
| 002 | Afficher plusieurs lignes | 56 | `WAD-Demo/Demos/AfficherEtLire.cs` |
| 003 | Sauter une ligne | 56 | `WAD-Demo/Demos/AfficherEtLire.cs` |
| 004 | Write : écrire sans revenir à la ligne | 56 | `WAD-Demo/Demos/AfficherEtLire.cs` |
| 005 | ReadLine : attendre la touche Entrée | 58 | `WAD-Demo/Demos/AvecUtilisateur.cs` |
| 006 | ReadLine : lire un prénom | 58 | `WAD-Demo/Demos/AvecUtilisateur.cs` |
| 007 | Poser deux questions | 58 | `WAD-Demo/Demos/AvecUtilisateur.cs` |
| 008 | ReadKey : attendre une seule touche | 59 | — |
| 009 | Clear : effacer la console | 59 | `WAD-Demo/Demos/AfficherEtLire.cs` |
| 010 | Le format composite {0} {1} | 57 | `WAD-Demo/Demos/AfficherDesVariables.cs` |
| 011 | Les commentaires | 39 | `WAD-Demo/Demos/Commentaires.cs` |

## PARTIE 2 — Les variables

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 012 | Déclarer un int | 62, 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 013 | Déclarer un string | 62, 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 014 | Déclarer un bool | 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 015 | Déclarer un long | 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 016 | Déclarer un decimal (pour l'argent) | 75, 79 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 017 | Déclarer un double | 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 018 | Déclarer un float | 75, 79 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 019 | Déclarer un char | 75, 76 | `WAD-Demo-Recap1/Demos/TypesDeVariables.cs` |
| 020 | Déclarer un byte (de 0 à 255) | 75 | — |
| 021 | Choisir le bon type | 75 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 022 | Déclarer d'abord, donner la valeur ensuite | 63 | — |
| 023 | Changer la valeur d'une variable | 63 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 024 | Ajouter quelque chose à une variable | 63 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 025 | Déclarer plusieurs variables sur une ligne | 62 | — |
| 026 | L'erreur CS0165 : variable sans valeur | 63 | `WAD-Demo/Demos/VariableNullable.cs` |
| 027 | Majuscules et minuscules comptent | 62 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 028 | Bien nommer ses variables (camelCase) | 62 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 029 | var : laisser C# deviner le type | 64, 74 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 030 | Les erreurs avec var | 64 | `WAD-Demo/Demos/NomDesVariables.cs` |
| 031 | La portée d'une variable | 67 | `WAD-Demo/Demos/Portee.cs` |
| 032 | Les constantes (const) | 68 | `WAD-Demo/Demos/Constante.cs` |
| 033 | Les erreurs avec une constante | 68 | `WAD-Demo/Demos/Constante.cs` |
| 034 | int? : un nombre qui peut être vide | 69 | `WAD-Demo/Demos/VariableNullable.cs` |
| 035 | HasValue et Value | 69 | `WAD-Demo/Demos/VariableNullable.cs` |
| 036 | Value sur un null : le programme plante | 69 | `WAD-Demo/Demos/VariableNullable.cs` |
| 037 | string? : un texte qui peut être null | 58, 70 | `WAD-Demo/Demos/VariableNullable.cs` |
| 038 | Déboguer : point d'arrêt et variables locales | 47 à 51 | — |

## PARTIE 3 — Les types de données

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 039 | int ou Int32 : le même type | 74 | — |
| 040 | Type valeur : on copie la valeur | 77 | `WAD-Demo/Demos/TypeValeurEtReference.cs` |
| 041 | Type référence : on copie l'adresse | 77 | `WAD-Demo/Demos/TypeValeurEtReference.cs` |
| 042 | Le type des valeurs écrites dans le code | 78 | `WAD-Demo/Demos/TypesLitteraux.cs` |
| 043 | Les suffixes L, F, D, M et U | 79 | `WAD-Demo/Demos/TypesLitteraux.cs` |
| 044 | Prédire le type d'un calcul (exercice slide 80) | 80 | `WAD-Demo/Demos/TypesLitteraux.cs` |
| 045 | Le séparateur _ pour les grands nombres | 81 | `WAD-Demo/Demos/TypesDeVariables.cs` |
| 046 | Retour à la ligne et tabulation dans un texte | 76 | — |
| 047 | Afficher des guillemets et un antislash | 76 | — |
| 048 | Un caractère de quatre façons | 76 | — |
| 049 | Un string ne se modifie pas | 82 | `WAD-Demo-String/Demos/Immuable.cs` |
| 050 | La chaîne verbatim @ pour un chemin | 83 | — |
| 051 | La chaîne verbatim @ sur plusieurs lignes | 83 | — |
| 052 | La chaîne brute avec trois guillemets | 84 | — |
| 053 | Coller des textes avec + | 85 | `WAD-Demo-Operateur/Demos/Concatenation.cs` |
| 054 | StringBuilder : construire un texte morceau par morceau | 85 | `WAD-Demo-String/Demos/AvecStringBuilder.cs` |
| 055 | string.Format | 86 | — |
| 056 | L'interpolation avec $ | 86 | `WAD-Demo/Demos/AfficherDesVariables.cs` |
| 057 | Formater un prix : N2, C et l'alignement | 86 | — |

## PARTIE 4 — Les conversions

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 058 | ToString : transformer en texte | 89 | `WAD-Demo-Conversion/Demos/VersString.cs` |
| 059 | Convert.ToInt32 : du texte vers un nombre | 91 | `WAD-Demo-Conversion/Demos/AvecConvert.cs` |
| 060 | Convert vers double, bool, et l'arrondi | 91 | `WAD-Demo-Conversion/Demos/AvecConvert.cs` |
| 061 | Convert qui plante : FormatException | 91 | `WAD-Demo-Conversion/Demos/AvecConvert.cs` |
| 062 | Parse : int.Parse, double.Parse, bool.Parse | 92 | `WAD-Demo-Conversion/Demos/AvecParse.cs` |
| 063 | Les deux erreurs de Parse | 92 | `WAD-Demo-Conversion/Demos/AvecParse.cs` |
| 064 | Lire un nombre tapé par l'utilisateur | 58, 92 | `WAD-Demo-Conversion/Demos/AvecUtilisateur.cs` |
| 065 | TryParse : convertir sans planter | 93 | `WAD-Demo-Conversion/Demos/AvecTryParse.cs` |
| 066 | TryParse avec un if | 93 | `WAD-Demo-Conversion/Demos/AvecTryParse.cs` |
| 067 | Conversion implicite : C# le fait tout seul | 94 | `WAD-Demo-Conversion/Demos/ConversionImplicite.cs` |
| 068 | char vers int : le code de la lettre | 94 | `WAD-Demo-Conversion/Demos/ConversionImplicite.cs` |
| 069 | long vers int : refusé par C# | 94 | `WAD-Demo-Conversion/Demos/ConversionImplicite.cs` |
| 070 | int / int : la virgule disparaît | 96 | `WAD-Demo-Operateur/Demos/Arithmetique.cs` |
| 071 | Le bug des 24 % au lieu de 25 % | 95, 96 | `WAD-Demo-Conversion/Demos/ConversionExplicite.cs` |
| 072 | Le cast (int) | 97 | `WAD-Demo-Conversion/Demos/ConversionExplicite.cs` |
| 073 | Le cast coupe, il n'arrondit pas | 98 | `WAD-Demo-Conversion/Demos/ConversionExplicite.cs` |
| 074 | Arrondir avec Math.Round | 98 | `WAD-Demo-Conversion/Demos/ConversionExplicite.cs` |
| 075 | Boxing : ranger dans un object | 99 | `WAD-Demo-Conversion/Demos/BoxingUnboxing.cs` |
| 076 | Unboxing : ressortir de l'object | 99 | `WAD-Demo-Conversion/Demos/BoxingUnboxing.cs` |
| 077 | Additionner deux nombres avec Parse (slide 100) | 100 | `WAD-Demo-Conversion/Demos/AvecUtilisateur.cs` |
| 078 | Additionner deux nombres avec TryParse (slide 100) | 100 | `WAD-Demo-Conversion/Demos/AvecTryParse.cs` |

## PARTIE 5 — Les conditions

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 079 | Le if tout seul | 103 | `WAD-Demo-Structure-Conditionnelle/Demos/IfElse.cs` |
| 080 | if ... else | 103 | `WAD-Demo-Structure-Conditionnelle/Demos/IfElse.cs` |
| 081 | if ... else avec ce que l'utilisateur tape | 103 | `WAD-Demo-Structure-Conditionnelle/Demos/AvecUtilisateur.cs` |
| 082 | Les 6 opérateurs de comparaison | 104 | `WAD-Demo-Operateur/Demos/Comparaison.cs` |
| 083 | Le ET : && | 104, 105 | `WAD-Demo-Operateur/Demos/Logique.cs` |
| 084 | Le OU : // | 104 | `WAD-Demo-Operateur/Demos/Logique.cs` |
| 085 | Le NON : ! | 104 | `WAD-Demo-Operateur/Demos/Logique.cs` |
| 086 | Le OU exclusif : ^ | 104 | — |
| 087 | Mélanger && et // avec des parenthèses | 104 | `WAD-Demo-Structure-Conditionnelle/Demos/IfElse.cs` |
| 088 | if ... else if ... else | 106 | `WAD-Demo-Structure-Conditionnelle/Demos/IfElseIfElse.cs` |
| 089 | Le piège des if séparés | 107 | `WAD-Demo-Structure-Conditionnelle/Demos/IfElseIfElse.cs` |
| 090 | Le switch | 108 | `WAD-Demo-Structure-Conditionnelle/Demos/Switch.cs` |
| 091 | Regrouper des case | 109 | `WAD-Demo-Structure-Conditionnelle/Demos/Switch.cs` |
| 092 | L'expression switch | 110 | `WAD-Demo-Structure-Conditionnelle/Demos/Switch.cs` |
| 093 | Pair ou impair avec les moitiés (slide 111) | 111 | — |
| 094 | Déboguer : les espions | 52 | — |

## PARTIE 6 — Les opérateurs

| N° | Exercice | Slides | Démo |
|---|---|---|---|
| 095 | Les opérateurs + - * / % | 115 | `WAD-Demo-Operateur/Demos/Arithmetique.cs` |
| 096 | Le modulo pour savoir si c'est pair | 115 | `WAD-Demo-Operateur/Demos/Arithmetique.cs` |
| 097 | Division entière, modulo et division (slide 141 n°1) | 96, 115, 141 | `WAD-Demo-Operateur/Demos/Arithmetique.cs` |
| 098 | Les raccourcis += et -= | 117 | `WAD-Demo-Operateur/Demos/Affectation.cs` |
| 099 | Les raccourcis *= /= et %= | 117 | `WAD-Demo-Operateur/Demos/Affectation.cs` |
| 100 | Le panier avec remise (slide 121 n°1) | 121 | `WAD-Demo-Operateur/Demos/Affectation.cs` |
| 101 | ++ et -- | 117 | `WAD-Demo-Operateur/Demos/Incrementation.cs` |
| 102 | ++x ou x++ ? | 118, 119 | `WAD-Demo-Operateur/Demos/Incrementation.cs` |
| 103 | Prédire commandes++ et ++commandes (slide 121 n°2) | 121 | `WAD-Demo-Operateur/Demos/Incrementation.cs` |
| 104 | L'opérateur ternaire ? : | 120 | `WAD-Demo-Operateur/Demos/Ternaire.cs` |
| 105 | Ternaire : majeur ou mineur (slide 121 n°3) | 121 | `WAD-Demo-Structure-Conditionnelle/Demos/AvecUtilisateur.cs` |
| 106 | Ternaire : la livraison gratuite (slide 121 n°4) | 121 | `WAD-Demo-Operateur/Demos/AvecUtilisateur.cs` |
| 107 | Ternaire : pair ou impair (slide 121 n°5) | 121 | `WAD-Demo-Operateur/Demos/Ternaire.cs` |
| 108 | D'autres ternaires (slide 122) | 122 | `WAD-Demo-Operateur/Demos/Ternaire.cs` |
| 109 | Coalesce ?? : une valeur de secours (slide 126 n°1) | 123, 126 | `WAD-Demo-Operateur/Demos/Coalesce.cs` |
| 110 | Coalesce : une quantité de 1 par défaut (slide 126 n°2) | 123, 126 | `WAD-Demo-Operateur/Demos/Coalesce.cs` |
| 111 | Coalesce en chaîne : le premier numéro dispo (slide 126 n°3) | 123, 126 | `WAD-Demo-Operateur/Demos/Coalesce.cs` |
| 112 | Coalesce et affectation ??= (slide 126 n°4) | 124, 126 | `WAD-Demo-Operateur/Demos/Coalesce.cs` |
| 113 | typeof et nameof (slide 126 n°5) | 125, 126 | `WAD-Demo-Operateur/Demos/Is.cs` |
| 114 | is : vérifier le type | 128 | `WAD-Demo-Operateur/Demos/Is.cs` |
| 115 | is avec une variable (pattern matching) | 129, 136 | `WAD-Demo-Operateur/Demos/Is.cs` |
| 116 | is null, is not null et is 404 | 131 | `WAD-Demo-Operateur/Demos/Is.cs` |
| 117 | Les patterns and, or, not | 132 | — |
| 118 | switch avec des comparaisons (mention et âge) | 132, 136 | `WAD-Demo-Operateur/Demos/Ternaire.cs` |
| 119 | switch sur le type d'une valeur | 130 | — |
| 120 | Tester une propriété : { Length: > 5 } | 133 | — |
| 121 | L'opérateur as | 134 | — |
| 122 | L'ordre de priorité des calculs (slide 141 n°5) | 140, 141 | `WAD-Demo-Operateur/Demos/Arithmetique.cs` |
| 123 | Priorité : && passe avant // | 140 | `WAD-Demo-Operateur/Demos/Logique.cs` |
