<p>
  <img src="https://raw.githubusercontent.com/biolds/sosse/main/se/static/se/logo.svg" width="64" align="right">
  <a href="https://gitlab.com/biolds1/sosse/" alt="Couverture de code Gitlab" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-coverage/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/pipelines" alt="Statut du pipeline Gitlab" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-status/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://sosse.readthedocs.io/en/stable/" alt="Documentation" style="text-decoration: none">
    <img src="https://img.shields.io/readthedocs/sosse?style=flat-square">
  </a>
  <a href="https://discord.gg/Vt9cMf7BGK" alt="Discord" style="text-decoration: none">
    <img src="https://img.shields.io/discord/1102142186423844944?style=flat-square&color=%235865f2">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/blob/main/LICENSE" alt="Licence" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/license/biolds1/sosse?style=flat-square">
  </a>
</p>

# Sosse 🦦

**Découvrez Sosse** — le moteur de recherche open source Selenium conçu pour l’archivage web, le crawling et la recherche puissants.
Explorez toutes ses fonctionnalités et capacités sur le [site officiel](https://sosse.io).

Que vous soyez développeur, chercheur ou passionné de données, Sosse est prêt à soutenir vos projets.
Rejoignez la communauté sur [GitHub](https://github.com/biolds/sosse) ou [GitLab](https://gitlab.com/biolds1/sosse) pour soumettre des demandes de fonctionnalités, signaler des bugs, contribuer au code, ou [lancer une discussion](https://github.com/biolds/sosse/discussions).

## Fonctionnalités clés

- 🌍 **Recherche de pages web** : Recherchez le contenu des pages web, y compris celles rendues dynamiquement, avec des requêtes avancées.
  ([doc](https://sosse.readthedocs.io/en/stable/guides/search.html))

- 🕑 **Crawling récurrent** : Explorez les pages à intervalles fixes ou adaptez la fréquence selon les changements de contenu.
  ([doc](https://sosse.readthedocs.io/en/stable/crawl/policies.html))

- 🔖 **Archivage de pages web** : Archivez le contenu HTML, ajustez les liens pour un usage local, téléchargez les ressources nécessaires et prenez en charge
  le contenu dynamique. ([doc](https://sosse.readthedocs.io/en/stable/guides/archive.html))

- 🏷️ **Étiquettes** : Organisez et filtrez les pages explorées ou archivées à l’aide d’étiquettes pour une meilleure recherche et gestion.
  ([doc](https://sosse.readthedocs.io/en/stable/tags.html))

- 📂 **Téléchargement de fichiers** : Téléchargement en lot de fichiers binaires depuis des pages web.
  ([doc](https://sosse.readthedocs.io/en/stable/guides/download.html))

- 📡 **Webhooks** : Intégration avec des services externes via des webhooks très flexibles. Connexion à des plateformes d’IA propriétaires
  ([doc](https://sosse.readthedocs.io/en/stable/guides/ai_api_processing.html)) ou à des solutions hébergées localement
  ([doc](https://sosse.readthedocs.io/en/stable/guides/local_ai.html)) pour permettre une extraction avancée de données,
  un résumé, un auto-étiquetage, des notifications, et plus encore.

- 🔔 **Flux Atom** : Génération de flux de contenu pour les sites web qui n’en disposent pas, ou réception de mises à jour lorsqu’une nouvelle page
  contenant un mot-clé est publiée.
  ([doc](https://sosse.readthedocs.io/en/stable/guides/feed_website_monitor.html))

- 🔒 **Authentification** : Le robot d’exploration peut s’authentifier pour accéder à des pages privées et récupérer leur contenu.
  ([doc](https://sosse.readthedocs.io/en/stable/guides/authentication.html))

- 👥 **Permissions** : Les administrateurs peuvent configurer les robots d’exploration et consulter les statistiques, tandis que les utilisateurs authentifiés peuvent effectuer des recherches ou le faire anonymement.
  ([doc](https://sosse.readthedocs.io/en/stable/permissions.html))

- 👤 **Fonctions de recherche** : Comprend un historique de recherche privé ([doc](https://sosse.readthedocs.io/en/stable/user/history.html)),
  et des raccourcis vers des moteurs de recherche externes ([doc](https://sosse.readthedocs.io/en/stable/user/shortcuts.html)), etc.

Explorez la 📚 [documentation](https://sosse.readthedocs.io/en/stable/index.html) et découvrez quelques
📷 [captures d’écran](https://sosse.readthedocs.io/en/stable/screenshots.html).

Sosse est écrit en Python et distribué sous la [licence GNU AGPLv3](https://www.gnu.org/licenses/agpl-3.0.en.html). Il utilise une exploration basée sur un navigateur avec [Mozilla Firefox](https://www.mozilla.org/firefox/) ou
[Google Chromium](https://www.chromium.org/Home) en association avec [Selenium](https://www.selenium.dev/) pour indexer les pages qui dépendent de JavaScript. Pour une exploration plus rapide, [Requests](https://docs.python-requests.org/en/latest/index.html) peut également être utilisé. Sosse utilise
[PostgreSQL](https://www.postgresql.org/) pour le stockage des données.

## Essayez-le

Pour essayer rapidement la dernière version avec Docker :

```
docker run -p 8005:80 biolds/sosse:stable
```

Ensuite, ouvrez [http://127.0.0.1:8005/](http://127.0.0.1:8005/) et connectez-vous avec le nom d'utilisateur `admin` et le mot de passe `admin`.

Pour la persistance des données Docker ou des méthodes d'installation alternatives, veuillez consulter le [guide d'installation](https://sosse.readthedocs.io/en/stable/install.html).

## Restez Connecté

Rejoignez le [serveur Discord](https://discord.gg/Vt9cMf7BGK) pour obtenir de l'aide, partager des idées ou discuter de Sosse !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---