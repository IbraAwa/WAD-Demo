# LABO 1 — La caisse enregistreuse

**Niveau :** Facile (guidé étape par étape)
**Durée estimée :** 1 journée (≈ 8 h) — + une 2e journée possible avec « Pour aller plus loin »

## 📖 L'histoire

L'épicerie de quartier **« Le Petit Marché »** veut remplacer sa vieille caisse par un programme console.
Le matin, la caissière **ouvre la caisse**. Toute la journée, des clients passent : elle tape le **code** de chaque produit et la **quantité**,
le programme affiche le **ticket**, applique les **promotions** et les **remises**, encaisse en **espèces** ou par **carte** et rend la **monnaie**.
Le programme surveille aussi le **stock** des produits. Le soir, elle **ferme la caisse** et lit le **rapport de la journée**.

## 🧰 Ce que tu vas pratiquer

| Notion | Où ? |
|---|---|
| `enum` (classique) | la catégorie d'un produit, le mode de paiement |
| `struct` (et le piège de la copie !) | un produit, une vente |
| `Dictionary<TKey, TValue>` | **le catalogue** (code unique → produit), le panier, les quantités vendues, les totaux par catégorie |
| `List<T>` | les ventes de la journée, les produits à recommander |
| Tableau | les billets et les pièces pour rendre la monnaie |
| Méthodes (`static`, paramètres, `return`) | presque tout le programme |
| Boucles `for`, `foreach`, `while`, `do ... while` | catalogue, scan, menu, monnaie |
| `if` / `else if` / `else`, `switch` | remises, promotions, menu |
| `TryParse` | aucune saisie ne doit faire planter le programme |
| Division entière | la promotion « 3 pour 2 » |
| Interpolation, alignement et format `N2` | ticket et rapport |

## 📏 Règles du jeu

- Fais les étapes **dans l'ordre**. Chaque étape se termine par **« ✅ Vérifie »** : lance le programme (F5) et compare.
- Les **méthodes** s'écrivent **tout en bas de `Program.cs`**, après ton code principal, avec le mot-clé `static` (comme dans le support de cours).
- Les prix sont des `decimal` et s'affichent avec **2 chiffres après la virgule** (format `N2`) suivis de ` €`.
- Le labo est découpé en **5 parties**. Ne passe à la partie suivante que si la précédente fonctionne parfaitement.
- Quand les 5 parties sont terminées, **le labo est fini** 🎉. « Pour aller plus loin » est pour ceux qui ont une 2e journée.

| Partie | Contenu | Temps indicatif |
|---|---|---|
| 1 | Un client passe en caisse | 3 h |
| 2 | Une journée entière : le menu et les ventes | 1 h |
| 3 | Le stock et les nouveaux produits | 1 h 30 |
| 4 | Promotions et paiement | 1 h 30 |
| 5 | Le rapport de la journée | 1 h |

---

# PARTIE 1 — Un client passe en caisse

## Étape 1 — L'énumération `Categorie`

🎯 Un produit appartient toujours à une catégorie parmi une liste fixe : c'est le rôle d'une `enum`.

1. Clic droit sur le projet > **Ajouter** > **Nouvel élément...** > **Classe**, nomme le fichier `Categorie.cs`.
2. Remplace le mot `class` par `enum` et retire tout ce qui ne sert pas.
3. Déclare les 4 valeurs : `Fruit`, `Legume`, `Boisson`, `Snack`.

💡 Visual Studio a peut-être mis un `namespace` en haut du fichier. Si c'est le cas, ajoute en haut de `Program.cs` un `using` vers ce namespace (comme `using DEMO;` dans la démo sur les struct).

✅ **Vérifie :** le programme compile toujours (F5) et affiche le titre.

---

## Étape 2 — La structure `Produit`

🎯 Un produit regroupe plusieurs informations : c'est le rôle d'une `struct`.

1. Ajoute un fichier `Produit.cs` et transforme la classe en `struct`.
2. Déclare 4 champs **publics** :

| Champ | Type | Exemple |
|---|---|---|
| `Code` | `int` | 1 |
| `Nom` | `string` | Pomme |
| `Prix` | `decimal` | 0,50 |
| `Categorie` | `Categorie` (ton enum) | Fruit |

✅ **Vérifie :** le programme compile.

