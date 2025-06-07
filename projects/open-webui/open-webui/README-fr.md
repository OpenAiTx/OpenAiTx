# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI est une plateforme IA auto-hébergée [extensible](https://docs.openwebui.com/features/plugin/), riche en fonctionnalités et conviviale, conçue pour fonctionner entièrement hors-ligne.** Elle prend en charge divers moteurs LLM tels que **Ollama** et les **API compatibles OpenAI**, avec un **moteur d’inférence intégré** pour le RAG, ce qui en fait une **solution de déploiement IA puissante**.

![Démonstration Open WebUI](./demo.gif)

> [!TIP]  
> **Vous cherchez une [offre Entreprise](https://docs.openwebui.com/enterprise) ?** – **[Contactez notre équipe commerciale dès aujourd'hui !](mailto:sales@openwebui.com)**
>
> Profitez de **capacités améliorées**, dont **thématisation et branding sur mesure**, **support SLA**, **versions LTS** et **bien plus !**

Pour plus d’informations, consultez notre [documentation Open WebUI](https://docs.openwebui.com/).

## Fonctionnalités clés d’Open WebUI ⭐

- 🚀 **Installation sans effort** : Installez facilement avec Docker ou Kubernetes (kubectl, kustomize ou helm) pour une expérience sans tracas avec prise en charge des images taguées `:ollama` et `:cuda`.

- 🤝 **Intégration API Ollama/OpenAI** : Intégrez aisément les API compatibles OpenAI pour des conversations polyvalentes avec les modèles Ollama. Personnalisez l’URL de l’API OpenAI pour vous connecter à **LMStudio, GroqCloud, Mistral, OpenRouter, et plus encore**.

- 🛡️ **Permissions granulaires et groupes d’utilisateurs** : En permettant aux administrateurs de créer des rôles et permissions détaillés, nous garantissons un environnement utilisateur sécurisé. Cette granularité renforce la sécurité et permet des expériences personnalisées, favorisant l’engagement et la responsabilité des utilisateurs.

- 📱 **Design adaptatif** : Profitez d’une expérience fluide sur PC de bureau, ordinateur portable et appareils mobiles.

- 📱 **Application Web Progressive (PWA) pour mobile** : Bénéficiez d’une expérience proche d’une application native sur votre mobile grâce à notre PWA, permettant un accès hors-ligne sur localhost et une interface utilisateur fluide.

- ✒️🔢 **Prise en charge complète de Markdown et LaTeX** : Améliorez votre expérience LLM avec un support complet de Markdown et LaTeX pour des interactions enrichies.

- 🎤📹 **Appels vocaux/vidéo mains-libres** : Profitez d’une communication fluide avec les fonctionnalités intégrées d’appel vocal et vidéo, rendant l’environnement de chat plus dynamique et interactif.

- 🛠️ **Créateur de modèles** : Créez facilement des modèles Ollama via l’interface Web. Ajoutez des personnages/agents personnalisés, personnalisez les éléments de chat et importez des modèles simplement grâce à l’intégration de la [communauté Open WebUI](https://openwebui.com/).

- 🐍 **Outil natif d’appel de fonctions Python** : Améliorez vos LLM avec un éditeur de code intégré dans l’espace outils. Apportez vos propres fonctions Python (BYOF) en ajoutant simplement vos fonctions pures Python, permettant une intégration fluide avec les LLM.

- 📚 **Intégration RAG locale** : Découvrez le futur des interactions de chat avec un support innovant de la génération augmentée par récupération (RAG). Chargez des documents directement dans le chat ou ajoutez des fichiers à votre bibliothèque pour les accéder facilement via la commande `#` avant une requête.

- 🔍 **Recherche web pour RAG** : Effectuez des recherches web avec des fournisseurs comme `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` et `Bing`, et injectez les résultats directement dans votre expérience de chat.

- 🌐 **Navigation web intégrée** : Intégrez facilement des sites web dans votre expérience de chat en utilisant la commande `#` suivie d’une URL. Cette fonctionnalité enrichit la profondeur de vos conversations.

- 🎨 **Intégration de la génération d’images** : Incorporez la génération d’images via l’API AUTOMATIC1111, ComfyUI (local) ou DALL-E d’OpenAI (externe), pour enrichir vos chats de contenus visuels dynamiques.

- ⚙️ **Conversations multi-modèles** : Interagissez simultanément avec plusieurs modèles, tirant parti de leurs points forts respectifs pour des réponses optimales. Profitez d’un ensemble diversifié de modèles en parallèle.

- 🔐 **Contrôle d’accès basé sur les rôles (RBAC)** : Garantissez un accès sécurisé avec des permissions restreintes ; seuls les utilisateurs autorisés peuvent accéder à votre Ollama et seuls les administrateurs peuvent créer/télécharger des modèles.

- 🌐🌍 **Support multilingue** : Utilisez Open WebUI dans votre langue grâce à la prise en charge de l’internationalisation (i18n). Rejoignez-nous pour élargir la liste des langues ! Nous recherchons activement des contributeurs !

- 🧩 **Pipelines, support des plugins Open WebUI** : Intégrez facilement des logiques personnalisées et des bibliothèques Python via le [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Lancez votre instance Pipelines, définissez l’URL OpenAI sur celle de Pipelines, et explorez de nombreuses possibilités. [Exemples](https://github.com/open-webui/pipelines/tree/main/examples) : **Appel de fonctions**, **limitation de débit** utilisateur, **suivi d’utilisation** avec Langfuse, **traduction en direct avec LibreTranslate** pour le multilingue, **filtrage de messages toxiques** et bien plus.

- 🌟 **Mises à jour continues** : Nous nous engageons à améliorer Open WebUI avec des mises à jour régulières, correctifs et nouvelles fonctionnalités.

Vous souhaitez en savoir plus sur les fonctionnalités d’Open WebUI ? Consultez notre [documentation Open WebUI](https://docs.openwebui.com/features) pour une vue d’ensemble complète !

## Sponsors 🙌

#### Émeraude

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Votre interface a-t-elle déjà un backend ?<br>Essayez <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Le terminal intelligent pour les développeurs
    </td>
  </tr>
</table>

---

Nous sommes extrêmement reconnaissants envers nos sponsors pour leur soutien généreux. Leurs contributions nous aident à maintenir et à améliorer notre projet, assurant ainsi la qualité de notre travail pour la communauté. Merci !

## Comment installer 🚀

### Installation via pip Python 🐍

Open WebUI peut être installé avec pip, le gestionnaire de paquets Python. Avant de commencer, assurez-vous d’utiliser **Python 3.11** pour éviter tout problème de compatibilité.

1. **Installer Open WebUI** :
   Ouvrez votre terminal et exécutez la commande suivante pour installer Open WebUI :

   ```bash
   pip install open-webui
   ```

2. **Lancer Open WebUI** :
   Après l’installation, démarrez Open WebUI avec :

   ```bash
   open-webui serve
   ```

Cela lancera le serveur Open WebUI, accessible à l’adresse [http://localhost:8080](http://localhost:8080)

### Démarrage rapide avec Docker 🐳

> [!NOTE]  
> Veuillez noter que certains environnements Docker nécessitent des configurations supplémentaires. Si vous rencontrez des problèmes de connexion, notre guide détaillé dans la [documentation Open WebUI](https://docs.openwebui.com/) est là pour vous aider.

> [!WARNING]
> Lors de l’utilisation de Docker pour installer Open WebUI, assurez-vous d’inclure `-v open-webui:/app/backend/data` dans votre commande Docker. Cette étape est cruciale pour que votre base de données soit bien montée et éviter toute perte de données.

> [!TIP]  
> Pour utiliser Open WebUI avec Ollama inclus ou l’accélération CUDA, nous recommandons d’utiliser nos images officielles taguées `:cuda` ou `:ollama`. Pour activer CUDA, vous devez installer le [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) sur votre système Linux/WSL.

### Installation avec la configuration par défaut

- **Si Ollama est sur votre ordinateur**, utilisez cette commande :

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Si Ollama est sur un autre serveur**, utilisez cette commande :

  Pour vous connecter à Ollama sur un autre serveur, changez `OLLAMA_BASE_URL` par l’URL du serveur :

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://exemple.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Pour exécuter Open WebUI avec le support GPU Nvidia**, utilisez cette commande :

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Installation pour utilisation exclusive de l’API OpenAI

- **Si vous n’utilisez que l’API OpenAI**, utilisez cette commande :

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Installer Open WebUI avec Ollama intégré

Cette méthode d’installation utilise une seule image de conteneur regroupant Open WebUI et Ollama, permettant une mise en place simplifiée en une commande. Choisissez la commande appropriée selon votre matériel :

- **Avec support GPU** :
  Utilisez les ressources GPU avec la commande suivante :

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Pour CPU uniquement** :
  Si vous n’utilisez pas de GPU, utilisez plutôt cette commande :

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Ces deux commandes permettent une installation intégrée et simplifiée d’Open WebUI et Ollama, pour un démarrage rapide.

Après installation, accédez à Open WebUI à l’adresse [http://localhost:3000](http://localhost:3000). Bonne utilisation ! 😄

### Autres méthodes d’installation

Nous proposons différentes alternatives, y compris des méthodes d’installation natives (hors Docker), Docker Compose, Kustomize et Helm. Consultez notre [documentation Open WebUI](https://docs.openwebui.com/getting-started/) ou rejoignez notre [communauté Discord](https://discord.gg/5rJgQTnV4s) pour un accompagnement complet.

### Dépannage

Vous rencontrez des problèmes de connexion ? Notre [documentation Open WebUI](https://docs.openwebui.com/troubleshooting/) vous guide. Pour toute aide supplémentaire et rejoindre notre communauté dynamique, rendez-vous sur le [Discord Open WebUI](https://discord.gg/5rJgQTnV4s).

#### Open WebUI : Erreur de connexion au serveur

Si vous avez des problèmes de connexion, c’est souvent parce que le conteneur docker WebUI ne peut pas atteindre le serveur Ollama à 127.0.0.1:11434 (host.docker.internal:11434) à l’intérieur du conteneur. Utilisez l’option `--network=host` dans votre commande Docker pour résoudre ce problème. Notez que le port change de 3000 à 8080, donnant le lien : `http://localhost:8080`.

**Exemple de commande Docker** :

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Garder votre installation Docker à jour

Pour mettre à jour votre installation locale Docker vers la dernière version, utilisez [Watchtower](https://containrrr.dev/watchtower/) :

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

À la fin de la commande, remplacez `open-webui` par le nom de votre conteneur si besoin.

Consultez notre guide de mise à jour dans la [documentation Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Utilisation de la branche Dev 🌙

> [!WARNING]
> La branche `:dev` contient les dernières fonctionnalités instables. Utilisez-la à vos risques et périls : elle peut contenir des bugs ou des fonctionnalités incomplètes.

Pour tester les toutes dernières fonctionnalités, en acceptant une certaine instabilité, utilisez le tag `:dev` ainsi :

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Mode hors-ligne

Si vous exécutez Open WebUI dans un environnement hors-ligne, définissez la variable d’environnement `HF_HUB_OFFLINE` à `1` pour empêcher toute tentative de téléchargement de modèles depuis Internet.

```bash
export HF_HUB_OFFLINE=1
```

## Et ensuite ? 🌟

Découvrez les prochaines fonctionnalités sur notre feuille de route dans la [documentation Open WebUI](https://docs.openwebui.com/roadmap/).

## Licence 📜

Ce projet est sous licence [Open WebUI License](LICENSE), une licence BSD-3-Clause révisée. Vous bénéficiez des mêmes droits que la licence BSD-3 classique : utilisation, modification et distribution du logiciel, y compris dans des produits propriétaires et commerciaux, avec des restrictions minimales. L’unique exigence supplémentaire est de préserver la marque "Open WebUI", comme précisé dans le fichier LICENSE. Pour les conditions complètes, consultez le [document LICENSE](LICENSE). 📄

## Support 💬

Pour toute question, suggestion ou demande d’aide, ouvrez une issue ou rejoignez notre
[communauté Discord Open WebUI](https://discord.gg/5rJgQTnV4s) pour échanger avec nous ! 🤝

## Historique des étoiles

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Créé par [Timothy Jaeryang Baek](https://github.com/tjbck) – Améliorons ensemble Open WebUI ! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---