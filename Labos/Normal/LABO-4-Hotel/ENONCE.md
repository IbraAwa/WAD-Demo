# LABO 4 — L'hôtel

**Niveau :** Normal (pas d'étapes : c'est toi qui organises ton code)
**Durée estimée :** 1 journée (≈ 8 h) — + une 2e journée possible avec « Pour aller plus loin »

## 📖 L'histoire

L'**Hôtel des Ardennes** est un petit hôtel de 3 étages. La réceptionniste veut un programme console pour savoir
en un coup d'œil quelles chambres sont libres, occupées ou à nettoyer, **enregistrer l'arrivée** des clients (check-in),
noter leurs **consommations** (minibar, restaurant, spa...), **faire la facture** à leur départ (check-out),
organiser le **ménage** et la **maintenance**, reconnaître les **clients fidèles** et suivre l'activité de l'hôtel.

Le programme **simule le temps** : on ne va pas attendre de vrais jours, on fait avancer un compteur de jours.

À toi de concevoir le programme : quelles `enum`, quelles `struct`, quelles collections, quelles méthodes.
L'énoncé te dit **quoi** faire, pas **comment** le faire.

---

## 🗺️ Plan de route conseillé

Le labo est gros : avance **par jalons**, et ne commence un jalon que quand le précédent fonctionne.

| Jalon | Contenu | Temps indicatif |
|---|---|---|
| 1 | Les types, la création des chambres par boucles, le calendrier, le plan de l'hôtel, les méthodes de saisie, le menu | 1 h 30 |
| 2 | Le check-in, les clients présents, faire passer les jours | 1 h 45 |
| 3 | Le check-out et la facture complète (semaine / week-end, adultes / enfants, remises), l'historique | 2 h 15 |
| 4 | Les consommations, le ménage, la maintenance | 1 h 15 |
| 5 | Les clients fidèles, les statistiques, quitter | 1 h 15 |

👉 **Les jalons 1 à 3 sont le minimum attendu.** Le labo est **complet** quand les 5 jalons sont faits.

---

## 🏨 Les chambres

L'hôtel a **3 étages** de **4 chambres**, soit 12 chambres. Une chambre est numérotée **étage × 100 + position** :
101, 102, 103, 104, 201, ..., 304.

