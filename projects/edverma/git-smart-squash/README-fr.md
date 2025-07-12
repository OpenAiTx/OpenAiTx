# Git Smart Squash

Arrêtez de perdre du temps à réorganiser manuellement vos commits. Laissez l'IA le faire pour vous.

## Le problème

Vous connaissez la situation : 15 commits pour une fonctionnalité, dont la moitié sont "fix", "typo" ou "WIP". Maintenant, vous devez tout nettoyer pour la revue de PR. Écraser et réécrire manuellement est fastidieux.

## La solution

Git Smart Squash analyse vos modifications et les réorganise en commits logiques avec des messages appropriés :

```bash
# Avant : votre branche en désordre
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Après : des commits propres et logiques
* feat : implémenter le système d’authentification JWT
* test : ajouter la couverture du point de terminaison auth
```

## Démarrage rapide

### 1. Installation

```bash
# Avec pip
pip install git-smart-squash

# Avec pipx (recommandé pour une installation isolée)
pipx install git-smart-squash

# Avec uv (gestionnaire de paquets Python rapide)
uv tool install git-smart-squash
```
### 2. Configurer l'IA

**Option A : Local (Gratuit, Privé)**
```bash
# Installer Ollama depuis https://ollama.com
ollama pull devstral  # Modèle par défaut
```

**Option B : Cloud (Meilleurs résultats)**
```bash
export OPENAI_API_KEY="votre-clé"
export ANTHROPIC_API_KEY="votre-clé"
export GEMINI_API_KEY="votre-clé"
```

### 3. Exécuter

```bash
cd votre-repo
git-smart-squash
```
C'est tout. Passez en revue le plan et approuvez.

## Paramètres de ligne de commande

| Paramètre | Description | Valeur par défaut |
|-----------|-------------|-------------------|
| `--base` | Branche de base à comparer | Fichier de config ou `main` |
| `--ai-provider` | Fournisseur d’IA à utiliser (openai, anthropic, local, gemini) | Configuré dans les paramètres |
| `--model` | Modèle d’IA spécifique à utiliser (voir modèles recommandés ci-dessous) | Par défaut du fournisseur |
| `--config` | Chemin vers le fichier de configuration personnalisé | `.git-smart-squash.yml` ou `~/.git-smart-squash.yml` |
| `--auto-apply` | Appliquer le plan de commit sans demande de confirmation | `false` |
| `--instructions`, `-i` | Instructions personnalisées pour l’IA (ex : "Regrouper par domaine fonctionnel") | Aucune |
| `--no-attribution` | Désactiver le message d’attribution dans les commits | `false` |
| `--debug` | Activer les logs de débogage pour des informations détaillées | `false` |

## Modèles recommandés

### Modèles par défaut
- **OpenAI** : `gpt-4.1` (par défaut)
- **Anthropic** : `claude-sonnet-4-20250514` (par défaut)
- **Gemini** : `gemini-2.5-pro` (par défaut)
- **Local/Ollama** : `devstral` (par défaut)

### Sélection du Modèle
```bash
# Spécifier un modèle différent
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Pour Ollama en local
git-smart-squash --ai-provider local --model llama-3.1
```

## Instructions Personnalisées

Le paramètre `--instructions` vous permet de contrôler comment les commits sont organisés :