---

## Étape 3 — Le catalogue : un dictionnaire

🎯 Chaque produit a un **code unique** : deux produits ne peuvent jamais avoir le même code. C'est exactement ce que fait un **dictionnaire** : chaque **clé** y est unique.

1. Dans `Program.cs`, sous la ligne « écris ton code en dessous », crée un `Dictionary<int, Produit>` nommé `catalogue` :
   - la **clé** = le code du produit ;
   - la **valeur** = le produit lui-même.
2. Ajoute-y ces 8 produits avec `Add` (crée chaque produit avec `new()` et des accolades, comme dans la démo sur les struct).
   La clé doit toujours être **égale** au champ `Code` du produit.

| Code | Nom | Prix | Catégorie |
|---|---|---|---|
| 1 | Pomme | 0,50 | Fruit |
| 2 | Banane | 0,35 | Fruit |
| 3 | Carotte | 0,20 | Legume |
| 4 | Tomate | 0,80 | Legume |
| 5 | Eau 1,5 L | 0,90 | Boisson |
| 6 | Jus d'orange | 2,40 | Boisson |
| 7 | Chips | 1,95 | Snack |
| 8 | Chocolat | 2,20 | Snack |

💡 Attention au suffixe des nombres `decimal`.

3. 🧪 **Expérience :** ajoute temporairement un 9e produit **avec la clé 1** (déjà utilisée) et lance le programme. Il **plante** : `Add` refuse une clé qui existe déjà.
   Note le nom de l'erreur, puis **supprime** cette ligne. Retiens : avant d'ajouter une clé qui vient de l'utilisateur, on vérifie **toujours** qu'elle n'existe pas déjà.

✅ **Vérifie :** affiche le nombre de produits du catalogue → `Le catalogue contient 8 produits`. Ensuite, supprime cette ligne de test.

---

## Étape 4 — Méthode `AfficherCatalogue`

🎯 Ta première méthode : elle affiche le catalogue.

1. Tout en bas de `Program.cs`, crée une méthode `static` qui **ne retourne rien** (`void`), nommée `AfficherCatalogue`, qui reçoit **le dictionnaire des produits** en paramètre.
2. Dedans, affiche un titre, puis parcours le dictionnaire avec un `foreach` et affiche chaque produit sur une ligne.
   💡 Chaque élément parcouru a une `.Key` (le code) et une `.Value` (le produit).
3. Pour que les colonnes soient bien alignées, aligne le nom sur 15 caractères (l'alignement `,-15` vu avec l'interpolation).
4. Appelle cette méthode dans ton code principal.

✅ **Vérifie :**
```
===== CATALOGUE =====
[1] Pomme           0,50 €  (Fruit)
[2] Banane          0,35 €  (Fruit)
[3] Carotte         0,20 €  (Legume)
...
[8] Chocolat        2,20 €  (Snack)
```

---

## Étape 5 — Méthode `DemanderEntier`

🎯 On va souvent demander un nombre entier au caissier. Au lieu de répéter le même code, on écrit une méthode.

1. Crée une méthode `static` nommée `DemanderEntier` qui reçoit **la question** (un `string`) et **retourne un `int`**.
2. Elle affiche la question, lit la saisie et essaie de la convertir avec `int.TryParse`.
3. Tant que la conversion rate, elle affiche `Ce n'est pas un nombre valide, recommence :` et redemande (boucle `while`).
4. Quand c'est bon, elle **retourne** le nombre.

✅ **Vérifie :** appelle-la provisoirement avec la question `Tape un nombre :`, tape `abc` puis `12`, et affiche le résultat.
```
Tape un nombre : abc
Ce n'est pas un nombre valide, recommence : 12
Tu as tapé 12
```
Supprime ensuite ce test.

---

## Étape 6 — Retrouver un produit grâce à son code

🎯 Avec un dictionnaire, pas besoin de parcourir tout le catalogue pour trouver un produit : on le demande directement **par sa clé**.

1. Teste provisoirement, dans le code principal :
   - afficher le nom du produit dont la clé est 6 (avec les crochets, comme pour un tableau) → `Jus d'orange` ;
   - afficher si la clé 42 existe (`ContainsKey`) → `False` ;
   - afficher le nom du produit dont la clé est 42 → le programme **plante** (clé introuvable).
