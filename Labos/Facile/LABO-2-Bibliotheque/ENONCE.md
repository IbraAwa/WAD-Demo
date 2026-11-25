# LABO 2 — La bibliothèque

**Niveau :** Facile (guidé étape par étape)
**Durée estimée :** 1 journée (≈ 8 h) — + une 2e journée possible avec « Pour aller plus loin »

## 📖 L'histoire

La bibliothèque communale veut un programme console pour gérer ses livres **et ses membres**.
Chaque livre porte une étiquette avec un **numéro d'inventaire unique** : deux livres ne peuvent jamais avoir le même numéro (même deux exemplaires du même titre).
Le bibliothécaire doit pouvoir **voir** et **rechercher** les livres, **inscrire** des membres, **prêter** et **récupérer** des livres
en respectant les **règles de prêt**, repérer les **retards**, encaisser les **amendes**, et consulter un **historique** et des **statistiques**.
Tout se fait depuis un **menu**.

## 🧰 Ce que tu vas pratiquer

| Notion | Où ? |
|---|---|
| `enum` (classique) | le genre d'un livre, le type de membre |
| `struct` (et le piège de la copie !) | un livre, un membre, un emprunt |
| `Dictionary<TKey, TValue>` | **les livres** (numéro d'inventaire unique → livre), les amendes, les statistiques |
| `List<T>` | les membres, l'historique des emprunts |
| Méthodes (`static`, paramètres, `return`) | une méthode par action, plus des petites méthodes utilitaires |
| `do ... while` + `switch` | le menu et les sous-menus |
| `for` / `foreach` | parcourir les livres et les membres |
| `TryParse`, `ToLower`, `Contains`, `IsNullOrWhiteSpace` | les saisies et la recherche |

## 📏 Règles du jeu

- Fais les étapes **dans l'ordre**. Chaque étape se termine par **« ✅ Vérifie »** : lance le programme (F5) et compare.
- Les **méthodes** s'écrivent **tout en bas de `Program.cs`**, après ton code principal, avec le mot-clé `static`.
- Le labo est découpé en **4 parties**. Ne passe à la partie suivante que si la précédente fonctionne parfaitement.
- Quand les 4 parties sont terminées, **le labo est fini** 🎉. « Pour aller plus loin » est pour ceux qui ont une 2e journée.

| Partie | Contenu | Temps indicatif |
|---|---|---|
| 1 | Les livres : afficher, rechercher, prêter, ajouter | 3 h |
| 2 | Les membres et les règles de prêt | 2 h |
| 3 | Le temps qui passe : retards et amendes | 1 h 30 |
| 4 | Historique, recherche avancée et statistiques | 1 h 30 |

---

# PARTIE 1 — Les livres

## Étape 1 — L'énumération `Genre`

1. Ajoute un fichier `Genre.cs` (clic droit sur le projet > **Ajouter** > **Classe**) et transforme-le en `enum`.
2. Déclare les 5 valeurs : `Roman`, `BandeDessinee`, `ScienceFiction`, `Policier`, `Documentaire`.

💡 Si Visual Studio a mis un `namespace` en haut du fichier, ajoute le `using` correspondant en haut de `Program.cs`.

✅ **Vérifie :** le programme compile.

---

## Étape 2 — La structure `Livre`

1. Ajoute un fichier `Livre.cs` et transforme-le en `struct`.
2. Déclare 6 champs **publics** :

| Champ | Type | Exemple |
|---|---|---|
| `Numero` | `int` | 3 (le numéro d'inventaire) |
| `Titre` | `string` | Dune |
| `Auteur` | `string` | Frank Herbert |
| `Annee` | `int` | 1965 |
| `Genre` | `Genre` (ton enum) | ScienceFiction |
| `EstDisponible` | `bool` | true |

✅ **Vérifie :** le programme compile.

---

## Étape 3 — Les livres de départ : un dictionnaire

🎯 Le numéro d'inventaire est **unique**. Un **dictionnaire** garantit justement que chaque **clé** est unique, et il permet de retrouver un livre **directement** par son numéro.

1. Dans `Program.cs`, crée un `Dictionary<int, Livre>` nommé `livres` :
   - la **clé** = le numéro d'inventaire ;
   - la **valeur** = le livre.
2. Ajoute-y ces 8 livres avec `Add`. La clé doit toujours être **égale** au champ `Numero` du livre.

| N° | Titre | Auteur | Année | Genre | Disponible |
|---|---|---|---|---|---|
| 1 | Le Petit Prince | Antoine de Saint-Exupéry | 1943 | Roman | oui |
| 2 | L'Étranger | Albert Camus | 1942 | Roman | oui |
| 3 | Dune | Frank Herbert | 1965 | ScienceFiction | oui |
| 4 | Fondation | Isaac Asimov | 1951 | ScienceFiction | **non** |
| 5 | Le Crime de l'Orient-Express | Agatha Christie | 1934 | Policier | oui |
| 6 | Tintin au Tibet | Hergé | 1960 | BandeDessinee | oui |
| 7 | Astérix le Gaulois | Goscinny et Uderzo | 1961 | BandeDessinee | **non** |
| 8 | Sapiens | Yuval Noah Harari | 2011 | Documentaire | oui |

3. 🧪 **Expérience :** ajoute temporairement un livre **avec la clé 3** (déjà utilisée). Lance le programme : il **plante**, car `Add` refuse une clé qui existe déjà.
   Supprime cette ligne. Retiens : avant d'ajouter une clé qui vient de l'utilisateur, on vérifie **toujours** avec `ContainsKey`.

✅ **Vérifie :** affiche `La bibliothèque contient 8 livres`, puis supprime cette ligne de test.

---

## Étape 4 — Méthodes `AfficherLivre` et `AfficherLivres`

🎯 Afficher **un** livre, puis **tous** les livres.

1. Crée une méthode `static void AfficherLivre` qui reçoit **un livre**. Elle affiche :
   - `[numéro] Titre — Auteur (Année) · Genre · disponible` si le livre est disponible ;
   - `[numéro] Titre — Auteur (Année) · Genre · EMPRUNTÉ` sinon.
   💡 Un opérateur ternaire est parfait pour choisir entre `disponible` et `EMPRUNTÉ`.
2. Crée une méthode `static void AfficherLivres` qui reçoit **le dictionnaire des livres**. Avec un `foreach`, elle appelle `AfficherLivre` pour chaque livre.
   💡 Chaque élément parcouru a une `.Key` (le numéro) et une `.Value` (le livre).
3. Appelle `AfficherLivres` dans le code principal.

✅ **Vérifie :**
```
[1] Le Petit Prince — Antoine de Saint-Exupéry (1943) · Roman · disponible
[2] L'Étranger — Albert Camus (1942) · Roman · disponible
[3] Dune — Frank Herbert (1965) · ScienceFiction · disponible
[4] Fondation — Isaac Asimov (1951) · ScienceFiction · EMPRUNTÉ
...
```

---

## Étape 5 — Méthode `DemanderEntier` avec un minimum et un maximum

🎯 Pour le menu et les numéros, il faut un nombre **valide** et **dans les limites**.

1. Crée une méthode `static` nommée `DemanderEntier` qui reçoit **la question**, **le minimum** et **le maximum**, et **retourne un `int`**.
2. Elle redemande (boucle `while`) **tant que** la saisie n'est pas un nombre **ou** qu'elle est en dehors des limites.
   Message d'erreur : `Tape un nombre entre 1 et 8 :` (avec le vrai minimum et le vrai maximum).

✅ **Vérifie :** avec min = 1 et max = 8, tape `abc`, puis `12`, puis `3` → la méthode retourne 3.

---

## Étape 6 — Le menu

🎯 Le cœur du programme : un menu qui revient tant qu'on ne choisit pas « Quitter ».

1. Crée une méthode `static void AfficherMenu` qui affiche :
   ```
   ===== BIBLIOTHÈQUE =====
   1. Afficher tous les livres
   2. Rechercher un livre
   3. Emprunter un livre
   4. Rendre un livre
   5. Ajouter un livre
   6. Statistiques
   0. Quitter
   ```
2. Dans le code principal, remplace l'appel de l'étape 4 par une boucle `do ... while` qui tourne **tant que le choix n'est pas 0** :
   1. `Console.Clear()`, puis affiche le menu ;
   2. demande le choix avec `DemanderEntier` (entre 0 et 6) ;
   3. un `switch` sur le choix : pour l'instant, chaque `case` (de 1 à 6) affiche `Pas encore fait...`, sauf le `case 1` qui appelle `AfficherLivres`, et le `case 0` qui affiche `Au revoir !` ;
   4. si le choix n'est pas 0, affiche `Appuie sur une touche pour revenir au menu...` et attends une touche (`Console.ReadKey()`).

✅ **Vérifie :** le menu s'affiche, le choix 1 montre les livres, les choix 2 à 6 affichent `Pas encore fait...`, le choix 0 quitte.

---

## Étape 7 — Rechercher un livre (choix 2)

1. Crée une méthode `static void RechercherLivre` qui reçoit les livres.
2. Elle demande `Mot à chercher dans le titre :`.
3. Elle parcourt les livres et affiche (avec `AfficherLivre`) ceux dont le titre **contient** le mot cherché.
   La recherche ne doit pas tenir compte des majuscules : `dune`, `DUNE` et `Dune` trouvent tous le même livre.
   💡 Mets le titre ET le mot cherché en minuscules avant de comparer (`ToLower`), puis utilise `Contains`.
   💡 Le titre n'est **pas** la clé du dictionnaire : pour chercher par titre, il faut **parcourir** tous les livres.
4. Compte les livres trouvés. S'il n'y en a aucun, affiche `Aucun livre trouvé.`
5. Appelle cette méthode dans le `case 2`.

✅ **Vérifie :** `le` → trouve *Le Petit Prince*, *Le Crime de l'Orient-Express* et *Astérix le Gaulois* (3 livres). `zzz` → `Aucun livre trouvé.`

---

## Étape 8 — Emprunter un livre (choix 3) ⚠️ le piège de la struct

1. Crée une méthode `static` nommée `DemanderNumeroLivre` qui reçoit les livres, demande `Numéro du livre :` et **redemande tant que** ce numéro n'est pas une clé du dictionnaire (`Numéro de livre inconnu, recommence :`). Elle retourne le numéro.
2. Crée une méthode `static void EmprunterLivre` qui reçoit les livres.
3. Elle affiche tous les livres, puis demande le numéro avec `DemanderNumeroLivre`.
4. Si ce livre **n'est pas disponible** → affiche `Désolé, ce livre est déjà emprunté.`
5. Sinon, il faut passer `EstDisponible` à `false`. **Attention :** si tu essaies de modifier directement le champ du livre dans le dictionnaire, Visual Studio refuse (erreur **CS1612**).
   Pourquoi ? Parce que `Livre` est une **struct** (type valeur) : lire une valeur du dictionnaire te donne une **COPIE**.
   👉 La bonne méthode, en 3 temps :
   1. copie le livre du dictionnaire dans une variable ;
   2. modifie la variable ;
   3. remets la variable dans le dictionnaire, **avec la même clé** (avec les crochets, pas avec `Add` !).
6. Affiche `Bonne lecture ! « Dune » est maintenant emprunté.`
7. Appelle cette méthode dans le `case 3`.

💡 Pourquoi la modification se voit-elle en dehors de la méthode ? Parce qu'un `Dictionary` est un **type référence** : la méthode travaille sur le même dictionnaire que le code principal.

✅ **Vérifie :** emprunte *Dune* (n°3), reviens au menu, choix 1 → *Dune* est `EMPRUNTÉ`. Essaie d'emprunter *Fondation* (n°4) → message « déjà emprunté ». Le numéro 42 → redemandé.

---

## Étape 9 — Rendre un livre (choix 4)

1. Crée une méthode `static void RendreLivre`, sur le même modèle que l'étape 8, mais à l'envers :
   - si le livre **est déjà disponible** → `Ce livre n'a pas été emprunté.`
   - sinon → il redevient disponible, et tu affiches `Merci ! « Fondation » est de retour.`
2. Appelle-la dans le `case 4`.

✅ **Vérifie :** rends *Fondation* (n°4), puis choix 1 → *Fondation* est `disponible`.

---

## Étape 10 — Ajouter un livre (choix 5) — un numéro unique !

🎯 Un nouveau livre arrive avec son étiquette. Le bibliothécaire tape **son numéro d'inventaire**, et le programme doit **refuser un numéro déjà utilisé**.

1. Crée une méthode `static void AjouterLivre` qui reçoit les livres.
2. Elle demande le **numéro d'inventaire** (entre 1 et 9999). **Tant que** ce numéro est déjà une clé du dictionnaire, elle affiche
   `Le numéro 3 est déjà utilisé par « Dune ».` et redemande.
   ⚠️ Ne compte pas sur `Add` pour faire le contrôle : il ferait **planter** le programme (étape 3).
3. Elle demande le **titre**. Tant que le titre est vide (ou ne contient que des espaces), elle redemande.
   💡 `string.IsNullOrWhiteSpace`. Comme tu vas souvent demander un texte non vide, écris une méthode `DemanderTexte` qui reçoit la question et retourne le texte.
4. Même chose pour l'**auteur**.
5. Elle demande l'**année** avec `DemanderEntier`, entre 1450 (l'invention de l'imprimerie !) et l'année actuelle (`DateTime.Now.Year`).
6. Pour le **genre** :
   1. affiche les genres numérotés (le numéro d'une valeur d'enum s'obtient avec un cast en `int`) :
      ```
      0. Roman
      1. BandeDessinee
      2. ScienceFiction
      3. Policier
      4. Documentaire
      ```
   2. demande le numéro avec `DemanderEntier` (entre 0 et 4) ;
   3. transforme le numéro en `Genre` avec un cast.
   💡 Tu auras encore besoin de choisir un genre plus tard : range ce code dans une méthode `ChoisirGenre` qui retourne un `Genre`.
7. Crée le nouveau livre (disponible au départ), ajoute-le au dictionnaire et affiche `« Titre » a été ajouté avec le numéro 12.`
8. Appelle-la dans le `case 5`.

✅ **Vérifie :**
- Numéro `3` → refusé (`déjà utilisé par « Dune »`), puis `12` → accepté : *Harry Potter à l'école des sorciers*, J.K. Rowling, 1997, Roman. Choix 1 → il apparaît avec le n°12.
- Ajoute un **2e exemplaire** de *Dune* avec le numéro `13` → accepté : le **titre** peut se répéter, le **numéro** jamais.

---

## Étape 11 — Statistiques (choix 6)

1. Crée une méthode `static void AfficherStatistiques` qui reçoit les livres.
2. Crée un `Dictionary<Genre, int>` : pour chaque livre, ajoute 1 au compteur de son genre (crée la clé si elle n'existe pas encore).
3. Compte aussi combien de livres sont disponibles et combien sont empruntés.
4. Affiche :
   ```
   ===== STATISTIQUES =====
   Roman : 2 livre(s)
   ScienceFiction : 2 livre(s)
   Policier : 1 livre(s)
   BandeDessinee : 2 livre(s)
   Documentaire : 1 livre(s)
   ------------------------
   Total      : 8
   Disponibles: 6
   Empruntés  : 2
   ```
5. Appelle-la dans le `case 6`.

🏁 **Fin de la partie 1.** Les livres sont gérés... mais on ne sait pas **qui** a emprunté quoi !

---

# PARTIE 2 — Les membres et les règles de prêt

## Étape 12 — L'énumération `TypeMembre` et la liste des membres

1. Ajoute une `enum` `TypeMembre` avec 2 valeurs : `Enfant`, `Adulte`.
2. Ajoute une `struct` `Membre` avec 3 champs publics :

| Champ | Type | Exemple |
|---|---|---|
| `Numero` | `int` | 1 |
| `Nom` | `string` | Sarah Lemaire |
| `Type` | `TypeMembre` | Adulte |

3. Dans le code principal, crée une **`List<Membre>`** nommée `membres` avec ces 3 membres :

| Numéro | Nom | Type |
|---|---|---|
| 1 | Sarah Lemaire | Adulte |
| 2 | Tom Dubois | Enfant |
| 3 | Inès Martin | Adulte |

💡 Cette fois on utilise une **liste** : les numéros de membre ne sont **pas** tapés par l'utilisateur, le programme les attribue lui-même (étape 15). Tu vas donc pratiquer les deux façons de faire : chercher dans un dictionnaire **par la clé**, et chercher dans une liste **avec une boucle**.

✅ **Vérifie :** le programme compile.

---

## Étape 13 — Qui a emprunté le livre ?

1. Ajoute un champ public `NumeroEmprunteur` (`int`) à la structure `Livre`. Il vaut **0** quand personne n'a le livre.
2. Les 2 livres empruntés au départ le sont par :
   - *Fondation* (n°4) → membre n°1 (Sarah) ;
   - *Astérix le Gaulois* (n°7) → membre n°2 (Tom).
3. Modifie `AfficherLivre` : un livre emprunté affiche `EMPRUNTÉ (membre n°1)`.

✅ **Vérifie :**
```
[4] Fondation — Isaac Asimov (1951) · ScienceFiction · EMPRUNTÉ (membre n°1)
```

---

## Étape 14 — Afficher les membres (choix 7)

1. Ajoute au menu l'option `7. Afficher les membres` (et pense à changer le maximum du choix).
2. Crée une méthode `static` nommée `CompterEmprunts` qui reçoit **les livres** et **un numéro de membre**, et **retourne** le nombre de livres que ce membre a actuellement.
3. Crée une méthode `static void AfficherMembres` qui reçoit les membres **et** les livres, et affiche :
   ```
   ===== MEMBRES =====
   [1] Sarah Lemaire (Adulte) — 1 livre(s) emprunté(s)
   [2] Tom Dubois (Enfant) — 1 livre(s) emprunté(s)
   [3] Inès Martin (Adulte) — 0 livre(s) emprunté(s)
   ```
4. Appelle-la dans le `case 7`.

✅ **Vérifie :** l'affichage ci-dessus.

---

## Étape 15 — Inscrire un membre (choix 8)

1. Ajoute l'option `8. Inscrire un membre` au menu.
2. Crée une méthode `static` nommée `TrouverIndexMembre` qui reçoit les membres et un numéro, parcourt la liste avec une boucle `for`, et retourne l'**index** du membre, ou **-1** s'il n'existe pas.
3. Crée une méthode `static void InscrireMembre` qui :
   - demande le nom avec `DemanderTexte` ;
   - demande le type (`0. Enfant` / `1. Adulte`) ;
   - attribue le numéro **automatiquement** : le plus grand numéro existant + 1 (💡 parcours la liste pour trouver le plus grand) ;
   - affiche `Bienvenue Lucas Petit ! Ton numéro de membre est le 4.`
4. Appelle-la dans le `case 8`.

✅ **Vérifie :** inscris *Lucas Petit*, Enfant → numéro 4, visible dans la liste des membres. `TrouverIndexMembre(membres, 4)` vaut 3 et `TrouverIndexMembre(membres, 42)` vaut -1.

---

## Étape 16 — Emprunter et rendre avec un membre

🎯 Maintenant, un emprunt est fait **par quelqu'un**, et la bibliothèque a des règles.

| Règle | Message si elle n'est pas respectée |
|---|---|
| Le membre doit exister. | `Membre inconnu.` |
| Un **enfant** peut avoir **2 livres** maximum, un **adulte 4**. | `Tom Dubois a déjà 2 livre(s) : c'est le maximum pour un enfant.` |
| Un **enfant** ne peut emprunter **ni** `Policier` **ni** `ScienceFiction`. | `Ce genre de livre n'est pas autorisé pour un enfant.` |
| Le livre doit être disponible. | `Désolé, ce livre est déjà emprunté.` |

1. Crée une méthode `static` nommée `NombreMaxLivres` qui reçoit un `TypeMembre` et retourne 2 ou 4 (un `switch` est parfait).
2. Modifie `EmprunterLivre` : elle reçoit aussi les membres, demande d'abord le **numéro de membre** (cherché avec `TrouverIndexMembre`) et vérifie **toutes** les règles. Si tout est bon, le livre retient le numéro de l'emprunteur.
   Message : `Bonne lecture Tom Dubois ! « Tintin au Tibet » est maintenant emprunté.`
3. Modifie `RendreLivre` : quand un livre revient, `NumeroEmprunteur` repasse à 0.

✅ **Vérifie :**
- Tom (n°2) emprunte *Tintin au Tibet* (n°6) → accepté (il a maintenant 2 livres).
- Tom essaie d'emprunter *Sapiens* (n°8) → refusé (maximum atteint).
- Inès (n°3) emprunte *Dune* (n°3) → accepté. Inscris Lucas (n°4, enfant), puis il essaie *Le Crime de l'Orient-Express* (n°5) → refusé (genre).
- Le membre n°42 → `Membre inconnu.`
- Le choix 7 affiche les bons compteurs.

🏁 **Fin de la partie 2.**

---

# PARTIE 3 — Le temps qui passe : retards et amendes

## Étape 17 — Le jour actuel (choix 12)

🎯 Pour gérer les retards, le programme doit savoir **quel jour** on est. On ne va pas attendre de vrais jours : on simule le temps.

1. Dans le code principal, crée une variable `jour` qui vaut **1** au lancement.
2. Le titre du menu affiche le jour : `===== BIBLIOTHÈQUE — Jour 1 =====` (passe `jour` en paramètre à `AfficherMenu`).
3. Ajoute l'option `12. Faire passer des jours` : demande `Combien de jours ? (1 à 30)`, ajoute-les à `jour`, et affiche `Nous sommes maintenant le jour 8.`

💡 Les options 9, 10 et 11 arrivent dans les étapes suivantes : pour l'instant, elles peuvent afficher `Pas encore fait...`. Le menu complet sera :
```
===== BIBLIOTHÈQUE — Jour 1 =====
1. Afficher tous les livres
2. Rechercher un livre
3. Emprunter un livre
4. Rendre un livre
5. Ajouter un livre
6. Statistiques
7. Afficher les membres
8. Inscrire un membre
9. Livres en retard
10. Payer une amende
11. Historique d'un membre
12. Faire passer des jours
0. Quitter
```

✅ **Vérifie :** le jour avance et s'affiche dans le titre du menu.

---

## Étape 18 — La date de retour

1. Ajoute un champ public `JourRetour` (`int`) à `Livre` : le jour où le livre doit être rendu (0 si le livre est disponible).
2. Un emprunt dure **14 jours** : quand un livre est emprunté, `JourRetour` = jour actuel + 14.
   ⚠️ `EmprunterLivre` a donc besoin de connaître le jour actuel.
3. Au départ : *Fondation* doit être rendu le **jour 3**, *Astérix le Gaulois* le **jour 10**.
4. `AfficherLivre` reçoit aussi le jour actuel. Un livre emprunté affiche `EMPRUNTÉ (membre n°1, retour jour 3)`, et en plus `⚠ EN RETARD` si le jour de retour est **dépassé**.

✅ **Vérifie :** au jour 1, aucun retard. Fais passer 5 jours (jour 6) → *Fondation* est `⚠ EN RETARD`, pas *Astérix*.

---

## Étape 19 — Livres en retard (choix 9)

1. Crée une méthode `static void AfficherRetards` qui reçoit les livres, les membres et le jour actuel.
2. Elle affiche chaque livre en retard, avec le **nom** du membre et le **nombre de jours de retard** :
   ```
   ===== LIVRES EN RETARD (jour 7) =====
   [4] Fondation — Sarah Lemaire — 4 jour(s) de retard
   ```
3. S'il n'y en a aucun : `Aucun livre en retard. 👍`

✅ **Vérifie :** au jour 7 → *Fondation* a 4 jours de retard.

---

## Étape 20 — Les amendes

🎯 Un livre rendu en retard coûte **0,25 € par jour de retard**, avec un **maximum de 5,00 €** par livre.

| Retard | Amende |
|---|---|
| 0 jour | 0,00 € |
| 4 jours | 1,00 € |
| 20 jours | 5,00 € |
| 30 jours | 5,00 € (et pas 7,50 €) |

1. Crée une méthode `static` nommée `CalculerAmende` qui reçoit le nombre de jours de retard et **retourne** le montant (`decimal`).
2. Dans le code principal, crée un `Dictionary<int, decimal>` nommé `amendes` : numéro de membre → montant **qu'il doit encore**.
   Un membre qui ne doit rien n'a **pas** de clé dans ce dictionnaire.
3. Dans `RendreLivre` : si le livre revient en retard, calcule l'amende, **ajoute-la** à ce que le membre doit déjà (crée la clé si besoin) et affiche
   `Retour en retard de 4 jour(s) : amende de 1,00 €. Sarah Lemaire doit maintenant 1,00 €.`

✅ **Vérifie :** au jour 7, rends *Fondation* → amende de 1,00 €.

---

## Étape 21 — Bloquer les emprunts et payer l'amende (choix 10)

1. Ajoute 2 règles à `EmprunterLivre` :

| Règle | Message |
|---|---|
| Un membre qui doit une amende ne peut pas emprunter. | `Sarah Lemaire doit encore 1,00 € : emprunt refusé.` |
| Un membre qui a un livre **en retard** ne peut pas emprunter. | `Tom Dubois a un livre en retard : emprunt refusé.` |

2. Crée une méthode `static void PayerAmende` (choix 10) :
   - demande le numéro de membre ; s'il n'a pas de clé dans `amendes` → `Ce membre ne doit rien.` ;
   - affiche ce qu'il doit et demande le montant payé (un `decimal` **plus grand que 0** et **pas plus grand** que ce qu'il doit) ;
   - diminue la dette. Si elle tombe à 0, **supprime la clé** (`Remove`) et affiche `Amende soldée, merci !`, sinon `Il reste 0,50 € à payer.`
3. Garde le total des amendes encaissées dans une variable du code principal (`totalAmendes`) : tu en auras besoin pour les statistiques.
   💡 La méthode peut **retourner** le montant encaissé.

✅ **Vérifie :** Sarah doit 1,00 € → elle ne peut pas emprunter. Elle paie 0,50 → il reste 0,50 €. Elle paie 0,50 → soldée. Elle peut à nouveau emprunter.

🏁 **Fin de la partie 3.**

---

# PARTIE 4 — Historique, recherche avancée et statistiques

## Étape 22 — L'historique des emprunts

1. Ajoute une `struct` `Emprunt` :

| Champ | Type | Signification |
|---|---|---|
| `NumeroLivre` | `int` | le numéro d'inventaire du livre |
| `NumeroMembre` | `int` | qui l'a emprunté |
| `JourEmprunt` | `int` | le jour de l'emprunt |
| `JourRendu` | `int` | le jour du retour, **0** tant que le livre n'est pas rendu |
| `Amende` | `decimal` | l'amende pour ce retour (0 si à l'heure) |

2. Dans le code principal, crée une **`List<Emprunt>`** nommée `historique` : les emprunts s'ajoutent **à la suite**, dans l'ordre où ils arrivent.
3. À chaque emprunt, **ajoute** une ligne à l'historique.
4. À chaque retour, retrouve **la ligne en cours** de ce livre (même numéro de livre, `JourRendu` qui vaut 0) avec une boucle `for`, et complète `JourRendu` et `Amende`.
   ⚠️ Piège de la struct, encore ! (cette fois dans une liste : on remet la copie **à la même position**).
   Les 2 emprunts de départ (*Fondation* et *Astérix*) ne sont pas dans l'historique : si aucune ligne n'est trouvée, on ne fait rien.

✅ **Vérifie :** emprunte puis rends un livre ; affiche provisoirement le nombre de lignes de l'historique.

---

## Étape 23 — Historique d'un membre (choix 11)

1. Crée une méthode `static void AfficherHistoriqueMembre` qui demande un numéro de membre et affiche ses emprunts.
   Le titre du livre se retrouve **dans le dictionnaire des livres**, grâce au numéro de livre.
   ```
   ===== HISTORIQUE — Inès Martin =====
   [3] Dune — emprunté le jour 1, rendu le jour 9
   [8] Sapiens — emprunté le jour 9, rendu le jour 30 (amende : 1,75 €)
   [2] L'Étranger — emprunté le jour 30, en cours
   ```
2. Si le membre n'a encore rien emprunté : `Aucun emprunt pour ce membre.`

✅ **Vérifie :** reproduis un scénario comme celui ci-dessus et compare.

---

## Étape 24 — La recherche avancée (choix 2)

🎯 Chercher seulement dans les titres, c'est limité.

1. Transforme `RechercherLivre` en **sous-menu** (une petite boucle à l'intérieur de la méthode, qui revient tant qu'on ne choisit pas 0) :
   ```
   --- RECHERCHE ---
   1. Par numéro d'inventaire
   2. Par titre
   3. Par auteur
   4. Par genre
   5. Par période (de ... à ...)
   0. Retour au menu
   ```
2. **Par numéro** : **pas de boucle** ici ! Utilise directement le dictionnaire (`ContainsKey` puis les crochets). Numéro inconnu → `Aucun livre avec ce numéro.`
3. **Par auteur** : comme par titre, sans tenir compte des majuscules.
4. **Par genre** : réutilise `ChoisirGenre`.
5. **Par période** : demande une année de début et une année de fin (la fin ne peut pas être avant le début).
6. Pour les choix 2 à 5, demande ensuite `Seulement les livres disponibles ? (O/N) :` et filtre si nécessaire.
7. Message si rien n'est trouvé, comme avant.

✅ **Vérifie :** numéro `6` → *Tintin au Tibet*. Auteur `camus` → *L'Étranger*. Genre `BandeDessinee` + seulement disponibles → *Tintin au Tibet* (si personne ne l'a). Période 1940 à 1960 → 4 livres (les deux années comprises).

---

## Étape 25 — Les statistiques complètes (choix 6)

Complète `AfficherStatistiques` (elle reçoit maintenant tout ce dont elle a besoin) pour afficher, en plus de ce qui existe déjà :

1. le livre **le plus ancien** et le **plus récent** ;
2. le nombre de **membres** (dont enfants / dont adultes) ;
3. le nombre total d'**emprunts** dans l'historique ;
4. le **titre le plus emprunté**, tous exemplaires confondus (💡 un `Dictionary<string, int>` titre → nombre d'emprunts, rempli à partir de l'historique : deux exemplaires de *Dune* comptent pour le même titre) ;
5. le **membre le plus actif** (celui qui a le plus d'emprunts dans l'historique) ;
6. le nombre de livres **actuellement en retard** ;
7. le total des amendes **encaissées** et le total des amendes **encore dues**.

✅ **Vérifie** (exemple, tes chiffres dépendent de ce que tu as fait) :
```
===== STATISTIQUES (jour 30) =====
Roman : 3 livre(s)
...
------------------------
Total       : 10
Disponibles : 7
Empruntés   : 3
Plus ancien : Le Crime de l'Orient-Express (1934)
Plus récent : Sapiens (2011)
------------------------
Membres     : 4 (2 enfant(s), 2 adulte(s))
Emprunts    : 7
Le plus emprunté : Dune (3 fois)
Le plus actif    : Inès Martin (3 emprunts)
En retard        : 1 livre(s)
Amendes encaissées : 2,75 €
Amendes dues       : 1,00 €
```

🎉 **Si tout fonctionne : le labo est terminé !**

Fais une dernière passe : essaie de **casser** ton programme (lettres, numéros inexistants, numéro d'inventaire déjà utilisé, montant négatif, rendre un livre disponible...). Il ne doit jamais planter.

---

## 🚀 Pour aller plus loin (2e journée)

1. **Prolonger un emprunt.** Un membre peut prolonger un livre **une seule fois**, de 7 jours, et seulement s'il n'est pas déjà en retard (ajoute un champ `bool` à `Livre`).
2. **Les réservations.** Un membre peut réserver un livre emprunté (`Dictionary<int, int>` numéro du livre → numéro du membre qui attend ; un livre ne peut avoir qu'**une** réservation).
   Quand le livre revient, affiche `À mettre de côté pour Inès Martin !`, et seul ce membre peut l'emprunter pendant 3 jours.
3. **Supprimer un livre** abîmé : seulement s'il est disponible, avec confirmation `O/N` (`Remove` sur le dictionnaire).
4. **Changer le numéro d'inventaire** d'un livre : le nouveau numéro doit être libre. Retire l'ancienne clé, ajoute la nouvelle, et corrige les lignes de l'historique.
5. **Trier les livres** par titre (ordre alphabétique) avant de les afficher, **sans** méthode de tri toute faite : copie d'abord les livres dans une `List<Livre>`, puis trie-la. 💡 `string.Compare`.
6. **Choisir le genre par son nom** : l'utilisateur tape `Policier`, et tu convertis avec `Enum.TryParse`.
7. **Un membre Senior** (nouvelle valeur de l'enum) : 4 livres maximum comme un adulte, mais des amendes **réduites de moitié**.
