# LABO 3 — Le concessionnaire automobile

**Niveau :** Normal (pas d'étapes : c'est toi qui organises ton code)
**Durée estimée :** 1 journée (≈ 8 h) — + une 2e journée possible avec « Pour aller plus loin »

## 📖 L'histoire

Le garage **« AutoPrestige »** vend des voitures d'occasion. Trois vendeurs y travaillent.
Le patron en a assez du carnet papier : il veut un programme console pour gérer **le stock**, **vendre** des voitures
en appliquant **toutes les règles commerciales** du garage (remises, reprises, garanties, crédit), ne jamais **vendre à perte**,
calculer les **commissions** des vendeurs et suivre la **rentabilité** de la journée.

Chaque voiture est identifiée par sa **plaque d'immatriculation**. Une plaque est **unique** : le programme ne doit **jamais** accepter deux voitures avec la même plaque.

À toi de concevoir le programme : quelles `enum`, quelles `struct`, quelles collections, quelles méthodes.
L'énoncé te dit **quoi** faire, pas **comment** le faire.

---

## 🗺️ Plan de route conseillé

Le labo est gros : avance **par jalons**, et ne commence un jalon que quand le précédent fonctionne.

| Jalon | Contenu | Temps indicatif |
|---|---|---|
| 1 | Les types (`enum`, `struct`), les données de départ (dictionnaire + listes), les méthodes de saisie (dont la plaque), le menu, l'affichage du stock | 1 h 30 |
| 2 | La recherche multicritère, l'ajout d'une voiture (plaque unique), la modification d'un prix | 1 h 30 |
| 3 | La vente : vendeurs, remises, vente à perte, garantie, reprise — et l'historique | 2 h 30 |
| 4 | Le financement à crédit et l'annulation d'une vente | 1 h 15 |
| 5 | Le tri du stock, les statistiques et le bilan de fin de journée | 1 h 15 |

👉 **Les jalons 1 à 3 sont le minimum attendu.** Le labo est **complet** quand les 5 jalons sont faits.

---

## 🚗 Les données de départ

### Le stock

| Plaque | Marque | Modèle | Année | Km | Prix d'achat (€) | Prix de vente (€) | Carburant |
|---|---|---|---|---|---|---|---|
| 1-GHT-482 | Peugeot | 208 | 2019 | 85 000 | 10 200 | 12 500 | Essence |
| 2-KLM-115 | Renault | Clio | 2021 | 32 000 | 13 100 | 15 900 | Essence |
| 1-DFR-907 | Volkswagen | Golf | 2016 | 160 000 | 7 800 | 9 900 | Diesel |
| 2-MZA-340 | Toyota | Yaris | 2022 | 18 000 | 18 300 | 21 500 | Hybride |
| 2-TSL-003 | Tesla | Model 3 | 2023 | 12 000 | 34 500 | 38 900 | Electrique |
| 1-HBX-761 | BMW | Série 1 | 2018 | 98 000 | 14 600 | 17 400 | Diesel |
| 2-ABP-258 | Peugeot | 3008 | 2020 | 67 000 | 21 200 | 24 900 | Hybride |
| 1-CVN-624 | Dacia | Sandero | 2015 | 172 000 | 5 300 | 5 900 | Essence |

- Le **prix d'achat** est ce que le garage a payé la voiture. Le client ne le voit jamais.
- Le **prix de vente** (ou « prix affiché ») est le prix sur le pare-brise.

### Les vendeurs

| N° | Prénom | Niveau | Remise négociée maximum |
|---|---|---|---|
| 1 | Marc | Senior | 10 % |
| 2 | Julie | Senior | 10 % |
| 3 | Karim | Junior | 5 % |

---

## 🔑 La plaque d'immatriculation