Le type d'une chambre dépend de sa **position** dans l'étage (c'est pareil à chaque étage) :

| Position | Type | Prix par nuit (semaine) | Prix par nuit (week-end) | Personnes max |
|---|---|---|---|---|
| 1 et 2 | Simple | 65,00 € | 78,00 € | 1 |
| 3 | Double | 95,00 € | 114,00 € | 2 |
| 4 | Suite | 160,00 € | 192,00 € | 4 |

⚠️ Les 12 chambres doivent être **créées par des boucles imbriquées** au lancement du programme, pas écrites une par une.

Une chambre est toujours dans **un** de ces états :

| État | Signification |
|---|---|
| Libre | propre et disponible |
| Occupée | un client y séjourne |
| À nettoyer | le client vient de partir ; on ne peut pas y mettre de client avant le ménage |
| Hors service | en maintenance ; elle ne compte plus dans les chambres disponibles |

Au lancement, toutes les chambres sont libres.

---

## 📅 Le calendrier

- Le programme commence au **jour 1**, qui est un **lundi**. Le jour 7 est un dimanche, le jour 8 un lundi, etc.
- Le menu affiche toujours le jour actuel : `Jour 5 (vendredi)`.
- Le nom du jour est donné par **une méthode** (💡 le modulo 7 et un `switch`).
- La **nuit du jour J** est la nuit entre le jour J et le jour J + 1.
  Les nuits du **vendredi** et du **samedi** sont des nuits de **week-end** : leur prix est **augmenté de 20 %**.

---

## 📋 Fonctionnalités demandées

Le programme affiche un **menu** qui revient après chaque action, jusqu'à ce que l'utilisateur choisisse de quitter.

### 1. Plan de l'hôtel
Affiche l'hôtel étage par étage (du 3e au 1er, comme un vrai immeuble), avec pour chaque chambre son numéro, son type et son état :
```
===== HÔTEL DES ARDENNES — Jour 5 (vendredi) =====
Étage 3 : [301 Simple  libre ] [302 Simple  libre ] [303 Double  OCCUPÉ] [304 Suite   MÉNAGE]
Étage 2 : [201 Simple  libre ] [202 Simple  H.S.  ] [203 Double  libre ] [204 Suite   libre ]
Étage 1 : [101 Simple  OCCUPÉ] [102 Simple  libre ] [103 Double  libre ] [104 Suite   OCCUPÉ]
Libres : 7 / 11 en service — à nettoyer : 1 — hors service : 1
```

### 2. Arrivée d'un client (check-in)
1. La réceptionniste saisit le **nom du client**, le **type de chambre** voulu, le **nombre d'adultes** (au moins 1), le **nombre d'enfants** (0 ou plus),
   le **nombre de nuits prévues** (de 1 à 30) et si le client veut le **petit-déjeuner** (`O`/`N`).
2. Adultes + enfants ne peuvent pas dépasser la capacité du type de chambre.
3. Le programme attribue **la première chambre libre** de ce type (le plus petit numéro). Une chambre à nettoyer ou hors service n'est **pas** libre.
   S'il n'y en a plus : `Désolé, plus aucune Suite n'est libre.` — et s'il en reste à nettoyer : `(1 Suite attend le ménage.)`
4. Le séjour retient le **jour d'arrivée**.
5. Le programme affiche le numéro de la chambre, le **jour de départ prévu** et une **estimation** du prix du séjour (sans les consommations, qu'on ne connaît pas encore).
6. **Jalon 5 :** si le client est un **client fidèle**, le programme le salue et annonce sa remise (voir *Clients fidèles*).

### 3. Départ d'un client (check-out)
1. La réceptionniste saisit le **numéro de la chambre**.
2. Erreur si la chambre n'existe pas ou si elle n'est pas occupée.
3. Le **nombre de nuits facturées** = jour actuel − jour d'arrivée (au minimum 1, même si le client part le jour de son arrivée).
   Ce nombre peut être différent du nombre de nuits prévues : c'est la réalité qui compte.
4. Le programme affiche la **facture détaillée**, la chambre passe à l'état **à nettoyer**, et la facture est enregistrée dans l'**historique**.

### 4. Clients présents
Affiche les chambres occupées avec : le nom du client, adultes / enfants, le jour d'arrivée, le jour de départ prévu,
le total des consommations, et `⚠ DÉPART DÉPASSÉ` si le jour de départ prévu est passé.
Si l'hôtel est vide : `Aucun client pour le moment.`

### 5. Ajouter une consommation (jalon 4)
Pendant son séjour, un client peut consommer des services. La réceptionniste saisit le numéro de la chambre (qui doit être occupée), le service et la quantité (1 à 20).

| Service | Prix unitaire |
|---|---|
| Minibar | 4,50 € |
| Restaurant (un repas) | 24,00 € |
| Spa (une entrée) | 35,00 € |
| Parking (une journée) | 15,00 € |

Les consommations apparaissent sur la facture, une ligne par consommation.

### 6. Ménage (jalon 4)
- Affiche les chambres **à nettoyer**.
- La réceptionniste choisit une chambre à marquer comme propre (elle redevient **libre**), ou `0` pour **toutes** les nettoyer.
- S'il n'y a rien à nettoyer : `Tout est propre !`

### 7. Maintenance (jalon 4)
- Mettre une chambre **hors service** : seulement si elle est **libre**.
- Remettre une chambre **en service** : elle redevient libre.

### 8. Faire passer des jours
- La réceptionniste choisit le nombre de jours (1 à 14).
- Le jour avance, puis le programme affiche un **résumé du nouveau jour** :
  les **départs prévus aujourd'hui** (chambre et nom), les clients en **dépassement**, et le nombre de chambres **à nettoyer**.

### 9. Statistiques (jalon 5)
- **Taux d'occupation** actuel = chambres occupées ÷ chambres **en service**, en pourcentage avec 1 chiffre après la virgule (ex. `33,3 %`).
- Nombre de séjours terminés et **chiffre d'affaires** total, dont **hébergement** (nuitées − remises) et dont **consommations**.
- **Par type de chambre** : nombre de séjours terminés et chiffre d'affaires.
- La **plus grosse facture** (montant, chambre et nom du client).
- La **durée moyenne** d'un séjour (en nuits, 1 chiffre après la virgule).
- Le **meilleur client** : celui qui a dépensé le plus au total (tous séjours confondus).

### 0. Quitter
Si des clients sont encore présents, affiche combien et demande une confirmation avant de quitter.

---

## 🧾 Calcul de la facture

- **Nuitées** : on parcourt **chaque nuit** du séjour. Une nuit de semaine coûte le prix normal, une nuit de **vendredi ou samedi** coûte **+20 %**.
- **Remise long séjour** : à partir de **7 nuits**, **10 %** de remise **sur les nuitées uniquement**.
- **Remise fidélité** (jalon 5) : **5 %** de remise **sur les nuitées uniquement**. Elle s'**additionne** à la remise long séjour (donc 15 % si les deux s'appliquent).
- **Petit-déjeuner** (si choisi) : **12,00 €** par adulte et par nuit, **6,00 €** par enfant et par nuit.
- **Taxe de séjour** (toujours) : **2,50 €** par **adulte** et par nuit (les enfants ne paient pas de taxe).
- **Consommations** (jalon 4) : la somme de toutes les consommations de la chambre pendant le séjour.
- **Total** = nuitées − remises + petit-déjeuner + taxe de séjour + consommations.

**Exemples pour vérifier ton calcul :**

| | Séjour | Nuitées | Remises | Petit-déj. | Taxe | Conso. | **Total** |
|---|---|---|---|---|---|---|---|
| 1 | Simple, 1 adulte, arrivée jour 1, départ jour 3, sans petit-déj. | 2 × 65,00 = 130,00 | — | — | 5,00 | — | **135,00 €** |
| 2 | Suite, 2 adultes + 2 enfants, arrivée jour 5, départ jour 8, avec petit-déj. | 192,00 + 192,00 + 160,00 = 544,00 | — | 72,00 + 36,00 = 108,00 | 15,00 | — | **667,00 €** |
| 3 | Double, 2 adultes, arrivée jour 1, départ jour 8, avec petit-déj., 2 minibars + 2 repas | 5 × 95,00 + 2 × 114,00 = 703,00 | −70,30 (10 %) | 168,00 | 35,00 | 57,00 | **892,70 €** |
| 4 | Simple, 1 adulte, **client fidèle**, arrivée jour 8, départ jour 15, sans petit-déj. | 5 × 65,00 + 2 × 78,00 = 481,00 | −72,15 (15 %) | — | 17,50 | — | **426,35 €** |

```
===== FACTURE — Chambre 103 =====
Client : Lambert (2 adultes, 0 enfant)
Arrivée : jour 1 (lundi) — Départ : jour 8 (lundi) — 7 nuit(s)
Nuitées semaine  (5 x 95,00 €)          475,00 €
Nuitées week-end (2 x 114,00 €)         228,00 €
Remise long séjour 10 %                 -70,30 €
Petit-déjeuner                          168,00 €
Taxe de séjour                           35,00 €
Minibar (2 x 4,50 €)                      9,00 €
Restaurant (2 x 24,00 €)                 48,00 €
-----------------------------------------------
TOTAL                                   892,70 €
```

---

## ⭐ Clients fidèles (jalon 5)

- Le programme retient, pour chaque nom de client (sans tenir compte des majuscules), le **nombre de séjours terminés** et le **total dépensé**.
- Un client qui a **déjà terminé au moins 2 séjours** est un **client fidèle** : à partir de son **3e séjour**, il reçoit la **remise fidélité** de 5 %.
- Au check-in, le programme l'annonce : `Bon retour parmi nous, M. Lambert ! 3e séjour : 5 % de remise fidélité sur les nuitées.`

---

## 🔧 Contraintes techniques

- Au moins **trois `enum`** : le type de chambre, l'état d'une chambre, le service.
- Au moins **trois `struct`** (par exemple une chambre, un séjour, une consommation, une facture).
- Les chambres sont rangées dans une **collection vue au cours** (tableau ou `List<T>`), remplie par des **boucles imbriquées**.
- Au moins **deux `Dictionary<TKey, TValue>`**. Le numéro de chambre ferait une très bonne clé pour les séjours en cours...
- **Chaque option du menu est une méthode.** Le code principal ne contient presque que la boucle du menu.
- Le prix, le prix du week-end et la capacité d'un type de chambre, ainsi que le prix d'un service, sont donnés par **des méthodes** qui reçoivent l'`enum` (un `switch` est parfait).
- Au moins **une méthode utilise un paramètre `out`** (par exemple pour chercher une chambre libre et dire si on en a trouvé une).
- Les **calculs** de la facture sont dans des **méthodes qui retournent une valeur** et qui **n'affichent rien** : tu dois pouvoir les tester avec les 4 exemples.
- Les saisies répétées passent par **des méthodes réutilisables**. **Aucune saisie ne doit faire planter le programme.**
- Les montants sont des `decimal`, affichés avec 2 chiffres après la virgule.
- Attention : une `struct` est un type valeur. Pour changer l'état d'une chambre dans une collection, pense à ce que tu as vu dans la démo.

---

## ✅ Critères de réussite

**Minimum attendu (jalons 1 à 3)**
- [ ] Les 12 chambres sont créées par des boucles, avec les bons numéros, types et prix.
- [ ] Le plan de l'hôtel s'affiche étage par étage, du 3e au 1er, avec le jour et son nom.
- [ ] Le check-in respecte la capacité (adultes + enfants) et attribue la première chambre **libre** du bon type.
- [ ] Faire passer des jours affiche les départs prévus.
- [ ] Le check-out refuse une chambre inexistante ou non occupée.
- [ ] Les exemples 1, 2 et 3 (sans les consommations) donnent les bons totaux.
- [ ] Après un check-out, la chambre est à nettoyer et la facture est dans l'historique.

**Labo complet (jalons 4 et 5)**
- [ ] Les 4 exemples donnent les bons totaux, consommations comprises.
- [ ] Une chambre à nettoyer ou hors service n'est jamais attribuée.
- [ ] Le client fidèle est reconnu au check-in et sa remise est appliquée.
- [ ] Les statistiques sont justes (teste avec au moins 4 séjours terminés).
- [ ] Aucune saisie ne fait planter le programme.
- [ ] Le code est découpé en méthodes avec des noms clairs.

---

## 🚀 Pour aller plus loin (2e journée)

1. **Les réservations à l'avance.** Un client réserve un type de chambre pour un jour d'arrivée futur et un nombre de nuits.
   Une réservation n'est acceptée que s'il existe une chambre de ce type **libre pendant toute la période** (attention aux séjours en cours et aux autres réservations qui se **chevauchent**).
   Le jour venu, le check-in se fait à partir de la réservation. Un client qui ne vient pas (*no-show*) paie la première nuit.
2. **Changer de chambre** : un client présent passe dans une autre chambre libre (de même type ou d'un type supérieur). La facture tient compte des nuits passées dans chaque chambre.
3. **Prolonger un séjour** : ajouter des nuits prévues à un client présent (sans dépasser 30 au total).
4. **Haute saison** : demande au lancement si on est en haute saison. Si oui, tous les prix par nuit augmentent encore de 15 %.
5. **Choisir le type par son nom** : la réceptionniste tape `Suite` et tu convertis avec `Enum.TryParse`.
6. **Le plan en couleurs** : `Console.ForegroundColor` pour afficher les chambres libres en vert, occupées en rouge, à nettoyer en jaune.
