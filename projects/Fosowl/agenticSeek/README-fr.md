# AgenticSeek : Alternative privée et locale à Manus.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Une **alternative 100% locale à Manus AI**, cet assistant IA activé par la voix navigue de façon autonome sur le web, écrit du code et planifie des tâches tout en gardant toutes les données sur votre appareil. Conçu pour les modèles de raisonnement locaux, il fonctionne entièrement sur votre matériel, garantissant une confidentialité totale et aucune dépendance au cloud.*

[![Visiter AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Pourquoi AgenticSeek ?

* 🔒 Entièrement local & privé - Tout s'exécute sur votre machine — pas de cloud, pas de partage de données. Vos fichiers, conversations et recherches restent privés.

* 🌐 Navigation web intelligente - AgenticSeek peut naviguer sur Internet de façon autonome — rechercher, lire, extraire des informations, remplir des formulaires web — tout cela en mode mains libres.

* 💻 Assistant de codage autonome - Besoin de code ? Il peut écrire, déboguer et exécuter des programmes en Python, C, Go, Java, et plus encore — sans supervision.

* 🧠 Sélection intelligente d’agents - Vous demandez, il choisit automatiquement le meilleur agent pour la tâche. Comme si vous aviez une équipe d’experts à disposition.

* 📋 Planifie & exécute des tâches complexes - De la planification de voyage à la gestion de projets complexes — il peut découper de grandes tâches en étapes et les réaliser en utilisant plusieurs agents IA.

* 🎙️ Activation vocale - Voix propre, rapide et futuriste, et transcription vocale permettant de lui parler comme à votre IA personnelle d’un film de science-fiction. (En cours de développement)

### **Démo**

> *Peux-tu rechercher le projet agenticSeek, apprendre quelles compétences sont requises, puis ouvrir le CV_candidates.zip et ensuite me dire lesquelles correspondent le mieux au projet*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Avertissement : Cette démo, y compris tous les fichiers qui apparaissent (ex : CV_candidates.zip), est entièrement fictive. Nous ne sommes pas une entreprise, nous recherchons des contributeurs open-source, pas des candidats.

> 🛠⚠️️ **Travail en cours actif**

> 🙏 Ce projet a commencé comme un projet annexe, sans feuille de route ni financement. Il a largement dépassé mes attentes en finissant dans GitHub Trending. Les contributions, retours et votre patience sont grandement appréciés.

## Prérequis

Avant de commencer, assurez-vous d’avoir les logiciels suivants installés :

*   **Git :** Pour cloner le dépôt. [Télécharger Git](https://git-scm.com/downloads)
*   **Python 3.10.x :** Nous recommandons fortement d’utiliser Python version 3.10.x. L’utilisation d’autres versions peut entraîner des erreurs de dépendances. [Télécharger Python 3.10](https://www.python.org/downloads/release/python-3100/) (choisissez une version 3.10.x).
*   **Docker Engine & Docker Compose :** Pour exécuter les services groupés comme SearxNG.
    *   Installer Docker Desktop (qui inclut Docker Compose V2) : [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternativement, installez Docker Engine et Docker Compose séparément sur Linux : [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (assurez-vous d’installer Compose V2, ex : `sudo apt-get install docker-compose-plugin`).

### 1. **Cloner le dépôt et configurer**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Modifier le contenu du fichier .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Mettez à jour le fichier `.env` avec vos propres valeurs si besoin :

- **SEARXNG_BASE_URL** : Laisser inchangé 
- **REDIS_BASE_URL** : Laisser inchangé 
- **WORK_DIR** : Chemin vers votre dossier de travail local. AgenticSeek pourra lire et interagir avec ces fichiers.
- **OLLAMA_PORT** : Numéro de port pour le service Ollama.
- **LM_STUDIO_PORT** : Numéro de port pour le service LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT** : Port pour tout service LLM personnalisé supplémentaire.

**Les clés API sont totalement optionnelles pour les utilisateurs qui choisissent de faire tourner les LLM localement. C’est le but principal de ce projet. Laissez vide si vous avez un matériel suffisant**

### 3. **Démarrer Docker**

Assurez-vous que Docker est installé et en cours d’exécution sur votre système. Vous pouvez démarrer Docker avec les commandes suivantes :

- **Sur Linux/macOS :**  
    Ouvrez un terminal et lancez :
    ```sh
    sudo systemctl start docker
    ```
    Ou lancez Docker Desktop depuis votre menu d’applications si installé.

- **Sur Windows :**  
    Lancez Docker Desktop depuis le menu Démarrer.

Vous pouvez vérifier que Docker fonctionne en exécutant :
```sh
docker info
```
Si vous voyez des informations sur votre installation Docker, cela fonctionne correctement.

Voir le tableau des [Fournisseurs locaux](#list-of-local-providers) ci-dessous pour un résumé.

Prochaine étape : [Lancer AgenticSeek en local](#start-services-and-run)

*Voir la section [Dépannage](#troubleshooting) si vous rencontrez des problèmes.*
*Si votre matériel ne peut pas exécuter les LLM localement, voir [Configuration pour utilisation via API](#setup-to-run-with-an-api).*
*Pour une explication détaillée de `config.ini`, voir la [Section Config](#config).*

---

## Configuration pour faire tourner un LLM localement sur votre machine

**Configuration matérielle requise :**

Pour faire tourner les LLM localement, vous aurez besoin d’un matériel suffisant. Au minimum, un GPU capable d’exécuter Magistral, Qwen ou Deepseek 14B est requis. Voir la FAQ pour des recommandations détaillées sur les modèles/performances.

**Démarrez votre fournisseur local**  

Lancez votre fournisseur local, par exemple avec ollama :

```sh
ollama serve
```

Voir ci-dessous la liste des fournisseurs locaux pris en charge.

**Mettre à jour le config.ini**

Modifiez le fichier config.ini pour définir provider_name sur un fournisseur pris en charge et provider_model sur un LLM supporté par votre fournisseur. Nous recommandons un modèle de raisonnement tel que *Magistral* ou *Deepseek*.

Voir la **FAQ** à la fin du README pour le matériel requis.

```sh
[MAIN]
is_local = True # Si vous exécutez localement ou avec un fournisseur distant.
provider_name = ollama # ou lm-studio, openai, etc..
provider_model = deepseek-r1:14b # choisissez un modèle adapté à votre matériel
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nom de votre IA
recover_last_session = True # pour récupérer la session précédente
save_session = True # pour mémoriser la session courante
speak = False # texte vers parole
listen = False # reconnaissance vocale, uniquement pour CLI, expérimental
jarvis_personality = False # Pour un comportement plus "Jarvis" (expérimental)
languages = en zh # Liste des langues, la synthèse vocale utilisera la première langue de la liste
[BROWSER]
headless_browser = True # laisser inchangé sauf utilisation CLI sur hôte.
stealth_mode = True # Utilise selenium indétectable pour réduire la détection par les sites
```

**Attention** :

- Le format du fichier `config.ini` ne supporte pas les commentaires. 
Ne copiez/collez pas la configuration d’exemple directement, car les commentaires provoqueront des erreurs. Modifiez plutôt manuellement le fichier `config.ini` selon vos besoins, sans commentaires.

- Ne mettez *PAS* provider_name à `openai` si vous utilisez LM-studio pour exécuter les LLM. Utilisez `lm-studio`.

- Certains fournisseurs (ex : lm-studio) exigent `http://` devant l’IP. Par exemple `http://127.0.0.1:1234`

**Liste des fournisseurs locaux**

| Fournisseur  | Local ? | Description                                               |
|--------------|---------|-----------------------------------------------------------|
| ollama       | Oui     | Exécutez des LLM localement facilement avec ollama        |
| lm-studio    | Oui     | Exécutez un LLM localement avec LM studio (utiliser `provider_name` à `lm-studio`)|
| openai       | Oui     | Utilisez une API compatible openai (ex : serveur llama.cpp)  |

Prochaine étape : [Démarrer les services et lancer AgenticSeek](#Start-services-and-Run)  

*Voir la section [Dépannage](#troubleshooting) si vous rencontrez des problèmes.*
*Si votre matériel ne peut pas exécuter les LLM localement, voir [Configuration pour utilisation via API](#setup-to-run-with-an-api).*
*Pour une explication détaillée de `config.ini`, voir la [Section Config](#config).*

## Configuration pour utilisation via API

Cette configuration utilise des fournisseurs LLM externes, basés sur le cloud. Vous aurez besoin d’une clé API provenant du service choisi.

**1. Choisissez un fournisseur API et obtenez une clé API :**

Consultez la [Liste des fournisseurs API](#list-of-api-providers) ci-dessous. Rendez-vous sur leur site web pour vous inscrire et obtenir une clé API.

**2. Définissez votre clé API comme variable d’environnement :**


*   **Linux/macOS :**
    Ouvrez votre terminal et utilisez la commande `export`. Il est conseillé de l’ajouter à votre fichier de profil de shell (ex : `~/.bashrc`, `~/.zshrc`) pour la persistance.
    ```sh
    export PROVIDER_API_KEY="votre_cle_api_ici" 
    # Remplacez PROVIDER_API_KEY par le nom de variable spécifique, ex : OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Exemple pour TogetherAI :
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows :**
*   **Invite de commandes (Temporaire pour la session en cours) :**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Temporaire pour la session en cours) :**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **De façon permanente :** Recherchez "variables d'environnement" dans la barre de recherche Windows, cliquez sur "Modifier les variables d'environnement système", puis cliquez sur le bouton "Variables d'environnement...". Ajoutez une nouvelle variable utilisateur avec le nom approprié (par exemple, `OPENAI_API_KEY`) et votre clé comme valeur.

*(Voir la FAQ : [Comment définir les clés API ?](#how-do-i-set-api-keys) pour plus de détails).*

**3. Mettre à jour `config.ini` :**
```ini
[MAIN]
is_local = False
provider_name = openai # Ou google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Ou gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 etc.
provider_server_address = # Généralement ignoré ou peut rester vide lorsque is_local = False pour la plupart des APIs
# ... autres paramètres ...
```
*Attention :* Assurez-vous qu'il n'y a pas d'espaces à la fin des valeurs dans le fichier `config.ini`.

**Liste des fournisseurs d'API**

| Fournisseur   | `provider_name` | Local ? | Description                                           | Lien de clé API (Exemples)                     |
|---------------|-----------------|---------|------------------------------------------------------|-----------------------------------------------|
| OpenAI        | `openai`        | Non     | Utilise les modèles ChatGPT via l'API d'OpenAI.      | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | Non     | Utilise les modèles Google Gemini via Google AI Studio.| [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | Non     | Utilise les modèles Deepseek via leur API.            | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | Non     | Utilise les modèles de l'API Hugging Face Inference.  | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | Non     | Utilise divers modèles open source via l'API TogetherAI.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Remarque :*
*   Nous déconseillons l'utilisation de `gpt-4o` ou d'autres modèles OpenAI pour la navigation web complexe et la planification de tâches, car les optimisations actuelles des prompts sont adaptées à des modèles comme Deepseek.
*   Les tâches de codage/bash peuvent rencontrer des problèmes avec Gemini, car il ne suit pas toujours strictement le formatage des prompts optimisés pour Deepseek.
*   Le champ `provider_server_address` dans `config.ini` n'est généralement pas utilisé lorsque `is_local = False` car le point d'accès API est généralement codé en dur dans la bibliothèque du fournisseur concerné.

Étape suivante : [Démarrer les services et lancer AgenticSeek](#Start-services-and-Run)

*Voir la section **Problèmes connus** si vous rencontrez des difficultés*

*Voir la section **Config** pour une explication détaillée du fichier de configuration.*

---

## Démarrer les services et lancer AgenticSeek

Par défaut, AgenticSeek fonctionne entièrement dans Docker.

Démarrez les services requis. Cela démarrera tous les services du fichier docker-compose.yml, y compris :
    - searxng
    - redis (requis par searxng)
    - frontend
    - backend (si vous utilisez `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Attention :** Cette étape téléchargera et chargera toutes les images Docker, ce qui peut prendre jusqu'à 30 minutes. Après le démarrage des services, veuillez attendre que le service backend soit complètement opérationnel (vous devriez voir **backend: "GET /health HTTP/1.1" 200 OK** dans le journal) avant d'envoyer des messages. Les services backend peuvent prendre 5 minutes à démarrer lors du premier lancement.

Accédez à `http://localhost:3000/` et vous devriez voir l'interface web.

*Dépannage du démarrage des services :* Si ces scripts échouent, assurez-vous que Docker Engine est en cours d'exécution et que Docker Compose (V2, `docker compose`) est correctement installé. Vérifiez les messages d'erreur dans le terminal. Voir [FAQ : Aide ! J'obtiens une erreur lors de l'exécution d'AgenticSeek ou de ses scripts.](#faq-troubleshooting)

**Optionnel :** Exécuter sur l'hôte (mode CLI) :

Pour utiliser l'interface CLI, vous devez installer le paquet sur l'hôte :

```sh
./install.sh
./install.bat # windows
```

Démarrez les services :

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Utilisez la CLI : `python3 cli.py`

---

## Utilisation

Assurez-vous que les services sont actifs avec `./start_services.sh full` et rendez-vous sur `localhost:3000` pour l'interface web.

Vous pouvez également utiliser la reconnaissance vocale en définissant `listen = True` dans la configuration. Uniquement en mode CLI.

Pour quitter, dites/écrivez simplement `goodbye`.

Voici quelques exemples d'utilisation :

> *Créer un jeu du serpent en python !*

> *Cherche sur le web les meilleurs cafés à Rennes, France, et sauvegarde une liste de trois avec leurs adresses dans rennes_cafes.txt.*

> *Écris un programme Go pour calculer la factorielle d'un nombre, sauvegarde-le sous factorial.go dans ton espace de travail*

> *Recherche dans mon dossier summer_pictures tous les fichiers JPG, renomme-les avec la date d’aujourd’hui, et sauvegarde la liste des fichiers renommés dans photos_list.txt*

> *Recherche en ligne les films de science-fiction populaires de 2024 et choisis-en trois à regarder ce soir. Sauvegarde la liste dans movie_night.txt.*

> *Cherche sur le web les derniers articles d’actualité IA de 2025, sélectionne-en trois, et écris un script Python pour extraire leurs titres et résumés. Sauvegarde le script sous news_scraper.py et les résumés dans ai_news.txt dans /home/projects*

> *Vendredi, cherche sur le web une API gratuite de prix d’actions, inscris-toi avec supersuper7434567@gmail.com puis écris un script Python pour récupérer les prix quotidiens de Tesla via l’API et sauvegarde les résultats dans stock_prices.csv*

*Notez que les capacités de remplissage de formulaire sont encore expérimentales et peuvent échouer.*

Après avoir saisi votre requête, AgenticSeek allouera le meilleur agent pour la tâche.

Comme il s'agit d'un prototype précoce, le système de routage des agents peut ne pas toujours choisir le bon agent en fonction de votre requête.

Par conséquent, vous devez être très explicite sur ce que vous voulez et comment l’IA doit procéder ; par exemple, si vous souhaitez qu’elle effectue une recherche web, ne dites pas :

`Connais-tu de bons pays pour voyager en solo ?`

Demandez plutôt :

`Fais une recherche web et trouve quels sont les meilleurs pays pour voyager en solo`

---

## **Configuration pour exécuter le LLM sur votre propre serveur**  

Si vous disposez d'un ordinateur puissant ou d'un serveur que vous pouvez utiliser, mais que vous souhaitez l'utiliser à distance depuis votre ordinateur portable, vous avez la possibilité d'exécuter le LLM sur un serveur distant en utilisant notre serveur llm personnalisé.

Sur votre "serveur" qui exécutera le modèle IA, récupérez l'adresse IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip locale
curl https://ipinfo.io/ip # ip publique
```

Remarque : Pour Windows ou macOS, utilisez respectivement ipconfig ou ifconfig pour trouver l'adresse IP.

Clonez le dépôt et entrez dans le dossier `server/`.

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Installez les dépendances spécifiques au serveur :

```sh
pip3 install -r requirements.txt
```

Exécutez le script serveur.

```sh
python3 app.py --provider ollama --port 3333
```

Vous avez le choix entre utiliser `ollama` ou `llamacpp` comme service LLM.

Maintenant sur votre ordinateur personnel :

Modifiez le fichier `config.ini` pour définir `provider_name` sur `server` et `provider_model` sur `deepseek-r1:xxb`.
Définissez `provider_server_address` sur l'adresse IP de la machine qui exécutera le modèle.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

Étape suivante : [Démarrer les services et lancer AgenticSeek](#Start-services-and-Run)  

---

## Reconnaissance vocale (Speech to Text)

Attention : la reconnaissance vocale ne fonctionne actuellement qu’en mode CLI.

Veuillez noter qu’actuellement la reconnaissance vocale ne fonctionne qu’en anglais.

La fonctionnalité de reconnaissance vocale est désactivée par défaut. Pour l’activer, définissez l’option listen sur True dans le fichier config.ini :

```
listen = True
```

Lorsqu’elle est activée, la reconnaissance vocale attend un mot-clé déclencheur, qui est le nom de l’agent, avant de commencer à traiter votre entrée. Vous pouvez personnaliser le nom de l’agent en modifiant la valeur `agent_name` dans le fichier *config.ini* :

```
agent_name = Friday
```

Pour une reconnaissance optimale, nous recommandons d'utiliser un prénom anglais courant comme "John" ou "Emma" comme nom d'agent.

Une fois que vous voyez la transcription apparaître, dites le nom de l'agent à voix haute pour le réveiller (ex. : "Friday").

Énoncez clairement votre requête.

Terminez votre demande par une phrase de confirmation pour indiquer au système de procéder. Exemples de phrases de confirmation :
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

Exemple de configuration :
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Exemple pour Ollama ; utilisez http://127.0.0.1:1234 pour LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Liste des langues pour la synthèse vocale et potentiellement le routage.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Explication des paramètres `config.ini`** :

*   **Section **`[MAIN]`** :**
    *   `is_local` : `True` si vous utilisez un fournisseur LLM local (Ollama, LM-Studio, serveur compatible OpenAI local) ou l'option serveur auto-hébergé. `False` si vous utilisez une API cloud (OpenAI, Google, etc.).
    *   `provider_name` : Spécifie le fournisseur LLM.
        *   Options locales : `ollama`, `lm-studio`, `openai` (pour les serveurs compatibles OpenAI locaux), `server` (pour l'installation en auto-hébergement).
        *   Options API : `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model` : Le nom ou ID du modèle spécifique pour le fournisseur choisi (ex. : `deepseekcoder:6.7b` pour Ollama, `gpt-3.5-turbo` pour l'API OpenAI, `mistralai/Mixtral-8x7B-Instruct-v0.1` pour TogetherAI).
    *   `provider_server_address` : L'adresse de votre fournisseur LLM.
        *   Pour les fournisseurs locaux : ex. `http://127.0.0.1:11434` pour Ollama, `http://127.0.0.1:1234` pour LM-Studio.
        *   Pour le type de fournisseur `server` : l'adresse de votre serveur LLM auto-hébergé (ex. : `http://votre_ip_serveur:3333`).
        *   Pour les API cloud (`is_local = False`) : cela est souvent ignoré ou peut rester vide, car le point de terminaison de l'API est généralement géré par la bibliothèque cliente.
    *   `agent_name` : Nom de l'assistant IA (ex. : Friday). Utilisé comme mot déclencheur pour la reconnaissance vocale si activée.
    *   `recover_last_session` : `True` pour tenter de restaurer l'état de la session précédente, `False` pour recommencer à zéro.
    *   `save_session` : `True` pour sauvegarder l'état actuel de la session pour une éventuelle récupération, `False` sinon.
    *   `speak` : `True` pour activer la synthèse vocale, `False` pour désactiver.
    *   `listen` : `True` pour activer la reconnaissance vocale (mode CLI uniquement), `False` pour désactiver.
    *   `work_dir` : **Crucial :** Le répertoire dans lequel AgenticSeek lira/écrira les fichiers. **Assurez-vous que ce chemin est valide et accessible sur votre système.**
    *   `jarvis_personality` : `True` pour utiliser un prompt système de type "Jarvis" (expérimental), `False` pour le prompt standard.
    *   `languages` : Liste de langues séparées par des virgules (ex. : `en, zh, fr`). Utilisé pour la sélection de la voix TTS (par défaut la première) et peut aider le routeur LLM. Évitez d’indiquer trop de langues ou des langues très similaires pour l’efficacité du routeur.
*   **Section **`[BROWSER]`** :**
    *   `headless_browser` : `True` pour exécuter le navigateur automatisé sans fenêtre visible (recommandé pour l’interface web ou une utilisation non interactive). `False` pour afficher la fenêtre du navigateur (utile pour le mode CLI ou le débogage).
    *   `stealth_mode` : `True` pour activer des mesures rendant l’automatisation du navigateur plus difficile à détecter. Peut nécessiter l’installation manuelle d’extensions comme anticaptcha.


Cette section résume les types de fournisseurs LLM supportés. Configurez-les dans `config.ini`.

**Fournisseurs locaux (exécutés sur votre matériel) :**

| Nom du fournisseur dans `config.ini` | `is_local` | Description                                                                 | Section de configuration                                                    |
|-------------------------------|------------|-----------------------------------------------------------------------------|-----------------------------------------------------------------------------|
| `ollama`                      | `True`     | Utilise Ollama pour servir des LLM locaux.                                  | [Configuration pour exécuter un LLM localement](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Utilise LM-Studio pour servir des LLM locaux.                               | [Configuration pour exécuter un LLM localement](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (pour serveur local) | `True`     | Connexion à un serveur local exposant une API compatible OpenAI (ex : llama.cpp). | [Configuration pour exécuter un LLM localement](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Connexion au serveur LLM AgenticSeek auto-hébergé sur une autre machine.    | [Configuration pour exécuter le LLM sur votre propre serveur](#setup-to-run-the-llm-on-your-own-server) |

**Fournisseurs API (basés sur le cloud) :**

| Nom du fournisseur dans `config.ini` | `is_local` | Description                                        | Section de configuration                                 |
|-------------------------------|------------|----------------------------------------------------|----------------------------------------------------------|
| `openai`                      | `False`    | Utilise l’API officielle d’OpenAI (ex. GPT-3.5, GPT-4). | [Configuration pour utiliser une API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | Utilise les modèles Gemini de Google via API.           | [Configuration pour utiliser une API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Utilise l’API officielle de Deepseek.                  | [Configuration pour utiliser une API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Utilise l’API d’inférence de Hugging Face.             | [Configuration pour utiliser une API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | Utilise l’API TogetherAI pour divers modèles open source. | [Configuration pour utiliser une API](#setup-to-run-with-an-api) |

---
## Dépannage

Si vous rencontrez des problèmes, cette section vous guide.

# Problèmes connus

## Problèmes de ChromeDriver

**Exemple d’erreur :** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Cause :** La version de ChromeDriver installée est incompatible avec la version de votre navigateur Google Chrome.
*   **Solution :**
    1.  **Vérifiez la version de Chrome :** Ouvrez Google Chrome, allez dans `Paramètres > À propos de Chrome` pour trouver votre version (ex. : "Version 120.0.6099.110").
    2.  **Téléchargez le ChromeDriver correspondant :**
        *   Pour Chrome version 115 et supérieure : Rendez-vous sur les [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Trouvez le canal "stable" et téléchargez le ChromeDriver pour votre OS correspondant à la version majeure de votre Chrome.
        *   Pour les versions plus anciennes (plus rare) : Vous pouvez les trouver sur la page [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   L'image ci-dessous montre un exemple depuis la page CfT :
            ![Télécharger une version spécifique de Chromedriver sur la page Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Installez ChromeDriver :**
        *   Assurez-vous que le `chromedriver` téléchargé (ou `chromedriver.exe` sur Windows) est placé dans un dossier référencé par la variable d’environnement PATH de votre système (ex. : `/usr/local/bin` sous Linux/macOS, ou un dossier de scripts ajouté au PATH sous Windows).
        *   Alternativement, placez-le dans le répertoire racine du projet `agenticSeek`.
        *   Assurez-vous que le pilote est exécutable (ex. : `chmod +x chromedriver` sous Linux/macOS).
    4.  Consultez la section [Installation de ChromeDriver](#chromedriver-installation) dans le guide principal d'installation pour plus de détails.

Si cette section est incomplète ou si vous rencontrez d’autres problèmes avec ChromeDriver, veuillez consulter les [Issues GitHub existants](https://github.com/Fosowl/agenticSeek/issues) ou en ouvrir un nouveau.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Cela arrive s'il y a un décalage entre la version de votre navigateur et celle de chromedriver.

Vous devez télécharger la dernière version :

https://developer.chrome.com/docs/chromedriver/downloads

Si vous utilisez Chrome version 115 ou supérieure, allez sur :

https://googlechromelabs.github.io/chrome-for-testing/

Et téléchargez la version de chromedriver correspondant à votre système d’exploitation.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Si cette section est incomplète, veuillez ouvrir une issue.

##  Problèmes d’adaptateurs de connexion

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Note : le port peut varier)
```

*   **Cause :** Le paramètre `provider_server_address` dans `config.ini` pour `lm-studio` (ou tout autre serveur local compatible OpenAI) ne comporte pas le préfixe `http://` ou pointe vers le mauvais port.
*   **Solution :**
    *   Assurez-vous que l’adresse commence par `http://`. LM-Studio utilise généralement `http://127.0.0.1:1234` par défaut.
    *   Correction dans `config.ini` : `provider_server_address = http://127.0.0.1:1234` (ou le port réel de votre serveur LM-Studio).

## URL de base SearxNG non fournie

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**Q : De quel matériel ai-je besoin ?**  

| Taille du modèle  | GPU  | Remarques                                               |
|-------------------|------|--------------------------------------------------------|
| 7B                | 8GB Vram | ⚠️ Non recommandé. Performances faibles, hallucinations fréquentes, les agents planificateurs échoueront probablement. |
| 14B               | 12 GB VRAM (ex. RTX 3060) | ✅ Utilisable pour des tâches simples. Peut peiner sur la navigation web et la planification. |
| 32B               | 24+ GB VRAM (ex. RTX 4090) | 🚀 Réussite sur la plupart des tâches, peut encore avoir des difficultés pour la planification. |
| 70B+              | 48+ GB Vram | 💪 Excellent. Recommandé pour des usages avancés. |

**Q : J’ai une erreur, que faire ?**  

Assurez-vous que le local est lancé (`ollama serve`), que votre `config.ini` correspond à votre fournisseur, et que les dépendances sont installées. Si rien ne fonctionne, n’hésitez pas à ouvrir une issue.

**Q : Peut-on vraiment tout faire tourner en local à 100% ?**  

Oui, avec Ollama, lm-studio ou les fournisseurs `server`, toute la reconnaissance vocale, LLM et la synthèse vocale tournent en local. Les options non-locales (OpenAI ou autres API) sont facultatives.

**Q : Pourquoi utiliser AgenticSeek alors que j’ai Manus ?**

Contrairement à Manus, AgenticSeek privilégie l’indépendance vis-à-vis des systèmes externes, vous donnant plus de contrôle, de confidentialité et évitant les coûts d’API.

**Q : Qui est à l’origine du projet ?**

Le projet a été créé par moi-même, avec deux amis qui sont mainteneurs et contributeurs issus de la communauté open source sur GitHub. Nous ne sommes qu’un groupe de passionnés, pas une startup ni affiliés à une organisation.

Tout compte AgenticSeek sur X autre que mon compte personnel (https://x.com/Martin993886460) est une usurpation.

## Contribuer

Nous recherchons des développeurs pour améliorer AgenticSeek ! Consultez les issues ouvertes ou les discussions.

[Guide de contribution](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Mainteneurs :

 > [Fosowl](https://github.com/Fosowl) | Fuseau horaire de Paris 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Fuseau horaire de Taipei 

 > [steveh8758](https://github.com/steveh8758) | Fuseau horaire de Taipei 

## Remerciements particuliers :

 > [tcsenpai](https://github.com/tcsenpai) et [plitc](https://github.com/plitc) pour leur aide à la dockerisation du backend

## Sponsors :

Les sponsors mensuels de 5 $ ou plus apparaissent ici :
- **tatra-labs**

Certainly! However, you have not provided the content of "Part 4 of 4" to be translated. Please provide the text of the technical document you want translated into French, and I will proceed accordingly.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---