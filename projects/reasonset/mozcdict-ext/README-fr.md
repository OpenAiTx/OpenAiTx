# mozcdict-ext

Convertir des mots externes en dictionnaire système Mozc

# 概要

Ce groupe d'outils a été initialement créé pour être utilisé comme « solution d'urgence » afin de compenser la perte de Mozc-UT (Mozcdic-UT).  
Il vise désormais à construire un environnement de conversion plus confortable grâce à une approche différente de Mozc-UT.

Ce groupe d'outils construit un dictionnaire système Mozc à partir de ressources externes à Mozc.  
En l'intégrant à Mozc et en le compilant, il est possible d'augmenter le vocabulaire de Mozc.

Le logiciel ne *contient pas* le dictionnaire généré de cette manière.  
De plus, il *ne contient pas non plus le corps principal de Mozc*.

À l'origine, ce logiciel a été créé comme un « palliatif » d'urgence, mais il est maintenant développé selon une politique légèrement différente de celle de Mozc-UT.

Les principales différences avec Mozcdic-UT sont les suivantes :

* C'est un projet ouvert sous licence GPL v3  
* Le logiciel est un outil de génération de dictionnaire, pas le dictionnaire généré lui-même  
* Mozcdic-UT vise uniquement les noms communs, tandis que Mozcdict-EXT ne limite pas les catégories grammaticales  
* En plus du convertisseur de dictionnaire web, il possède un dictionnaire ByHand compilé manuellement

# 使い方

## Génération de base

Les fichiers `mkdict.zsh` ou `mkdict.rb` dans chaque répertoire génèrent le dictionnaire converti et l’écrivent sur la sortie standard.

À ce moment, il est nécessaire de satisfaire les conditions suivantes :

* L’exécution du script doit se faire en ayant pour répertoire courant celui où se trouve le script  
* La variable d’environnement `$MOZC_ID_FILE` doit contenir le chemin vers le fichier `id.def` de Mozc

Le fichier `id.def` se trouve dans `src/data/dictionary_oss/id.def` de Mozc.  
Ce fichier *n’est pas inclus dans ce logiciel.*  
Puisqu’il est nécessaire d’avoir Mozc pour la compilation, il est recommandé d’obtenir et de mettre à jour le dépôt de Mozc au préalable.

Le contenu ainsi écrit sur la sortie standard peut être traité comme un dictionnaire système Mozc,  
et peut être inclus en le compilant dans le dictionnaire système.
La recommandation est d’ajouter dans `src/data/dictionary_oss/dictionary09.txt`.

## Mise en forme finale

Lorsqu’on génère plusieurs dictionnaires, il est préférable d’appliquer une mise en forme couvrant plusieurs dictionnaires.

`.dev.utils/uniqword.rb` lit les dictionnaires depuis `ARGF`, exclut les mots identiques incluant la catégorie grammaticale, et affiche le résultat sur STDOUT.
Les mots en double sont envoyés sur STDERR.

```bash
ruby uniqword.rb ~/dict/neologd.txt ~/dict/sudachi.txt > ~/dict/unified.txt
```
Mozcdic-UTとは異なり、固有名詞の生成を行うため、この作業は実施した方が良い。

## Dans le cas d'Archlinux

Un paquet AUR distinct nommé `fcitx5-mozc-ext-neologd` est disponible.

En installant ce paquet via AUR, il est possible de construire et d’installer Mozc avec un dictionnaire externe inclus.

À noter que ce paquet est indépendant de ce projet.

# Variables d'environnement

## `$MOZC_ID_FILE`

Obligatoire. Indique l'emplacement de `id.def` de MOZC.

## `$WORDCLASS_ROUND`

Lorsque aucune catégorie grammaticale exacte n'existe, arrondit à une catégorie plus générale.  
Spécifier `no` pour désactiver ce traitement.  
Fonctionne avec les outils dictionnaires suivants :

* sudachi

## `$ERROR_ON_UNEXPECTED_CLASS`

Génère une erreur si un mot avec une catégorie grammaticale inconnue est rencontré.  
Par défaut, aucune erreur n'est générée ; spécifier `yes` pour activer l'erreur.  
Fonctionne avec les outils dictionnaires suivants :

* sudachi

# Options d'exécution

## -e / --english

Par défaut, cet outil exclut la « conversion vers l’anglais ».  
L'option `-e` ou `--english` permet d'accepter les résultats de conversion en anglais.


## --english-proper

Si `--english` n'est pas utilisé mais que `--english-proper` l'est, l'anglais est autorisé uniquement s'il s'agit d'un nom propre.

## -P / --no-proper

Exclure les noms propres.

## -w / --fullwidth-english (neologd, sudachi)

Ne pas exclure la conversion en caractères anglais en pleine largeur et en kana demi-largeur.

Plus précisément, en temps normal, la correspondance avec l'expression régulière Onigmo `/^[\p{Symbol}\p{In_CJK_Symbols_and_Punctuation}\p{Punctuation}\p{White_Space}\p{In_Halfwidth_and_Fullwidth_Forms}]+$/` entraîne une exclusion, mais cette exclusion est désactivée.

