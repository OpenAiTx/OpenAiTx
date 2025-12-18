# Compétence iOS Simulator pour Claude Code

Automatisation prête pour la production pour les tests et la construction d'applications iOS. 21 scripts optimisés pour les développeurs humains et les agents IA.

Ceci est essentiellement une version Compétence de mon XCode MCP : [https://github.com/conorluddy/xc-mcp](https://github.com/conorluddy/xc-mcp)

Les MCP chargent beaucoup de tokens dans la fenêtre de contexte lorsqu'ils sont actifs, mais semblent aussi très bien fonctionner. Les Compétences ne chargent aucun contexte. Je vais créer un plugin ensuite et essayer de trouver l'équilibre...

Mise à jour : La version Plugin vous permet de désactiver facilement les MCP pour différents groupes d'outils. Optimisez votre fenêtre de contexte en n'activant que les outils que vous utilisez activement, comme xcodebuild : [https://github.com/conorluddy/xclaude-plugin](https://github.com/conorluddy/xclaude-plugin)

## Ce que ça fait

Au lieu d'une navigation basée sur les pixels qui se casse lorsque l'interface change :

```bash
# Fragile - breaks if UI changes
idb ui tap 320 400

# Robust - finds by meaning
python scripts/navigator.py --find-text "Login" --tap
```

Utilise la navigation sémantique sur les API d’accessibilité pour interagir avec les éléments par leur signification, pas par leurs coordonnées. Fonctionne sur différentes tailles d’écran et résiste aux refontes de l’interface utilisateur.

## Fonctionnalités

- **21 scripts de production** pour la construction, les tests et l’automatisation  
- **Navigation sémantique** - trouver les éléments par texte, type ou ID  
- **Optimisé en tokens** - réduction de 96 % par rapport aux outils bruts (3-5 lignes par défaut)  
- **Aucune configuration** - fonctionne immédiatement sur macOS avec Xcode  
- **Sortie structurée** - JSON et texte formaté, facile à analyser  
- **Détection automatique UDID** - pas besoin de spécifier l’appareil à chaque fois  
- **Opérations groupées** - démarrer, supprimer, effacer plusieurs simulateurs en une fois  
- **Tests complets** - conformité WCAG, différences visuelles, audits d’accessibilité  
- **Prêt pour CI/CD** - sortie JSON, codes de sortie, cycle de vie automatisé des appareils  

## Installation

### En tant que Claude Code Skill

```bash
# Personal installation
git clone https://github.com/conorluddy/ios-simulator-skill.git ~/.claude/skills/ios-simulator-skill

# Project installation
git clone https://github.com/conorluddy/ios-simulator-skill.git .claude/skills/ios-simulator-skill
```

Redémarrer Claude Code. La compétence se charge automatiquement.

### Depuis la version

```bash
# Download latest release
curl -L https://github.com/conorluddy/ios-simulator-skill/releases/download/vX.X.X/ios-simulator-skill-vX.X.X.zip -o skill.zip

# Extract
unzip skill.zip -d ~/.claude/skills/ios-simulator-skill
```

## Prérequis

- macOS 12+
- Outils en ligne de commande Xcode (`xcode-select --install`)
- Python 3
- IDB (optionnel, pour les fonctionnalités interactives : `brew tap facebook/fb && brew install idb-companion`)

## Démarrage rapide

```bash
# 1. Check environment
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# 2. Launch your app
python ~/.claude/skills/ios-simulator-skill/scripts/app_launcher.py --launch com.example.app

# 3. See what's on screen
python ~/.claude/skills/ios-simulator-skill/scripts/screen_mapper.py
# Output:
# Screen: LoginViewController (45 elements, 7 interactive)
# Buttons: "Login", "Cancel", "Forgot Password"
# TextFields: 2 (0 filled)

# 4. Tap login button
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-text "Login" --tap

# 5. Enter text
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-type TextField --enter-text "user@test.com"

# 6. Check accessibility
python ~/.claude/skills/ios-simulator-skill/scripts/accessibility_audit.py
```

## 21 Scripts Organisés par Catégorie

### Construction & Développement
- **build_and_test.py** - Construire des projets, exécuter des tests, analyser les résultats
- **log_monitor.py** - Surveillance des journaux en temps réel

### Navigation & Interaction
- **screen_mapper.py** - Analyser l'écran actuel
- **navigator.py** - Trouver et interagir avec les éléments
- **gesture.py** - Balayages, défilements, pincements
- **keyboard.py** - Saisie de texte et boutons matériels
- **app_launcher.py** - Contrôle du cycle de vie des applications

### Tests & Analyse
- **accessibility_audit.py** - Vérification de conformité WCAG
- **visual_diff.py** - Comparaison de captures d'écran
- **test_recorder.py** - Documentation automatisée des tests
- **app_state_capture.py** - Instantanés pour le débogage
- **sim_health_check.sh** - Vérification de l'environnement

### Tests Avancés & Permissions
- **clipboard.py** - Gestion du presse-papiers
- **status_bar.py** - Contrôle de la barre d'état
- **push_notification.py** - Notifications push
- **privacy_manager.py** - Gestion des permissions

### Cycle de Vie de l’Appareil
- **simctl_boot.py** - Démarrer le simulateur
- **simctl_shutdown.py** - Arrêter le simulateur
- **simctl_create.py** - Créer un simulateur
- **simctl_delete.py** - Supprimer un simulateur
- **simctl_erase.py** - Réinitialisation d’usine

Voir **SKILL.md** pour la référence complète.

## Comment ça fonctionne avec Claude Code

Claude Code détecte automatiquement quand utiliser cette compétence en fonction de votre demande. Vous n’avez pas besoin de l’invoquer manuellement.

**Exemple de conversation :**

```
You: "Set up my iOS app for testing"
Claude: [Uses simctl_boot.py and app_launcher.py automatically]

You: "Tap the login button"
Claude: [Uses navigator.py to find and tap]

You: "Check if the form is accessible"
Claude: [Uses accessibility_audit.py]
```

Vous pouvez également exécuter des scripts manuellement si nécessaire.

## Exemples d'utilisation

### Exemple 1 : Flux de connexion

```bash
# Launch app
python scripts/app_launcher.py --launch com.example.app

# Map screen to find fields
python scripts/screen_mapper.py

# Enter credentials
python scripts/navigator.py --find-type TextField --index 0 --enter-text "user@test.com"
python scripts/navigator.py --find-type SecureTextField --enter-text "password"

# Tap login
python scripts/navigator.py --find-text "Login" --tap

# Verify accessibility
python scripts/accessibility_audit.py
```

### Exemple 2 : Documentation de test

```bash
# Record test execution
python scripts/test_recorder.py --test-name "Login Flow" --output test-reports/

# Generates:
# - Screenshots per step
# - Accessibility trees
# - Markdown report with timing
```

### Exemple 3 : Test Visuel

```bash
# Capture baseline
python scripts/app_state_capture.py --output baseline/

# Make changes...

# Compare
python scripts/visual_diff.py baseline/screenshot.png current/screenshot.png
```

### Exemple 4 : Test des permissions

```bash
# Grant permissions
python scripts/privacy_manager.py --bundle-id com.example.app --grant camera,location

# Test app behavior with permissions...

# Revoke permissions
python scripts/privacy_manager.py --bundle-id com.example.app --revoke camera,location
```

### Exemple 5 : Cycle de vie des appareils dans CI/CD

```bash
# Create test device
DEVICE_ID=$(python scripts/simctl_create.py --device "iPhone 16 Pro" --json | jq -r '.new_udid')

# Run tests
python scripts/build_and_test.py --project MyApp.xcodeproj

# Clean up
python scripts/simctl_delete.py --udid $DEVICE_ID --yes
```

## Principes de conception

**Navigation sémantique** : Trouver des éléments par leur signification (texte, type, ID) et non par coordonnées de pixels. Résiste aux changements d’interface et fonctionne sur différentes tailles d’appareils.

**Efficacité des tokens** : Sortie par défaut de 3 à 5 lignes. Utilisez `--verbose` pour les détails ou `--json` pour un traitement machine. Réduction de 96 % par rapport aux outils bruts.

**Accessibilité avant tout** : Basé sur les API d’accessibilité iOS pour une fiabilité accrue. Meilleur pour les utilisateurs avec besoins d’accessibilité et plus robuste pour l’automatisation.

**Aucune configuration** : Fonctionne immédiatement sur n’importe quel macOS avec Xcode. Pas d’installation complexe, pas de fichiers de configuration.

**Données structurées** : Les scripts produisent du JSON ou du texte formaté, pas des logs bruts. Facile à analyser, intégrer et comprendre.

**Apprentissage automatique** : Le système apprend la préférence de votre appareil et s’en souvient pour la prochaine fois.

## Exigences

**Système :**
- macOS 12 ou ultérieur
- Outils en ligne de commande Xcode
- Python 3

**Optionnel :**
- IDB (pour fonctionnalités interactives)
- Pillow (pour visual_diff.py : `pip3 install pillow`)

## Documentation

- **SKILL.md** - Référence complète des scripts et table des matières
- **CLAUDE.md** - Architecture et guide développeur
- **references/** - Documentation approfondie sur des sujets spécifiques
- **examples/** - Flux de travail d’automatisation complets

## Efficacité de sortie

Tous les scripts minimisent la sortie par défaut :

| Tâche | Outils bruts | Cette compétence | Économies |
|-------|--------------|------------------|-----------|
| Analyse d’écran | 200+ lignes | 5 lignes | 97,5 % |
| Trouver & appuyer sur le bouton | 100+ lignes | 1 ligne | 99% |
| Saisir du texte | 50+ lignes | 1 ligne | 98% |
| Flux de connexion | 400+ lignes | 15 lignes | 96% |

Cette efficacité permet de garder les conversations avec l’agent IA ciblées et rentables.

## Dépannage

### Problèmes d’environnement

```bash
# Run health check
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# Checks: macOS, Xcode, simctl, IDB, Python, simulators, packages
```

### Aide au script

```bash
# All scripts support --help
python scripts/navigator.py --help
python scripts/accessibility_audit.py --help
```

### Ne pas trouver les éléments

```bash
# Use verbose mode to see all elements
python scripts/screen_mapper.py --verbose

# Check for exact text match
python scripts/navigator.py --find-text "Exact Button Text" --tap
```
## Contribution

Les contributions doivent :
- Maintenir l'efficacité des tokens (sortie par défaut minimale)
- Suivre une conception axée sur l'accessibilité
- Supporter la documentation `--help`
- Supporter `--json` pour CI/CD
- Passer le formateur Black et le linter Ruff
- Inclure des annotations de type
- Mettre à jour SKILL.md

## Licence

Licence MIT - Autorise l'utilisation commerciale et la distribution.

## Support

- **Problèmes** : Créez un problème GitHub avec les étapes de reproduction
- **Documentation** : Voir SKILL.md et references/
- **Exemples** : Consultez le répertoire examples/
- **Docs Skills** : https://docs.claude.com/en/docs/claude-code/skills

---

**Conçu pour les agents IA. Optimisé pour les développeurs.**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---