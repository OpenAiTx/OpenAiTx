# llum

### Une interface de chat rapide, légère et ouverte

![image](https://github.com/user-attachments/assets/38cc47cf-06a3-4dca-8ee5-d9c9edf57903)

### Fonctionnalités clés :

- 🔌 Plusieurs fournisseurs, branchez vos clés API (stockées entièrement localement) et vous êtes prêt à partir

  - Modèles locaux (via Ollama)
  - OpenRouter (qui vous permet d'utiliser TOUS les modèles de nombreux fournisseurs : OpenAI, Anthropic, OSS, plus de 50 autres)
  - OpenAI
  - Anthropic
  - Mistral
  - Groq

- 🛠️ Utilisation d’outils
  - Consultez `server/toolfns/toolfns.go`. Vous n’avez qu’à écrire des fonctions. Le commentaire de la fonction est la description que le modèle reçoit, il sait donc quoi utiliser. Cliquez sur le bouton `Sync` dans l’interface web pour actualiser vos outils.
- 🖼️ Entrée multimodale : téléchargez, collez ou partagez des liens vers des images
- 🎨 Génération d’images avec DALL-E 3
- 📝 Prompting multi-shot. Éditez, supprimez, régénérez des messages, faites ce que vous voulez. Le monde est à vous
- ⚡ Réponses pré-remplies (lorsque supportées par le fournisseur)
- 🌐 Support de tous les modèles disponibles chez tous les fournisseurs
- 🔄 Changement de modèle en cours de conversation
- 🔐 Synchronisation des conversations et des clés entre appareils, chiffrée de bout en bout. Auto-hébergé, ou utilisez notre instance hébergée.
- 🔗 Partage de conversation (si vous choisissez de partager, votre conversation doit être stockée sur un serveur externe pour que le lien de partage soit disponible. Options de partage auto-hébergées à venir. Non, je ne consulterai rien de vos données.)
- 🌿 Historique de conversation en branches (comme les flèches gauche-droite de ChatGPT que vous pouvez cliquer pour revenir à une réponse précédente)

### Confidentialité :

- Complètement privé et transparent. Tout votre historique de conversation et vos clés sont stockés entièrement localement, uniquement dans votre navigateur, sur votre appareil.

## Comment installer ?

Si vous ne souhaitez pas utiliser d’outils, vous n’avez rien à installer. Une instance hébergée est disponible sur : https://llum.chat

Si vous voulez utiliser des outils, suivez les instructions ci-dessous.

## Binaire unique :

Le serveur d’outils llum est disponible précompilé en un seul binaire. [Téléchargez le package précompilé depuis la page des releases.](https://github.com/zakkor/llum/releases)

Téléchargez le binaire pour votre plateforme, puis lancez-le, ce qui démarrera le serveur d’outils :

```
./llum-darwin-amd64
Tool server running at http://localhost:8081
```

Retournez sur https://llum.chat, allez dans Paramètres -> Appel d’outil, et cliquez sur le bouton "Actualiser les outils". Vous devriez être prêt à partir !

### Construction du client et du serveur localement :

1. Clonez le dépôt
2. Installez et démarrez le client : `npm i && npm run dev`. Le client sera accessible à http://localhost:5173
3. Installez et démarrez le serveur : `cd server && go generate ./... && go build && ./server -password foobar`. Le serveur sera accessible à http://localhost:8081. Vous pouvez connecter cela à l'adresse du serveur dans l'interface de chat avec le mot de passe que vous avez choisi.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---