## -W / --exclude-containing-fullwidth-english (byhand)

Exclure si des caractères anglais en pleine largeur ou des kana demi-largeur sont présents.

## --fullwidth-english-proper (neologd, sudachi)

Autoriser uniquement les noms propres si `--fullwidth-english` n'est pas utilisé.

## -s / --symbol

Habituellement, cet outil exclut les symboles qui perturbent la conversion,  
mais avec l'option `-s` ou `--symbol`, ils sont forcés d'être inclus dans la génération.

# Options par défaut

Si vous souhaitez modifier les options par défaut sans utiliser d'options en ligne de commande, vous pouvez définir les options par défaut via `config.yaml` dans le répertoire de configuration (`${XDG_CONFIG_HOME:-$HOME/.config}/mozcdict-ext`).

Par exemple, pour activer toujours `--fullwidth-english`, procédez comme suit.

```yaml
fullwidth-english: true
```

# Exclusion

Vous pouvez spécifier les motifs à exclure de l’ajout au dictionnaire en utilisant le fichier `exclude.txt` dans le répertoire de configuration.

La liste d’exclusion contient un motif par ligne, séparant le motif de lecture et le motif de forme de base par au moins un espace blanc consécutif.

Chaque motif est vérifié à l’aide de `File.fnmatch`.

Par exemple, pour exclure tous les candidats convertis commençant par la lecture `ゃ`

```
ゃ*    *
```

et ainsi de suite.

# Issues et PR

Si vous rencontrez un problème, veuillez le noter dans une Issue ou générer une Pull Request.

Cependant, je souhaite que vous compreniez que je crée ce logiciel de bonne volonté après y avoir déjà beaucoup contribué.
Autrement dit, je ne garantis pas de pouvoir répondre à toutes les Issues ou Pull Requests.
(Au moins, j’essaierai d’y répondre autant que possible.)

# Ajout de vocabulaire au dictionnaire ByHand et rapport de vocabulaire manquant

Si un mot ne peut pas être converti avec la dernière version de Mozc et tous les dictionnaires de ce logiciel activés, veuillez le signaler via [Rapport d’absence de vocabulaire Mozcdict Ext](https://mozc.chienomi.org).

Pour les mots qui ne peuvent pas être signalés depuis cette page, veuillez les rapporter via une issue.
De plus, si vous pouvez spécifier une catégorie grammaticale Mozc précise, créez une issue plutôt que d’utiliser cette page.

# Licence et empaquetage

Ce logiciel est sous licence GPL v3.
Vous êtes libre de copier et d’utiliser ce logiciel.

En revanche, je ne peux être tenu responsable en cas de problème ou de défauts dans ce logiciel.
Comme tout le monde le sait bien, il est fourni SANS AUCUNE GARANTIE.

Ce logiciel fournit uniquement un outil de génération de dictionnaire.
Cependant, si vous souhaitez le distribuer en tant que distribution, ce sera probablement Mozc construit avec cet outil.
Mozc ainsi construit n’est pas du tout lié à la licence de cet outil.
Car cet outil n’est pas inclus dans Mozc.
Un tel paquet devra respecter la licence et les règles de Mozc ainsi que des ressources utilisées en tant que dictionnaires externes.
Je ne garantis pas non plus que cette distribution soit possible.

# État actuel des progrès

* NEologd - Fonctionnel
* Sudachi - Généré seulement pour certaines catégories grammaticales (expérimental, en développement)

# Remarques importantes

* Ce logiciel ne se porte aucunement garant de la licence ni de la légitimité des dictionnaires générés par ce logiciel.

# Ce qui nécessite particulièrement une contribution

Le fichier `clsmap.yaml` de sudachi (conversion de la classification des parties du discours de Sudachi vers celle de Mozc)

En utilisant `utils/dev-by-cls.rb`, les mots sont classés par partie du discours et exportés sous `.dev.reference/sudachi-cls` (spécifié dans `.gitignore`), ce qui sert de référence pour affiner la classification des parties du discours.

# Dépendances

* Ruby >= 3.0
* Zsh
* xz(1)
* curl(1)
* Git (Sous-modules)

# À propos des dictionnaires

## neologd

Il s'agit d'un dictionnaire basé sur mecab-ipadic-NEologd.

## sudachi

Il s'agit d'un dictionnaire réutilisant celui du logiciel d'analyse morphologique Sudachi.

L’utilisation pour les parties du discours autres que les noms est prévue, mais actuellement en pause.

## byhand

Il s'agit d'un dictionnaire compilé manuellement pour les mots qui ne peuvent pas être convertis ou sont difficiles à convertir avec neologd ou sudachi.

En principe, il ne contient que des mots généraux figurant dans les petits dictionnaires de langue japonaise, sans noms propres.

## Mozc Common User Dict

[Mozc Common User Dict](https://github.com/reasonset/mozc-common-user-dict) est un dictionnaire utilisateur général qui complète ce projet.

Les mots difficiles à inclure dans byhand pour une raison quelconque sont inclus ici.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---