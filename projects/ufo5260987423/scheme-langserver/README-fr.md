![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Vous pouvez lire mon [article](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) et le citer comme ceci 
> WANG, Z. (2025, 12 mai). Scheme-langserver : Considérer l’édition de code Scheme comme une préoccupation de première classe. 18ème Symposium Européen Lisp (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

En raison du fait que GitHub peut bloquer les adresses IP chinoises, j’ai dû copier ce dépôt [ici](https://codeberg.org/ufo5260987423/scheme-langserver) et [ici](https://gitee.com/ufo5260987423/scheme-langserver). Je continuerai à mettre à jour tous les dépôts, mais je ne peux pas le garantir. Je collabore également maintenant avec [XmacsLabs](https://github.com/XmacsLabs), vous pouvez aussi trouver un fork [ici](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Désormais, VSCode peut utiliser scheme-langserver !** Veuillez vous référer [ICI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>REMARQUE : Il y a encore de très nombreux bugs dans scheme-langserver. Je suis en train de les corriger et je sollicite l’aide de la communauté. Merci de votre patience.

>REMARQUE : vous pouvez trouver les informations de type générées automatiquement [ici](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Ceci est principalement utilisé pour le développement des prochaines étapes (peut-être incluant AKKU) et le débogage.

Implémenter des fonctionnalités comme l’autocomplétion, le "goto definition" ou la documentation au survol représente un effort considérable pour la programmation. Cependant, comparé à d’autres langages comme Java, Python, JavaScript et C, les implémentations du protocole du serveur de langage pour les langages Lisp sont réalisées dans le vide. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) et [swish-lint](https://github.com/becls/swish-lint), etc., leurs travaux sont tous basés sur le `repl` (Read-Eval-Print Loop) ou sur un tokeniseur de mots-clés au lieu d’une véritable programmation. Par exemple, si un programmeur travaille sur un projet non abouti, dans lequel le code n’est pas entièrement exécutable, [Geiser](https://gitlab.com/emacs-geiser) ou d’autres ne complèteront que les identifiants de liaison de niveau supérieur listés par la procédure `environment-symbols` (pour [Chez](https://cisco.github.io/ChezScheme/)), ou complèteront les symboles au lieu des identifiants. Cela signifie que pour les liaisons locales et les codes non aboutis, même si l’effort de programmation est supposé être primordial, [Geiser](https://gitlab.com/emacs-geiser) et ses homologues n’aident en rien à reconnaître la portée valide des identifiants. Des cas similaires se présentent pour le "goto definition" et de nombreuses autres fonctionnalités.

Une cause principale est que, pour Scheme et d’autres dialectes Lisp, leur abondance de structures de données et la flexibilité de leurs structures de contrôle rendent l’analyse de programme très complexe. En particulier les macros : on dirait que Scheme est principalement utilisé pour la programmation géniale et méta/macro. Mais je ne suis pas d’accord. Scheme peut permettre beaucoup de choses intéressantes si un meilleur environnement de programmation est fourni. Et maintenant, vous pouvez [**COMMENCER ICI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Ce paquet est une implémentation du protocole du serveur de langage pour aider à la programmation Scheme. Il fournit la complétion, la définition et l’inférence de type. Ces fonctionnalités reposent sur une analyse statique du code conforme à la [norme r6rs](http://www.r6rs.org/) et à certaines règles évidentes pour les codes non aboutis. Ce paquet et les bibliothèques associées sont publiés ou vont l’être avec [Akku](https://akkuscm.org/), qui est un gestionnaire de paquets pour Scheme.

Ce paquet a également été testé avec [Chez Scheme](https://cisco.github.io/ChezScheme/) versions 9.4 et 9.5. Un test détaillé sur la version 10.0.0 sera effectué après la mise à jour de mon système d’exploitation.

Je réalise ce travail open source uniquement sur mon temps libre et je peux apporter de nombreuses idées brillantes à la communauté, comme l’intégration de l’analyse de flux de données à scheme-langserver ou bien d’autres choses. Et je sollicite continuellement plus de dons ou de financements. Vous pouvez faire un don via [cette page Patreon](https://www.patreon.com/PoorProgrammer/membership) ou [爱发电](https://afdian.com/a/ufo5260987423).


## Compilation, Installation & Configuration c’est [ICI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## État récent
Je vais continuer à corriger les bugs, profiler le code et collecter des informations pour mon ouvrage de référence sur les systèmes d’inférence de types faits maison. Cela me prendra environ 1 an. Les développements futurs incluent un plugin [VScode](https://code.visualstudio.com/) et l’analyse de flux de données. Mais en réalité, je considère maintenant ce travail open source comme un emploi à temps partiel, et je ne peux pas garantir un calendrier fixe.

## Release 
1.2.9 Maintenant, profitez de l’inférence de type !

Pour les versions précédentes, veuillez vous référer à [ce fichier](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Fonctionnalités
1. Complétion des identifiants de liaison de niveau supérieur et locaux.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Goto definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatible avec le gestionnaire de paquets : Akku.
4. Synchronisation des modifications de fichiers et mise à jour de l’index correspondant.
5. Hover.
6. Références et surlignage des documents (références au sein du document).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Symboles de document.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Capture des liaisons locales basées sur *-syntax (define-syntax, let-syntax, etc.). 
9. Indexation parallèle multiplateforme.
10. Annotateur de code source maison compatible avec les fichiers .sps.
11. Optimisation peephole pour les requêtes API avec tâche suspendable.
12. Inférence de type avec un interpréteur DSL fait maison (j’en suis très fier !). Et maintenant, elle est intégrée à l’autocomplétion. Comme le montre la figure suivante, "length-b" et "length-a", ayant le type "integer?", sont placés en tête des options recommandées car elles correspondent au type de paramètre attendu par "<=". 
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Un test peut prouver ce résultat, il suffit d’exécuter `scheme --script tests/protocol/apis/test-completion.sps` et le fichier log `scheme-langserver.log` contiendra des résultats comme ceci :
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interpréteur abstrait pour la capture d’identifiants entre différentes extensions de fichiers comme scm, ss, sps, sls et sld.

### TODOs
14. Renommage. 
15. Compatibilité totale avec la [norme r6rs](http://www.r6rs.org/).
16. Expandeur de macros étape par étape : en fait, j’en ai déjà implémenté un et je voulais en faire une étape clé pour capturer la liaison d’identifiant dans les macros auto-définies. Maintenant, je trouve que cette capture est bien plus difficile que je ne le pensais, et je ne sais pas où mon expandeur pourrait servir.
17. Évaluation de code.
18. Diagnostic de code.
19. Ajouter la prise en charge de la sémantique inter-langages. Eh bien, serait-il possible de supporter Java, C, Python et beaucoup d’autres langages avec un transformateur AST ?
20. Extraire des expressions/instructions dans une procédure.

## TODO : Contribution 

## Débogage

### Comment Déboguer
https://www.scheme.com/debug/debug.html#g1

### Journal de sortie (Output Log)
En suivant les conseils de [Compilation](#building), [Installation pour Lunar Vim](#installation-for-lunarvim) et [Installation pour VScode](#todo-installation-for-vscode), si quelqu’un souhaite développer et enregistrer des logs, il sera pratique d’ajouter `path-to-log-file` et de réécrire le fichier `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` comme suit :
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, une implémentation du protocole serveur de langage pour scheme
]]   ,
  },
```
### Exécution récurrente avec Log
Avec le [journal de sortie](#output-log) ci-dessus, vous pouvez utiliser `tests/log-debug.sps` pour reproduire des bugs :
1. Renommez `{path-to-log}` (généralement `~/scheme-langserver.log`) en `~/ready-for-analyse.log` ;
2. exécutez `scheme --script tests/log-debug.sps`. Si vous souhaitez reproduire l'environnement multi-thread, il est aussi possible d'exécuter `scheme --script tests/log-debug.sps`.

## Test
Presque toutes les procédures et API clés sont testées. Mon travail est encore brut mais utile, peut-être voudrez-vous voir ce que j'ai fait dans le répertoire `tests` ou simplement exécuter la commande suivante dans le `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>REMARQUE
Il est difficile de tester dans un environnement multi-thread. Donc, les tests actuels se concentrent sur un seul thread.

## Utiliser Scheme-langserver pour d'autres usages
### Script-Fu dans GIMP
Script-Fu est basé sur un langage interprété appelé Scheme, et fonctionne en utilisant des fonctions qui interagissent avec les fonctions internes de GIMP. En prenant le script de [cette page](https://dalelane.co.uk/blog/?p=628) comme exemple, vous pouvez appliquer scheme-langserver avec des fichiers script ayant l'extension "SCM".

### Autres

Eh bien, je m'intéresse aussi à [OMN (Opusmodus Notation)](https://opusmodus.com/) et à AutoLisp. Mais j'ai encore beaucoup de choses à faire.

## Comptage de code
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentation détaillée
1. [Scheme-langserver : Traiter l'édition de code Scheme comme une priorité absolue](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Capter les liaisons d'identificateur](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronisation](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inférence de type](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsolète, et j'écris un livre en chinois à ce sujet)
5. [Analyse de l'API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historique des étoiles

[![Graphique d'historique des étoiles](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contributeurs

![Contributeurs](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---