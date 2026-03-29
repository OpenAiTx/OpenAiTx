# `acexy` - Un proxy AceStream écrit en Go ! ⚡

[![Go Build](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker Release](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## Table des matières

- [Comment ça marche ? 🛠](#comment-ca-marche-)
- [Fonctionnalités clés 🔗](#fonctionnalites-cles-)
- [Utilisation 📐](#utilisation-)
- [Optimisation 🚀](#optimisation-)
  - [Alternative 🧃](#alternative-)
- [Options de configuration ⚙](#options-de-configuration-)

## Comment ça marche ? 🛠

Ce projet est une interface autour de
[l’API HTTP middleware AceStream](https://docs.acestream.net/developers/start-playback/#using-middleware), permettant à la fois
la lecture en
[HLS](https://fr.wikipedia.org/wiki/HTTP_Live_Streaming) et en
[MPEG-TS](https://fr.wikipedia.org/wiki/HTTP_Live_Streaming)
d’un flux.

J’en avais assez des limitations d’AceStream et de certains problèmes qui
existent lors de la lecture d’un flux 📽. Par exemple, il est seulement possible de lire
le même canal pour **1 seul client**. Pour avoir plusieurs clients
lisant **différents flux**, vous devez ajouter manuellement un `pid` unique par
client. S’il y a une erreur pendant la transmission, **le flux entier
tombe**, etc.

J’ai trouvé assez frustrante l’expérience d’utilisation d’AceStream dans un réseau domestique
avec un seul serveur et plusieurs clients, pour tenter d’optimiser les ressources. Voici
la topologie pour laquelle j’utilise AceStream :

![Topologie AceStream pour mon réseau](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

Il y a quelques problèmes :

* Uniquement **un client** peut lire le même flux à la fois 🚫.
* Faire en sorte que chaque client exécute AceStream sur sa propre machine est un gaspillage de ressources
  et saturé le réseau 📉.
* Plusieurs clients peuvent lire différents flux s'ils ont un `pid`
  (ID du lecteur) unique associé 🔓.
* L'API HTTP standard d'AceStream n'est pas assez résistante aux erreurs,
  si la transmission s'arrête, elle s'arrête pour tous les clients ❌.

## Fonctionnalités clés 🔗

En utilisant `acexy`, vous disposez automatiquement de :

* Un serveur unique et centralisé exécutant **tous vos flux AceStream** ⛓.
* Attribution automatique d'un `pid` (ID du lecteur) unique **par client par flux** 🪪.
* **Multiplexage de flux** 🕎 : Le même flux peut être reproduit *en même temps sur plusieurs clients*.
* Streaming **résilient et à l'épreuve des erreurs** grâce au Middleware HTTP 🛡.
* *Proxy ultra-rapide et minimaliste* ☄ écrit en Go !

Avec ce proxy, l'architecture suivante est maintenant possible :

![acexy Topology](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## Utilisation 📐

`acexy` est disponible et publié sous forme d'image Docker. Assurez-vous
d'avoir la dernière image [Docker](https://docker.com) installée et disponible.

Le conteneur Acexy se connectera à un serveur AceStream. Vous devez
déployer soit une image Docker et lier Acexy dans le même réseau ; soit
avoir une version AceStream en fonctionnement sur votre hôte et exécuter
Acexy en mode réseau hôte.

> **INFO** : Un fichier `docker-compose.yml` est disponible dans le dépôt et
> peut être utilisé directement pour lancer l'ensemble du bloc. C'est
> **la configuration recommandée à partir de la version `v0.2.0`**.

Pour lancer le bloc de services, récupérez d'abord le fichier `docker-compose.yml`, et exécutez :


```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```

Si vous ne souhaitez pas utiliser Docker Compose, en supposant que vous avez déjà un
serveur AceStream, une autre méthode pourrait être :

```shell
docker run --network host ghcr.io/javinator9889/acexy
```

> **REMARQUE** : Pour votre commodité, un fichier `docker-compose.yml` est fourni avec
> tous les paramètres ajustables possibles. Il devrait être prêt à l'emploi, et c'est
> la méthode recommandée à partir de la version `v0.2.0`.

Par défaut, le proxy fonctionnera en mode MPEG-TS. Pour basculer entre eux,
vous devez ajouter le **flag `-m3u8`** ou définir la **variable d'environnement `ACEXY_M3U8=true`**.

> **REMARQUE** : Le mode HLS - `ACEXY_M3U8` ou le flag `-m3u8` - est dans un état non testé.
> Son utilisation est déconseillée et non garantie.

Il y a un seul point d'accès disponible : `/ace/getstream` qui prend les mêmes
paramètres que l'
[API HTTP/Middleware AceStream standard](https://docs.acestream.net/developers/api-reference/). Par conséquent,
pour lancer un flux, il suffit d'ouvrir le lien suivant dans votre application préférée - comme VLC :


```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```
où `dd1e67078381739d14beca697356ab76d49d1a2` est l’ID du canal AceStream.

## Optimisation 🚀

Le moteur AceStream fonctionnant derrière le proxy dispose de plusieurs ports pouvant
être exposés pour optimiser les performances. Ceux-ci sont, par défaut :

- `8621/tcp`
- `8621/udp`

> REMARQUE : Ils peuvent être ajustés via la variable `EXTRA_FLAGS` - dans Docker - en
> utilisant l’option `--port`.

L’exposition de ces ports devrait permettre d’obtenir une expérience de streaming plus stable. Notez
que vous devrez également ouvrir ces ports sur votre passerelle.

Pour référence, voici comment vous devez exécuter la commande Docker :



```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```

### Alternative 🧃

AceStream tente d’utiliser UPnP IGD pour se connecter à une machine distante.
Le problème est que cela ne fonctionne pas à cause de la couche de pont ajoutée par Docker
(voir : https://docs.docker.com/engine/network/drivers/bridge/).

Si vous exécutez une seule instance d’Acexy - et une seule instance d’AceStream -
il devrait être sûr pour vous d’exécuter le conteneur avec *le réseau hôte*. Cela signifie :

- Le conteneur **peut accéder** à toute autre application connectée à votre réseau principal.
- Vous **n’avez pas besoin** d’exposer des ports.
- Les performances **sont un peu optimisées**.

> REMARQUE : Cela ne fonctionne que sur les environnements Linux. Voir https://docs.docker.com/engine/network/drivers/host/
> pour plus d’informations.

La commande est assez simple :

```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```
Cela devrait permettre à AceStream d'utiliser UPnP librement.

## Options de Configuration ⚙

Acexy dispose de nombreuses options de configuration qui vous permettent de personnaliser le comportement. Toutes ont
des valeurs par défaut qui ont été testées pour une expérience optimale, mais vous devrez peut-être les ajuster
pour répondre à vos besoins.

> **ASTUCE PRO** : Vous pouvez lancer `acexy -help` pour avoir une vue complète de toutes les options disponibles.

Comme Acexy est conçu pour être exécuté dans un conteneur Docker, toutes les variables et paramètres sont
ajustables via des variables d'environnement.


<table>
  <thead>
    <tr>
      <th>Drapeau</th>
      <th>Variable d'Environnement</th>
      <th>Description</th>
      <th>Par Défaut</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>Affiche la licence du programme et quitte</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>Affiche le message d'aide et quitte</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>

      <th>Adresse où Acexy écoute. Utile lors de l'exécution en mode <code>host</code>.</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        Le schéma du middleware AceStream. Si vous avez configuré AceStream pour fonctionner en HTTPS,
        vous devrez ajuster cette valeur.
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        Où se trouve le middleware AceStream. Changez-le si vous avez besoin qu'Acexy se connecte à un
        moteur AceStream différent.
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        Le port pour se connecter au middleware AceStream. Changez-le si vous avez besoin qu'Acexy se connecte
        à un moteur AceStream différent.
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        Lors de l'exécution d'Acexy en mode M3U8, le délai d'attente pour considérer qu'un flux est terminé.
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>
      <th><code>ACEXY_M3U8</code></th>
      <th>
        Activer le mode M3U8 dans Acexy. <b>ATTENTION</b> : Ce mode est expérimental et peut ne pas fonctionner comme prévu.
      </th>
      <th>Désactivé</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        Délai pour considérer qu’un flux est terminé une fois que des informations vides sont reçues du
        middleware. Inutile en mode M3U8.
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        Tamponne jusqu’à <code>buffer-size</code> octets d’un flux avant de copier les données vers le
        lecteur. Utile pour une meilleure stabilité lors des lectures.
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        Temps d’attente pour que le middleware AceStream retourne une réponse pour un flux nouvellement ouvert.
        Ce délai doit être aussi court que possible sauf si votre connexion Internet est très mauvaise
        (c’est-à-dire : vous avez des latences très élevées).
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **NOTE** : La liste des options est étendue mais peut être obsolète. Référez-vous toujours à la
> sortie `-help` du binaire Acexy en cas de doute.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---