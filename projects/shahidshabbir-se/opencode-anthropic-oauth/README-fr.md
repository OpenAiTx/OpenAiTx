# opencode-anthropic-oauth

Plugin OpenCode pour la connexion OAuth Anthropic Claude Pro/Max — aucun code Claude requis.

## Ce que cela fait

Vous permet de vous authentifier avec votre abonnement Claude Pro/Max directement dans OpenCode via OAuth navigateur. Pas besoin d’installer Claude Code ou de gérer des fichiers de crédentiels.

## Installation

```bash
npm install -g opencode-anthropic-oauth
```

Ajoutez ensuite à votre `opencode.json` :

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```

## Utilisation

1. Exécutez `/connect` dans OpenCode (ou `oc auth login` depuis la CLI)  
2. Sélectionnez **Anthropic** > **Claude Pro/Max**  
3. Ouvrez le lien dans votre navigateur et autorisez  
4. Collez le code dans OpenCode  
5. Terminé — tous les modèles Anthropic sont maintenant disponibles  

## Fonctionnement

- Implémente le flux OAuth PKCE directement via les endpoints d'authentification Anthropic  
- Ouvre votre navigateur pour l'authentification — vous vous connectez avec votre compte Claude  
- Échange le code d'autorisation contre des tokens d'accès + de rafraîchissement  
- **Rafraîchit automatiquement les tokens** à leur expiration — pas besoin de re-authentification manuelle  
- Définit les en-têtes API requis sur les requêtes Anthropic  
- **Préserve la mise en cache des invites** pour une utilisation efficace des tokens  

## Journal des modifications

### 0.4.1  
- **Correction de la consommation élevée de tokens** — suppression du `cache_control` qui désactivait la mise en cache des invites  
- Ajout de `x-anthropic-billing-header` pour un suivi correct des tokens  
- Alignement des flags beta avec le plugin officiel Claude CLI  

### 0.4.0  
- Ajout du paramètre URL `?beta=true` pour compatibilité OAuth  
- Injection du préfixe d’identité système pour la beta claude-code  
- Suppression du `cache_control` (maintenant corrigée en 0.4.1)  

### 0.3.0  
- Ajout du rafraîchissement automatique des tokens via hook de chargeur  
- Minuteur de rafraîchissement proactif en arrière-plan (intervalles de 5 min)  

## Surcharges des variables d’environnement

Tous les paramètres OAuth peuvent être surchargés via des variables d’environnement. Si Anthropic change quelque chose avant que nous publiions une mise à jour, définissez une variable d’environnement et continuez à travailler :  

| Variable | Description |

| `ANTHROPIC_CLIENT_ID` | ID client OAuth |
| `ANTHROPIC_CLI_VERSION` | Version CLI Claude pour User-Agent |
| `ANTHROPIC_USER_AGENT` | Chaîne complète User-Agent (remplace la version) |
| `ANTHROPIC_AUTHORIZE_URL` | Point de terminaison d'autorisation OAuth |
| `ANTHROPIC_TOKEN_URL` | Point de terminaison de jeton OAuth |
| `ANTHROPIC_REDIRECT_URI` | URI de redirection OAuth |
| `ANTHROPIC_SCOPES` | Périmètres OAuth |
| `ANTHROPIC_BETA_FLAGS` | Indicateurs de fonctionnalités bêta Anthropic |

Exemple :

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## Avertissement

Ce plugin utilise l'ID client OAuth public d'Anthropic pour s'authentifier. Les conditions d'utilisation d'Anthropic (février 2026) stipulent que les tokens d'abonnement Claude Pro/Max doivent uniquement être utilisés avec les clients officiels d'Anthropic. Ce plugin existe comme solution communautaire de contournement et peut cesser de fonctionner si Anthropic modifie son infrastructure OAuth. Utilisez-le à votre propre discrétion.

## Licence

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---