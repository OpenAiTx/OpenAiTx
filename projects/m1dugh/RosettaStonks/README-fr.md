
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introduction](#introduction)
- [Installation](#install)
  - [Chrome](#chrome-based-browsers)
    - [Guide visuel](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [Comment utiliser](#how-to-use)
  - [Ajout de temps](#adding-time)
    - [Fondations](#adding-time-in-foundations)
    - [Générateur de fluidité](#adding-time-in-fluency-builder)
  - [Validation de leçon](#validating-lesson)
    - [Fondations](#validating-lesson-in-foundations)
    - [Générateur de fluidité](#validating-lesson-in-fluency-builder)

## Introduction

RosettaStonks est une extension de navigateur qui permet d’ajouter du temps et de valider
des leçons sur la plateforme d’apprentissage de langues Rosetta Stone.

> RosettaStonks, et votre rosetta stone devient stonks.

## Installation

### Navigateurs basés sur Chrome

➡️ **Nouveau pour installer manuellement des extensions Chrome ?** Consultez le [Guide visuel étape par étape](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — inclut des captures d’écran utiles ! 🖼️

#### 1. Utilisation de la version GitHub

Pour utiliser l’extension sur un navigateur basé sur Chrome, vous devez :

- télécharger le fichier `rosettastonks-chrome.tar.gz` depuis la dernière version
  sur votre ordinateur.
- créer un dossier nommé `rosettastonks` quelque part sur votre ordinateur pour stocker
  l’extension
- exécuter la commande suivante dans le dossier `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Utilisation du gestionnaire de paquets nix

Au lieu des commandes précédentes, si vous êtes sur un système nix **prenant en charge
flakes**, vous pouvez exécuter les commandes suivantes, qui installeront un dossier
sous le chemin `/tmp/rosettastonks` avec tous les fichiers.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Le dossier est maintenant installé sous `/tmp/rosettastonks/`

**Cette partie est pour tous les utilisateurs, indépendamment de la méthode utilisée, github ou nix.**

Dans votre navigateur :

- allez à `chrome://extensions`
- activez l'interrupteur `Mode développeur`
- cliquez sur `Charger l'extension non empaquetée`
- Sélectionnez votre dossier `rosettastonks`

### Navigateurs basés sur Firefox

- téléchargez le fichier `rosettastonks.xpi` depuis la dernière version.
- alternativement, si vous utilisez le gestionnaire de paquets nix avec le support flake, vous pouvez exécuter
  la commande suivante.


```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- allez à `about:addons` dans votre navigateur  
- cliquez sur le bouton des paramètres et allez à `Déboguer les modules complémentaires`.  
- cliquez sur `Charger un module complémentaire temporaire`  
- sélectionnez le fichier `/tmp/rosettastonks.xpi` dans le sélecteur de fichiers.  

_Attention : Cette méthode installe l’extension uniquement temporairement, ce qui signifie que si  
vous fermez votre navigateur, le module complémentaire sera désinstallé. Cela est dû aux politiques  
de Firefox qui n’autorisent pas l’utilisation d’extensions non vérifiées._  

## Comment utiliser  

### Ajouter du temps  

#### Ajouter du temps dans Foundations  

Pour ajouter du temps sur le produit `foundations`, vous devez aller à vos exercices, et  
cliquer sur ignorer ou résoudre au moins une question. Une fois cela fait, un champ de temps  
devrait apparaître sur la page de l’extension où vous pouvez ajouter votre temps.  

#### Ajouter du temps dans Fluency builder  

Pour ajouter du temps sur le produit `fluency builder`, vous devez aller à vos exercices, et  
répondre à au moins un exercice. Si le champ d’ajout de temps n’apparaît pas, cela signifie  
qu’aucune demande de temps n’a été détectée, vous devez actualiser la question et y répondre  
à nouveau. Pour que le temps soit ajouté, vous devez terminer la leçon que vous avez utilisée  
pour ajouter du temps.  

_Remarque : Si vous ne voyez pas le champ d’ajout de temps, cela signifie que les actions que vous avez prises  
sur le site Rosetta Stone n’ont pas conduit à l’ajout de temps légitime, et par conséquent,  
vous devez répondre à d’autres questions._  

### Valider la leçon  

#### Valider la leçon dans Foundations  

Pour valider une leçon, il faut commencer une leçon, et passer par toutes les  
questions en utilisant le bouton `ignorer` en bas à droite. Une fois que toutes les  
questions ont été vues, cliquer sur le bouton `valider la leçon` devrait valider  
la leçon. Sinon, retournez à votre page d’accueil, cliquez sur la même leçon, il

devrait vous demander `Voulez-vous continuer ou réinitialiser ?`, vous pouvez choisir les deux, et  
valider la leçon à nouveau jusqu'à ce que cela fonctionne. Cela devrait fonctionner après 3/4 tentatives maximum.  

#### Validation de la leçon dans Fluency builder  

Pour le moment, la fonction de validation de la leçon n'est pas disponible sur rosetta stonks.  

## Construction de l'application  

### Construction du worker  

Le worker peut être empaqueté en utilisant la commande suivante  

```
$ deno task build:worker
```

Ce qui crée le fichier empaqueté `/dist/worker.esm.js` qui est le fichier empaqueté
pour le worker.

### Construction du frontend

Le worker peut être empaqueté en utilisant la commande suivante

```
$ deno task build:frontend
```

Ce qui crée le fichier empaqueté `/dist/frontend.esm.js` qui est le fichier
empaqueté pour le frontend.

## Emballage de l'extension

### Chrome

Pour empaqueter l'extension pour Chrome, la commande suivante peut être exécutée :

```
$ make chrome
```

### Firefox

Pour empaqueter l'extension pour Firefox, la commande suivante peut être exécutée :

```
$ make firefox
```

Ce qui produira `rosettastonks.xpi`, le fichier de l'extension pouvant être
chargée dans Firefox.

📸 Vous préférez les visuels ? Consultez le [Guide d'installation Chrome avec images](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---