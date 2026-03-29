<h1 align="center"><img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="" width="64" style="vertical-align: middle;">&nbsp; CLI-Anything : Rendre TOUS les logiciels natifs pour agents</h1>

<p align="center">
  <strong>Les logiciels d'aujourd'hui servent les humains👨‍💻. Les utilisateurs de demain seront des agents🤖.<br>
CLI-Anything : Combler le fossé entre les agents IA et les logiciels du monde</strong><br>
</p>

**🌐 [CLI-Hub](https://hkuds.github.io/CLI-Anything/)** : Explorez toutes les CLI créées par la communauté et installez-les en une seule commande sur le **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)**. Vous souhaitez ajouter la vôtre ? [Ouvrez une PR](https://github.com/HKUDS/CLI-Anything/blob/main/CONTRIBUTING.md) — le hub se met à jour instantanément.

<p align="center">
  <a href="#-quick-start"><img src="https://img.shields.io/badge/Quick_Start-5_min-blue?style=for-the-badge" alt="Démarrage rapide"></a>
  <a href="https://hkuds.github.io/CLI-Anything/"><img src="https://img.shields.io/badge/CLI_Hub-Browse_%26_Install-ff69b4?style=for-the-badge" alt="CLI Hub"></a>
  <a href="#-demonstrations"><img src="https://img.shields.io/badge/Demos-16_Apps-green?style=for-the-badge" alt="Démonstrations"></a>
  <a href="#-test-results"><img src="https://img.shields.io/badge/Tests-1%2C839_Passing-brightgreen?style=for-the-badge" alt="Tests"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="Licence"></a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/python-≥3.10-blue?logo=python&logoColor=white" alt="Python">
  <img src="https://img.shields.io/badge/click-≥8.0-green" alt="Click">
  <img src="https://img.shields.io/badge/pytest-100%25_pass-brightgreen" alt="Pytest">
  <img src="https://img.shields.io/badge/coverage-unit_%2B_e2e-orange" alt="Couverture">
  <img src="https://img.shields.io/badge/output-JSON_%2B_Human-blueviolet" alt="Sortie">
  <a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/Feishu-Group-E9DBFC?style=flat&logo=feishu&logoColor=white" alt="Feishu"></a>
<a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/WeChat-Group-C5EAB4?style=flat&logo=wechat&logoColor=white" alt="WeChat"></a>
</p>

**Une ligne de commande** : Rendez n'importe quel logiciel prêt pour agent avec OpenClaw, nanobot, Cursor, Claude Code, etc.&nbsp;&nbsp;[**Documentation en chinois**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_CN.md) | [**Documentation en japonais**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_JA.md)

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/cli-typing.gif" alt="Démonstration de frappe CLI-Anything" width="800">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/teaser.png" alt="Bande-annonce CLI-Anything" width="800">
</p>

---

## 📰 Actualités

> Merci à tous pour les efforts inestimables de la communauté ! De nouvelles mises à jour arrivent continuellement chaque jour..

- **2026-03-23** 🤖 Lancement de la **meta-compétence CLI-Hub** — les agents peuvent désormais découvrir et installer des CLI de manière autonome via [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md). Le catalogue se met à jour automatiquement depuis `registry.json` via GitHub Actions, rendant tout le marché natif aux agents.

- **2026-03-22** 🎵 **MuseScore CLI** fusionné avec transposition, export et gestion des instruments. Les contributions de la communauté continuent d’étendre la couverture des domaines.

- **2026-03-21** 🔧 Améliorations de l’infrastructure — affinement des bancs de test et de la documentation sur plusieurs CLI. Compatibilité Windows améliorée pour plusieurs backends.

- **2026-03-20** 🌐 Ajout de la CLI **Novita AI** pour un accès API compatible OpenAI. Améliorations des métadonnées du registre pour une meilleure découverte du hub.

- **2026-03-19** 📦 Raffinements de la structure des paquets à travers les bancs de test. Amélioration de la génération SKILL.md avec une meilleure documentation des commandes.

- **2026-03-18** 🧪 Extension de la couverture des tests — scénarios E2E supplémentaires et validation des cas limites sur plusieurs CLI.

- **2026-03-17** 🌐 Lancement du **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)** — un registre central où vous pouvez parcourir, rechercher et installer n’importe quel CLI avec une simple commande `pip`. Les contributeurs peuvent ajouter de nouveaux CLI ou mettre à jour les existants en ouvrant simplement une PR avec une entrée `registry.json`. Le hub se met à jour automatiquement à chaque fusion.

<details>
<summary>Actualités antérieures</summary>

- **2026-03-16** 🤖 Ajout de la **génération SKILL.md** (Phase 6.5) — chaque CLI généré est maintenant livré avec une définition de compétence détectable par IA à l’intérieur du paquet Python. ReplSkin détecte automatiquement le fichier skill après `pip install`, et la bannière REPL affiche le chemin absolu pour les agents. Inclut `skill_generator.py`, modèle Jinja2, `package_data` dans tous les setup.py, et 51 nouveaux tests.

- **2026-03-15** 🐾 Support pour **OpenClaw** de la communauté ! Fusion du garde `cygpath` Windows pour garantir que CLI-Anything fonctionne de manière fiable dans les environnements bash Windows. Les contributions communautaires continuent de renforcer le support multiplateforme.

- **2026-03-14** 🔒 Correction d’une vulnérabilité d’injection de chemin dans GIMP Script-Fu et ajout de la traduction du **README japonais**. Documentation des exigences de version OpenCode accompagnée de plusieurs améliorations de compatibilité Windows.

- **2026-03-13** 🔌 Plugin **Qodercli** officiellement fusionné en contribution communautaire avec scripts d’installation dédiés. La compétence Codex a reçu un script d’installation Windows, et les URLs de remplacement ont été nettoyées dans tout le projet.

- **2026-03-12** 📦 Intégration de la **compétence Codex**, apportant CLI-Anything à une autre plateforme de codage IA. Le support Qodercli a également été introduit, et la documentation mise à jour avec des limitations et labels expérimentaux.

- **2026-03-11** 📞 Ajout du banc de test vidéo **Zoom** comme 11e application supportée. Plusieurs corrections communautaires ont été déployées pour la sauvegarde automatique Shotcut, le backend LibreOffice Windows/macOS, et le support OpenCode.

</details>

---

## 🤔 Pourquoi CLI ?

