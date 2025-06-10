# Outil de Traduction de Captures d'Écran par IA (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Introduction

Cet outil permet, via une **simple opération de capture d'écran**, d'envoyer une image à un modèle d’IA pour la reconnaissance et la traduction de texte. Le résultat de la traduction est affiché dans une fenêtre indépendante au format HTML interactif.

L’outil prend en charge **le déclenchement par raccourci clavier personnalisé, la gestion multi-fenêtres des résultats ainsi que le fonctionnement dans la barre système**, ce qui améliore considérablement l’efficacité de traduction au quotidien au travail ou lors des études.

**Caractéristiques de l’outil** : 1. Traduction par capture d’écran, démarrage par raccourci clavier ; 2. Capture et traduction en patchs, possibilité de déplacer et de redimensionner librement, possibilité de créer plusieurs groupes de patchs de traduction ; 3. Les formules peuvent être basculées en texte brut pour faciliter la copie ; 4. Interface API personnalisable

**Problèmes à résoudre** : 1. Les solutions majeures de traduction de documents complets sont souvent lourdes ; 2. En copiant-collant le texte d’un PDF, les blocs de formules sont parfois désordonnés ou impossibles à copier ; 3. Pour les PDF issus de numérisations d’images, il est impossible de copier le texte

# Démonstration

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Présentation des fenêtres

Fenêtre de traduction :

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Fenêtre de configuration :

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Pour une présentation plus détaillée des options de configuration, veuillez consulter le logiciel ou la page web [Conseils](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Installation

Vous pouvez choisir de télécharger et d’exécuter le code source, ou de vous rendre sur la page [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) pour télécharger le fichier exécutable.

### 1. Cloner le dépôt

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Créer un environnement virtuel et exécuter

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Feuille de route

- ~~Ajout d’une fenêtre graphique pour la configuration de l’API, optimisation de la logique de configuration manuelle du fichier yaml pour un processus automatisé par le logiciel (terminé en v0.3.0)~~
- Ajout d’un système de stockage d’images et de formules pour un usage ultérieur (prévu pour v0.4)
- (D’autres fonctionnalités sont les bienvenues via issue ou PR)

# Divers

- L’icône du logiciel provient de [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Merci à Gemini 2.5 Flash et DeepSeek-V3-0324 pour leur aide dans la détection de bugs

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---