# Soulseek CLI

[![Build Status](https://travis-ci.org/aeyoll/soulseek-cli.svg?branch=develop)](https://travis-ci.org/aeyoll/soulseek-cli)

Un client Soulseek CLI.

Exigences
---

NodeJS >= 20

Installation
---

```sh
npm install -g soulseek-cli
```

### Sur Linux

Une des dépendances de soulseek-cli ([node-keytar](https://github.com/atom/node-keytar)) utilise libsecret, vous devez donc l’installer avant d’exécuter `npm install`.

Selon votre distribution, vous devrez exécuter la commande suivante :

- Debian/Ubuntu : `sudo apt-get install libsecret-1-dev`
- Basé sur Red Hat : `sudo yum install libsecret-devel`
- Arch Linux : `sudo pacman -S libsecret`

### Sur Linux sans interface graphique

Sur Linux, [node-keytar](https://github.com/atom/node-keytar) utilise l’API Linux SecretService. Il est possible d’utiliser le backend SecretService sur des systèmes Linux sans serveur X11 disponible (seul D-Bus est requis). Dans ce cas, vous pouvez faire ce qui suit (exemple dans un environnement Debian) :

#### Installer les dépendances

```sh
apt install gnome-keyring --no-install-recommends # Install the GNOME Keyring daemon. "no-install-recommends" prevents X11 install
```

#### Utilisation

```sh
dbus-run-session -- $SHELL # Start a D-Bus session
echo 'root' | /usr/bin/gnome-keyring-daemon -r -d --unlock # Unlock GNOME Keyring
soulseek ... # Use soulseek-cli normally
```
Commandes
---

### Connexion

Avant de pouvoir effectuer une recherche, vous devez être connecté.

Utilisation :

```
soulseek login
```

Vous serez invité à entrer votre identifiant et mot de passe Soulseek. Les identifiants sont stockés et chiffrés dans le trousseau de clés de votre système.

Alternativement, vous pouvez également vous connecter en configurant des variables d'environnement :

```sh
export SOULSEEK_ACCOUNT=youraccount
export SOULSEEK_PASSWORD=yourpassword
soulseek download "..."
```

### Télécharger

Téléchargez avec la requête requise.

Utilisation :
```
soulseek download|d [options] [query...]
```

:warning: Cette commande s'appelait `search` dans les versions antérieures à 0.1.0.

Options :

| Option                    | Description                                                                   |
| ------------------------- | ----------------------------------------------------------------------------- |
| -d --destination <folder> | destination des téléchargements                                               |
| -q --quality <quality>    | afficher uniquement les mp3 d'une qualité définie                            |
| -m --mode <mode>          | filtrer le type de fichiers souhaités (disponible : "mp3", "flac", défaut : "mp3") |
| -h --help                 | afficher l'aide pour la commande                                             |

Exemples :

```sh
soulseek download "Your query" # Download in the current folder
soulseek download "Your query" --destination=/path/to/directory # Download in a defined folder (relative or absolute)
soulseek download "Your query" --quality=320 # Filter by quality
soulseek download "Your query" --mode=flac # Filter by file type
```

### Requête

Recherchez avec la requête requise, mais ne téléchargez rien. Si un résultat est trouvé, le code de retour sera 0. Sinon,
le code de retour sera 1 (utile pour les scripts)

Utilisation :

```
soulseek query|q [options] [query...]
```
Options :

| Option                 | Description                                                                  |
| ---------------------- | ---------------------------------------------------------------------------- |
| -q --quality <quality> | afficher uniquement les mp3 avec une qualité définie                         |
| -m --mode <mode>       | filtrer le type de fichiers souhaité (disponible : "mp3", "flac", défaut : "mp3") |
| -h --help              | afficher l’aide pour la commande                                             |



Contribution
---

Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/aeyoll/soulseek-cli/main/CONTRIBUTING.md).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---