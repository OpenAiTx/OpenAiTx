# Obsidian Orgmode CM6

[Orgmode](https://orgmode.org) pour [Obsidian](https://obsidian.md).

![Capture d’écran](https://raw.githubusercontent.com/BBazard/obsidian-orgmode-cm6/master/./screenshot.png)

## Utilisation

Par défaut, les fichiers org ne sont pas affichés dans la barre latérale.
Pour les afficher, vous devez aller dans les paramètres d’Obsidian, section `Fichiers et liens` et cocher `Détecter toutes les extensions de fichiers`.

![detect-all-file-extensions](https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/e6a91e66-295d-4057-bf80-e43dcdb8e3e7)

Pour créer un fichier org dans votre coffre, vous devez actuellement le créer en dehors d’Obsidian, car Obsidian ne permet pas de créer un fichier non Markdown.

Si vous n’avez pas encore de fichier org, essayez de créer un fichier appelé `todo.org` avec le contenu suivant :

```org
* TODO [#A] A task with *high* priority

The description of the task

* A collapsed section

You cannot see the description when collapsed

* DONE something done already :sometag:
SCHEDULED: <2023-12-08 Fri 11:13>
:PROPERTIES:
:CREATED: [2023-12-03 Sun 10:48]
:END:

a [[https://github.com/BBazard/obsidian-orgmode-cm6][link]]

#+begin_src javascript
const block = "highlighted"
#+end_src
```

## Fonctionnalités prises en charge

### Éditeur Orgmode

- Aperçu en direct
- Mise en évidence de la syntaxe (avec des classes css modifiables)
- Mots-clés Todo personnalisables dans les paramètres
- Pliage (cliquez dans la marge sur la première ligne de l’élément pour le plier)
- Liens Wiki (`[[unicorn]]` ouvrira le fichier unicorn.org n’importe où dans le coffre ou retombe sur unicorn.md)
- Images en ligne (`[[myimage.png]]` affichera l’image si elle existe dans le coffre)
- Liens ID (`[[id:12345]]` redirigera vers le titre avec le :ID: correspondant dans un tiroir de propriété situé dans n’importe quel fichier org du coffre)
- Support Vim (si activé dans Obsidian)
- Mise en évidence des blocs source (pris en charge : c, c++, css, html, java, javascript, json, php, python, rust, sass, xml)

### Analyseur Orgmode (mise en évidence de la syntaxe)

Suivant la [Syntaxe Org](https://orgmode.org/worg/org-syntax.html)

- [x] Titre (imbriqué, pas de support pour les titres COMMENT)
- [x] Section (y compris la section zéro)
- [x] Balises de texte (gras, italique, souligné, etc...)
- [x] Lien (lien régulier, lien entre chevrons, lien simple)
- [x] Combinaison de balises et lien
- [x] Ligne de commentaire
- [x] Ligne de mot-clé
- [x] Ligne de planification
- [x] Tiroir de propriétés
- [x] Bloc mineur (non formaté sauf blocs source)
- [ ] Bloc dynamique (impossible car Obsidian n’autorise pas l’exécution arbitraire dans les plugins)
- [ ] Tiroir
- [ ] Liste et case à cocher
- [ ] Règle horizontale
- [ ] Horodatage
- [ ] Horloge
- [ ] Sexp journalier
- [ ] Note de bas de page
- [ ] Tableau
- [ ] Latex
- [ ] : Ligne à largeur fixe (vous pouvez utiliser un Bloc à la place)
## Détails de l'implémentation

- Les fichiers orgmode sont gérés avec une instance [codemirror 6](https://codemirror.net) distincte de celle utilisée pour les fichiers markdown. Cela signifie que le plugin doit réimplémenter toutes les fonctionnalités fonctionnant pour les fichiers markdown.

- Le parseur lit un fichier orgmode et construit un arbre de nœuds syntaxiques en utilisant une grammaire [lezer](https://lezer.codemirror.net) avec des tokenizer personnalisés. Cette approche permet de faire correspondre les tokens plus précisément que l’approche basée sur les regex d’Emacs. Par exemple, les lignes de planification ne sont reconnues qu’après un titre et non au milieu d’une section.

- Les tokens qui se chevauchent ne sont pas considérés comme valides. Prenons par exemple : `*one _two three* four_`. Emacs, utilisant des regex, aurait `*one _two three*` comme gras et `_two three* four_` comme souligné. Le parseur lezer considère plutôt `*one _two three*` comme gras et ` four_` comme texte normal, ce qui permet d’avoir la plage de mise en forme du texte comme son propre nœud syntaxique.

- Il n’y a pas de limite au niveau des titres (donc pas de Inlinetask) ni au nombre de lignes d’une mise en forme de texte.

## Afficher les tâches orgmode dans les fichiers markdown

Cette fonctionnalité est instable et changera probablement de manière incompatible à l’avenir.

Actuellement seuls TODO et DONE sont pris en charge.

https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/b071b2c8-b56e-4050-8fcf-02a922fdd1c0

Pour filtrer, les [expressions de recherche orgzly](https://www.orgzly.com/docs#search) sont supportées (implémentées : s, d, c, i, it, ad).


```orgmode-tasks
filepath: Orgmode/Orgmode file.org
query: it.todo or it.done
```

## Développement

```
git clone https://github.com/bbazard/obsidian-orgmode-cm6
cd obsidian-orgmode-cm6
npm install
npm run build
npm test
cp main.js styles.css manifest.json "$OBSIDIAN_VAULT"/.obsidian/plugins/obsidian-orgmode-cm6/
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---