### Exemples
```bash
# Ajouter des préfixes de ticket
git-smart-squash -i "Préfixer tous les commits avec [ABC-1234]"

# Séparer par type
git-smart-squash -i "Garder les modifications backend et frontend dans des commits séparés"
```
# Limiter le nombre de commits
git-smart-squash -i "Créer au maximum 3 commits au total"
```

### Conseils pour de meilleurs résultats
- **Soyez spécifique** : "Regrouper les migrations de base de données séparément" fonctionne mieux que "organiser proprement"
- **Une instruction à la fois** : Les instructions complexes en plusieurs parties peuvent être partiellement ignorées
- **Utilisez de meilleurs modèles** : Les modèles plus grands suivent les instructions plus fidèlement que les modèles plus petits

## Cas d'utilisation courants

### "J'ai besoin de nettoyer avant la revue PR"
```bash
git-smart-squash              # Affiche le plan et demande une confirmation
git-smart-squash --auto-apply # Applique automatiquement sans demander
```

### "Je travaille avec une branche principale différente"
```bash
git-smart-squash --base develop
```
### "Je veux utiliser un fournisseur d'IA spécifique"
```bash
git-smart-squash --ai-provider openai
```

## Sécurité

**Votre code est en sécurité :**
- Affiche le plan avant d'apporter des modifications
- Crée une branche de sauvegarde automatique
- Nécessite un répertoire de travail propre
- Ne pousse jamais sans votre commande

**En cas de problème :**
```bash
# Trouver la sauvegarde
git branch | grep backup

# Restaurer
git reset --hard your-branch-backup-[timestamp]
```

## Fournisseurs d’IA

| Fournisseur | Coût  | Confidentialité |
|-------------|-------|----------------|
| **Ollama**  | Gratuit | Local         |
| **OpenAI**  | ~0,01 $ | Cloud         |
| **Anthropic** | ~0,01 $ | Cloud       |
| **Gemini**  | ~0,01 $ | Cloud         |

## Configuration avancée (optionnel)

Vous souhaitez personnaliser ? Créez un fichier de configuration :

**Spécifique au projet** (`.git-smart-squash.yml` dans votre dépôt) :
```yaml
ai:
  provider: openai   # Utiliser OpenAI pour ce projet
base: develop        # Utiliser develop comme branche de base pour ce projet
```
**Défaut global** (`~/.git-smart-squash.yml`) :
```yaml
ai:
  provider: local   # Toujours utiliser l’IA locale par défaut
base: main          # Branche de base par défaut pour tous les projets
```

## Dépannage

### Erreur "Invalid JSON"
Cela signifie généralement que le modèle d’IA n’a pas pu formater correctement la réponse :
- **Avec Ollama** : Passez de `llama2` à `mistral` ou `mixtral`
- **Solution** : `ollama pull mistral` puis réessayez
- **Alternative** : Utilisez un fournisseur cloud avec `--ai-provider openai`

### Le modèle ne suit pas les instructions
Certains modèles ont du mal avec des instructions complexes :
- **Utilisez de meilleurs modèles** : `--model gpt-4-turbo` ou `--model claude-3-opus`
- **Simplifiez les instructions** : Une directive claire fonctionne mieux que plusieurs
- **Soyez explicite** : "Préfixer avec [ABC-123]" et non "ajouter le numéro du ticket"

### "Ollama introuvable" 
```bash
# Installer depuis https://ollama.com
ollama serve
ollama pull devstral  # Modèle par défaut
```

### Mauvais groupement des commits
Si l'IA crée trop de commits ou ne les regroupe pas correctement :
- **Modèle insuffisant** : Utilisez un modèle plus grand
- **Ajouter des instructions** : `-i "Regrouper les modifications liées, maximum 3 commits"`
- **Donner un retour** : Créez un ticket sur GitHub et dites-nous ce qui s’est passé

### Problèmes d'installation (Mac)
Si vous n'avez pas pip ou préférez des installations isolées :
```bash
# Utiliser pipx (recommandé)
brew install pipx
pipx install git-smart-squash
```
### "Aucun changement à réorganiser"
```bash
git log --oneline main..HEAD  # Vérifiez que vous avez des commits
git diff main                 # Vérifiez que vous avez des modifications
```

### Grandes différences / Limites de jetons
Les modèles locaux ont une limite d’environ 32k jetons. Pour les modifications importantes :
- Utilisez `--base` avec un commit plus récent
- Passez au cloud : `--ai-provider openai`
- Divisez en plus petites PR

### Besoin de plus d’aide ?

Consultez notre [documentation détaillée](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) ou ouvrez un ticket !

## Licence

Licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---