Partout où le programme demande une plaque (vente, ajout, reprise, modification de prix...) :
- la saisie est **nettoyée** : espaces retirés au début et à la fin, lettres mises en **majuscules** (`1-ght-482` = `1-GHT-482`) ;
- le **format** est vérifié : **1 chiffre** (de 1 à 9), un **tiret**, **3 lettres**, un **tiret**, **3 chiffres** (9 caractères au total).
  Exemples refusés : `1GHT482`, `1-GH-482`, `0-GHT-482`, `A-GHT-482`.
  💡 Une chaîne se lit caractère par caractère comme un tableau ; regarde `char.IsLetter` et `char.IsDigit`.
- Pour **ajouter** une voiture (ajout ou reprise), la plaque doit être **libre** :
  `Une voiture avec la plaque 1-GHT-482 est déjà enregistrée (Peugeot 208).` → le programme redemande.
- Pour **utiliser** une voiture existante (vente, modification), la plaque doit **exister** : `Aucune voiture avec la plaque 9-ZZZ-999.`

⚠️ Une voiture **vendue** reste enregistrée (avec un indicateur « vendue ») : sa plaque reste donc **prise**.

---

## 📋 Fonctionnalités demandées

Le programme affiche un **menu** qui revient après chaque action, jusqu'à ce que l'utilisateur choisisse de quitter.

### 1. Afficher le stock
- Affiche toutes les voitures **pas encore vendues**, une par ligne, en colonnes alignées (plaque, marque, modèle, année, kilométrage, carburant, prix de vente).
- Une voiture qui a **plus de 150 000 km** affiche en plus l'étiquette `[KM ÉLEVÉ]`.
- Une voiture qui vient d'une **reprise** (voir la vente) affiche l'étiquette `[REPRISE]`.
- En bas : le nombre de voitures en stock.
- **Jalon 5 :** avant d'afficher, l'utilisateur choisit l'ordre (voir *Tri du stock*).

### 2. Rechercher (multicritère)
L'utilisateur remplit **plusieurs critères** ; chacun peut être **laissé vide** pour l'ignorer :
- **marque** (texte vide = toutes les marques ; sans tenir compte des majuscules ; `peu` trouve les Peugeot) ;
- **carburant** (un choix « tous » en plus des carburants) ;
- **budget maximum** (0 = pas de limite) ;
- **kilométrage maximum** (0 = pas de limite) ;
- **année minimum** (0 = pas de limite).

Seules les voitures qui respectent **tous** les critères remplis sont affichées (voitures non vendues uniquement).
Si rien n'est trouvé, le programme le dit.

Une option **« Fiche d'une voiture »** affiche toutes les informations d'une voiture à partir de sa **plaque** (vendue ou non), **sans parcourir** toutes les voitures.

**Exemples :**

| Marque | Carburant | Budget max | Km max | Année min | Résultat |
|---|---|---|---|---|---|
| `peugeot` | tous | 0 | 0 | 0 | 208 et 3008 |
| *(vide)* | Diesel | 0 | 0 | 0 | Golf et Série 1 |
| *(vide)* | tous | 16 000 | 100 000 | 0 | 208 et Clio |
| *(vide)* | tous | 0 | 0 | 2021 | Clio, Yaris, Model 3 |
| `tesla` | Diesel | 0 | 0 | 0 | aucune voiture trouvée |

### 3. Ajouter une voiture
- Le vendeur saisit la **plaque** (format valide et **plaque libre**), marque, modèle, année, kilométrage, prix d'achat, prix de vente et carburant.
- Contrôles :
  - marque et modèle ne peuvent pas être vides ;
  - l'année est comprise entre 1990 et l'année actuelle ;
  - le kilométrage est positif ou nul ;
  - le prix d'achat est strictement positif ;
  - le prix de vente est **supérieur ou égal** au prix d'achat.

### 4. Modifier le prix d'une voiture
- Le vendeur tape la plaque (voiture existante et non vendue) et le nouveau prix de vente.
- Le nouveau prix ne peut pas être inférieur au prix d'achat.
- Affiche l'ancien et le nouveau prix, et la **variation en %** (1 chiffre après la virgule).
  Exemple : la Clio passe de 15 900 € à 14 900 € → `-6,3 %`.