2. Conclusion à retenir : **on vérifie toujours avec `ContainsKey` avant de lire une clé tapée par l'utilisateur.**
3. Supprime ces tests.

✅ **Vérifie :** tu as vu les 3 résultats ci-dessus, et tu sais expliquer pourquoi le 3e plante.

---

## Étape 7 — Le panier

🎯 Pendant le passage en caisse, on retient **quel produit** et **combien**. Un dictionnaire est encore parfait pour ça.

1. Dans le code principal (après l'affichage du catalogue), crée un `Dictionary<int, int>` nommé `panier`.
   - la **clé** = le code du produit
   - la **valeur** = la quantité achetée

✅ **Vérifie :** le programme compile.

---

## Étape 8 — Scanner les produits

🎯 Le caissier tape les codes un par un. Le code **0** veut dire « fini ».

1. Écris une boucle `do ... while` qui continue **tant que le code tapé n'est pas 0**.
2. À chaque tour :
   1. demande le code avec `DemanderEntier` : `Code du produit (0 pour terminer) :`
   2. si le code vaut 0 → ne fais rien de plus (la boucle va s'arrêter) ;
   3. sinon, si le code n'est **pas une clé** du catalogue → affiche `Code inconnu !` ;
   4. sinon, demande la quantité avec `DemanderEntier`. Si la quantité est **inférieure ou égale à 0** → affiche `Quantité invalide !` ;
   5. sinon :
      - si le code est **déjà** dans le panier (`ContainsKey`) → **ajoute** la quantité à celle qui y est déjà ;
      - sinon → **crée** la clé avec cette quantité ;
      - affiche `+ 3 x Pomme` (quantité et nom du produit).

✅ **Vérifie :**
```
Code du produit (0 pour terminer) : 1
Quantité : 3
+ 3 x Pomme
Code du produit (0 pour terminer) : 42
Code inconnu !
Code du produit (0 pour terminer) : 7
Quantité : 2
+ 2 x Chips
Code du produit (0 pour terminer) : 6
Quantité : 1
+ 1 x Jus d'orange
Code du produit (0 pour terminer) : 1
Quantité : 2
+ 2 x Pomme
Code du produit (0 pour terminer) : 0
```
(Le panier contient maintenant 5 pommes, et pas deux lignes « Pomme ».)

---

## Étape 9 — Méthode `AfficherTicket`

🎯 Afficher le ticket et calculer le total.

1. Crée une méthode `static` nommée `AfficherTicket` qui reçoit **le catalogue** et **le panier**, et **retourne le total** (`decimal`).
2. Déclare une variable `total` qui commence à 0.
3. Parcours le panier avec un `foreach` (chaque élément a une `.Key` et une `.Value`).
4. Pour chaque ligne : retrouve le produit dans le catalogue **grâce au code**, calcule le prix de la ligne (quantité × prix), ajoute-le au total, et affiche la ligne.
5. Affiche le total, puis **retourne-le**.
6. Dans le code principal, après la boucle de scan, appelle la méthode et range le résultat dans une variable `total`.

✅ **Vérifie** (3 pommes, 2 chips, 1 jus d'orange) :
```
===== TICKET =====
3 x Pomme          =    1,50 €
2 x Chips          =    3,90 €
1 x Jus d'orange   =    2,40 €
------------------------------
TOTAL              =    7,80 €
```

💡 Si le panier est vide, affiche `Panier vide, au revoir !` et arrête le programme (avec `return` dans le code principal).

---

## Étape 10 — La remise

🎯 Le magasin récompense les gros paniers.

| Total | Remise |
|---|---|
| moins de 20 € | aucune |
| de 20 € à moins de 50 € | 5 % |
| 50 € et plus | 10 % |

1. Crée une méthode `static` nommée `CalculerRemise` qui reçoit le total et **retourne le montant de la remise** (`decimal`).
2. Utilise `if` / `else if` / `else`.
3. Dans le code principal : s'il y a une remise, affiche-la puis affiche le **total à payer** (total − remise).

✅ **Vérifie** (avec 10 chocolats → 22,00 €) :
```
TOTAL              =   22,00 €
Remise 5 %         =   -1,10 €
À PAYER            =   20,90 €
```

---

## Étape 11 — Le paiement en espèces

🎯 Le client donne de l'argent, la caisse calcule la monnaie.

1. Crée une méthode `static` nommée `DemanderMontant` qui fonctionne comme `DemanderEntier`, mais avec `decimal.TryParse` et qui retourne un `decimal`.
2. Demande le montant donné par le client : `Montant donné par le client :`.
3. **Tant que** le montant est inférieur au montant à payer, affiche `Montant insuffisant, il manque X €` et redemande.
4. Affiche la monnaie à rendre, puis `Merci et à bientôt au Petit Marché !`.

✅ **Vérifie :**
```
Montant donné par le client : 5
Montant insuffisant, il manque 2,80 €
Montant donné par le client : 10
Monnaie à rendre : 2,20 €
Merci et à bientôt au Petit Marché !
```

🏁 **Fin de la partie 1.** Un client peut passer en caisse. Mais la caisse s'arrête après lui... ce n'est pas très pratique pour une journée de travail !

---

# PARTIE 2 — Une journée entière : le menu et les ventes

## Étape 12 — Méthode `DemanderEntierEntre`

🎯 Pour un menu, il faut un nombre **valide** et **dans les limites**.

1. Crée une méthode `static` nommée `DemanderEntierEntre` qui reçoit **la question**, **le minimum** et **le maximum**, et retourne un `int`.
2. Elle **réutilise** `DemanderEntier` (ne recopie pas le `TryParse` !) et redemande **tant que** le nombre est en dehors des limites.
   Message d'erreur : `Tape un nombre entre 0 et 5 :` (avec le vrai minimum et le vrai maximum).

✅ **Vérifie :** avec min = 0 et max = 5, tape `abc`, puis `9`, puis `3` → la méthode retourne 3.

---

## Étape 13 — La structure `Vente` et la liste des ventes

🎯 Chaque passage en caisse produit une **vente**. On veut toutes les garder, **dans l'ordre**, pour le rapport du soir : c'est le rôle d'une **liste**.

1. Ajoute un fichier `Vente.cs` avec une `struct` `Vente` et ces champs publics :

| Champ | Type | Signification |
|---|---|---|
| `NumeroTicket` | `int` | 1 pour le premier client, 2 pour le suivant... |
| `NombreArticles` | `int` | la somme des quantités du panier |
| `Remise` | `decimal` | le montant de la remise accordée (0 s'il n'y en a pas) |
| `MontantPaye` | `decimal` | le total à payer après remise |

2. Dans le code principal, crée une `List<Vente>` nommée `ventes` (juste après le catalogue).

💡 Pourquoi une liste ici et pas un dictionnaire ? Les ventes n'ont pas besoin d'être retrouvées par une clé : on les ajoute **à la suite** et on les parcourt **dans l'ordre**. Le n° de ticket se déduit du nombre de ventes.

✅ **Vérifie :** le programme compile.

---

## Étape 14 — Méthode `PasserEnCaisse`

🎯 Tout le code des étapes 7 à 11 forme **un passage en caisse**. On le range dans une méthode pour pouvoir l'appeler autant de fois qu'on veut.

1. Crée une méthode `static` nommée `PasserEnCaisse` qui reçoit **le catalogue** et **le numéro du ticket**, et **retourne une `Vente`**.
2. **Déplace** dedans tout le code du panier, du scan, du ticket, de la remise et du paiement.
   Le panier doit être créé **dans** la méthode : chaque client commence avec un panier vide.
3. Au début du ticket, affiche `Ticket n° 3` (avec le vrai numéro).
4. À la fin, crée une `Vente`, remplis ses champs et **retourne-la**.
5. Si le panier est vide : affiche `Panier vide.` et retourne une vente dont le `MontantPaye` vaut 0.
   ⚠️ Le `return` ne quitte plus le programme : il quitte seulement la méthode.

✅ **Vérifie :** dans le code principal, appelle la méthode avec le numéro 1, puis affiche le montant payé de la vente reçue.

---

## Étape 15 — Le menu de la caisse

🎯 Le cœur du programme : un menu qui revient tant qu'on ne ferme pas la caisse.

1. Crée une méthode `static void AfficherMenu` qui affiche :
   ```
   ===== LE PETIT MARCHÉ =====
   1. Nouveau client
   2. Afficher le catalogue
   3. Réapprovisionner un produit
   4. Ajouter un produit au catalogue
   5. Rapport de la journée
   0. Fermer la caisse
   ```
2. Dans le code principal, écris une boucle `do ... while` qui tourne **tant que le choix n'est pas 0** :
   1. affiche le menu ;
   2. demande le choix avec `DemanderEntierEntre` (entre 0 et 5) ;
   3. un `switch` sur le choix :
      - `case 1` : appelle `PasserEnCaisse` avec le bon numéro de ticket (nombre de ventes déjà faites + 1). Si le montant payé est plus grand que 0, **ajoute la vente** à la liste `ventes` ;
      - `case 2` : affiche le catalogue ;
      - `case 3`, `4` et `5` : affiche `Pas encore fait...` ;
      - `case 0` : ne fait rien pour l'instant ;
   4. si le choix n'est pas 0, affiche `Appuie sur une touche pour revenir au menu...`, attends une touche puis efface la console.

✅ **Vérifie :** fais passer 2 clients à la suite. Le premier a le ticket n° 1, le second le ticket n° 2. Un client avec un panier vide ne consomme pas de numéro.

---

## Étape 16 — Fermer la caisse

1. Crée une méthode `static` nommée `CalculerRecette` qui reçoit la liste des ventes et **retourne** la somme des montants payés.
2. Quand on choisit 0, demande `Voulez-vous vraiment fermer la caisse ? (O/N) :`.
   - Si la réponse n'est pas `O` (ou `o`), le menu doit continuer (💡 change la valeur du choix pour que la boucle ne s'arrête pas).
   - Sinon, affiche :
     ```
     Caisse fermée. 2 client(s) aujourd'hui, recette : 28,70 €
     ```

✅ **Vérifie :** répondre `N` revient au menu ; répondre `O` affiche le bon nombre de clients et la bonne recette.

🏁 **Fin de la partie 2.** La caisse tient une journée entière.

---

# PARTIE 3 — Le stock et les nouveaux produits

## Étape 17 — Le stock de chaque produit

1. Ajoute un champ public `Stock` (`int`) à la structure `Produit`.
2. Complète les 8 produits du catalogue avec leur stock de départ :

| Code | Nom | Stock |
|---|---|---|
| 1 | Pomme | 50 |
| 2 | Banane | 40 |
| 3 | Carotte | 30 |
| 4 | Tomate | 25 |
| 5 | Eau 1,5 L | 24 |
| 6 | Jus d'orange | 4 |
| 7 | Chips | 15 |
| 8 | Chocolat | 12 |

3. Modifie `AfficherCatalogue` pour afficher le stock. Ajoute `⚠ stock bas` si le stock est **inférieur à 5**, et `RUPTURE` s'il vaut **0**.

✅ **Vérifie :**
```
===== CATALOGUE =====
[1] Pomme           0,50 €  (Fruit)    stock : 50
...
[6] Jus d'orange    2,40 €  (Boisson)  stock : 4   ⚠ stock bas
...
```

---

## Étape 18 — On ne vend pas ce qu'on n'a pas

🎯 Pendant le scan, la quantité demandée ne peut pas dépasser ce qui reste en rayon.

1. Dans le scan, avant d'ajouter au panier :
   - si le stock du produit vaut 0 → affiche `Jus d'orange est en rupture de stock !` ;
   - sinon, calcule **ce qui reste disponible** = stock − quantité **déjà dans le panier** pour ce produit (0 si le produit n'est pas encore dans le panier) ;
   - si la quantité demandée est plus grande que ce qui reste → affiche `Stock insuffisant : il reste seulement 2 Jus d'orange.` et n'ajoute rien.

✅ **Vérifie :** scanne 2 jus d'orange (accepté), puis encore 3 (refusé : il en reste 2), puis 2 (accepté).

---

## Étape 19 — Méthode `RetirerDuStock` ⚠️ le piège de la struct

🎯 Quand le client a **payé**, les produits quittent le magasin.

1. Crée une méthode `static void RetirerDuStock` qui reçoit **le catalogue** et **le panier**.
2. Pour chaque ligne du panier, diminue le stock du produit correspondant.
   **Attention :** si tu essaies de modifier directement le champ d'un produit **dans le dictionnaire**, Visual Studio refuse (erreur **CS1612**).
   Pourquoi ? Parce que `Produit` est une **struct** (type valeur) : lire une valeur du dictionnaire te donne une **COPIE**.
   👉 La bonne méthode, en 3 temps :
   1. copie le produit du dictionnaire dans une variable ;
   2. modifie la variable ;
   3. remets la variable dans le dictionnaire, **avec la même clé** (avec les crochets, pas avec `Add` !).
3. Appelle-la dans `PasserEnCaisse`, **après** le paiement.

💡 Pourquoi la modification se voit-elle en dehors de la méthode ? Parce que `Dictionary<TKey, TValue>` est un **type référence** : la méthode travaille sur le même dictionnaire que le code principal.

✅ **Vérifie :** vends 3 pommes, reviens au menu, affiche le catalogue → stock des pommes : 47. Le catalogue contient toujours 8 produits (pas de doublon).

---

## Étape 20 — Réapprovisionner (choix 3)

1. Crée une méthode `static void Reapprovisionner` qui reçoit le catalogue.
2. Elle demande le code du produit. Si ce code n'est pas une clé du catalogue → `Code inconnu !` et la méthode s'arrête.
3. Elle demande la quantité livrée (entre 1 et 500), l'ajoute au stock (attention au piège de la struct !) et affiche :
   `Jus d'orange : stock passé de 4 à 28.`
4. Appelle-la dans le `case 3`.

✅ **Vérifie :** réapprovisionne 24 jus d'orange, puis affiche le catalogue → plus de `⚠ stock bas` pour le jus.

---

## Étape 21 — Ajouter un produit au catalogue (choix 4) — un code unique !

🎯 Le magasin reçoit un nouveau produit. C'est **la caissière qui choisit son code**... et le programme doit **refuser un code déjà utilisé**.

1. Crée une méthode `static void AjouterProduit` qui reçoit le catalogue.
2. Elle demande le **code** (entre 1 et 999). **Tant que** ce code est déjà une clé du catalogue, elle affiche
   `Le code 3 est déjà utilisé par Carotte.` et redemande.
   ⚠️ Ne compte pas sur `Add` pour faire le contrôle : il ferait **planter** le programme (étape 3).
3. Elle demande le **nom**. On redemande tant que :
   - le nom est vide (ou ne contient que des espaces) 💡 `string.IsNullOrWhiteSpace` ;
   - **ou** un produit porte déjà ce nom, sans tenir compte des majuscules (`pomme` = `Pomme`) → `Ce produit existe déjà.`
     💡 Écris une petite méthode `NomExisteDeja` qui retourne un `bool`. Ici, le nom n'est **pas** une clé : il faut parcourir les produits.
4. Elle demande le **prix** avec `DemanderMontant` ; il doit être **strictement positif**.
5. Pour la **catégorie** : affiche les catégories numérotées (le numéro d'une valeur d'enum s'obtient avec un cast en `int`), demande le numéro avec `DemanderEntierEntre`, puis transforme le numéro en `Categorie` avec un cast.
   ```
   0. Fruit
   1. Legume
   2. Boisson
   3. Snack
   ```
6. Elle demande le **stock de départ** (entre 0 et 500).
7. Ajoute le produit au dictionnaire (la clé = le code) et affiche `Kiwi a été ajouté avec le code 20.`
8. Appelle-la dans le `case 4`.

✅ **Vérifie :**
- Code `3` → refusé (`déjà utilisé par Carotte`), puis code `20` → accepté.
- Nom `POMME` → refusé, puis `Kiwi` → accepté. 0,45 €, Fruit, stock 60.
- Kiwi apparaît dans le catalogue avec le code 20, et tu peux le vendre en tapant 20.

🏁 **Fin de la partie 3.** Le stock est suivi en temps réel et aucun code ne peut être utilisé deux fois.

---

# PARTIE 4 — Promotions et paiement

## Étape 22 — Retirer un produit du panier

🎯 Le client change d'avis : « Finalement, je ne prends pas les chips ».

1. Dans le scan, si le caissier tape un code **négatif** (ex. `-7`), on **retire** ce produit du panier.
   💡 Le code du produit est l'**opposé** du nombre tapé.
2. Si le produit n'est pas dans le panier → `Ce produit n'est pas dans le panier.`
3. Sinon, demande `Quantité à retirer :`.
   - Si elle est plus grande ou égale à la quantité du panier → **supprime** la clé (`Remove`).
   - Sinon → diminue la quantité.
   - Affiche `- 1 x Chips`.

✅ **Vérifie :** scanne 2 chips, tape `-7` et retire 1 → le ticket affiche `1 x Chips`. Tape `-7` et retire 5 → les chips disparaissent du ticket.

---

## Étape 23 — La promotion « 3 pour 2 » sur les fruits

🎯 Cette semaine, pour **tous les fruits** : 3 achetés, **1 offert**. 6 achetés, 2 offerts. 7 achetés, 2 offerts (le 7e est payé).

1. Crée une méthode `static` nommée `CalculerProduitsOfferts` qui reçoit **un produit** et **une quantité**, et **retourne le nombre de produits offerts** (`int`).
   - si le produit n'est pas un fruit → 0 ;
   - sinon → un produit offert **par tranche complète de 3** (💡 la division entière).
2. Dans `AfficherTicket`, sous la ligne d'un produit qui a des produits offerts, affiche une ligne de promotion et **déduis-la** du total.
3. La remise (étape 10) se calcule sur le total **après** promotion.

✅ **Vérifie** (7 pommes puis 3 bananes) :
```
===== TICKET =====
Ticket n° 1
7 x Pomme          =    3,50 €
  Promo 3 pour 2   =   -1,00 €
3 x Banane         =    1,05 €
  Promo 3 pour 2   =   -0,35 €
------------------------------
TOTAL              =    3,20 €
```

---

## Étape 24 — Le mode de paiement

🎯 Le client peut payer en **espèces** ou par **carte**.

1. Ajoute un fichier `ModePaiement.cs` avec une `enum` : `Especes`, `Carte`.
2. Ajoute un champ public `Mode` (`ModePaiement`) à la structure `Vente`.
3. Après l'affichage du montant à payer, demande `Mode de paiement (1 = espèces, 2 = carte) :` avec `DemanderEntierEntre`.
4. Règle du magasin : **la carte n'est acceptée qu'à partir de 5,00 €**. En dessous, affiche
   `Paiement par carte refusé : minimum 5,00 €. Paiement en espèces.` et passe en espèces.
5. Par carte : pas de monnaie, affiche `Paiement par carte accepté.`
6. En espèces : le paiement de l'étape 11.
7. Range le mode dans la vente retournée.

✅ **Vérifie :** un ticket de 3,20 € payé par carte → refusé, passage en espèces. Un ticket de 22,00 € (20,90 € après remise) par carte → accepté.

---

## Étape 25 — Rendre la monnaie en billets et en pièces

🎯 La caissière veut savoir **quels** billets et **quelles** pièces rendre, avec le moins possible.

1. Crée une méthode `static void AfficherDetailMonnaie` qui reçoit le montant à rendre.
2. Range les valeurs possibles dans un **tableau** de `decimal`, de la plus grande à la plus petite :
   50, 20, 10, 5, 2, 1, 0,50, 0,20, 0,10, 0,05, 0,02, 0,01.
3. Pour chaque valeur du tableau : calcule combien de fois elle « rentre » dans ce qui reste à rendre, affiche la ligne si c'est au moins 1, puis enlève ce montant de ce qui reste.
   💡 Une division suivie d'un cast en `int`... ou une boucle `while`. Les deux marchent.
4. Appelle-la après l'affichage de la monnaie à rendre (seulement s'il y a de la monnaie à rendre).

✅ **Vérifie** (à payer 12,70 €, le client donne 50 €) :
```
Monnaie à rendre : 37,30 €
  1 x 20,00 €
  1 x 10,00 €
  1 x 5,00 €
  1 x 2,00 €
  1 x 0,20 €
  1 x 0,10 €
```

🏁 **Fin de la partie 4.**

---

# PARTIE 5 — Le rapport de la journée

## Étape 26 — Les quantités vendues

🎯 Le soir, le patron veut savoir **combien** de chaque produit a été vendu.

1. Dans le code principal, crée un `Dictionary<int, int>` nommé `quantitesVendues` (code du produit → quantité vendue aujourd'hui).
2. Passe-le en paramètre à `PasserEnCaisse` : après chaque paiement, ajoute les quantités du panier (crée la clé si elle n'existe pas encore).

✅ **Vérifie :** vends 3 pommes à un client et 2 pommes à un autre → la valeur pour la clé 1 vaut 5 (affiche-la provisoirement).

---

## Étape 27 — Méthode `AfficherRapport` (choix 5)

1. Crée une méthode `static void AfficherRapport` qui reçoit **le catalogue**, **les ventes** et **les quantités vendues**.
2. Elle affiche, **dans cet ordre** :
   1. le nombre de clients ;
   2. la recette totale (réutilise `CalculerRecette`), puis la part **espèces** et la part **carte** ;
   3. le **panier moyen** (recette ÷ nombre de clients) ⚠️ attention s'il n'y a eu aucun client !
   4. le **plus gros ticket** (numéro et montant) ;
   5. le total des **remises** accordées ;
   6. les **3 derniers tickets**, du plus récent au plus ancien (💡 une boucle `for` qui part de la fin de la liste ; attention s'il y a moins de 3 ventes) ;
   7. le **produit le plus vendu** (nom et quantité) ;
   8. le chiffre d'affaires **par catégorie**, calculé avec un `Dictionary<Categorie, decimal>` (quantité vendue × prix du catalogue, sans tenir compte des promotions ni des remises) ;
   9. les **produits à recommander** (stock inférieur à 5) : range-les d'abord dans une **`List<Produit>`**, puis affiche-les. Si la liste est vide → `Aucun produit à recommander.`
3. Appelle-la dans le `case 5`, et aussi **automatiquement** quand la caisse est fermée (étape 16).

✅ **Vérifie** (exemple, tes chiffres dépendent de tes ventes) :
```
===== RAPPORT DE LA JOURNÉE =====
Nombre de clients     : 3
Recette totale        :    45,60 €
  dont espèces        :    12,30 €
  dont carte          :    33,30 €
Panier moyen          :    15,20 €
Plus gros ticket      : n° 2 (25,10 €)
Remises accordées     :     1,32 €
Derniers tickets      : n° 3 (8,20 €) · n° 2 (25,10 €) · n° 1 (12,30 €)
---------------------------------
Produit le plus vendu : Pomme (12)
Ventes par catégorie :
  Fruit    :  8,40 €
  Boisson  : 14,40 €
  Snack    : 24,15 €
Produits à recommander :
  Jus d'orange (stock : 2)
  Chocolat (stock : 0)
```
S'il n'y a encore eu aucune vente : `Aucune vente pour le moment.`

🎉 **Si tout fonctionne : le labo est terminé !**

Fais une dernière passe : essaie de **casser** ton programme (lettres, nombres négatifs, codes inexistants, code déjà utilisé, stock à 0, panier vide...). Il ne doit jamais planter.

---

## 🚀 Pour aller plus loin (2e journée)

1. **La carte de fidélité.** Au moment de payer, demande le numéro de carte du client (vide = pas de carte).
   Range les points dans un `Dictionary<string, int>` : 1 point par euro entier payé. Une carte inconnue est créée automatiquement.
   Dès qu'un client a 100 points, propose-lui d'en utiliser 100 pour une réduction de 5,00 €.
2. **Annuler la dernière vente.** Un nouveau choix du menu annule la dernière vente : elle disparaît de la liste, les produits reviennent dans le stock et les quantités vendues sont corrigées.
   💡 Pour ça, la vente doit se souvenir de son panier...
3. **Changer le code d'un produit.** Le nouveau code doit être libre. Il faut **retirer** l'ancienne clé et **ajouter** la nouvelle (et penser au champ `Code` du produit).
4. **Supprimer un produit** du catalogue : seulement si son stock est à 0, avec confirmation `O/N`.
5. **Chercher un produit par son nom.** Si le caissier tape des **lettres** à la place d'un code, affiche les produits dont le nom contient ces lettres, puis redemande le code.
6. **Trier le catalogue** par prix croissant avant de l'afficher, **sans** méthode de tri toute faite (avec des boucles) : copie d'abord les produits du dictionnaire dans une `List<Produit>`, puis trie cette liste.
