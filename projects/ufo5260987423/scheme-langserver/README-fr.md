<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Vous pouvez lire mon [article](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) et le citer ainsi :
> WANG, Z. (2025, 12 mai). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

En raison du fait que GitHub peut bloquer les adresses IP chinoises, j'ai dû copier ce dépôt [ici](https://codeberg.org/ufo5260987423/scheme-langserver) et [ici](https://gitee.com/ufo5260987423/scheme-langserver). Je continuerai à mettre à jour tous les dépôts mais je ne peux pas garantir la synchronisation. Je collabore également avec [XmacsLabs](https://github.com/XmacsLabs), vous pouvez aussi trouver un fork [ici](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Désormais, VSCode peut utiliser scheme-langserver !** Veuillez vous référer [ICI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>REMARQUE : Il y a de très nombreux bugs dans scheme-langserver. Je suis en train de les corriger et je sollicite l'aide de la communauté. Merci de votre patience.

>REMARQUE : vous pouvez trouver les informations de types générées automatiquement [ici](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). C'est actuellement utilisé principalement pour le développement ultérieur (peut-être incluant AKKU) et le débogage.

Implémenter des fonctionnalités telles que l’autocomplétion, le "goto definition" ou la documentation au survol représente un effort considérable en programmation. Cependant, comparé à d'autres langages comme Java, Python, Javascript ou C, l’implémentation du protocole de serveur de langage pour les langages Lisp se fait quasiment dans le vide. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) et [swish-lint](https://github.com/becls/swish-lint) etc., leurs travaux sont tous basés sur le `repl` (Read-Eval-Print Loop) ou un tokeniseur de mots-clés au lieu d'une analyse réelle du programme. Par exemple, si un programmeur travaille sur un projet non terminé dont le code n'est pas pleinement exécutable, [Geiser](https://gitlab.com/emacs-geiser) ou d’autres ne compléteront que les identifiants de liaison de niveau supérieur listés par la procédure `environment-symbols` (pour [Chez](https://cisco.github.io/ChezScheme/)), ou compléteront uniquement les symboles au lieu des identifiants. Ce qui signifie que pour les liaisons locales et le code non abouti, bien qu’un travail de fond sur la programmation soit censé être primordial, [Geiser](https://gitlab.com/emacs-geiser) et ses équivalents n’aident pas à reconnaître la portée valide des identifiants. Des cas similaires apparaissent avec le "goto definition" et beaucoup d’autres fonctionnalités.

