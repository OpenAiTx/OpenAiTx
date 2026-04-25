# InstagramToMealie

Un petit convertisseur simple, qui importe une URL Instagram dans Mealie

<p align="center">
    <img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="center" width="30%">
</p>
<p align="center"><h1 align="center">INSTAGRAM VERS MEALIE</h1></p>

<p align="center">
	<img src="https://img.shields.io/github/license/JoTec2002/InstagramToMealie?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/JoTec2002/InstagramToMealie?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/JoTec2002/InstagramToMealie?style=default&color=0080ff" alt="repo-language-count">
</p>
<br>

## Table des matières

- [Aperçu](#overview)
- [Commencer](#getting-started)
    - [Prérequis](#prerequisites)
    - [Installation](#installation)
    - [Utilisation](#usage)
    - [Configuration](#configuration)
- [Contribuer](#contributing)
- [Licence](#license)
- [Remerciements](#acknowledgments)

---

## Aperçu

Avec InstagramToMealie, vous pouvez simplement entrer une URL de publication Instagram. Le projet s’intègre parfaitement à l’API Mealie pour
créer une nouvelle recette avec une image ou une vidéo associée.

---

## Commencer

### Prérequis

1. Assurez-vous d'avoir OpenAI / Ollama configuré dans Mealie en naviguant vers `/admin/debug/openai` sur votre instance Mealie. Ce projet ne s'intègre pas directement avec OpenAI / Ollama, mais nécessite sa configuration dans Mealie pour fonctionner correctement. Personnellement, j'ai obtenu les meilleurs résultats avec `qwen2.5:7b` comme modèle Ollama.
2. Générez une clé API Mealie (`/user/profile/api-tokens`). [Documentation Mealie](https://docs.mealie.io/documentation/getting-started/api-usage/)
3. Générez un fichier de session Instagram (!c’est l’étape la plus délicate). Un [script d’aide](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py) est fourni dans ce dépôt ! Il est simplement
   copié depuis la [documentation Instaloader](https://instaloader.github.io/troubleshooting.html).
    1. Téléchargez le script : [https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py](https://raw.githubusercontent.com/JoTec2002/InstagramToMealie/refs/heads/main/helpers/instaloader_login_helper.py)
    2. Connectez-vous à Instagram dans Firefox
    3. Exécutez le script : `python ./instaloader_login_helper.py`
    4. Copiez le fichier généré par le script vers un emplacement connu. Ce fichier sera monté plus tard dans le conteneur Docker. Il peut être généré sur un autre système puis copié sur le système cible.

### Installation

Installez InstagramToMealie en utilisant l’une des méthodes suivantes :

**Compiler depuis la source :**
<details closed>

1. Clonez le dépôt InstagramToMealie :

```sh
❯ git clone https://github.com/JoTec2002/InstagramToMealie
```
2. Accédez au répertoire du projet :


```sh
❯ cd InstagramToMealie
```

3. Installez les dépendances du projet :

```sh
❯ pip install -r requirements.txt
```

4. Démarrez le serveur :

```sh
❯ python -u main.py
```

</details>

**Utilisez l'image Docker fournie sur [jotec2002/instagramtomealie](https://hub.docker.com/repository/docker/jotec2002/instagramtomealie/general)**

Déployez-la via Docker Compose en parallèle de votre installation Mealie

Exemple de fichier `compose.yaml` utilisant un fichier de session pour l'authentification :

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
    volumes:
      - ./session-file:/app/session-file        # The Instagram session file you created in the Prerequisites
    depends_on:
      mealie:
        condition: service_healthy
```

Exemple de fichier `compose.yaml` utilisant des variables d'environnement nom d'utilisateur et mot de passe pour l'authentification :

> [!IMPORTANT]
> **L'authentification à deux facteurs (TFA/TOTP) doit être désactivée sur le compte pour que cette méthode fonctionne.**
> Vous aurez probablement besoin de plusieurs tentatives pour que cela fonctionne. Connectez-vous sur d'autres systèmes / IP en parallèle pour ne pas déclencher la détection de bot d'Instagram.
> Ce n'est pas la méthode recommandée pour configurer InstagramToMealie.

```yaml
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
    image: jotec2002/instagramtomealie
    ports:
      - 9001:9001
    environment:
      INSTA_USER: "instagram username"
      INSTA_PWD: "Cleartext Instagram password"
      MEALIE_API_KEY: "MEALIE API KEY"
      MEALIE_URL: "YOU LOCAL MEALIE INSTALLATION" # e.g http://mealie:9000
      MEALIE_OPENAI_REQUEST_TIMEOUT: 60           # Optional, default: 60
      MEALIE_USE_INSTAGRAM_TAGS: true
```

**Construire l'image Docker vous-même**

Configurez de la même manière que lors de l'utilisation de l'image Docker fournie, mais remplacez par ce qui suit dans `compose.yaml` :

```diff
services:
  mealie:
    image: ghcr.io/mealie-recipes/mealie:v2.1.0
    container_name: mealie
    #Look up in the Mealie Docs for how to use Mealie
  InstagramToMealie:
+   build:
+     context: .
+     dockerfile: Dockerfile
+   image: instagramtomealie:latest
    ports:
      - 9001:9001
```

### Utilisation

1. Ouvrez dans un navigateur web (par exemple `http://instagramtomealie.my-server.com`) et importez simplement l'URL Instagram dans le champ de texte  
2. Appelez depuis une automatisation (par exemple un raccourci iOS) l'URL `http://instagramtomealie.my-server.com?url=<InstagramURL>`  
3. Si vous avez besoin d'une API qui répond avec le résultat de l'import, utilisez `POST http://instagramtomealie.my-server.com/api` en envoyant l'URL soit dans le corps de la requête en format JSON (préféré, `{"url": "<InstagramURL>"}`) soit en paramètre de requête (voir le point précédent). L'API répond avec un JSON au format :
```json
{
  "recipe_slug": <imported recipe slug>,
  "error": <error message if any error>,
  "url": <Instagram URL which was imported>
}
```

### Configuration

```env
MEALIE_URL:                          # Full URL of your Mealie instance (e.g http://mealie:9000, http://192.168.1.2:9000, http://my-mealie.com), required.
MEALIE_API_KEY:                      # API key used to authenticate with the Mealie REST API, required.
MEALIE_OPENAI_REQUEST_TIMEOUT: 60    # The timeout in seconds for OpenAI / Ollama requests, optional, default 60.
MEALIE_USE_INSTAGRAM_TAGS: true      # Embeds tags provided on the Instagram post as tags in Mealie, optional, default true.
INSTA_USER:                          # Instagram username (e.g mob_kitchen), required.
INSTA_PWD:                           # Instagram password in plaintext, optional (if using a session file).
INSTA_TOTP_SECRET:                   # Secret key used for 2FA authentication, optional, not recommended.
HTTP_PORT:                           # Port to use for the Flask HTTP server, optional, default 9001
```

---

## Contribution

- **💬 [Rejoignez les discussions](https://github.com/JoTec2002/InstagramToMealie/discussions)** : Partagez vos idées, donnez
  votre avis ou posez des questions.
- **🐛 [Signalez des problèmes](https://github.com/JoTec2002/InstagramToMealie/issues)** : Soumettez les bugs trouvés ou
  enregistrez des demandes de fonctionnalités pour le projet `InstagramToMealie`.
- **💡 [Soumettez des pull requests](https://github.com/JoTec2002/InstagramToMealie/blob/main/CONTRIBUTING.md)** : Consultez
  les PR ouvertes et soumettez les vôtres.

<details closed>
<summary>Graphe des contributeurs</summary>
<br>
<p align="left">
   <a href="https://github.com{/JoTec2002/InstagramToMealie/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=JoTec2002/InstagramToMealie">
   </a>
</p>
</details>

---

## Licence

Ce projet est protégé par la licence MIT. Pour plus de détails,
référez-vous au fichier [LICENSE](https://choosealicense.com/licenses/).

---

## Remerciements

- [Mealie](https://github.com/mealie-recipes/mealie/)
- [Instadownloader](https://github.com/instaloader/instaloader)

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---