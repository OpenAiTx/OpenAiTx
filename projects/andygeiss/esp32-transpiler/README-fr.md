# ESP32 Transpileur

[![Licence](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![Releases](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go Report Card](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![Maintenabilité](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## Objectif

L’[IDE Arduino](https://www.arduino.cc/en/Main/Software) est facile à utiliser.
Mais j’ai rencontré des problèmes comme la maintenabilité et la testabilité sur des projets IoT plus complexes.
Je devais compiler et flasher l’ESP32 avant de tester la fonctionnalité de mon code en le faisant 100% manuellement.

Cette solution transpile du Golang en code Arduino, qui peut être compilé en image en utilisant la chaîne d’outils ESP32.
Maintenant, je peux utiliser une approche de test entièrement automatisée au lieu de le faire 100% manuellement.

**Important** :

Le Transpileur ne supporte qu’un petit sous-ensemble de la [spécification du langage Golang](https://golang.org/ref/spec).
Consultez le [mapping](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go) et les [tests](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go) pour connaître la fonctionnalité actuelle.
Il n’est pas non plus possible de déclencher le ramasse-miettes C/C++, car Golang le gère automatiquement « sous le capot ».
Les chaînes Go seront transpilées en tableaux constants de caractères C, qui pourront être gérés sur la pile.

### Prérequis

1. Installez la dernière version de [Go](https://golang.org/dl/).
2. Installez la dernière version de [Just](https://github.com/casey/just).
3. Incluez `$HOME/bin` dans votre `$PATH`.

## Installation

Clonez le dépôt et installez le binaire `esp32-transpiler` dans `$HOME/bin` :

    just install

## Utilisation

Transpilez un fichier source Golang en un fichier sketch Arduino :

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-18

---