Une raison principale est que, pour Scheme et d’autres dialectes Lisp, l’abondance de jeux de données et la flexibilité des structures de contrôle rendent l’analyse de programme très complexe. En particulier les macros, il semble que Scheme soit surtout utilisé pour la programmation de génie et la méta/macro-programmation. Mais je dis non. Scheme peut permettre beaucoup de choses intéressantes si un meilleur environnement de programmation est fourni. Et maintenant vous pouvez [**DÉMARRER ICI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Ce paquet est une implémentation du protocole de serveur de langage facilitant la programmation en Scheme. Il fournit l’autocomplétion, la définition et l’inférence de types. Ces fonctionnalités sont basées sur une analyse statique du code conforme à la [norme r6rs](http://www.r6rs.org/) et quelques règles évidentes pour le code inachevé. Ce paquet et les bibliothèques associées sont publiés ou vont l’être via [Akku](https://akkuscm.org/), qui est un gestionnaire de paquets pour Scheme.

Ce paquet a aussi été testé avec [Chez Scheme](https://cisco.github.io/ChezScheme/) versions 9.4 et 9.5. Un test détaillé sur la version 10.0.0 sera effectué après la mise à jour de mon système d'exploitation.

Je réalise ce travail open source uniquement sur mon temps libre et je peux apporter beaucoup d’idées brillantes à la communauté, comme l'intégration de l’analyse de flux de données dans scheme-langserver ou bien d’autres choses. Et je demande continuellement des dons ou financements. Vous pouvez faire un don via [cette page patreon](https://www.patreon.com/PoorProgrammer/membership) ou [爱发电](https://afdian.com/a/ufo5260987423).


## Compilation, Installation & Configuration [ICI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Statut actuel
Je continuerai à corriger les bugs, à profiler le code et à recueillir des informations pour mon livre géant sur les systèmes d’inférence de types faits maison. Cela me prendra environ 1 an. Les développements futurs incluent un plugin [VScode](https://code.visualstudio.com/) et l’analyse de flux de données. Mais en réalité, je considère désormais ce travail open source comme un emploi à temps partiel, et je ne peux pas garantir un calendrier.

## Release
1.2.9 Maintenant, profitez de l’inférence de types !

Pour les versions précédentes, veuillez vous référer à [ce fichier](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Fonctionnalités
1. Autocomplétion des liaisons d’identifiants de niveau supérieur et local.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Goto definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatible avec le gestionnaire de paquets : Akku.
4. Synchronisation des modifications de fichiers et modification de l’index correspondant.
5. Survol (hover).
6. Références et surlignage de document (références à l’échelle du document).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Symboles du document.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Prise en compte des liaisons locales d’identifiants basées sur *-syntax (define-syntax, let-syntax, etc.).
9. Indexation parallèle multiplateforme.
10. Annotateur de code source fait maison compatible avec les fichiers .sps.
11. Optimisation peephole pour les requêtes d’API avec tâche suspendable.
12. Inférence de types avec un interpréteur DSL maison (j’en suis très fier !). Et maintenant, cela a été intégré à l’autocomplétion. Comme indiqué dans la figure suivante, les “length-b” et “length-a” de type “integer?” sont en tête des options recommandées car elles correspondent au type de paramètre requis par “<=”.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Un test peut prouver ce résultat, il suffit d’exécuter `scheme --script tests/protocol/apis/test-completion.sps` et le fichier journal `scheme-langserver.log` contiendra des résultats comme celui-ci :
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interpréteur abstrait pour la détection d’identifiants entre différentes extensions de fichiers comme scm, ss, sps, sls et sld.

### TODOs
14. Renommage.
15. Pleine compatibilité avec la [norme r6rs](http://www.r6rs.org/).
16. Macro-expanseur pas à pas : eh bien, j’en ai effectivement implémenté un et je voulais en faire une étape clé pour détecter la liaison des identifiants dans les macros auto-définies. Maintenant, je me rends compte que cette détection est bien plus difficile que prévu, et je ne sais pas où l’expanseur pourrait réellement fonctionner.
17. Évaluation de code.
18. Code de diagnostic.
19. Ajouter la prise en charge sémantique multilingue. Eh bien, Java, C, Python et de nombreux autres langages peuvent-ils être pris en charge avec un transformateur AST ?
20. Extraire des expressions/instructions dans une procédure.

## TODO : Contribution

## Débogage

### Comment déboguer
https://www.scheme.com/debug/debug.html#g1

### Journal de sortie
En suivant les conseils de [Compilation](#building), [Installation pour Lunar Vim](#installation-for-lunarvim) et [Installation pour VScode](#todo-installation-for-vscode), si quelqu’un souhaite faire du développement et consigner des informations, il sera pratique d’ajouter `chemin-vers-le-fichier-log` et de réécrire le fichier `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` comme suit :
```lua
local util = require 'lspconfig.util'
local bin_name = '{chemin-vers-exécutable}'
local cmd = { bin_name ,"chemin-vers-le-fichier-log"}

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
`scheme-langserver`, une implémentation du protocole Language Server pour scheme
]]   ,
  },
}
```
### Rejouer avec le journal 
Avec le [journal de sortie](#output-log) ci-dessus, vous pouvez utiliser `tests/log-debug.sps` pour reproduire les bugs :
1. Renommez `{chemin-vers-le-log}` (généralement `~/scheme-langserver.log`) en `~/ready-for-analyse.log` ;
2. Exécutez `scheme --script tests/log-debug.sps`. Si vous souhaitez reproduire l’environnement multithread, il est également possible d’exécuter `scheme --script tests/log-debug.sps`.

## Test
Presque toutes les procédures et API clés sont testées. Mon travail est assez rudimentaire mais utile, peut-être voudrez-vous voir ce que j’ai fait dans le répertoire `tests` ou simplement exécuter la commande suivante dans `{répertoire-racine-scheme-langserver}`
``` bash
bash test.sh
```
> REMARQUE  
Il est difficile de tester dans un environnement multithread. Ainsi, les tests actuels se concentrent sur un seul thread.

## Utiliser Scheme-langserver à d'autres fins
### Script-Fu dans GIMP
Script-Fu est basé sur un langage interprété appelé Scheme et fonctionne en utilisant des fonctions qui interagissent avec les fonctions internes de GIMP. En prenant comme exemple le script de [cette page](https://dalelane.co.uk/blog/?p=628), vous pouvez appliquer scheme-langserver avec un fichier script portant l’extension "SCM".

### Autres

Eh bien, je m'intéresse aussi à [OMN (Opusmodus Notation)](https://opusmodus.com/) et à AutoLisp. Mais j’ai encore beaucoup de choses à faire.

## Comptage du code
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentation détaillée
1. [Scheme-langserver : Considérer l’édition de code Scheme comme une préoccupation de premier ordre](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Capturer les liaisons d’identificateurs](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronisation](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inférence de types](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsolète, et j’écris un livre en chinois à ce sujet)
5. [Analyse des API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historique des étoiles

[![Graphique de l’historique des étoiles](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contributeurs

![Contributeurs](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---