### 5. Vendre une voiture

La vente suit **ces étapes, dans cet ordre**. Une règle non respectée affiche un message clair et **redemande** la valeur (sauf indication contraire).

1. **La voiture** : la plaque doit exister et la voiture ne doit pas être vendue (sinon, retour au menu).
2. **Le vendeur** : un numéro de vendeur valide.
3. **Le client** : un nom non vide.
4. **La remise négociée** : un pourcentage **entier** entre 0 et le **maximum du vendeur** (10 % pour un senior, 5 % pour un junior).
5. **La remise kilométrique** : si la voiture a **plus de 150 000 km**, une remise **automatique de 5 %** s'ajoute à la remise négociée.
   Les deux pourcentages s'additionnent et sont calculés sur le **prix affiché**.
   → on obtient le **prix après remises**.
6. **Pas de vente à perte** : le prix après remises ne peut **jamais** être inférieur au prix d'achat.
   Si c'est le cas, le programme l'explique et **redemande la remise négociée**.
   (Si même avec 0 % de remise négociée la vente est à perte, la vente est annulée.)
7. **L'extension de garantie** (facultative). La garantie de 12 mois est offerte. Le client peut acheter :
   - **+12 mois** pour **390 €** ;
   - **+24 mois** pour **690 €**.
   Impossible si la voiture a plus de 150 000 km : le programme ne propose même pas l'extension et affiche pourquoi.
8. **La reprise** (facultative) : le client fait reprendre son ancienne voiture.
   - Le montant de la reprise ne peut pas dépasser **30 % du prix affiché** (sinon : refus et le programme redemande).
   - Le vendeur saisit la **plaque** de la voiture reprise (format valide et **plaque libre** : on ne reprend pas une voiture déjà enregistrée au garage),
     puis **marque, modèle, année, kilométrage et carburant**.
   - Quand la vente est confirmée, la voiture reprise **entre dans le stock** avec :
     prix d'achat = montant de la reprise, prix de vente = montant de la reprise **× 1,30**, et l'étiquette `[REPRISE]`.
9. **Le prix final** = prix après remises + extension de garantie − reprise.
10. **Le paiement** : comptant ou à crédit (voir *Financement*, jalon 4 — avant ça, tout est payé comptant).
11. **Le récapitulatif** : le programme affiche le **détail complet du calcul**, la **marge** du garage et la **commission** du vendeur, puis demande une confirmation (`O`/`N`).

**La marge et la commission :**
- **Marge** = prix après remises − prix d'achat (la garantie et la reprise n'entrent pas dans la marge).
- **Commission du vendeur** = **10 % de la marge**.

