# janitor
## Objectif
Janitor est un outil autonome qui surveille la disponibilité de vos appareils IOT et vous alerte en cas de disparition d’un appareil ou d’arrêt de transmission des données. Ceci est particulièrement utile si vous avez de nombreux capteurs, éventuellement avec du matériel ou une connexion instable, afin que vous puissiez agir en cas de problème et surveiller la stabilité de vos appareils.

Janitor ne vise pas à implémenter des fonctionnalités supplémentaires, ce n’est donc pas une alternative à vos autres logiciels de domotique (par ex. HASS). Se concentrer uniquement sur cette fonctionnalité permettra de garder cet outil simple et efficace.

Janitor supporte actuellement les méthodes de surveillance suivantes :
* **MQTT :** Janitor s’abonnera à des topics MQTT prédéfinis et surveillera les messages entrants. Une fréquence moyenne de transmission sera calculée pour chaque canal et si aucun nouveau message n’est reçu dans cet intervalle, Janitor vous alertera (le seuil peut être configuré comme un multiple de la fréquence moyenne ou en valeurs absolues par topic). Cette méthode est particulièrement utile pour tout type de capteurs soumettant régulièrement des données via MQTT (ex. température).
* **Ping :** Janitor pingera des hôtes prédéfinis avec une fréquence prédéfinie (configurable par hôte) et vous alertera en cas d’absence de réponse (le seuil utilisé pour les pings manqués consécutifs est configurable). Cette méthode est utile pour tout type d’appareils IOT, par ex. capteurs, caméras, etc.
* **HTTP :** Janitor enverra une requête HTTP GET à des adresses prédéfinies et vérifiera la réponse, ainsi que, optionnellement, si la réponse contient une chaîne prédéfinie. Janitor vous alertera en cas de requêtes consécutivement infructueuses au-delà du seuil configuré. La fréquence et le délai d’attente sont également configurables par adresse. Cette méthode est utile pour tout type de services avec interface web (ex. APIs, services hébergés, etc.).
* **Exec :** Janitor exécutera une commande préconfigurée et vérifiera son code de sortie. Janitor vous alertera en cas d’exécutions consécutivement infructueuses au-delà du seuil configuré. La fréquence et le délai d’attente sont également configurables par commande. Avec cette méthode, vous pouvez implémenter tout type de surveillance personnalisée.

Janitor supporte actuellement les méthodes d’alerte suivantes :
* **Telegram :** Janitor enverra un message à un canal Telegram prédéfini.
* **Gotify :** Janitor enverra un message push à Gotify.
* **MQTT :** Janitor publiera un message sur un topic préconfiguré sur un serveur MQTT préconfiguré. Le message contiendra une charge JSON (voir la configuration d’exemple). Ceci est adapté aux automatisations, par ex. dans HASS.
* **Exec :** Janitor exécutera une commande préconfigurée. Cela permet de créer tout type de méthode d’alerte personnalisée.

De plus, Janitor dispose d’une interface web où vous pouvez voir le statut actuel et les données historiques, supprimer des éléments, modifier les délais, intervalles et seuils, et recharger le fichier de configuration (voir capture d’écran ci-dessous).

Enfin, Janitor inclut une API JSON simple avec les endpoints suivants :
* `/api/data` fournit un instantané de toutes les données liées à la surveillance.
* `/api/stats` fournit le décompte des cibles de surveillance en état fonctionnel/dysfonctionnel.
* `/api/metrics` fournit les statistiques des cibles au format métriques Prometheus.

## Capture d’écran
![Capture d’écran](https://raw.githubusercontent.com/a-bali/janitor/master/docs/screenshot.png)

## Compilation et installation

Janitor est écrit en Go et compilera en un binaire autonome unique. Janitor devrait compiler et fonctionner aussi bien sous Linux que sous Windows.

Pour compiler, utilisez au minimum la version 1.16 de Go et exécutez les commandes suivantes pour cloner le dépôt et construire le binaire :

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ go build

Cela créera le binaire autonome nommé `janitor` que vous pouvez placer où vous voulez. Des binaires précompilés pour les versions
sont disponibles sur Github.
## Configuration et utilisation

Pour la configuration, un fichier au format YAML est requis. Veuillez utiliser le [fichier de configuration exemple](https://raw.githubusercontent.com/a-bali/janitor/master/config.yml) et le modifier selon vos besoins, en suivant les commentaires dans le fichier. La plupart des variables sont optionnelles et ont des valeurs par défaut raisonnables, pour plus de détails, veuillez consulter les commentaires. Vous pouvez référencer des variables d’environnement avec `$ENV_VAR` ou `${ENV_VAR}` qui seront substituées par leur valeur si elles existent (ou par une chaîne vide si elles n’existent pas).

Une configuration minimale mais déjà opérationnelle peut être aussi courte que ce qui suit (en supposant que l’interface web de Janitor sera disponible sur son port par défaut qui est 8080) :

    monitor:
      mqtt:
        server: mymqtt.server
        targets:
        - topic: "/sensors/#"
    alert:
      gotify:
        server: "http://mygotify.server:1234"
        token: gotify_token

Une fois que vous avez créé un fichier de configuration, Janitor peut être lancé comme suit :

    $ janitor path/to/your/configfile.yml

Janitor va enregistrer les logs sur la sortie standard. Le journal est également visible sur l’interface web, où vous pouvez supprimer des cibles surveillées et recharger le fichier de configuration (par exemple si vous avez ajouté de nouvelles cibles ou modifié des paramètres).

Janitor ne se déconnectera pas pour tourner en arrière-plan. Il est recommandé de créer un service systemd pour janitor si vous souhaitez qu’il fonctionne en continu.

## Exécution avec Docker

La dernière version de Janitor est disponible sur Docker Hub [`abali/janitor`](https://hub.docker.com/repository/docker/abali/janitor). Pour l’utiliser, mappez votre fichier de configuration vers `/janitor/config.yml` :

    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 abali/janitor

Alternativement, vous pouvez utiliser le Dockerfile fourni pour construire vous-même un conteneur :

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ docker build . -t janitor
    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 janitor

## Plans futurs et contribution


L'objectif de Janitor est clair et simple : surveiller la disponibilité et le fonctionnement des appareils IOT et alerter en cas de problème. Toute amélioration future doit suivre cet objectif et ainsi soit ajouter de nouvelles méthodes de surveillance, soit de nouvelles méthodes d'alerte.

Janitor est un logiciel open source et vous êtes encouragé à envoyer des pull requests via Github pour améliorer le logiciel.

## Licence

Janitor est sous licence GPL 3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-25

---