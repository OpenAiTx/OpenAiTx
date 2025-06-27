# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Capture d'écran Gemini CLI](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Ce dépôt contient Gemini CLI, un outil de workflow IA en ligne de commande qui se connecte à vos outils, comprend votre code et accélère vos flux de travail.

Avec Gemini CLI, vous pouvez :

- Interroger et modifier de grandes bases de code, dans et au-delà de la fenêtre de contexte de 1M de tokens de Gemini.
- Générer de nouvelles applications à partir de PDF ou de croquis, en utilisant les capacités multimodales de Gemini.
- Automatiser des tâches opérationnelles, comme interroger des pull requests ou gérer des rebase complexes.
- Utiliser des outils et des serveurs MCP pour connecter de nouvelles capacités, notamment la [génération de médias avec Imagen, Veo ou Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Ancrer vos requêtes grâce à l’outil [Google Search](https://ai.google.dev/gemini-api/docs/grounding), intégré à Gemini.

## Démarrage rapide

1. **Prérequis :** Assurez-vous d’avoir [Node.js version 18](https://nodejs.org/en/download) ou une version supérieure installée.
2. **Exécutez le CLI :** Exécutez la commande suivante dans votre terminal :

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Ou installez-le avec :

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Choisissez un thème de couleurs**
4. **Authentifiez-vous :** Lorsque vous y êtes invité, connectez-vous avec votre compte Google personnel. Cela vous permettra d’effectuer jusqu’à 60 requêtes de modèle par minute et 1 000 requêtes de modèle par jour avec Gemini.

Vous êtes maintenant prêt à utiliser Gemini CLI !

### Pour un usage avancé ou des limites augmentées :

Si vous avez besoin d’utiliser un modèle spécifique ou d’une capacité de requêtes plus élevée, vous pouvez utiliser une clé API :

1. Générez une clé depuis [Google AI Studio](https://aistudio.google.com/apikey).
2. Définissez-la comme variable d’environnement dans votre terminal. Remplacez `YOUR_API_KEY` par votre clé générée.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Pour d’autres méthodes d’authentification, y compris les comptes Google Workspace, consultez le guide [authentication](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Exemples

Une fois le CLI lancé, vous pouvez commencer à interagir avec Gemini depuis votre shell.

Vous pouvez démarrer un projet à partir d’un nouveau dossier :

```sh
cd new-project/
gemini
> Écris-moi un bot Discord Gemini qui répond aux questions en utilisant un fichier FAQ.md que je fournirai
```

Ou travailler sur un projet existant :

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Donne-moi un résumé de tous les changements qui ont eu lieu hier
```

### Prochaines étapes

- Apprenez à [contribuer ou compiler depuis la source](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Explorez les **[commandes CLI disponibles](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Si vous rencontrez des problèmes, consultez le **[guide de dépannage](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Pour une documentation plus complète, consultez la [documentation complète](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Jetez un œil à quelques [tâches populaires](#popular-tasks) pour plus d’inspiration.

### Dépannage

Consultez le guide de [dépannage](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) si vous rencontrez des problèmes.

## Tâches populaires

### Explorer une nouvelle base de code

Commencez par faire un `cd` dans un dépôt existant ou nouvellement cloné puis exécutez `gemini`.

```text
> Décris les principales composantes de l’architecture de ce système.
```

```text
> Quels mécanismes de sécurité sont en place ?
```

### Travailler avec votre code existant

```text
> Implémente un premier jet pour l’issue GitHub #123.
```

```text
> Aide-moi à migrer cette base de code vers la dernière version de Java. Commence par un plan.
```

### Automatiser vos flux de travail

Utilisez des serveurs MCP pour intégrer vos outils système locaux à votre suite de collaboration d’entreprise.

```text
> Fais-moi une présentation de type slide montrant l’historique git des 7 derniers jours, groupé par fonctionnalité et membre de l’équipe.
```

```text
> Crée une application web plein écran pour un affichage mural afin de montrer nos tickets GitHub les plus consultés.
```

### Interagir avec votre système

```text
> Convertis toutes les images de ce dossier en png, et renomme-les en utilisant les dates des données exif.
```

```text
> Organise mes factures PDF par mois de dépense.
```

## Conditions d'utilisation et avis de confidentialité

Pour plus de détails sur les conditions d’utilisation et l’avis de confidentialité applicables à votre utilisation de Gemini CLI, consultez les [Conditions d'utilisation et avis de confidentialité](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---