Le CLI est l’interface universelle pour les humains comme pour les agents IA :

• **Structuré & Composable** - Les commandes textuelles correspondent au format LLM et s’enchaînent pour des flux de travail complexes

• **Léger & Universel** - Surcharge minimale, fonctionne sur tous les systèmes sans dépendances

• **Auto-descriptif** - Les options --help fournissent une documentation automatique que les agents peuvent découvrir

• **Succès Prouvé** - Claude Code exécute quotidiennement des milliers de flux de travail réels via la CLI

• **Conception Axée Agent** - La sortie JSON structurée élimine la complexité de l’analyse

• **Déterministe & Fiable** - Des résultats cohérents permettent un comportement prévisible des agents

## 🚀 Démarrage Rapide

### Prérequis

- **Python 3.10+**
- Logiciel cible installé (ex. : GIMP, Blender, LibreOffice, ou votre propre application)
- Un agent IA de codage supporté : [Claude Code](#-claude-code) | [OpenClaw](#-openclaw) | [OpenCode](#-opencode) | [Codex](#-codex) | [Qodercli](#-qodercli) | [GitHub Copilot CLI](#-github-copilot-cli) | [Plus de plateformes](#-more-platforms-coming-soon)

### Choisissez Votre Plateforme

<details open>
<summary><h4 id="-claude-code">⚡ Claude Code</h4></summary>

**Étape 1 : Ajouter le Marketplace**

CLI-Anything est distribué comme un plugin marketplace Claude Code hébergé sur GitHub.

```bash
# Add the CLI-Anything marketplace
/plugin marketplace add HKUDS/CLI-Anything
```

**Étape 2 : Installer le plugin**

```bash
# Install the cli-anything plugin from the marketplace
/plugin install cli-anything
```

C’est tout. Le plugin est maintenant disponible dans votre session Claude Code.

> **Note pour les utilisateurs Windows :** Claude Code exécute les commandes shell via `bash`. Sous Windows, installez Git pour Windows (comprend `bash` et
`cygpath`) ou utilisez WSL ; sinon, les commandes peuvent échouer avec `cygpath : commande introuvable`.

**Étape 3 : Construire une interface en ligne de commande en une seule commande**

```bash
# /cli-anything:cli-anything <software-path-or-repo>
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything:cli-anything ./gimp

# Note: If your Claude Code is under 2.x, use "/cli-anything" instead.
```

Cela exécute la chaîne complète :
1. 🔍 **Analyser** — Analyse le code source, associe les actions GUI aux API
2. 📐 **Concevoir** — Architecture des groupes de commandes, modèle d'état, formats de sortie
3. 🔨 **Implémenter** — Construit CLI Click avec REPL, sortie JSON, annulation/rétablissement
4. 📋 **Planifier les tests** — Crée TEST.md avec plans de tests unitaires + E2E
5. 🧪 **Écrire les tests** — Met en œuvre une suite de tests complète
6. 📝 **Documenter** — Met à jour TEST.md avec les résultats
7. 📦 **Publier** — Crée `setup.py`, installe dans PATH

**Étape 4 (Optionnelle) : Affiner et améliorer le CLI**

Après la construction initiale, vous pouvez affiner itérativement le CLI pour étendre la couverture et ajouter les capacités manquantes :

```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything:refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything:refine ./gimp "I want more CLIs on image batch processing and filters"
```

La commande refine effectue une analyse des écarts entre les capacités complètes du logiciel et la couverture actuelle de l'interface en ligne de commande, puis implémente de nouvelles commandes, tests et documentation pour les écarts identifiés. Vous pouvez l'exécuter plusieurs fois pour étendre progressivement la couverture — chaque exécution est incrémentale et non destructive.

<details>
<summary><strong>Alternative : Installation manuelle</strong></summary>

Si vous préférez ne pas utiliser le marketplace :

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Copy plugin to Claude Code plugins directory
cp -r CLI-Anything/cli-anything-plugin ~/.claude/plugins/cli-anything

# Reload plugins
/reload-plugins
```

</details>

</details>

<details>
<summary><h4 id="-opencode">⚡ OpenCode (Expérimental)</h4></summary>

**Étape 1 : Installer les Commandes**

> **Remarque :** Veuillez mettre à jour vers la dernière version d'OpenCode. Les versions plus anciennes peuvent utiliser un chemin de commandes différent.

Copiez les commandes CLI-Anything **et** `HARNESS.md` dans votre répertoire de commandes OpenCode :

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Global install (available in all projects)
cp CLI-Anything/opencode-commands/*.md ~/.config/opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md ~/.config/opencode/commands/

# Or project-level install
cp CLI-Anything/opencode-commands/*.md .opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md .opencode/commands/
```

> **Note :** `HARNESS.md` est la spécification méthodologique à laquelle toutes les commandes se réfèrent. Il doit se trouver dans le même répertoire que les commandes.

Cela ajoute 5 commandes slash : `/cli-anything`, `/cli-anything-refine`, `/cli-anything-test`, `/cli-anything-validate` et `/cli-anything-list`.

**Étape 2 : Construire une CLI en une seule commande**

```bash
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything ./gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender
```

La commande s'exécute en tant que sous-tâche et suit la même méthodologie en 7 phases que Claude Code.

**Étape 3 (Optionnel) : Affiner et améliorer l'interface CLI**

```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything-refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything-refine ./gimp "batch processing and filters"
```

</details>

<details>
<summary><h4 id="-goose">⚡ Goose (Bureau / CLI) <sup><code>Expérimental</code></sup> <sup><code>Communauté</code></sup></h4></summary>

**Étape 1 : Installer Goose**

Installez Goose (Bureau ou CLI) en suivant les instructions officielles de Goose pour votre système d’exploitation.

**Étape 2 : Configurer un fournisseur CLI**

Configurez Goose pour utiliser un fournisseur CLI tel que Claude Code, et assurez-vous que le CLI est installé et authentifié.

**Étape 3 : Utiliser CLI-Anything dans une session Goose**

Une fois Goose configuré, démarrez une session et utilisez les mêmes commandes CLI-Anything décrites ci-dessus pour Claude Code, par exemple :

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
```

> Remarque : Lorsque Goose s'exécute via un fournisseur CLI, il utilise les capacités et le format de commande de ce fournisseur.
</details>

<details>

<summary><h4 id="-qodercli">⚡ Qodercli <sup><code>Communauté</code></sup></h4></summary>

**Étape 1 : Enregistrer le Plugin**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
bash CLI-Anything/qoder-plugin/setup-qodercli.sh
```

Cela enregistre le plugin cli-anything dans `~/.qoder.json`. Démarrez une nouvelle session Qodercli après l'enregistrement.

**Étape 2 : Utiliser CLI-Anything depuis Qodercli**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>

<summary><h4 id="-openclaw">⚡ OpenClaw <sup><code>Communauté</code></sup></h4></summary>

**Étape 1 : Installer la Skill**

CLI-Anything fournit un fichier OpenClaw `SKILL.md` natif. Copiez-le dans votre répertoire de skills OpenClaw :

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install to the global skills folder
mkdir -p ~/.openclaw/skills/cli-anything
cp CLI-Anything/openclaw-skill/SKILL.md ~/.openclaw/skills/cli-anything/SKILL.md
```

**Étape 2 : Construire une CLI**

Vous pouvez maintenant invoquer la compétence dans OpenClaw :

`@cli-anything build a CLI for ./gimp`

La compétence suit la même méthodologie en 7 phases que Claude Code et OpenCode.

</details>

<details>

<summary><h4 id="-codex">⚡ Codex <sup><code>Expérimental</code></sup> <sup><code>Communauté</code></sup></h4></summary>

**Étape 1 : Installer la compétence**

Exécutez l'installateur fourni :

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install the skill
bash CLI-Anything/codex-skill/scripts/install.sh
```

Sous Windows PowerShell, utilisez :

```powershell
.\CLI-Anything\codex-skill\scripts\install.ps1
```

Cela installe la compétence dans `$CODEX_HOME/skills/cli-anything` (ou `~/.codex/skills/cli-anything` si `CODEX_HOME` n'est pas défini).

Redémarrez Codex après l'installation pour qu'elle soit détectée.

**Étape 2 : Utiliser CLI-Anything depuis Codex**

Décrivez la tâche en langage naturel, par exemple :

```text
Use CLI-Anything to build a harness for ./gimp
Use CLI-Anything to refine ./shotcut for picture-in-picture workflows
Use CLI-Anything to validate ./libreoffice
```

La compétence Codex utilise la même méthodologie que le plugin Claude Code et
les commandes OpenCode, tout en conservant le format du harnais Python généré inchangé.
</details>

<details>

<summary><h4 id="-github-copilot-cli">⚡ GitHub Copilot CLI <sup><code>Communauté</code></sup></h4></summary>

**Étape 1 : Installer le Plugin**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
cd CLI-Anything
copilot plugin install ./cli-anything-plugin
```

Cela installe le plugin CLI-Anything pour GitHub Copilot CLI. Le plugin devrait maintenant être disponible dans votre session GitHub Copilot CLI.

**Étape 2 : Utiliser CLI-Anything depuis GitHub Copilot CLI**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```

</details>

<details>
<summary><h4 id="-more-platforms-coming-soon">🔮 Plus de plateformes (bientôt disponibles)</h4></summary>

CLI-Anything est conçu pour être indépendant de la plateforme. Le support pour plus d'agents d'IA de codage est prévu :

- **Codex** — disponible via la compétence incluse dans `codex-skill/`
- **Cursor** — bientôt disponible
- **Windsurf** — bientôt disponible
- **Votre outil préféré** — contributions bienvenues ! Voir le répertoire `opencode-commands/` pour une implémentation de référence.

</details>

### Utiliser le CLI Généré

Peu importe la plateforme utilisée pour le créer, le CLI généré fonctionne de la même manière :

```bash
# Install to PATH
cd gimp/agent-harness && pip install -e .

# Use from anywhere
cli-anything-gimp --help
cli-anything-gimp project new --width 1920 --height 1080 -o poster.json
cli-anything-gimp --json layer add -n "Background" --type solid --color "#1a1a2e"

# Enter interactive REPL
cli-anything-gimp
```

Chaque CLI installée est livrée avec un [`SKILL.md`](#-skillmd-generation) à l'intérieur du paquet Python (`cli_anything/<software>/skills/SKILL.md`). La bannière REPL affiche automatiquement le chemin absolu vers ce fichier afin que les agents IA sachent exactement où lire la définition de la compétence. Aucune configuration supplémentaire nécessaire — `pip install` rend la compétence détectable.

---

## 🤖 Donnez du pouvoir à vos agents avec CLI-Hub

CLI-Hub permet aux agents de découvrir et d’installer de manière autonome les CLIs dont ils ont besoin — sans aucune intervention humaine.

Nous avons publié une **méta-compétence** qui permet à tout agent IA d’explorer librement le catalogue complet des CLIs communautaires et de choisir celui qui convient à la tâche.

**Installation en une commande :**

```bash
# OpenClaw
openclaw skills install cli-anything-hub

# nanobot
nanobot skills install cli-anything-hub
```

**Ensuite, il suffit de demander à votre agent :**

```
Find appropriate CLI software in CLI-Hub and complete the task: <your task here>
```

L'agent parcourra le catalogue, installera l'outil CLI adapté à la tâche, et l'utilisera — de manière totalement autonome.

**Comment cela fonctionne en coulisses :**

1. La méta-compétence pointe vers le catalogue en ligne à [`https://hkuds.github.io/CLI-Anything/SKILL.txt`](https://hkuds.github.io/CLI-Anything/SKILL.txt)
2. L'agent lit plus de 20 CLI organisés par catégorie avec des commandes `pip install` en une ligne
3. L'agent installe le CLI adapté à la tâche, puis lit le propre SKILL.md de ce CLI pour une utilisation détaillée

Le catalogue se met à jour automatiquement dès que `registry.json` change — les nouveaux CLI communautaires apparaissent automatiquement.

> **Pour les utilisateurs de Claude Code :** Copiez [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) dans votre projet ou répertoire de compétences pour la même découverte automatique de CLI.

---

## 💡 Vision de CLI-Anything : Construire des logiciels natifs agents

• 🌐 **Accès universel** - Chaque logiciel devient instantanément contrôlable par un agent via un CLI structuré.

• 🔗 **Intégration transparente** - Les agents contrôlent toute application sans API, GUI, reconstruction ou wrappers complexes.

• 🚀 **Écosystème prêt pour l'avenir** - Transformer les logiciels conçus par des humains en outils natifs agents en une commande.

---

## 🔧 Quand utiliser CLI-Anything

| Catégorie | Comment devenir natif agent | Exemples notables |
|----------|-----------------------------|-------------------|
| **📂 Dépôts GitHub** | Transformer tout projet open-source en outils contrôlables par agent via génération automatique de CLI | VSCodium, WordPress, Calibre, Zotero, Joplin, Logseq, Penpot, Super Productivity |
| **🤖 Plateformes IA/ML** | Automatiser l'entraînement de modèles, les pipelines d'inférence, et le réglage d'hyperparamètres via commandes structurées | Stable Diffusion WebUI, ComfyUI, Ollama, InvokeAI, Text-generation-webui, Open WebUI, Fooocus, Kohya_ss, AnythingLLM, SillyTavern |
| **📊 Données & Analytique** | Permettre le traitement programmatique des données, la visualisation et les analyses statistiques | JupyterLab, Apache Superset, Metabase, Redash, DBeaver, KNIME, Orange, OpenSearch Dashboards, Lightdash |
| **💻 Outils de développement** | Rationaliser l'édition, la construction, les tests et les déploiements de code via interfaces en ligne de commande | Jenkins, Gitea, Hoppscotch, Portainer, pgAdmin, SonarQube, ArgoCD, OpenLens, Insomnia, Beekeeper Studio, **[iTerm2](https://iterm2.com)** |
| **🎨 Création & Médias** | Contrôler la création, l’édition et le rendu de contenus de manière programmatique | Blender, GIMP, OBS Studio, Audacity, Krita, Kdenlive, Shotcut, Inkscape, Darktable, LMMS, Ardour |
| **🔬 Calcul scientifique** | Automatiser les workflows de recherche, simulations et calculs complexes | ImageJ, FreeCAD, QGIS, ParaView, Gephi, LibreCAD, Stellarium, KiCad, JASP, Jamovi |
| **🏢 Entreprise & Bureautique** | Convertir les applications métier et outils de productivité en systèmes accessibles par agents | NextCloud, GitLab, Grafana, Mattermost, LibreOffice, AppFlowy, NocoDB, Odoo (Communauté), Plane, ERPNext |
| **📞 Communication & Collaboration** | Automatiser la planification des réunions, gestion des participants, récupération d’enregistrements et rapports via CLI structuré | Zoom, Jitsi Meet, BigBlueButton, Mattermost |
| **📐 Diagrammes & Visualisation** | Créer et manipuler diagrammes, organigrammes, diagrammes d’architecture et documentation visuelle de façon programmatique | Draw.io (diagrams.net), Mermaid, PlantUML, Excalidraw, yEd |
| **🌐 Réseau & Infrastructure** | Gérer services réseau, DNS, blocage de pub, et infrastructure via commandes CLI structurées | AdGuardHome |
| **🔬 Graphismes & Débogage GPU** | Analyser les captures GPU, inspecter l’état du pipeline, exporter des shaders, et comparer l’état de rendu | RenderDoc |
| **✨ Génération de contenu IA** | Générer des livrables professionnels (diapositives, documents, diagrammes, sites web, rapports de recherche) via des API cloud alimentées par l'IA | [AnyGen](https://www.anygen.io), Gamma, Beautiful.ai, Tome |

---

## Fonctionnalités clés de CLI-Anything

### Le fossé entre agent et logiciel
Les agents IA excellent en raisonnement mais sont incapables d’utiliser de vrais logiciels professionnels. Les solutions actuelles reposent sur une automatisation fragile de l’interface utilisateur, des API limitées, ou des réimplémentations simplifiées qui perdent 90 % des fonctionnalités.

**Solution CLI-Anything** : Transformer n’importe quel logiciel professionnel en outils natifs pour agents sans perte de capacités.

| **Problème actuel** | **Solution CLI-Anything** |
|----------|----------------------|
| 🤖 « L’IA ne peut pas utiliser de vrais outils » | Intégration directe avec les backends de logiciels réels (Blender, LibreOffice, FFmpeg) — capacités professionnelles complètes, zéro compromis |
| 💸 « L’automatisation UI casse constamment » | Pas de captures d’écran, pas de clics, pas de fragilité RPA. Fiabilité pure en ligne de commande avec interfaces structurées |
| 📊 « Les agents ont besoin de données structurées » | Sortie JSON intégrée pour consommation fluide par les agents + formats lisibles par l’humain pour le débogage |
| 🔧 « Intégrations personnalisées coûteuses » | Un plugin Claude génère automatiquement des CLI pour TOUT code via un pipeline éprouvé en 7 phases |
| ⚡ « Écart prototype vs production » | Plus de 1 839 tests validés avec logiciels réels. Testé en conditions réelles sur 16 applications majeures |

---

## 🎯 Que pouvez-vous faire avec CLI-Anything ?

<table>
<tr>
<td width="33%">

### 🛠️ Laissez les agents gérer vos flux de travail

Professionnel ou quotidien — il suffit de lancer la base de code sur `/cli-anything`. GIMP, Blender, Shotcut pour le travail créatif. LibreOffice, OBS Studio pour les tâches journalières. Pas de source ? Trouvez une alternative open source et lancez *celle-là*. Vous obtiendrez instantanément une CLI complète que vos agents peuvent utiliser.

</td>
<td width="33%">

### 🔗 Unifiez les API dispersées en une seule CLI

Marre de jongler avec des API de services web fragmentées ? Donnez la documentation ou les SDK à `/cli-anything` et vos agents obtiennent une **CLI puissante et avec état** qui regroupe ces points de terminaison individuels en groupes de commandes cohérents. Un outil au lieu de dizaines d’appels API bruts — capacités renforcées tout en économisant des tokens.

</td>
<td width="33%">

### 🚀 Remplacer ou Améliorer les Agents GUI

CLI-Anything peut carrément **remplacer les approches d’agents basés sur GUI** — plus besoin de captures d’écran, plus de clics fragiles sur des pixels. Mais voici la partie amusante : une fois que vous `/cli-anything` un logiciel GUI, vous pouvez **synthétiser des tâches d’agents, des évaluateurs et des benchmarks** entièrement via le code et le terminal — entièrement automatisé, affiné de manière itérative, beaucoup plus efficace.

</td>
</tr>
</table>

---

## ✨ ⚙️ Comment Fonctionne CLI-Anything

<table>
<tr>
<td width="50%">

### 🏗️ Pipeline Entièrement Automatisé en 7 Phases
De l’analyse du code à la publication sur PyPI — le plugin gère la conception de l’architecture, l’implémentation, la planification des tests, la rédaction des tests et la documentation de manière totalement automatique.

</td>
<td width="50%">

### 🎯 Intégration Logicielle Authentique
Appels directs aux applications réelles pour un rendu effectif. LibreOffice génère des PDFs, Blender rend des scènes 3D, Audacity traite l’audio via sox. **Zéro compromis**, **Zéro implémentation factice**.

</td>
</tr>
<tr>
<td width="50%">

### 🔁 Gestion Intelligente des Sessions
État du projet persistant avec capacités d’annulation/rétablissement, plus interface REPL unifiée (ReplSkin) qui offre une expérience interactive cohérente sur tous les CLI.

</td>
<td width="50%">

### 📦 Installation Sans Configuration
Un simple pip install -e . place cli-anything-<software> directement dans le PATH. Les agents découvrent les outils via les commandes which standard. Pas de configuration, pas d’intermédiaires.

</td>
</tr>
<tr>
<td width="50%">

### 🧪 Tests de qualité production
Validation multi-couches : tests unitaires avec données synthétiques, tests de bout en bout avec fichiers réels et logiciels, plus vérification des commandes installées via sous-processus CLI.

</td>
<td width="50%">

### 🐍 Architecture propre du package
Tous les CLI organisés sous l’espace de noms cli_anything.* — sans conflit, installables via pip, avec une nomenclature cohérente : cli-anything-gimp, cli-anything-blender, etc.

</td>
</tr>
</table>

### 🤖 Génération de SKILL.md

Chaque CLI généré inclut un fichier `SKILL.md` dans le package Python à `cli_anything/<software>/skills/SKILL.md`. Cette définition de compétence autonome permet aux agents IA de découvrir et d’utiliser le CLI via le système de compétences de Claude Code ou d’autres frameworks d’agents.

**Ce que fournit SKILL.md :**
- **Frontmatter YAML** avec nom et description pour la découverte des compétences par l’agent
- **Groupes de commandes** avec toutes les sous-commandes documentées
- **Exemples d’utilisation** pour les flux de travail courants
- **Conseils spécifiques aux agents** pour la sortie JSON, la gestion des erreurs et l’usage programmatique

Les fichiers SKILL.md sont générés automatiquement durant la Phase 6.5 du pipeline via `skill_generator.py`, qui extrait les métadonnées directement des décorateurs Click du CLI, setup.py, et README. Comme le fichier vit dans le package, il est installé avec le CLI via `pip install` et détecté automatiquement par la bannière REPL — les agents peuvent lire le chemin absolu affiché au démarrage.

---

## 🎬 Démonstrations

### 🎯 Usage général
CLI-Anything fonctionne avec tout logiciel disposant d’une base de code — sans restrictions de domaine ni limitations architecturales.

### 🏭 Tests de qualité professionnelle
Testé sur 16 applications diverses et complexes couvrant les domaines créatif, productivité, communication, diagramme, génération d’images IA, génération de contenu IA, blocage publicitaire réseau, et inférence locale de LLM, auparavant inaccessibles aux agents IA.

### 🎨 Couverture de Domaines Diversifiés  
Des flux de travail créatifs (édition d’images, modélisation 3D, graphismes vectoriels) aux outils de production (audio, bureautique, streaming en direct, montage vidéo).

### ✅ Génération CLI Complète  
Chaque application a reçu des interfaces CLI complètes et prêtes pour la production — pas des démos, mais un accès complet aux outils en conservant toutes les fonctionnalités.

<table>  
<tr>  
<th align="center">Logiciel</th>  
<th align="center">Domaine</th>  
<th align="center">Commande CLI</th>  
<th align="center">Backend</th>  
<th align="center">Tests</th>  
</tr>  
<tr>  
<td align="center"><strong>🎨 GIMP</strong></td>  
<td>Édition d’images</td>  
<td><code>cli-anything-gimp</code></td>  
<td>Pillow + GEGL/Script-Fu</td>  
<td align="center">✅ 107</td>  
</tr>  
<tr>  
<td align="center"><strong>🧊 Blender</strong></td>  
<td>Modélisation & Rendu 3D</td>  
<td><code>cli-anything-blender</code></td>  
<td>bpy (scripting Python)</td>  
<td align="center">✅ 208</td>  
</tr>  
<tr>  
<td align="center"><strong>✏️ Inkscape</strong></td>  
<td>Graphismes Vectoriels</td>  
<td><code>cli-anything-inkscape</code></td>  
<td>Manipulation directe SVG/XML</td>  
<td align="center">✅ 202</td>  
</tr>  
<tr>  
<td align="center"><strong>🎵 Audacity</strong></td>  
<td>Production Audio</td>  
<td><code>cli-anything-audacity</code></td>  
<td>Python wave + sox</td>
<td align="center">✅ 161</td>
</tr>
<tr>
<td align="center"><strong>🌐 Navigateur</strong></td>
<td>Automatisation de navigateur</td>
<td><code>cli-anything-browser</code></td>
<td>DOMShell MCP + Arbre d’accessibilité</td>
<td align="center">✅ <a href="browser/agent-harness/">Nouveau</a></td>
</tr>
<tr>
<td align="center"><strong>📄 LibreOffice</strong></td>
<td>Suite bureautique (Writer, Calc, Impress)</td>
<td><code>cli-anything-libreoffice</code></td>
<td>Génération ODF + LO sans interface</td>
<td align="center">✅ 158</td>
</tr>
<tr>
<td align="center"><strong>📝 <a href="mubu/agent-harness/">Mubu</a></strong></td>
<td>Gestion des connaissances &amp; planification</td>
<td><code>cli-anything-mubu</code></td>
<td>Données locales Mubu + journaux de synchronisation</td>
<td align="center">✅ 96</td>
</tr>
<tr>
<td align="center"><strong>📹 OBS Studio</strong></td>
<td>Diffusion en direct & enregistrement</td>
<td><code>cli-anything-obs-studio</code></td>
<td>Scène JSON + obs-websocket</td>
<td align="center">✅ 153</td>
</tr>
<tr>
<td align="center"><strong>🎞️ Kdenlive</strong></td>
<td>Montage vidéo</td>
<td><code>cli-anything-kdenlive</code></td>
<td>MLT XML + moteur de rendu melt</td>
<td align="center">✅ 155</td>
</tr>
<tr>
<td align="center"><strong>🎬 Shotcut</strong></td>
<td>Montage vidéo</td>
<td><code>cli-anything-shotcut</code></td>
<td>MLT XML direct + melt</td>
<td align="center">✅ 154</td>
</tr>
<tr>
<td align="center"><strong>📞 Zoom</strong></td>
<td>Conférence vidéo</td>
<td><code>cli-anything-zoom</code></td>
<td>API REST Zoom (OAuth2)</td>
<td align="center">✅ 22</td>
</tr>
<tr>
<td align="center"><strong>🎵 MuseScore</strong></td>
<td>Notation musicale</td>
<td><code>cli-anything-musescore</code></td>
<td>CLI mscore (MSCX/MusicXML)</td>
<td align="center">✅ 56</td>
</tr>
<tr>
<td align="center"><strong>📐 Draw.io</strong></td>
<td>Création de diagrammes</td>
<td><code>cli-anything-drawio</code></td>
<td>XML mxGraph + CLI draw.io</td>
<td align="center">✅ 138</td>
</tr>
<tr>
<td align="center"><strong>🧜 Mermaid Live Editor</strong></td>
<td>Création de diagrammes</td>
<td><code>cli-anything-mermaid</code></td>
<td>État Mermaid + rendu mermaid.ink</td>
<td align="center">✅ 10</td>
</tr>
<tr>
<td align="center"><strong>✨ AnyGen</strong></td>
<td>Génération de contenu IA</td>
<td><code>cli-anything-anygen</code></td>
<td>API REST AnyGen (anygen.io)</td>
<td align="center">✅ 50</td>
</tr>
<tr>
<td align="center"><strong>🧠 NotebookLM</strong></td>
<td>Assistant de recherche IA</td>
<td><code>cli-anything-notebooklm</code></td>
<td>Wrapper CLI NotebookLM (expérimental)</td>
<td align="center">✅ 21</td>
</tr>
<tr>
<td align="center"><strong>🖼️ ComfyUI</strong></td>
<td>Génération d'images IA</td>
<td><code>cli-anything-comfyui</code></td>
<td>API REST ComfyUI</td>
<td align="center">✅ 70</td>
</tr>
<tr>
<td align="center"><strong>🛡️ AdGuard Home</strong></td>
<td>Blocage de publicités réseau</td>
<td><code>cli-anything-adguardhome</code></td>
<td>API REST AdGuard Home</td>
<td align="center">✅ 36</td>
</tr>
<tr>
<td align="center"><strong>🦙 Ollama</strong></td>
<td>Inférence LLM locale</td>
<td><code>cli-anything-ollama</code></td>
<td>API REST Ollama</td>
<td align="center">✅ 98</td>
</tr>
<tr>
<td align="center"><strong>🎨 Sketch</strong></td>
<td>Conception d'interface</td>
<td><code>sketch-cli</code></td>
<td>sketch-constructor (Node.js)</td>
<td align="center">✅ 19</td>
</tr>
<tr>
<td align="center" colspan="4"><strong>Total</strong></td>
<td align="center"><strong>✅ 1,858</strong></td>
</tr>
</table>

> **Taux de réussite de 100 %** sur l’ensemble des 1 858 tests — 1 355 tests unitaires + 484 tests de bout en bout + 19 tests Node.js.

---

## 📊 Résultats des tests

Chaque environnement CLI subit des tests rigoureux à plusieurs niveaux pour garantir la fiabilité en production :

| Niveau | Ce qu’il teste | Exemple |
|--------|----------------|---------|
| **Tests unitaires** | Chaque fonction cœur isolée avec des données synthétiques | `test_core.py` — création de projet, opérations de couche, paramètres de filtre |
| **Tests E2E (natifs)** | Pipeline de génération de fichiers projet | Structure ZIP ODF valide, XML MLT correct, bonne formation SVG |
| **Tests E2E (vrai backend)** | Invocation logicielle réelle + vérification de sortie | LibreOffice → PDF avec octets magiques `%PDF-`, Blender → PNG rendu |
| **Tests de sous-processus CLI** | Commande installée via `subprocess.run` | `cli-anything-gimp --json project new` → sortie JSON valide |

```
================================ Test Summary ================================
gimp          107 passed  ✅   (64 unit + 43 e2e)
blender       208 passed  ✅   (150 unit + 58 e2e)
inkscape      202 passed  ✅   (148 unit + 54 e2e)
audacity      161 passed  ✅   (107 unit + 54 e2e)
libreoffice   158 passed  ✅   (89 unit + 69 e2e)
mubu           96 passed  ✅   (85 unit + 11 e2e)
obs-studio    153 passed  ✅   (116 unit + 37 e2e)
kdenlive      155 passed  ✅   (111 unit + 44 e2e)
shotcut       154 passed  ✅   (110 unit + 44 e2e)
zoom           22 passed  ✅   (22 unit + 0 e2e)
drawio        138 passed  ✅   (116 unit + 22 e2e)
mermaid        10 passed  ✅   (5 unit + 5 e2e)
anygen         50 passed  ✅   (40 unit + 10 e2e)
notebooklm     21 passed  ✅   (21 unit + 0 e2e)
comfyui        70 passed  ✅   (60 unit + 10 e2e)
adguardhome    36 passed  ✅   (24 unit + 12 e2e)
ollama         98 passed  ✅   (87 unit + 11 e2e)
sketch         19 passed  ✅   (19 jest, Node.js)
renderdoc      59 passed  ✅   (45 unit + 14 e2e)
──────────────────────────────────────────────────────────────────────────────
TOTAL        1,917 passed  ✅   100% pass rate
```

---

## 🏗️ Architecture de CLI-Anything

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/architecture.png" alt="Architecture de CLI-Anything" width="750">
</p>

### 🎯 Principes de conception fondamentaux

1. **Intégration logicielle authentique** — Le CLI génère des fichiers projet valides (ODF, XML MLT, SVG) et délègue aux applications réelles le rendu. **Nous construisons des interfaces structurées VERS les logiciels, pas des remplacements**.

2. **Modèles d’interaction flexibles** — Chaque CLI fonctionne en modes doubles : REPL avec état pour sessions interactives d’agents + interface sous-commandes pour scripts/pipelines. **Lancer la commande seule → entrer en mode REPL**.

3. **Expérience utilisateur cohérente** — Tous les CLI générés partagent une interface REPL unifiée (repl_skin.py) avec bannières personnalisées, invites stylisées, historique des commandes, indicateurs de progression et formatage standardisé.

4. **Conception native pour agents** — Le flag --json intégré à chaque commande fournit des données structurées pour consommation machine, tandis que des tableaux lisibles par l’humain servent l’usage interactif. **Les agents découvrent les capacités via --help standard et les commandes which**.

5. **Dépendances sans compromis** — Le logiciel réel est une exigence stricte — pas de solutions de repli, pas de dégradation progressive. **Les tests échouent (ne sautent pas) si les backends manquent, garantissant une fonctionnalité authentique**.

---

## 📂 Structure du projet

```
cli-anything/
├── 📄 README.md                          # You are here
├── 📁 assets/                            # Images and media
│   ├── icon.png                          # Project icon
│   └── teaser.png                        # Teaser figure
│
├── 🔌 cli-anything-plugin/               # The Claude Code plugin
│   ├── HARNESS.md                        # Methodology SOP (source of truth)
│   ├── README.md                         # Plugin documentation
│   ├── QUICKSTART.md                     # 5-minute getting started
│   ├── PUBLISHING.md                     # Distribution guide
│   ├── repl_skin.py                      # Unified REPL interface
│   ├── commands/                         # Plugin command definitions
│   │   ├── cli-anything.md               # Main build command
│   │   ├── refine.md                     # Expand existing harness coverage
│   │   ├── test.md                       # Test runner
│   │   └── validate.md                   # Standards validation
│   └── scripts/
│       └── setup-cli-anything.sh         # Setup script
│
├── 🤖 codex-skill/                      # Codex skill entry point
├── 🎨 gimp/agent-harness/               # GIMP CLI (107 tests)
├── 🧊 blender/agent-harness/            # Blender CLI (208 tests)
├── ✏️ inkscape/agent-harness/            # Inkscape CLI (202 tests)
├── 🎵 audacity/agent-harness/           # Audacity CLI (161 tests)
├── 🌐 browser/agent-harness/            # Browser CLI (DOMShell MCP, new)
├── 📄 libreoffice/agent-harness/        # LibreOffice CLI (158 tests)
├── 📝 mubu/agent-harness/               # Mubu CLI (96 tests)
├── 📹 obs-studio/agent-harness/         # OBS Studio CLI (153 tests)
├── 🎞️ kdenlive/agent-harness/           # Kdenlive CLI (155 tests)
├── 🎬 shotcut/agent-harness/            # Shotcut CLI (154 tests)
├── 📞 zoom/agent-harness/               # Zoom CLI (22 tests)
├── 🎵 musescore/agent-harness/          # MuseScore CLI (56 tests)
├── 📐 drawio/agent-harness/             # Draw.io CLI (138 tests)
├── 🧜 mermaid/agent-harness/            # Mermaid Live Editor CLI (10 tests)
├── ✨ anygen/agent-harness/             # AnyGen CLI (50 tests)
├── 🖼️ comfyui/agent-harness/            # ComfyUI CLI (70 tests)
├── 🧠 notebooklm/agent-harness/         # NotebookLM CLI (experimental, 21 tests)
├── 🛡️ adguardhome/agent-harness/       # AdGuard Home CLI (36 tests)
├── 🦙 ollama/agent-harness/             # Ollama CLI (98 tests)
├── 🎨 sketch/agent-harness/             # Sketch CLI (19 tests, Node.js)
└── 🔬 renderdoc/agent-harness/          # RenderDoc CLI (59 tests)
```

Chaque `agent-harness/` contient un paquet Python installable sous `cli_anything.<software>/` avec CLI Click, modules principaux, utilitaires (y compris `repl_skin.py` et wrapper backend), et des tests complets.

---

## 🎯 Commandes Plugin

| Commande | Description |
|---------|-------------|
| `/cli-anything <chemin-ou-repo-du-logiciel>` | Construire un harnais CLI complet — les 7 phases |
| `/cli-anything:refine <chemin-du-logiciel> [focus]` | Affiner un harnais existant — étendre la couverture avec analyse des lacunes |
| `/cli-anything:test <chemin-ou-repo-du-logiciel>` | Exécuter les tests et mettre à jour TEST.md avec les résultats |
| `/cli-anything:validate <chemin-ou-repo-du-logiciel>` | Valider selon les standards HARNESS.md |

### Exemples

```bash
# Build a complete CLI for GIMP from local source
/cli-anything /home/user/gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender

# Refine an existing harness — broad gap analysis
/cli-anything:refine /home/user/gimp

# Refine with a specific focus area
/cli-anything:refine /home/user/shotcut "vid-in-vid and picture-in-picture compositing"

# Run tests and update TEST.md
/cli-anything:test /home/user/inkscape

# Validate against HARNESS.md standards
/cli-anything:validate /home/user/audacity
```

---

## 🎮 Demo: Using a Generated CLI

Here's what an agent can do with `cli-anything-libreoffice`:

```bash
# Create a new Writer document
$ cli-anything-libreoffice document new -o report.json --type writer
✓ Created Writer document: report.json

# Add content
$ cli-anything-libreoffice --project report.json writer add-heading -t "Q1 Report" --level 1
✓ Added heading: "Q1 Report"

$ cli-anything-libreoffice --project report.json writer add-table --rows 4 --cols 3
✓ Added 4×3 table

# Export to real PDF via LibreOffice headless
$ cli-anything-libreoffice --project report.json export render output.pdf -p pdf --overwrite
✓ Exported: output.pdf (42,831 bytes) via libreoffice-headless

# JSON mode for agent consumption
$ cli-anything-libreoffice --json document info --project report.json
{
  "name": "Q1 Report",
  "type": "writer",
  "pages": 1,
  "elements": 2,
  "modified": true
}
```

### Mode REPL

```
$ cli-anything-blender
╔══════════════════════════════════════════╗
║       cli-anything-blender v1.0.0       ║
║     Blender CLI for AI Agents           ║
╚══════════════════════════════════════════╝

blender> scene new --name ProductShot
✓ Created scene: ProductShot

blender[ProductShot]> object add-mesh --type cube --location 0 0 1
✓ Added mesh: Cube at (0, 0, 1)

blender[ProductShot]*> render execute --output render.png --engine CYCLES
✓ Rendered: render.png (1920×1080, 2.3 MB) via blender --background

blender[ProductShot]> exit
Goodbye! 👋
```

---

## 📖 Le Manuel Standard : HARNESS.md

HARNESS.md est notre procédure opérationnelle standard définitive pour rendre tout logiciel accessible via une génération automatisée de CLI.

Il encode des modèles et méthodologies éprouvés, affinés par des processus de génération automatisée.

Le manuel distille les enseignements clés issus de la construction réussie des 16 harnais divers et prêts pour la production.

### Leçons Critiques

| Leçon | Description |
|--------|-------------|
| **Utiliser le logiciel réel** | La CLI DOIT appeler l’application réelle pour le rendu. Pas de remplacements Pillow pour GIMP, ni de moteurs de rendu personnalisés pour Blender. Générer des fichiers projet valides → invoquer le vrai backend. |
| **Le fossé du rendu** | Les applis GUI appliquent les effets au moment du rendu. Si votre CLI manipule des fichiers projet mais utilise un outil d’export naïf, les effets sont silencieusement perdus. Solution : moteur natif → traduction de filtre → script de rendu. |
| **Traduction des filtres** | Lors du mappage des effets entre formats (MLT → ffmpeg), attention aux fusions de filtres en double, à l’ordre intercalé des flux, aux différences d’espace paramétrique et aux effets non mappables. |
| **Précision du timecode** | Les fréquences d’images non entières (29,97fps) causent des arrondis cumulatifs. Utilisez `round()` pas `int()`, l’arithmétique entière pour l’affichage, et une tolérance ±1 image dans les tests. |
| **Vérification de la sortie** | Ne jamais supposer que l’export a réussi parce qu’il a retourné 0. Vérifiez : octets magiques, structure ZIP/OOXML, analyse des pixels, niveaux RMS audio, contrôles de durée. |

> Voir la méthodologie complète : [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md)

---

## 📦 Installation & Utilisation

### Pour les utilisateurs de plugins (Claude Code)

```bash
# Add marketplace & install (recommended)
/plugin marketplace add HKUDS/CLI-Anything
/plugin install cli-anything

# Build a CLI for any software with a codebase
/cli-anything <software-name>
```

### Pour les interfaces en ligne de commande générées

```bash
# Install any generated CLI
cd <software>/agent-harness
pip install -e .

# Verify
which cli-anything-<software>

# Use
cli-anything-<software> --help
cli-anything-<software>                    # enters REPL
cli-anything-<software> --json <command>   # JSON output for agents
```

### Exécution des tests

```bash
# Run tests for a specific CLI
cd <software>/agent-harness
python3 -m pytest cli_anything/<software>/tests/ -v

# Force-installed mode (recommended for validation)
CLI_ANYTHING_FORCE_INSTALLED=1 python3 -m pytest cli_anything/<software>/tests/ -v -s
```

---

## 🤝 Contribution

Nous accueillons les contributions ! CLI-Anything est conçu pour être extensible :

- **Nouvelles cibles logicielles** — Utilisez le plugin pour générer une CLI pour tout logiciel disposant d’une base de code, puis soumettez votre harnais via [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md).
- **Améliorations méthodologiques** — PR vers `HARNESS.md` qui codifient de nouvelles leçons apprises
- **Améliorations du plugin** — Nouvelles commandes, amélioration des phases, meilleure validation
- **Couverture des tests** — Plus de scénarios E2E, cas limites, tests de workflow

### Limitations

- **Nécessite des modèles fondamentaux puissants** — CLI-Anything s’appuie sur des modèles de pointe (ex. Claude Opus 4.6, Claude Sonnet 4.6, GPT-5.4) pour une génération fiable de harnais. Des modèles plus faibles ou plus petits peuvent produire des CLI incomplètes ou incorrectes nécessitant une correction manuelle importante.
- **Dépend du code source disponible** — La pipeline en 7 phases analyse et génère à partir du code source. Lorsque le logiciel cible ne fournit que des binaires compilés nécessitant une décompilation, la qualité et la couverture du harnais se dégradent considérablement.
- **Peut nécessiter un affinage itératif** — Une seule exécution de `/cli-anything` peut ne pas couvrir toutes les fonctionnalités. L’exécution de `/refine` une ou plusieurs fois est souvent nécessaire pour pousser la performance et la couverture de la CLI à un niveau de qualité production.

### Feuille de route

- [ ] Support de plus de catégories d’applications (CAO, MAO, IDE, EDA, outils scientifiques)
- [ ] Suite de benchmarks pour les taux de complétion de tâches par agents
- [ ] Harnais CLI communautaires pour logiciels internes/personalizés
- [ ] Intégration avec d’autres frameworks d’agents au-delà de Claude Code
- [ ] Support des API d’emballage pour logiciels propriétaires et services web en CLI
- [x] Production de SKILL.md avec la CLI pour la découverte et l’orchestration des compétences d’agent

---

## 📖 Documentation

| Document | Description |
|----------|-------------|
| [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md) | La procédure opérationnelle standard méthodologique — source unique de vérité |
| [`cli-anything-plugin/README.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/README.md) | Documentation du plugin — commandes, options, phases |
| [`cli-anything-plugin/QUICKSTART.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/QUICKSTART.md) | Guide de démarrage rapide en 5 minutes |
| [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) | Guide de distribution et publication |

Chaque harnais généré inclut également :
- `<SOFTWARE>.md` — Procédure opérationnelle standard d’architecture spécifique à cette application
- `tests/TEST.md` — Plan de test et documentation des résultats

---

## ⭐ Historique des étoiles

Si CLI-Anything aide à rendre votre logiciel natif Agent, donnez-nous une étoile ! ⭐

<div align="center">
  <a href="https://star-history.com/#HKUDS/CLI-Anything&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
      <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
    </picture>
  </a>
</div>

---

## 📄 Licence

Licence MIT — libre d'utilisation, modification et distribution.

---

<div align="center">

**CLI-Anything** — *Rendez tout logiciel avec une base de code natif Agent.*

<sub>Une méthodologie pour l’ère des agents IA | 16 démos logicielles professionnelles | 1 839 tests réussis</sub>

<br>

<img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="Icône CLI-Anything" width="80">

</div>

<p align="center">
  <em> Merci de votre visite ✨ CLI-Anything !</em><br><br>
  <img src="https://visitor-badge.laobi.icu/badge?page_id=HKUDS.CLI-Anything&style=for-the-badge&color=00d4ff" alt="Views">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---