<h1 align="center">Contrôleur de Ventilateurs iLO</h1>

<p align="center">
  <img width="800" src="https://raw.githubusercontent.com/alex3025/ilo-fans-controller/main/screenshot.png" alt="Capture d'écran de la page web">
  <br>
  <i>Gérez facilement la vitesse des ventilateurs de votre serveur HP, où que vous soyez !</i>
</p>

---

<h3 align="center"> 🎉 Merci beaucoup pour les <code>1.000+</code> téléchargements du conteneur ! 🎉 </h3>

> ℹ **NOTE :** La version v1.0.0 est une **réécriture complète** de l'outil, donc tout retour est apprécié !<br>
> Si vous trouvez un bug ou avez une suggestion, veuillez [ouvrir une issue](https://github.com/alex3025/ilo-fans-controller/issues). Merci ! 😄

## FAQ

### Comment ça fonctionne ? 🛠

Cet outil est un **script PHP unique** qui utilise l'extension `php-curl` pour **récupérer la vitesse actuelle des ventilateurs du serveur via l'API REST iLO** et l'extension `php-ssh2` pour **régler la vitesse des ventilateurs en utilisant l'[interface SSH iLO patchée](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F).** Vous pouvez également **créer des profils personnalisés** pour définir une configuration spécifique des ventilateurs en un seul clic, le tout avec une **interface web simple et épurée** réalisée avec [Alpine.js](https://alpinejs.dev/) et [TailwindCSS](https://tailwindcss.com/).

### Puis-je utiliser cet outil avec mon serveur HP ? 🖥️

Cet outil nécessite un **firmware iLO patché** qui expose à l'interface SSH iLO certaines commandes pour manipuler la vitesse des ventilateurs. Vous pouvez trouver plus d'informations à propos de ce patch sur [ce post Reddit](https://www.reddit.com/r/homelab/comments/sx3ldo/hp_ilo4_v277_unlocked_access_to_fan_controls/).

À ce jour, le patch (et donc cet outil) fonctionne uniquement pour les **serveurs Gen8 & Gen9 avec iLO 4.**

> 🚫 Les serveurs Gen10/11/12 avec iLO 5/6/7 ne sont pas supportés (et probablement ne le seront jamais).

### Pourquoi PHP ? 📄

À mon avis, PHP est parfait pour ce type de tâche où vous avez besoin de faire des opérations simples côté serveur et d'un déploiement facile (il suffit d'un serveur web avec PHP installé).

### Pourquoi avez-vous créé cet outil ? 🤔

Consultez mon [commentaire original sur r/homelab](https://www.reddit.com/r/homelab/comments/rcel73/comment/hnu3iyp/?utm_source=share&utm_medium=web2x&context=3) pour connaître l'histoire derrière cet outil !

### Vous aimez ce projet ? Offrez-moi une part de pizza ! 🍕

Si vous trouvez cet outil utile, pensez à m'offrir une part (ou une pizza entière) via [PayPal](https://paypal.me/alex3025) ou [GitHub Sponsors](https://github.com/sponsors/alex3025) pour soutenir mon travail ! Merci beaucoup ! 🙏

---

## Getting started with Docker / Docker Compose

If you already have a Docker environment, you can be up and running in minutes using the following command (obviously you need to change the value):

```sh
docker run -d --name ilo-fans-controller --restart always \
    -p 8000:80 \
    -e ILO_HOST='your-ilo-address' \
    -e ILO_USERNAME='your-ilo-username' \
    -e ILO_PASSWORD='your-ilo-password' \
    ghcr.io/alex3025/ilo-fans-controller:latest
```

Ou si vous préférez, vous pouvez utiliser `docker compose`, car le fichier [docker-compose.yaml](https://github.com/alex3025/ilo-fans-controller/blob/main/docker-compose.yaml) est également fourni.

**Vérifiez [`config.inc.php`](https://github.com/alex3025/ilo-fans-controller/blob/main/config.inc.php) pour toutes les variables d'environnement disponibles !**

---

> ⚠ **IMPORTANT !** ⚠
>
> Encore une fois, cet outil fonctionne grâce à un **[firmware iLO patché](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)** qui expose à l'interface SSH d'iLO certaines commandes pour manipuler la vitesse des ventilateurs.
>
> **Ce patch est nécessaire pour utiliser cet outil !**

## Installation manuelle

### Le guide suivant a été réalisé sur

* Un serveur **HP ProLiant DL380e Gen8**
* **iLO 4 patché** Advanced **v2.77** (07 décembre 2020)
* Un conteneur Proxmox (LXC) exécutant **Ubuntu 22.04**
* **Apache 2** & **PHP 8.1**

### Préparation de l'environnement

1. Mettez à jour le système :

    ```sh
    sudo apt-get update && sudo apt-get upgrade
    ```
2. Installez les paquets requis (`apache2`, `php`, `php-curl` et `php-ssh2`) :


    ```sh
    sudo apt-get install apache2 php php-curl php-ssh2
    ```

### Téléchargement de l'outil

1. Téléchargez et extrayez le code source le plus récent en utilisant `wget` et `tar` :

    ```sh
    wget -qL https://github.com/alex3025/ilo-fans-controller/archive/refs/heads/main.tar.gz -O - | tar -xz
    ```

2. Entrez dans le répertoire :

    ```sh
    cd ilo-fans-controller-main
    ```

### Configuration et installation de l'outil

1. Ouvrez le fichier `config.inc.php` dans votre éditeur de texte préféré et modifiez les variables selon votre configuration.

    > ℹ **NOTE :** N'oubliez pas que `$ILO_HOST` est l'adresse IP de votre interface iLO, pas celle du serveur lui-même.

    > ℹ **NOTE :** Il est recommandé de créer un nouvel utilisateur iLO avec les privilèges minimum requis pour accéder à l'interface SSH et à l'API REST (accès à la console distante).

    Voici un exemple :

    ```php
    /*
    ILO ACCESS CREDENTIALS
    --------------
    These are used to connect to the iLO
    interface and manage the fan speeds.
    */

    $ILO_HOST = '192.168.1.69';
    $ILO_USERNAME = 'Administrator';
    $ILO_PASSWORD = 'AdministratorPassword1234';
    ```
2. Lorsque vous avez terminé, créez un nouveau sous-répertoire dans le répertoire racine de votre serveur web (généralement `/var/www/html/`) et copiez-y les fichiers `config.inc.php`, `ilo-fans-controller.php` et `favicon.ico` :


    ```sh
    sudo mkdir /var/www/html/ilo-fans-controller
    sudo cp config.inc.php ilo-fans-controller.php favicon.ico /var/www/html/ilo-fans-controller/
    ```

    Renommez ensuite `ilo-fans-controller.php` en `index.php` (pour que cela fonctionne sans spécifier le nom du fichier dans l'URL) :

    ```sh
    sudo mv /var/www/html/ilo-fans-controller/ilo-fans-controller.php /var/www/html/ilo-fans-controller/index.php
    ```

3. C'est tout ! Vous pouvez maintenant accéder à l'outil à l'adresse `http://<votre-ip-serveur>/ilo-fans-controller/` (ou `http://<votre-ip-serveur>/ilo-fans-controller/index.php` pour les requêtes API).

> ℹ **NOTE :** Si le serveur web où vous avez installé cet outil **sera accessible depuis l'extérieur de votre réseau**, pensez à **mettre en place une forme d'authentification** (comme Basic Auth) pour éviter une _gestion non autorisée des ventilateurs à 2h du matin_.

---

## Dépannage

La première chose à faire en cas de problème est de **vérifier les logs**.

> Si vous utilisez Apache, les erreurs PHP sont enregistrées dans le fichier `/var/log/apache2/error.log`.

Si vous pensez avoir trouvé un bug, veuillez [ouvrir un ticket](https://github.com/alex3025/ilo-fans-controller/issues) et je jetterai un œil.

Vous trouverez ci-dessous quelques problèmes courants et leurs solutions.

### Les préréglages ne sont pas enregistrés

Si vous voyez l'erreur suivante dans les logs lors de la création d'un nouveau préréglage :

```log
PHP Warning:  file_put_contents(presets.json): Failed to open stream: Permission denied in .../index.php on line X
```

Cela est probablement dû au fait que le fichier `presets.json` n’est pas modifiable par l’utilisateur du serveur web.<br>
Pour résoudre ce problème, exécutez la commande suivante pour changer le propriétaire du fichier en `www-data` (l’utilisateur Apache par défaut) :

```sh
sudo chown www-data:www-data /var/www/html/ilo-fans-controller/presets.json
```

---

## Documentation de l'API

L'outil expose une API simple qui peut être utilisée pour :

* Obtenir les vitesses actuelles des ventilateurs depuis iLO
* Régler les vitesses des ventilateurs
* Obtenir tous les préréglages
* Créer un préréglage

> Les exemples suivants utilisent cURL pour montrer comment utiliser l'API, mais vous pouvez utiliser tout autre outil de votre choix.

### API Ventilateurs

Pour utiliser les API suivantes, vous devez ajouter `?api=fans` à la fin de l'URL.

#### Obtenir les vitesses des ventilateurs (`GET`)

<details>
<summary>Structure JSON (réponse)</summary>

```jsonc
{
    "Fan 1": 85,
    "Fan 2": 48,
    "Fan 3": 69,
    "Fan 4": 18,
    "Fan 5": 44,
    "Fan 6": 96
}
```

</details>

<details>
<summary>Exemple cURL</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=fans'
```

</details>

#### Régler les vitesses des ventilateurs (`POST`)

<details>
<summary>Exemple de structure JSON</summary>

```jsonc
{
    "action": "fans",
    // You can use either an object or a single number value (that will be applied to all fans):
    // Example: `fans: { ... }` or `fans: 50`
    "fans": {
        "Fan 1": 40,
        "Fan 2": 23,
        "Fan 5": 70
        // ...
    }
}
```

</details>

<details>
<summary>Exemple cURL</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "fans", "fans": 50}'
```

Cette commande réglera tous les ventilateurs à 50%.<br>
_Je utilise personnellement cette commande pour ralentir automatiquement les ventilateurs au démarrage de mon serveur._
</details>

### API de préréglages

Pour utiliser les API suivantes, vous devez ajouter `?api=preset` à la fin de l'URL.

#### Obtenir tous les préréglages (`GET`)

<details>
<summary>Structure JSON (réponse)</summary>

```jsonc
[
    {
        "name": "Silent Mode",
        "speeds": [15]  // Like when setting the speeds, this number applies to all fans.
    },
    {
        "name": "Normal Mode",
        "speeds": [50]
    },
    {
        "name": "Turbo Mode",
        "speeds": [100]
    },
    {
        "name": "My Custom Preset",
        "speeds": [10, 10, 25, 30, 10, 15]  // Here you can see the different speeds for each fan.
    }
]
```

</details>

<details>
<summary>Exemple cURL</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=presets'
```

</details>

#### Créer un préréglage (`POST`)

<details>
<summary>Exemple de structure JSON</summary>

```jsonc
{
    "action": "presets",
    // WARNING: The API will replace all the saved presets with the new data!
    // To add a preset you should get all the presets first and then add the new one to the existing array.
    "presets": [
        {
            "name": "Silent Mode",
            "speeds": [15]
        },
        {
            "name": "Normal Mode",
            "speeds": [50]
        },
        {
            "name": "Turbo Mode",
            "speeds": [100]
        },
        {
            "name": "My Custom Preset",
            "speeds": [10, 10, 25, 30, 10, 15]
        }
    ]
}
```

</details>

<details>
<summary>Exemple cURL</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "presets", "presets": [{"My Custom Preset 1": [50], "My Custom Preset 2": [10, 20, 30, 30, 20, 10]}]}'
```

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---