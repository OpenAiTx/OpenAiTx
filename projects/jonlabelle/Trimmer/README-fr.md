# Trimmer

[![ci](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml)
[![Package Control Installs](https://img.shields.io/packagecontrol/dt/Trimmer.svg?label=installs)](https://packagecontrol.io/packages/Trimmer)
[![Latest Release](https://img.shields.io/github/tag/jonlabelle/Trimmer.svg?label=version)](https://github.com/jonlabelle/Trimmer/releases)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jonlabelle/Trimmer/blob/master/LICENSE.md)

> [Trimmer](https://github.com/jonlabelle/Trimmer) est un plug-in pour [Sublime Text](http://www.sublimetext.com) permettant de nettoyer les espaces blancs.

## Fonctionnalités

- Supprimer les espaces blancs à la fin de chaque ligne.
- Supprimer les espaces blancs au début de chaque ligne.
- Supprimer les espaces blancs au début et à la fin de chaque ligne.
- Supprimer les espaces blancs des sélections.
- Supprimer les lignes vides ne contenant que des espaces blancs.
- Réduire plusieurs lignes vides consécutives en une seule ligne vide.
- Réduire plusieurs espaces consécutifs en un seul espace.
- Supprimer les lignes vides ne contenant que des espaces blancs au début et à la fin du fichier.
- Supprimer les caractères d’espacement.
- Normaliser les espaces (réduction des espaces consécutifs, suppression des lignes vides et suppression des espaces en début et fin de ligne).
- Tokeniser une chaîne en réduisant les espaces consécutifs, et en supprimant les espaces en début et fin de chaîne.
- Supprimer les balises HTML et XML vides ne contenant que des espaces blancs.
- Supprimer les commentaires de code et réduire les lignes.
- Supprimer les lignes dupliquées adjacentes.

## Fonctionnalités supplémentaires

Une commande **Remplacer les caractères intelligents** qui effectue les actions suivantes :

- **Guillemets simples intelligents :** `’` _vers_ `'`
- **Guillemets doubles intelligents :** `“` _vers_ `"`
- **Prime :** `′` _vers_ `'`
- **Double prime :** `″` _vers_ `"`
- **Guillemets allemands :** `„` _vers_ `"` et `‚` _vers_ `'`
- **Points de suspension :** `…` _vers_ `...`
- **Tiret cadratin :** `—` _vers_ `---`
- **Tiret demi-cadratin :** `–` _vers_ `--`
- **Puces :** `•` _vers_ `*`
- **Point médian :** `·` _vers_ `-`
- **Espace cadratin** _en_ trois espaces  
- **Espace demi-cadratin** _en_ deux espaces  
- **Espace insécable** _en_ un espace  
- **Espace fine** _en_ un espace  
- **Espace cheveu** _en_ un espace  
- **Guillemet ouvrant :** `«` _en_ `<<`  
- **Guillemet fermant :** `»` _en_ `>>`  
- **Symbole copyright :** `©` _en_ `(C)`  
- **Symbole marque déposée :** `™` _en_ `(T)`  
- **Symbole marque enregistrée :** `®` _en_ `(R)`  

![Capture d’écran](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)  

Regardez une [**Démonstration rapide**](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/demo.gif)  

## Installation  

Trimmer est compatible avec Sublime Text 2 et 3 ainsi qu’avec tous les systèmes d’exploitation supportés.  

### Package Control  

La méthode la plus simple et recommandée pour installer Trimmer est d’utiliser [Package Control](https://packagecontrol.io).  

Dans le menu principal de l’application, naviguez vers :  

- `Outils` -> `Palette de commandes...` -> `Package Control : Installer un package`, tapez  
  le mot **_Trimmer_**, puis sélectionnez-le pour terminer l’installation.  

### Git  

Pour installer Trimmer avec Git, rendez-vous dans votre répertoire **Packages de Sublime Text**  
et clonez le [dépôt Trimmer](https://github.com/jonlabelle/Trimmer).  

Par exemple, sur **OS X**… lancez une nouvelle session **Terminal** et saisissez les commandes suivantes :


```shell
$ cd ~/Library/Application\ Support/Sublime\ Text\ 3/Packages/
$ git clone https://github.com/jonlabelle/Trimmer
```

### Manuellement

**Téléchargez** et **extrayez** le [zip](https://github.com/jonlabelle/Trimmer/zipball/master)
ou [tarball](https://github.com/jonlabelle/Trimmer/tarball/master) dans votre
répertoire des packages de Sublime Text.

**Chemins par défaut des packages Sublime Text :**

- **OS X :** `~/Library/Application Support/Sublime Text [2|3]/Packages`
- **Linux :** `~/.Sublime Text [2|3]/Packages`
- **Windows :** `%APPDATA%/Sublime Text [2|3]/Packages`

> **NOTE** Remplacez la partie `[2|3]` par la version appropriée de Sublime Text
> pour votre installation.

## Utilisation

Toutes les commandes sont accessibles depuis la **Palette de commandes** avec le préfixe
**_Trimmer_**, et dans le **Menu principal** sous `Édition` -> `Ligne` -> commande _Trimmer_.

- [Capture d’écran de la Palette de commandes](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)
- [Capture d’écran du Menu principal](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/main_menu.png)

### Raccourcis clavier

Le raccourci _par défaut_ supprime les espaces en fin de ligne pour chaque
ligne (fichier entier).

- **OS X** : `Ctrl + S`
- **Linux** : `Ctrl + Alt + S`
- **Windows** : `Ctrl + Alt + S`

### API de la commande Trimmer

| Commande                          | Description                                                                                           | Contexte                  |
| -------------------------------- | --------------------------------------------------------------------------------------------------- | ------------------------- |
| `trimmer`                        | supprime les espaces en fin de chaque ligne                                                         | fichier entier            |
| `trim_leading_whitespace`        | supprime les espaces au début de chaque ligne                                                       | sélection, ou fichier entier |
| `trim_leading_trailing_whitespace` | supprime les espaces au début et à la fin de chaque ligne                                           | sélection, ou fichier entier |
| `trim_selections`                  | supprimer les espaces blancs des sélections                                                           | sélection                 |
| `delete_empty_lines`               | supprimer les lignes vides ou ne contenant que des espaces                                            | sélection, ou fichier entier |
| `collapse_lines`                   | réduire plusieurs lignes vides consécutives en une seule ligne vide                                   | sélection, ou fichier entier |
| `collapse_spaces`                  | réduire plusieurs espaces consécutifs en un seul espace                                              | sélection, ou fichier entier |
| `trim_edges`                       | supprimer les lignes vides ou ne contenant que des espaces au début et à la fin du fichier           | fichier entier            |
| `remove_blank_spaces`              | supprimer tous les caractères d'espacement (tabulation, cr, ff, vt, espace)                           | sélection, ou fichier entier |
| `normalize_spaces`                 | réduire les espaces consécutifs, supprimer les lignes vides et couper les lignes                     | sélection, ou fichier entier |
| `replace_smart_characters`         | remplacer les caractères spéciaux (guillemets typographiques, tirets cadratin/demi-cadratin, points de suspension, nbsp) | sélection, ou fichier entier |
| `tokenize_string`                  | convertir une chaîne en jeton en réduisant les espaces consécutifs et en supprimant les espaces en début et fin | sélection, ou fichier entier |
| `delete_empty_tags`                | supprimer les balises HTML et XML vides ou ne contenant que des espaces                              | sélection, ou fichier entier |
| `remove_comments`                  | supprimer les commentaires de code et réduire les lignes                                             | sélection, ou fichier entier |
| `delete_adjacent_duplicate_lines`  | supprimer les lignes dupliquées adjacentes                                                          | sélection, ou fichier entier |

## Auteur

[Jon LaBelle](https://jonlabelle.com)

## Licence

Trimmer est licencié sous la [licence MIT](http://opensource.org/licenses/MIT).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---