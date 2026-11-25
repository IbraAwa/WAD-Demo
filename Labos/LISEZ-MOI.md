# Labos — Mettre tout en pratique

Les labos sont de **vrais petits projets**. Ils rassemblent tout ce que tu as vu dans les démos :
variables, conversions, conditions, opérateurs, boucles, tableaux, `List<T>`, `Dictionary<TKey, TValue>`,
`struct`, `enum` et méthodes.

## ⚠️ Tu ne fais PAS les 4 labos

**Chaque labo représente une journée complète de travail (≈ 8 h).**
Tu en **choisis un**, et tu t'y consacres pleinement.

| Parcours possible | Jour 1 | Jour 2 |
|---|---|---|
| **A — un seul labo, à fond** | un labo (facile **ou** normal) | le même labo : « Pour aller plus loin » |
| **B — deux labos** | un labo **facile** | un labo **normal** |

- Personne ne fait les 4 labos : ce n'est **pas** le but.
- **Un labo terminé, propre et qui ne plante jamais vaut bien plus que deux labos à moitié faits.**
- Le parcours B n'est possible que si le labo facile est **entièrement** terminé à la fin du premier jour.

## Les deux niveaux

| Dossier | Comment c'est écrit | Pour qui ? |
|---|---|---|
| **Facile** | Une histoire, puis des **parties** découpées en **étapes numérotées**. Chaque étape dit précisément quoi faire et ce que tu dois voir. Si tu suis toutes les étapes, le labo est fini. | Si tu as encore besoin d'être guidé, ou si les exercices te prennent du temps. |
| **Normal** | Une histoire, les **fonctionnalités** et les **règles** à respecter, et un **plan de route** par jalons. Pas d'étapes : c'est toi qui décides comment organiser ton code. | Si tu es à l'aise avec les exercices et que tu veux concevoir ton programme toi-même. |

## Les labos

| N° | Labo | Niveau | Durée | Ce qui t'attend |
|---|---|---|---|---|
| 1 | La caisse enregistreuse | Facile | 1 jour | passage en caisse, menu de la journée, stock, promotions, paiement espèces / carte, rendu de monnaie, rapport du soir |
| 2 | La bibliothèque | Facile | 1 jour | livres, membres et règles de prêt, temps simulé, retards et amendes, historique, recherche avancée, statistiques |
| 3 | Le concessionnaire automobile | Normal | 1 jour | stock, recherche multicritère, vente avec remises / reprise / garantie, interdiction de vendre à perte, commissions, crédit, annulation, tri, statistiques |
| 4 | L'hôtel | Normal | 1 jour | chambres créées par boucles, calendrier simulé, check-in / check-out, tarif week-end, adultes / enfants, consommations, ménage, clients fidèles, statistiques |

Chaque labo se termine par **« Pour aller plus loin »** : de quoi remplir une **deuxième journée** sur le même projet.

## Comment travailler

- **L'énoncé** est dans le fichier `ENONCE.md` de chaque projet (double-clic dessus dans Visual Studio). **Lis-le en entier avant d'écrire la moindre ligne.**
- **Pour lancer un labo** : clic droit sur son projet > *Définir comme projet de démarrage*, puis **F5**.
- **Les méthodes** s'écrivent **tout en bas de `Program.cs`**, après le code principal, avec le mot-clé `static`.
- **Les `struct` et les `enum`** vont chacune dans **leur propre fichier** (clic droit sur le projet > *Ajouter* > *Classe*).
- **Avance par petits morceaux** : une partie (facile) ou un jalon (normal) à la fois. Ne commence pas le suivant tant que le précédent ne fonctionne pas.
- **Teste souvent** : lance ton programme après chaque petite modification, pas seulement à la fin.
- **Essaie de le casser** : tape des lettres à la place des nombres, des valeurs négatives, des numéros qui n'existent pas.
  Un bon programme ne plante jamais.
