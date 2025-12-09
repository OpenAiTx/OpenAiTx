# Contrôle du ventilateur HDD

[![État CI](https://img.shields.io/github/actions/workflow/status/desbma/hddfancontrol/ci.yml)](https://github.com/desbma/hddfancontrol/actions)
[![version crates.io](https://img.shields.io/crates/v/hddfancontrol)](https://crates.io/crates/hddfancontrol)
[![version AUR](https://img.shields.io/aur/version/hddfancontrol.svg?style=flat)](https://aur.archlinux.org/packages/hddfancontrol/)
[![Licence](https://img.shields.io/github/license/desbma/hddfancontrol.svg?style=flat)](https://github.com/desbma/hddfancontrol/blob/master/LICENSE)

---

Depuis la version 2.0, cet outil a été réécrit en Rust. La version Python précédente se trouve dans la [branche v1](https://github.com/desbma/hddfancontrol/tree/v1). Voir [Migration depuis v1.x](#migrating-from-v1x) pour la migration.

---

HDD Fan control est un outil en ligne de commande pour contrôler dynamiquement la vitesse du ventilateur en fonction de la température du disque dur sous Linux.

Cela présente 3 avantages :

- il permet de maintenir vos disques durs dans la plage de température idéale pour une longévité maximale et éviter la surchauffe

Parce que les ventilateurs ralentissent ou s'arrêtent lorsqu'ils ne sont pas nécessaires :

- il minimise le bruit généré par les ventilateurs
- il réduit également la consommation d'énergie

## Table des matières

- [Quand est-ce utile ?](#when-is-this-useful)
- [Fonctionnalités](#features)
- [Prérequis](#prerequisites)
- [Installation](#installation)
  - [Paquets de la distribution](#distribution-packages)
  - [Depuis les sources](#from-source)
- [Configuration](#configuration)
  - [Un mot de prudence](#a-word-of-caution)
  - [Configuration du ventilateur](#fan-configuration)
- [Journal des modifications](#changelog)
  - [Migration depuis v1.x](#migrating-from-v1x)
- [Utilisation en ligne de commande](#command-line-usage)
- [Service systemd](#systemd-service)
- [Licence](#license)

## Quand est-ce utile ?

Le contrôle du ventilateur HDD est utile lorsque vous avez un ou plusieurs disques durs avec un ou plusieurs ventilateurs proches d’eux, et que vous ne souhaitez pas que la carte mère contrôle la vitesse du ventilateur, car elle le fait soit de manière statique, soit en utilisant un capteur de température non lié à la température réelle du disque (soit sur le CPU, soit ailleurs sur la carte mère).

Le cas d’utilisation idéal est pour un NAS avec plusieurs disques durs, un CPU basse consommation (c.-à-d. ARM ou Intel Atom) avec refroidissement passif (sans ventilateurs), et un boîtier avec des ventilateurs proches des disques durs. Dans ce cas, le CPU génèrera moins de chaleur que les disques durs et il est logique de contrôler la vitesse des ventilateurs en fonction de la principale source de chaleur.

## Fonctionnalités

- Peut contrôler plusieurs ventilateurs et/ou plusieurs disques avec une seule invocation
- Supporte 6 manières différentes de requêter la température :
  - invocation de `hddtemp`
  - requête au démon `hddtemp`
  - invocation de `hdparm`
  - invocation de `smartctl` (SCT)
  - invocation de `smartctl` (attributs SMART)
  - `drivetemp` natif hwmon du noyau
- Peut s’adapter à différentes caractéristiques de ventilateurs
- Peut être personnalisé selon vos besoins :
  - pour arrêter les ventilateurs ou les faire tourner à pleine vitesse à des températures personnalisables
  - pour ne jamais régler les ventilateurs en dessous d’une certaine vitesse (utile si les ventilateurs contrôlés par HDD Fan control sont les seuls disponibles dans le boîtier)
- Peut aussi, en option, surveiller la température du CPU et contrôler la vitesse du ventilateur en conséquence

## Prérequis

- Une distribution Linux
- Au moins un disque dur SATA/SAS\* qui supporte :
  - la requête de température
  - la requête d’état d’alimentation
- Une carte mère qui :
  - expose au système un PWM pour contrôler la vitesse du ventilateur
  - expose au système un capteur pour requêter la vitesse du ventilateur

La plupart des cartes mères et des disques SATA répondent à ces exigences.

\* Plusieurs rapports indiquent que `hddfancontrol` fonctionne bien avec des disques SAS, cependant cela a été moins testé que pour SATA.

## Installation

### Paquets de la distribution

Certaines distributions Linux proposent un paquet hddfancontrol dans leur dépôt :

- Alpine Linux (testing) : [hddfancontrol](https://pkgs.alpinelinux.org/package/edge/testing/x86_64/hddfancontrol)
- Arch Linux (AUR) : [hddfancontrol](https://aur.archlinux.org/packages/hddfancontrol/)
- Fedora : [hddfancontrol](https://packages.fedoraproject.org/pkgs/hddfancontrol/hddfancontrol/)

Voir les [releases GitHub](https://github.com/desbma/hddfancontrol/releases) pour d’autres paquets/binaires construits pour chaque version taguée.

### Depuis la source

Vous avez besoin d’un environnement de compilation Rust, par exemple via [rustup](https://rustup.rs/).

Lancez dans le dépôt courant :

```
cargo build --release
install -Dm 755 -t /usr/local/bin target/release/hddfancontrol
```

Installez également [hdparm](http://sourceforge.net/projects/hdparm/), [smartctl](https://www.smartmontools.org/), [sdparm](https://sg.danny.cz/sg/sdparm.html) (pour la prise en charge des disques SAS), et éventuellement [hddtemp](http://www.guzu.net/linux/hddtemp.php).
Sur les versions récentes d’Ubuntu et autres dérivés Debian : `sudo apt install hdparm sdparm smartmontools`.

Voir le [service systemd](#systemd-service) pour gérer facilement le démon.

### Depuis [`crates.io`](https://crates.io/)

```
sudo cargo install --root /usr/local
```

## Configuration

### Un mot de prudence

Les paramètres par défaut feront tourner les ventilateurs à 100 % de leur vitesse à des températures > 50°C, et à 20 % si < 30°C, ce qui correspond à la température de fonctionnement recommandée habituelle des disques. Si vous êtes sûr qu'il n'y a pas d'autres composants dans votre système qui génèrent une chaleur significative, si vous avez d'autres ventilateurs pour refroidir votre système, ou si vous disposez d'un boîtier optimisé pour le refroidissement passif, vous pouvez régler la vitesse minimale à 0 %, ce qui arrêtera les ventilateurs si la température est inférieure au seuil minimal.

**Soyez conscient qu'une mauvaise configuration de cet outil peut entraîner un échec du refroidissement correct de votre système, ce qui peut endommager les composants ou réduire leur durée de vie.**

Avant d'utiliser le contrôle du ventilateur HDD sans surveillance pendant une longue période, je recommande de garder une vitesse minimale de ventilateur pour la sécurité, et de vérifier que la température de votre système reste dans une plage raisonnable comme prévu.

### Configuration des ventilateurs

Pour obtenir les valeurs de démarrage/arrêt pour le paramètre `--pwm`, vous pouvez soit :

- Utiliser la commande `pwm-test` (`hddfancontrol pwm-test ...`), qui exécutera des tests et détectera les valeurs auxquelles les ventilateurs démarrent et s'arrêtent. Cependant, vous devez avoir préalablement identifié le fichier PWM (le paramètre `--pwm`)
- utiliser l'outil [pwmconfig](http://www.lm-sensors.org/wiki/man/pwmconfig).

## Journal des modifications

Voir le [journal des modifications détaillé](https://raw.githubusercontent.com/desbma/hddfancontrol/master/./CHANGELOG.md) pour tous les changements depuis la version initiale 2.

### Migration depuis la v1.x

Avec la version 2, `hddfancontrol` a été entièrement réécrit en langage Rust. Les principaux changements par rapport à la version 1 sont :

- `hddfancontrol` est un binaire compilé, et ne nécessite plus d'interpréteur Python.
- Les arguments en ligne de commande sont légèrement modifiés, et devront être ajustés manuellement, soit dans vos appels `hddfancontrol`, soit dans le fichier `/etc/conf.d/hddfancontrol` si vous l'utilisez via le service systemd. Voir `hddfancontrol daemon -h` pour une référence.
- La fonction d'arrêt automatique des disques a été supprimée. Si vous en avez besoin, je recommande d'utiliser [hd-idle](https://github.com/adelolmo/hd-idle) (attention, plusieurs projets portent des noms similaires), qui fonctionne bien en parallèle de `hddfancontrol`.

## Utilisation en ligne de commande

Exécutez `hddfancontrol -h` pour obtenir la référence complète des commandes en ligne.

À titre d'exemple, la ligne de commande ci-dessous indiquera à HDD Fan control de :

- surveiller la température des disques `/dev/sda` et `/dev/sdb`
- contrôler la vitesse des ventilateurs en utilisant PWM 2 et 3 dans `/sys/class/hwmon/hwmon1/device/`
- démarrer les deux ventilateurs avec une valeur PWM de 200
- considérer que les ventilateurs s'arrêtent avec une valeur PWM de 75
- ne jamais faire fonctionner les ventilateurs en dessous de 10 % de leur vitesse maximale  
- vérifier la température au moins toutes les minutes  

`hddfancontrol daemon -d /dev/sda /dev/sdb -p /sys/class/hwmon/hwmon1/device/pwm2:200:75 /sys/class/hwmon/hwmon1/device/pwm3:200:75 --min-fan-speed-prct 10 -i 1min`  

## service systemd  

Un fichier de service systemd est fourni pour contrôler facilement le démon.  
Si vous avez installé hddfancontrol depuis un paquet de distribution, vous l’avez probablement déjà installé, sinon vous pouvez l’installer depuis les sources de ce dépôt avec :

```
sudo install -Dm 644 ./systemd/hddfancontrol.service /etc/systemd/system/hddfancontrol.service
sudo install -Dm 644 ./systemd/hddfancontrol.conf /etc/conf.d/hddfancontrol
```

Ensuite, vous devez modifier la variable `HDDFANCONTROL_DAEMON_ARGS` dans `/etc/conf.d/hddfancontrol` pour définir les paramètres (disques, plage de température...).

Vous pouvez ensuite démarrer le démon avec `sudo systemctl start hddfancontrol`, voir son statut avec `sudo systemctl status hddfancontrol` et activer le démarrage automatique au démarrage avec `sudo systemctl enable hddfancontrol`.

## Licence

[GPLv3](https://www.gnu.org/licenses/gpl-3.0-standalone.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-09

---