**Une vente confirmée :**
- marque la voiture comme vendue (elle disparaît du stock, mais reste enregistrée) ;
- ajoute la voiture reprise au stock (s'il y en a une) ;
- est enregistrée dans l'**historique des ventes** avec un **numéro de vente** (1, 2, 3...), la **plaque** de la voiture vendue, le vendeur, le client,
  le prix affiché, le prix après remises, l'extension de garantie, la **plaque** de la voiture reprise (vide s'il n'y en a pas), le montant de la reprise, le prix final, la marge, la commission et le mode de paiement.

**Exemples pour vérifier ton calcul :**

| | Voiture | Vendeur | Remise négociée | Remise km | Après remises | Garantie | Reprise | **Prix final** | Marge | Commission |
|---|---|---|---|---|---|---|---|---|---|---|
| A | Peugeot 208 (1-GHT-482) | Julie | 5 % → 625,00 | — | 11 875,00 | +12 mois : 390,00 | 2 000,00 | **10 265,00 €** | 1 675,00 | 167,50 |
| B | Volkswagen Golf (1-DFR-907) | Karim | 0 % | 5 % → 495,00 | 9 405,00 | impossible (km) | — | **9 405,00 €** | 1 605,00 | 160,50 |
| C | Dacia Sandero (1-CVN-624) | Karim | 10 % → **refusé** (junior : max 5 %), puis 5 % → 295,00 | 5 % → 295,00 | 5 310,00 | impossible (km) | 2 000,00 → **refusée** (max 1 770,00) | **5 310,00 €** (sans reprise) | 10,00 | 1,00 |
| D | Dacia Sandero (1-CVN-624) | Marc | 10 % → 590,00 | 5 % → 295,00 | 5 015,00 → **vente à perte refusée** (achat : 5 300,00) | | | | | |

Pour la vente A, la voiture reprise est une Renault Twingo de 2012 (140 000 km, essence), plaque `1-AAZ-519` : elle entre dans le stock au prix de vente de 2 600 €.
Si le vendeur tape la plaque `2-KLM-115` pour la reprise → refusée (c'est la Clio du garage).

### 6. Historique des ventes
- Affiche toutes les ventes (numéro, voiture, vendeur, client, prix final, mode de paiement).
- Une vente annulée reste visible avec la mention `ANNULÉE`.
- Si aucune vente : `Aucune vente pour le moment.`

### 7. Annuler une vente (jalon 4)
Le vendeur tape un numéro de vente.
- La vente doit exister et ne pas être déjà annulée.
- La voiture vendue **revient dans le stock**.
- S'il y avait une reprise, la voiture reprise **est supprimée** du garage (sa plaque redevient libre)... sauf si elle a **déjà été revendue** : dans ce cas l'annulation est **refusée**.
- La vente reste dans l'historique, marquée `ANNULÉE`, et ne compte plus dans les statistiques.

### 8. Statistiques
- **Stock** : nombre de voitures, valeur totale (prix de vente), valeur d'achat, **marge potentielle** (différence des deux), kilométrage moyen, voiture la plus chère, voiture la plus ancienne, **nombre de voitures par carburant**.
- **Ventes** (sans les ventes annulées) : nombre de ventes, **chiffre d'affaires** (somme des prix après remises + garanties), **marge totale**, **marge moyenne** par vente, nombre d'extensions de garantie vendues, nombre de ventes à crédit.
- **Par vendeur** : nombre de ventes, chiffre d'affaires et total des commissions, puis le **meilleur vendeur** (celui qui a la plus grosse commission).
- **Par marque** : nombre de voitures vendues.

### 0. Quitter
Demande une confirmation, puis affiche le **bilan de la journée** : nombre de ventes, chiffre d'affaires, marge totale et meilleur vendeur.

---

## 💳 Financement à crédit (jalon 4)

Si le client choisit le crédit :
1. Il donne un **apport** (entre 0 et le prix final).
2. **Montant emprunté** = prix final − apport. S'il vaut 0, ce n'est pas un crédit : la vente est payée comptant.
3. Il choisit une **durée** parmi : **12, 24, 36, 48 ou 60 mois** (toute autre durée est refusée).
4. Le **taux annuel** dépend de la durée :

| Durée | Taux annuel |
|---|---|
| 12 ou 24 mois | 3 % |
| 36 ou 48 mois | 4 % |
| 60 mois | 5 % |

5. **Intérêts** (calcul simplifié) = montant emprunté × taux annuel × nombre d'années.
6. **Total remboursé** = montant emprunté + intérêts.
7. **Mensualité** = total remboursé ÷ nombre de mois, **arrondie à 2 chiffres** après la virgule (`Math.Round`).

**Exemples :**

| Vente | Prix final | Apport | Emprunté | Durée | Taux | Intérêts | Total remboursé | **Mensualité** |
|---|---|---|---|---|---|---|---|---|
| B (Golf) | 9 405,00 | 1 405,00 | 8 000,00 | 36 mois | 4 % | 960,00 | 8 960,00 | **248,89 €** |
| E : Tesla Model 3, Marc, 0 %, +24 mois de garantie, sans reprise | 39 590,00 | 9 590,00 | 30 000,00 | 60 mois | 5 % | 7 500,00 | 37 500,00 | **625,00 €** |

(Pour la vente E : marge 4 400,00 €, commission de Marc 440,00 €.)

---

## 🔀 Tri du stock (jalon 5)

Avant d'afficher le stock, l'utilisateur choisit l'ordre :
```
1. Par plaque (ordre d'enregistrement)
2. Par prix, du moins cher au plus cher
3. Par prix, du plus cher au moins cher
4. Par kilométrage, du plus petit au plus grand
5. Par année, de la plus récente à la plus ancienne
```
- Un dictionnaire ne se trie pas : copie d'abord les voitures en stock dans une **`List<T>`**, puis trie cette liste.
- Tu **n'as pas le droit** d'utiliser une méthode de tri toute faite : écris le tri **toi-même avec des boucles**.
  💡 Le principe du **tri par sélection** : on cherche le plus petit élément et on le met en 1re position, puis on cherche le plus petit parmi ceux qui restent et on le met en 2e position, et ainsi de suite.
- Essaie de n'écrire **qu'un seul** algorithme de tri pour les 4 ordres (une méthode qui sait comparer deux voitures selon le critère choisi).

---

## 🖥️ Exemples d'affichage (à titre indicatif)

Les nombres sont affichés au format belge (`N2` et `N0` : le point sépare les milliers).

(après la vente A : la 208 est vendue, la Twingo reprise est entrée dans le stock)
```
===== AUTOPRESTIGE — STOCK =====
Plaque      Marque       Modèle      Année        Km  Carburant           Prix
2-KLM-115   Renault      Clio         2021    32.000  Essence      15.900,00 €
1-DFR-907   Volkswagen   Golf         2016   160.000  Diesel        9.900,00 € [KM ÉLEVÉ]
...
1-AAZ-519   Renault      Twingo       2012   140.000  Essence       2.600,00 € [REPRISE]
8 voiture(s) en stock
```

```
===== VENTE — Peugeot 208 (2019) — 1-GHT-482 =====
Vendeur : Julie (Senior) — Client : Mme Dupont

Prix affiché                     12.500,00 €
Remise négociée 5 %                -625,00 €
-------------------------------------------
Prix après remises               11.875,00 €
Extension de garantie +12 mois      390,00 €
Reprise (Renault Twingo 2012)    -2.000,00 €
-------------------------------------------
PRIX FINAL                       10.265,00 €
Paiement : comptant

[Interne] Marge : 1.675,00 € — Commission de Julie : 167,50 €

Confirmer la vente ? (O/N) : O
Vente n° 1 enregistrée !
La Renault Twingo (1-AAZ-519) entre dans le stock au prix de 2.600,00 €.
```

```
Plaque de la voiture reprise : 2-klm-115
Une voiture avec la plaque 2-KLM-115 est déjà enregistrée (Renault Clio).
Plaque de la voiture reprise :
```

```
Remise négociée (0 à 10 %) : 10
Vente à perte interdite : avec ces remises, le prix tombe à 5.015,00 €
alors que le garage a payé cette voiture 5.300,00 €. Choisis une remise plus petite.
Remise négociée (0 à 10 %) :
```

---

## 🔧 Contraintes techniques

- Au moins **deux `enum`** (le carburant, le niveau du vendeur, le mode de paiement...).
  Ce sont des `enum` **classiques**, comme au cours : une variable de ce type contient **une seule valeur à la fois**.
- Au moins **trois `struct`** : une voiture, un vendeur, une vente.
- **Les voitures sont rangées dans un `Dictionary<string, Voiture>`** dont la **clé est la plaque**.
  On retrouve une voiture **par sa clé**, jamais en parcourant tout le dictionnaire.
  Avant chaque ajout, on vérifie que la clé est libre : le programme ne doit **jamais planter** sur une plaque en double.
- **Les vendeurs et les ventes sont rangés dans des `List<T>`** (on les parcourt dans l'ordre ; le numéro de vente se déduit de la liste).
- Au moins **deux autres `Dictionary<TKey, TValue>`** (par exemple pour les statistiques par carburant, par vendeur, par marque).
- **Chaque option du menu est une méthode.** Le code principal ne contient presque que la boucle du menu.
- Les **calculs** (remises, marge, commission, intérêts, mensualité) sont dans des **méthodes qui retournent une valeur** et qui **n'affichent rien** : tu dois pouvoir les tester avec les exemples du tableau.
- La vérification du format d'une plaque est une méthode qui retourne un `bool`.
- Les saisies répétées (un entier dans des limites, un decimal, un texte non vide, une plaque, un choix d'enum, une réponse `O`/`N`...) passent par **des méthodes réutilisables**.
- **Aucune saisie ne doit faire planter le programme** (lettres à la place d'un nombre, plaque inconnue ou en double, etc.).
- Les prix sont des `decimal`, affichés avec 2 chiffres après la virgule.
- Attention : une `struct` est un type valeur. Pour modifier une voiture dans le dictionnaire ou une vente dans la liste, pense à ce que tu as vu dans la démo.

---

## ✅ Critères de réussite

**Minimum attendu (jalons 1 à 3)**
- [ ] Le menu fonctionne et revient après chaque action.
- [ ] Le stock s'affiche en colonnes, avec les étiquettes `[KM ÉLEVÉ]` et `[REPRISE]`.
- [ ] Les 5 exemples de recherche donnent les bons résultats ; la fiche d'une voiture se trouve par sa plaque.
- [ ] Une plaque mal formée ou déjà utilisée est **toujours** refusée (ajout et reprise) ; `1-ght-482` est reconnue comme `1-GHT-482`.
- [ ] Un ajout ou une modification de prix refuse les valeurs invalides.
- [ ] Les ventes A, B, C et D donnent les bons résultats (y compris les refus).
- [ ] Une voiture vendue disparaît du stock ; une voiture reprise y apparaît.
- [ ] L'historique est juste.

**Labo complet (jalons 4 et 5)**
- [ ] Les deux exemples de crédit donnent les bonnes mensualités.
- [ ] L'annulation remet la voiture en stock, supprime la reprise, et refuse si la reprise a déjà été revendue.
- [ ] Les 5 ordres de tri fonctionnent, sans méthode de tri toute faite.
- [ ] Les statistiques sont justes (teste avec au moins 4 ventes dont une annulée).
- [ ] Aucune saisie ne fait planter le programme.
- [ ] Le code est découpé en méthodes avec des noms clairs.

---

## 🚀 Pour aller plus loin (2e journée)

1. **Neuve ou occasion.** Ajoute une `enum` `Etat` (`Neuve`, `Occasion`). Une voiture neuve a 0 km, ne peut pas recevoir de remise négociée, et la garantie offerte est de 24 mois.
2. **Les clients.** Range les clients dans un `Dictionary<string, Client>` dont la clé est le **numéro de registre national** (unique, 11 chiffres). Un client qui revient est reconnu : affiche ses achats précédents et offre 2 % de remise à partir de sa 2e voiture.
3. **La cote de reprise.** Au lieu de laisser le vendeur inventer le montant de la reprise, le programme le **propose** :
   on part d'une valeur de base selon le carburant, on retire 8 % par année d'âge et 1 % par tranche de 10 000 km (jamais moins de 300 €). Le vendeur peut seulement **baisser** cette proposition.
4. **Les objectifs des vendeurs.** Chaque vendeur a un objectif de chiffre d'affaires. Dans les statistiques, affiche une barre de progression en texte (`[██████░░░░] 60 %`).
5. **Les rendez-vous d'essai.** Un client réserve un essai pour une voiture à une heure donnée (de 9 h à 18 h). Deux essais de la même voiture ne peuvent pas avoir lieu à la même heure.
6. **Le vrai calcul de crédit.** Remplace le calcul simplifié par la formule des mensualités constantes (cherche « formule mensualité crédit »). 💡 `Math.Pow` travaille avec des `double` : attention aux conversions.
