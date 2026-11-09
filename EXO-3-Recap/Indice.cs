using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_3_Recap
{
    internal class Indice
    {
//        EXO 3 — LE GRIMOIRE — INDICES
//=============================
//Les indices te mettent sur la piste, ils ne donnent pas la réponse.
//Les questions sans code (RÉPONSE, prédictions, débogage, quiz) n'ont pas d'indice.


//ÉTAPE 2 — Constantes et variables
//---------------------------------
//2.1  Regarde la forme d'une constante sur la slide 68 : mot-clé, type, nom en PascalCase, valeur.
//     Pour la TVA, on calcule des prix : relis ce que dit la slide 75 sur les nombres à virgule
//     et l'argent. N'oublie pas le suffixe qui va avec le type choisi (slide 79).

//2.2  Il suffit d'écrire une ligne qui donne une nouvelle valeur à la constante, comme pour une
//     variable normale. Lis bien le message d'erreur.

//2.3  Pour chaque valeur, demande-toi : nombre entier ou à virgule ? Quelle taille maximum ?
//     Compare avec le tableau de la slide 75 (un int s'arrête autour de 2,1 milliards).
//     Les types à virgule ont souvent besoin d'un suffixe (slide 79).

//2.4  Le type ne s'écrit qu'une seule fois au début ; les variables sont séparées par une
//     virgule (slide 62).

//2.5  a) Une variable locale non initialisée ne peut pas être lue : le compilateur te le dira.
//     b) Pour ajouter 5, la variable apparaît à gauche ET à droite du =.

//2.7  a) Le mot-clé var remplace le type ; la valeur décide du type réel.
//        GetType() s'appelle sur la variable, avec un point.
//     c) Essaie de ranger un texte dans la variable qui contient 42.

//2.8  La slide 76 montre 5 façons d'écrire un caractère : prends les 4 qui donnent un A
//     (la 5e est une séquence d'échappement).


//ÉTAPE 4 — Le client
//-------------------
//4.1  La question s'affiche avec une méthode qui ne revient PAS à la ligne (slide 56).
//     Regarde le type que renvoie ReadLine (slide 58).

//4.2  La saisie peut être passée directement à int.Parse (slide 92).
//     Si un avertissement apparaît sur ReadLine, relis la slide 70.

//4.3  TryParse prend 2 paramètres : la saisie, puis la variable de sortie précédée de out.
//     Ce qu'il renvoie est un bool : range-le dans une variable, puis teste-la dans un if.

//4.4  Déclare la variable de la quantité sur sa propre ligne. Dans TryParse, après out,
//     écris seulement son nom (pas son type).

//4.5  Compte les chiffres et compare au maximum d'un int (slide 75).
//     Chaque type numérique a son propre TryParse, pas seulement int.
//     L'appel peut se mettre directement entre les parenthèses du if (slide 93).

//4.7  Toute valeur possède une méthode ToString() (slide 89). Pour le prix, le format se
//     donne entre les parenthèses de ToString. Les crochets font partie du texte affiché.


//ÉTAPE 5 — Les valeurs nulles
//----------------------------
//5.1  TryParse ne peut pas écrire directement dans un int? : passe par une variable int
//     intermédiaire, puis copie sa valeur dans numeroFidelite si la conversion a réussi.

//5.2  HasValue est un bool : il va dans la condition du if. Value ne s'utilise que dans
//     le bloc où HasValue est vrai (slide 69).

//5.4  La slide 69 montre la forme longue et le raccourci : prends la première.

//5.6  b) ?. renvoie null si surnom est null : la variable qui reçoit la longueur doit donc
//        pouvoir contenir null. Quel type choisir ?

//5.7  Deux façons de corriger : changer le type pour qu'il accepte null, ou ne pas mettre null.
//     L'opérateur ! se place juste après le nom de la variable (slide 70).


//ÉTAPE 6 — Les calculs du panier
//-------------------------------
//6.1  a) Multiplie le prix (étape 2) par la quantité (étape 4). Si le compilateur refuse,
//        vérifie le type que tu as choisi pour le prix à l'étape 2.3.
//     b) et c) Une simple affectation vers le nouveau type suffit (slide 94).

//6.2  b) Le type cible s'écrit entre parenthèses devant la variable (slide 97).
//        Pour comprendre le résultat, compare le chiffre d'affaires au maximum d'un int.

//6.3  TVA = total HT × ta constante. TTC = HT + TVA.
//     Si le compilateur refuse de multiplier, vérifie le type de ta constante.

//6.4  Déclare d'abord les 2 variables (8 et 3).
//     V4 : Math.Round se met autour du calcul ; il faut ensuite un cast pour obtenir un int
//          (slide 98).
//     V5 : il suffit qu'une seule valeur du calcul soit un decimal pour que tout le calcul
//          le devienne. Convert.ToDecimal transforme un nombre en decimal (slide 91).

//6.6  « Les ,5 vers le haut » : regarde le piège en bas de la slide 98.
//     Math.Round ne renvoie pas un int : il faudra un cast.
//     Pour « sinon 0 point », un if / else avec HasValue (étape 5).

//6.8  Une variable déclarée entre les accolades d'un if n'existe que là (slide 67).


//ÉTAPE 8 — Boxing et unboxing
//----------------------------
//8.1  Une simple affectation vers object suffit (slide 99).
//8.2  Pour sortir de la boîte, il faut un cast vers le type qui a été rangé (slide 99).
//8.5  Fais-le en 2 temps : d'abord ressortir le type exact, puis ranger ce résultat
//     dans un long. La 2e étape est-elle implicite ou explicite ? (slide 94)
//8.6  Même principe qu'en 8.1. Attention au suffixe du 3.5 (slide 79).


//ÉTAPE 9 — Les chaînes
//---------------------
//9.2  a) Sans @, chaque antislash doit être échappé (slide 76).
//     b) Le @ se place juste avant le guillemet ouvrant (slide 83).
//     Dans une chaîne @, un guillemet s'écrit en le doublant (slide 83).

//9.3  Une chaîne @ peut contenir de vrais retours à la ligne : appuie sur Entrée DANS la
//     chaîne (slide 83, l'exemple SQL).

//9.4  Une chaîne brute peut tenir sur une seule ligne ; avec $, la variable se met entre
//     accolades. Les guillemets s'écrivent tels quels (slide 84, dernière ligne).

//9.5  + : colle les textes et les variables, n'oublie pas les espaces.
//     Format composite : {0}, {1}, {2} dans le texte, puis les variables dans l'ordre,
//     après une virgule (slide 57).
//     Interpolation : $ devant la chaîne, variables entre accolades (slide 86).


//ÉTAPE 10 — Le ticket de caisse
//------------------------------
//- Le using de StringBuilder se met tout en haut du fichier (slide 85).
//- Crée UN StringBuilder, ajoute chaque ligne avec Append, et termine chaque ligne par \n.
//- Append renvoie le StringBuilder : c'est ce qui permet d'enchaîner .Append(...).Append(...).
//- Dans une chaîne $, {variable,10:N2} aligne sur 10 caractères ET formate (étape 9 et slide 86).
//- 0,06 → 6 : multiplie ta constante par 100.
//- Ligne fidélité : prépare d'abord le texte dans une variable string (avec HasValue ou ??),
//  puis ajoute-la au ticket.
//- À la fin, un seul Console.WriteLine avec ToString().
//    }
}
