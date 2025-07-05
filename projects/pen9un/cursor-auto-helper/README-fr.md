<h1 align="center">Bienvenue sur&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Outil de continuation automatique pour Cursor, tentative automatique pour Cursor, confirmation automatique pour Cursor, statistiques d’utilisation de Cursor, outils d’amélioration pour Cursor, outils d’assistance pour Cursor, outils d’automatisation pour Cursor, configuration de thème Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor après 25 appels d’outils, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Page d’accueil](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper est un outil d'automatisation et d'amélioration spécialement conçu pour Cursor IDE, capable d'afficher en temps réel l'utilisation, de gérer automatiquement la limite de 25 dialogues, les échecs de connexion réseau, les confirmations, etc., pour rendre votre expérience de développement plus fluide.

**Vidéo de démonstration :** [Vidéo de démonstration Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Avec des prompts de haute qualité et une bonne planification des besoins du projet, ce programme permet à Cursor de réaliser automatiquement un projet sans intervention humaine.

> 🔒 **Compatibilité des versions** : Actuellement testé et développé sur Cursor 0.49.6 et Cursor 1.0.0, compatible en théorie avec les versions Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Journal des modifications

- 2025-06-01 : publication de la version v2.3, ajout de la fonction de configuration de thème Cursor, optimisation de la stabilité de l'injection de code, correction de l’affichage de l’utilisation pour correspondre au format officiel
- 2025-05-21 : publication de la version v2.1, refonte de l’architecture, prise en charge multiplateforme, ajout de l'affichage en temps réel de l’utilisation, etc.
- 2025-04-25 : finalisation de la version v1.0, gestion automatique de la limite de 25 dialogues, des échecs de connexion réseau, des confirmations, etc.
- 2025-04-20 : lancement du projet

## 🌟 Meilleures pratiques Cursor Auto Helper

Remarque : la documentation suivante peut être générée à l’aide de Cursor ou d’autres IA, une vérification et une adaptation humaines sont nécessaires.

**ÉTAPE 1 :** Conception détaillée des besoins système du projet (plus les besoins sont clarifiés, meilleure sera la qualité du projet), rédiger des prompts de développement de projet de haute qualité **SYSTEM.md**

**ÉTAPE 2 :** Sur la base de **SYSTEM.md**, produire un document de conception système de haute qualité **DESIGN.md**

**ÉTAPE 3 :** Sur la base de **SYSTEM.md** et **DESIGN.md**, produire un document de plan de développement de haute qualité **TODOLIST.md**

**ÉTAPE 4 :** Utiliser **Cursor Auto Helper**, spécifier **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, utiliser des prompts de continuation automatique pour permettre à Cursor d'automatiser le développement du projet selon le plan, jusqu'à l'achèvement

**Prompt de continuation automatique Cursor Auto Helper :**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Veuillez suivre strictement le plan de développement du TODOLIST pour le développement des fonctionnalités ultérieures, et mettre à jour en temps réel le plan de développement du TODOLIST. Après chaque tâche terminée, veuillez me demander "Continuer ?", jusqu’à ce que le projet soit terminé et retourner "Le projet est terminé".
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Instructions d’utilisation

Merci de soutenir avec un Star, en cas de problème veuillez soumettre une [Issue](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Explication du fichier de configuration

Le fichier de configuration `config.ini` **permet de personnaliser le comportement d’automatisation** (modifiable et testable selon vos besoins), les paramètres suivants sont pris en charge :

#### Configuration de base
```ini
[common]
log_enable = true     # Activer ou non le journal, mettre à false pour désactiver

[cursor]
path = C:\Path\To\Cursor.exe  # Chemin d'installation de Cursor IDE, le programme recherchera automatiquement le chemin de Cursor, un message s’affichera s’il n’est pas trouvé, il suffit de modifier ce champ
```

#### Configuration des actions automatiques
Chaque action automatique commence par le préfixe `nom_action.`, les champs suivants sont pris en charge :

- `type` : type d’action
  - `click` : cliquer sur un bouton
  - `input_and_submit` : saisir et soumettre

- `text` / `text_list` : contenu texte à associer
  - `text` : chaîne unique
  - `text_list` : plusieurs chaînes séparées par |, si le contenu de la page contient l’une des chaînes, l’action est déclenchée

- `button_selector` : sélecteur CSS du bouton à cliquer (nécessaire uniquement pour le type `click`)
- `button_text` : texte du bouton (optionnel, pour restreindre davantage le bouton)
- `input_box_selector` : sélecteur CSS de la zone de saisie (nécessaire pour le type `input_and_submit`)
- `input_content` : contenu à saisir automatiquement
- `submit_btn_selector` : sélecteur CSS du bouton de soumission
- `delay` : délai avant l’exécution de l’action (ms), utile pour attendre le rendu de la page

##### Exemple de configuration
```ini
[auto_actions]
# Réessayer automatiquement en cas d’échec de connexion
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# après 25 appels d’outils
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# Confirmation automatique de la poursuite
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Remarque :**
> 1. Le nom de chaque action (comme `action_retry`, `action_continue`) peut être personnalisé, mais tous les champs d'une même action doivent avoir le même préfixe
> 2. Il est recommandé d'utiliser l'outil de développement du navigateur pour localiser précisément les sélecteurs CSS
> 3. Après modification du fichier de configuration, il est nécessaire de redémarrer le programme pour que les changements prennent effet

## 🎯 Scénarios d’application

### 💼 Développement de longues conversations
- Gère automatiquement la limite de 25 dialogues, prend en charge le développement de conversations longues et continues, poursuit automatiquement le processus de dialogue, améliore l'efficacité de développement.

### 👥 Réseau instable
- Détecte automatiquement les anomalies réseau, retente intelligemment la connexion, rétablit automatiquement le dialogue, garantit la continuité du développement.

### 🏢 Scénarios de confirmation
- Détecte intelligemment les scénarios de confirmation, gère automatiquement les invites de confirmation, réduit l’intervention humaine.

### 📚 Surveillance de l’utilisation
- Compte en temps réel le nombre de dialogues, surveille l’utilisation de Cursor, enregistre les données d’utilisation, optimise l’efficacité d’utilisation.

Affichage de l’utilisation dans le terminal :

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Affichage de l’utilisation dans Cursor IDE :

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟 Description des fonctionnalités

### 🤖 Poursuite automatique des longues conversations
- Gère automatiquement la limite de 25 dialogues de Cursor, prend en charge des dialogues multi-tours en continu.

### 🎨 Reconnexion automatique
- Détecte automatiquement les échecs de connexion réseau, retente intelligemment, surveille en temps réel l’état de la connexion.

### 📱 Confirmation automatique des invites
- Détecte intelligemment divers scénarios de confirmation, gère automatiquement les fenêtres de confirmation.
- Prend en charge la personnalisation du contenu de confirmation et des réponses, réduit l’intervention humaine.
- Règles de configuration flexibles, adaptées à des processus de développement variés.

### 🛍️ Statistiques d’utilisation
- Compte en temps réel le nombre de dialogues et l’utilisation, enregistre automatiquement les données.
- Visualisation des données d’utilisation pour faciliter l’analyse et l’optimisation.
- Prise en charge de l’affichage des journaux colorés dans le terminal et d’un panneau d’utilisation dans l’IDE, améliore l’utilisabilité.

### 💡 Système de journalisation
- Journaux multi-niveaux (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), sortie colorée dans le terminal.
- Les fichiers journaux sont générés automatiquement par date, prise en charge de l’enregistrement et de l’affichage par glisser-déposer.
- Panneau en temps réel pour faciliter la surveillance et la traçabilité par les développeurs.

### 🔒 Compatibilité des versions et optimisation des performances
- Développé sur Cursor 0.49.6, toutes les fonctionnalités principales sont entièrement testées.
- Optimisé pour des versions spécifiques, suivi continu des mises à jour de Cursor.
- Grande stabilité, bonne compatibilité, adapté à un usage en production.

## 🔮 Démonstration des effets

### 🤖 Poursuite automatique du dialogue

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Démonstration de l’achèvement automatique dans Cursor

De la demande du projet à la réalisation complète, sans intervention humaine :

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝 Auteur

👤 **pen9un**

* Site Web : https://github.com/pen9un/
* Github : [@pen9un](https://github.com/pen9un)

## ❤️ Soutien

Si vous trouvez ce projet utile, merci de laisser une petite étoile gratuite ⭐️⭐️

## ✨ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Statistiques de visite

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---