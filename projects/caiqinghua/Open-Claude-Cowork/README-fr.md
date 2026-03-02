# Exemple : Aidez-moi à organiser mon dossier de travail

https://github.com/user-attachments/assets/48743a51-705a-4c66-9fdb-4d7147f8098b


[简体中文](https://raw.githubusercontent.com/caiqinghua/Open-Claude-Cowork/main/README_ZH.md)

# Claude Cowork

Un **assistant IA de bureau** qui vous aide avec la **programmation, la gestion des fichiers, et toute tâche que vous pouvez décrire**.

Il est **entièrement compatible avec la même configuration que Claude Code**, ce qui signifie que vous pouvez l’exécuter avec **n’importe quel modèle de langage large compatible Anthropic**.

**✨ Pas d’abonnement Claude Max requis** - Prend en charge tout modèle API compatible Anthropic, y compris Zhipu GLM 4.7, MiniMax 2.1, Moonshot Kimi, DeepSeek, et plus encore.

> Pas seulement une interface graphique.  
> Un véritable partenaire de collaboration IA.  
> Pas besoin d’apprendre le SDK Claude Agent — créez simplement des tâches et choisissez les chemins d’exécution.


---

## ✨ Pourquoi Claude Cowork ?

Claude Code est puissant — mais il **ne fonctionne que dans le terminal**.

Cela signifie :
- ❌ Pas de retour visuel pour les tâches complexes
- ❌ Difficile de suivre plusieurs sessions
- ❌ Les sorties des outils sont peu pratiques à inspecter

**Open Claude Cowork résout ces problèmes :**

- 🖥️ Fonctionne comme une **application native de bureau**
- 🤖 Agit comme votre **partenaire de collaboration IA** pour toute tâche
- 🔁 Réutilise vos **paramètres existants `~/.claude/settings.json`**
- 🧠 **100% compatible** avec Claude Code

Si Claude Code fonctionne sur votre machine —  
**Open Claude Cowork fonctionne aussi.**

---

## 🚀 Démarrage rapide

> **💡 Astuce :** Cette application est entièrement compatible avec la configuration Claude Code. Aucun abonnement Claude Max n’est nécessaire - vous pouvez utiliser Zhipu GLM, MiniMax, Kimi, DeepSeek ou tout autre modèle API compatible Anthropic.

Avant d’utiliser Open Claude Cowork, assurez-vous que Claude Code est installé et correctement configuré.

### Option 1 : Télécharger une version

👉 [Aller aux versions](https://github.com/caiqinghua/open-claude-cowork/releases)

---

### Option 2 : Compiler depuis la source

#### Prérequis

- [Bun](https://bun.sh/) ou Node.js 22+
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code) installé et authentifié

```bash
# Clone the repository
git clone https://github.com/caiqinghua/open-claude-cowork.git
cd open-claude-cowork

# Install dependencies
bun install

# Configure environment (copy .env.example to .env)
cp .env.example .env

# Run in development mode
bun run dev

# Or build production binaries
bun run dist:mac    # macOS
bun run dist:win    # Windows
bun run dist:linux  # Linux
```

---

## 🧠 Capacités principales

### 🤖 Partenaire de collaboration IA — Pas seulement une interface graphique

Open Claude Cowork est votre partenaire IA qui peut :

* **Écrire et éditer du code** — dans n'importe quel langage de programmation
* **Gérer des fichiers** — créer, déplacer et organiser
* **Créer des PPT** — générer le contenu et la structure des présentations
* **Analyse thématique** — analyse approfondie des thèmes et directions de recherche
* **Rédaction d’articles** — écrire divers types d’articles et de documents
* **Faire n'importe quoi** — tant que vous pouvez le décrire en langage naturel

---

### 📂 Gestion des sessions

* Créer des sessions avec **répertoires de travail personnalisés**
* Reprendre toute conversation précédente
* Historique complet des sessions locales (stocké dans SQLite)
* Suppression sécurisée et persistance automatique

---

### 🎯 Sortie en streaming en temps réel

* **Sortie en streaming token par token**
* Voir le processus de raisonnement de Claude
* Rendu Markdown avec code en surbrillance syntaxique
* Visualisation des appels d’outils avec indicateurs de statut

---

### 🔐 Contrôle des permissions des outils

* Approbation explicite requise pour les actions sensibles
* Autoriser ou refuser par outil
* Panneaux de décision interactifs  
* Contrôle total sur ce que Claude est autorisé à faire  

---

## 🔁 Entièrement compatible avec Claude Code  

Open Claude Cowork **partage la configuration avec Claude Code**.  

Il réutilise directement :  

text  
~/.claude/settings.json  

Cela signifie :  

* Mêmes clés API  
* Même URL de base  
* Mêmes modèles  
* Même comportement  

**Les modèles supportés incluent :**  
- Zhipu GLM 4.7  
- MiniMax 2.1  
- Moonshot Kimi  
- DeepSeek  
- Tous les autres modèles compatibles API Anthropic  

> Configurez Claude Code une fois — utilisez-le partout.  

---

## 🔧 Dépannage  

### Erreur du module better-sqlite3  

Si vous rencontrez une erreur telle que :


```
Error: The module was compiled against a different Node.js version using
NODE_MODULE_VERSION 127. This version of Node.js requires NODE_MODULE_VERSION 140.
```

Cela se produit parce qu'Electron intègre sa propre version de Node.js et que les modules natifs doivent être recompilés pour celle-ci.

**Solution :**

```bash
# Install electron-rebuild as a dev dependency
npm install --save-dev electron-rebuild

# Rebuild better-sqlite3 for Electron
npx electron-rebuild -f -w better-sqlite3

# Run the app again
bun run dev
```
Cela garantit que les modules natifs sont compilés contre la version Node.js d'Electron plutôt que contre la version Node.js de votre système.

---

## 🧩 Vue d'ensemble de l'architecture

| Couche           | Technologie                   |
| ---------------- | ----------------------------- |
| Framework        | Electron 39                   |
| Frontend         | React 19, Tailwind CSS 4      |
| Gestion d'état   | Zustand                      |
| Base de données  | better-sqlite3 (mode WAL)     |
| IA               | @anthropic-ai/claude-agent-sdk |
| Build            | Vite, electron-builder        |

---

## 🛠 Développement

bash
# Démarrer le serveur de développement (rechargement à chaud)
bun run dev

# Vérification des types / build
bun run build


---

## 🗺 Feuille de route

Fonctionnalités prévues :

* Configuration GUI pour les modèles et les clés API
* 🚧 Plus de fonctionnalités à venir bientôt

---

## 🤝 Contribution


Les pull requests sont les bienvenues.

1. Forkez ce dépôt
2. Créez votre branche de fonctionnalité
3. Commitez vos modifications
4. Ouvrez une Pull Request

---

## ⭐ Mots de la fin

Si vous avez déjà voulu :

* Un partenaire de collaboration IA de bureau persistant
* Une vision visuelle de la façon dont Claude fonctionne
* Une gestion pratique des sessions entre projets

Ce projet est fait pour vous.

👉 **Si cela vous aide, merci de lui donner une étoile.**

---

## Licence

MIT





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-02

---