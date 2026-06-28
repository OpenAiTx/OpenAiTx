<div align="center">
  <img src="https://raw.githubusercontent.com/micr0-dev/Altbot/main/assets/micr0-alty-banner.png" alt="Une bannière décorative présentant un motif répétitif de petites icônes de robot violet sur un fond clair, créant un effet de papier peint rétro-tech">

# Altbot アクセシビリティロボット

_Rendre le Fediverse plus inclusif, une image à la fois_

[![Dernière version](https://img.shields.io/github/v/release/micr0-dev/Altbot)](https://github.com/micr0-dev/Altbot/releases)
[![Suivre sur Mastodon](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)
[![Licence : AGPLv3](https://img.shields.io/badge/License-AGPLv3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)
[![Version Go](https://img.shields.io/github/go-mod/go-version/micr0-dev/Altbot)](https://go.dev/)
![Statut](https://img.shields.io/badge/status-active-success)
![Environnement](https://img.shields.io/badge/environment-friendly-green)

</div>

## À propos

Altbot est un bot d’accessibilité open-source conçu pour améliorer le Fediverse en générant des descriptions alt-text pour les images, vidéos et audios. Cela aide à rendre le contenu plus accessible aux utilisateurs malvoyants.

## Confidentialité & Conformité au RGPD

**Altbot 2.0 traite désormais tout localement à 100 % sans aucune conservation des données !** [![Suivre sur Mastodon](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)

Conformément au RGPD, Altbot requiert un consentement éclairé explicite avant de traiter toute requête utilisateur. Lors de votre première interaction avec Altbot, vous recevrez une demande de consentement contenant des informations sur les pratiques de collecte des données et un lien vers notre [Politique de Confidentialité](https://raw.githubusercontent.com/micr0-dev/Altbot/main/PRIVACY.md).

- **Ce que nous collectons :** Horodatage des requêtes, temps de traitement, préférences linguistiques, type de média
- **Ce que nous ne collectons pas :** Images, informations personnelles, contenu de vos publications
- **Comment révoquer le consentement :** Il suffit de bloquer le compte du bot

Le contenu de vos publications n’est jamais sauvegardé ni partagé. Seules les images sans alt-text existant seront traitées, et tout le traitement se fait en privé sur notre serveur local.

## Avertissement

Les alt-texts sont générés à l’aide d’un grand modèle de langage (LLM). Bien que nous visons l’exactitude, les résultats peuvent parfois être factuellement incorrects. Vérifiez toujours l’alt-text avant de l’utiliser.

## Comment ça marche

Altbot écoute les mentions et les suivis sur Mastodon. Lorsqu’il détecte une mention ou une nouvelle publication d’un utilisateur suivi, il vérifie la présence d’images sans alt-text. S’il en trouve, il utilise un grand modèle de langage (LLM) pour générer un alt-text descriptif et répond avec le texte généré.

### Fonctionnalités

- **Génération de texte alternatif basée sur les mentions :** Mentionnez @Altbot dans une réponse à n'importe quel post contenant une image, une vidéo ou un audio, et Altbot générera une description en texte alternatif.
- **Texte alternatif automatique pour les abonnés :** Suivez @Altbot, et il surveillera vos publications. Si vous publiez une image, une vidéo ou un audio sans texte alternatif, Altbot en générera automatiquement un pour vous.
- **Support LLM local :** Utilisez des LLM locaux via Ollama pour générer des descriptions en texte alternatif.
- **Conformité RGPD :** Système de consentement éclairé explicite qui exige que les utilisateurs donnent leur accord avant le traitement de leurs demandes, avec des informations claires sur l'utilisation des données.
- **Demandes de consentement :** Demandez le consentement de l’auteur original avant de générer un texte alternatif lorsqu’il est mentionné par des utilisateurs autres que l’auteur.
- **Paramètres configurables :** Configurez facilement le bot à l’aide d’un fichier TOML.

## Installation

### Standard

1. Clonez le dépôt :

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```
2. Lancez l'assistant d'installation :


   ```sh
   go run .
   ```

   L'assistant de configuration vous guidera pour configurer les valeurs essentielles requises pour le bot, y compris :

   - L'URL de votre serveur Mastodon, le secret client, le jeton d'accès et le nom d'utilisateur du bot.
   - Le pseudo du contact administrateur pour les notifications de modération.
   - L'activation des fonctionnalités optionnelles telles que les métriques et les rappels de texte alternatif.

   Alternativement, copiez le fichier de configuration exemple et modifiez-le manuellement :

   ```sh
   cp example.config.toml config.toml
   ```

3. Exécutez le bot :
   ```sh
   go run .
   ```

### Docker

1. Clonez le dépôt :

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. Exécutez l'assistant d'installation :

   ```sh
   docker run -it -v ./:/data --rm ghcr.io/micr0-dev/altbot:latest
   ```

   L'assistant de configuration vous guidera pour configurer les valeurs essentielles requises pour le bot, y compris :

   - L'URL de votre serveur Mastodon, le secret client, le jeton d'accès et le nom d'utilisateur du bot.
   - Le contact administrateur pour les notifications de modération.
   - L'activation des fonctionnalités optionnelles comme les métriques et les rappels de texte alternatif.

   Alternativement, copiez le fichier de configuration exemple et modifiez-le manuellement :

   ```sh
   cp example.config.toml config.toml
   ```
3. Exécutez le bot :

   ```sh
   docker compose up -d
   ```

## Configuration du développement

### Prérequis

- **Go 1.24+** : Installer depuis [go.dev](https://go.dev/dl/)
- **Fournisseur LLM** (un des suivants) :
  - **API Gemini** : Obtenez une clé API depuis [Google AI Studio](https://aistudio.google.com/app/apikey)
  - **Ollama** : Installez depuis [ollama.ai](https://ollama.ai/) et téléchargez un modèle vision (ex. `ollama pull llava-phi3`)
  - **Transformers** : Nécessite Python avec la bibliothèque transformers et un GPU compatible

### Démarrage

1. Clonez le dépôt :

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. Installer les dépendances :

   ```sh
   go mod download
   ```

3. Copier et configurer le fichier de configuration :

   ```sh
   cp example.config.toml config.toml
   # Edit config.toml with your LLM API and model of choice
   ```

4. Exécutez le bot :
   ```sh
   go run .
   ```

### Mode Développement

Utilisez le drapeau `--dev` pour exécuter le bot en mode développement. Cela fournit une interface en ligne de commande interactive pour tester sans publier sur Mastodon :

```sh
go run . --dev
```

**Remarque :** Le mode développeur ignore l'authentification Mastodon, mais vous devez toujours disposer d'une API LLM valide (Gemini, Ollama, etc.) configurée dans `config.toml` pour tester le traitement d'images/vidéos/audio.

#### Commandes du mode développeur

| Commande       | Description                                       |
| -------------- | ------------------------------------------------ |
| `/image <url>` | Traiter une URL d'image et générer un texte alt  |
| `/video <url>` | Traiter une URL vidéo et générer un texte alt    |
| `/audio <url>` | Traiter une URL audio et générer un texte alt    |
| `/lang [code]` | Définir/afficher la langue des réponses (ex : en, de, ja) |
| `/follow`      | Simuler un événement de suivi                     |
| `/status`      | Afficher le statut actuel du mode développeur     |
| `/help`        | Afficher les commandes disponibles                |
| `/quit`        | Quitter le mode développeur                        |

Vous pouvez également coller une URL directement pour la traiter comme une image.

**Exemple de session :**

```
[dev] > /lang de
Language set to: de

[dev] > https://example.com/image.jpg
Processing image: https://example.com/image.jpg
Please wait...

=== Generated Alt-Text ===
Ein Foto von...
```

### Construction

```sh
go build -o altbot .
```

## Contribution

Nous accueillons les contributions ! Veuillez ouvrir un problème ou soumettre une demande de tirage avec vos améliorations.

## Support / Communauté

Des questions ? Vous voulez discuter ? Rejoignez-nous sur [chat.micr0.dev](https://chat.micr0.dev)

Canaux : #dev pour les discussions sur le projet, #help pour le support

IRC : irc.micr0.dev (ports 6667/6697)

## Merci

### Remerciements Spéciaux

Je tiens à exprimer ma plus profonde gratitude à **Henrik Schönemann** ([@Schoeneh](https://github.com/Schoeneh)) qui m’a motivé tout au long de ce parcours. Son aide pour gérer la critique et la transformer en retour constructif a été inestimable. Je ne serais vraiment pas là où je suis aujourd’hui sans son soutien et ses conseils.

### Supporters Ko-fi

Un grand merci à tous mes supporters [Ko-fi](https://ko-fi.com/) ! Vos contributions généreuses aident à faire fonctionner Altbot et à l’améliorer continuellement. Votre soutien signifie beaucoup pour moi et contribue à rendre le Fediverse plus accessible à tous.

## Licence

Ce projet est sous licence [GNU AFFERO GENERAL PUBLIC LICENSE Version 3 (AGPLv3).](https://www.gnu.org/licenses/agpl-3.0.en.html) Voir le fichier [LICENSE](LICENSE) pour plus de détails.

---

Rejoignez-nous pour rendre le Fediverse plus inclusif pour tous !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---