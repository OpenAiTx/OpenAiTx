# ExKeyMo
Depuis Android 4.1, une application peut fournir des dispositions de clavier supplémentaires via des fichiers [Key Character Map](https://source.android.com/docs/core/input/key-character-map-files).
Depuis lors, il est possible de personnaliser une disposition de clavier sans accès root en installant une application contenant la disposition requise.
ExKeyMo vous aide à créer une telle application même si vous ne connaissez rien au développement Android.

ExKeyMo était hébergé par [Heroku](https://exkeymo.herokuapp.com/) mais n'est plus disponible car Heroku a cessé d'héberger des projets gratuitement et n'a pas approuvé ce projet pour le programme de crédit logiciel open source Heroku. Vous devez exécuter ExKeyMo localement pour créer un APK avec votre disposition personnalisée ou utiliser un APK précompilé listé ci-dessous.

Besoin de plus de deux dispositions ? Vous pouvez créer un tel APK en vous basant sur le projet [Custom Keyboard Layout](https://github.com/ris58h/custom-keyboard-layout).

Vous souhaitez soutenir ? [Offrez-moi un café](https://www.buymeacoffee.com/ris58h).

## APK précompilés
- CapsLock vers Ctrl [ExKeyMo-caps2ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775514/ExKeyMo-caps2ctrl.zip)
- CapsLock vers Ctrl et inversement [ExKeyMo-swap-caps-and-ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775516/ExKeyMo-swap-caps-and-ctrl.zip)
- CapsLock vers Esc [ExKeyMo-caps2esc.zip](https://github.com/ris58h/exkeymo-server/files/12775515/ExKeyMo-caps2esc.zip)
- CapsLock vers Esc et inversement [ExKeyMo-swap-caps-and-esc.zip](https://github.com/ris58h/exkeymo-server/files/12775517/ExKeyMo-swap-caps-and-esc.zip)

## Installation et configuration de l'application

1. Installez l'application. L'application est auto-signée, donc Android vous avertira d'une source non fiable ou quelque chose de similaire. Note : si vous installez l'application et obtenez une erreur, essayez de désinstaller d'abord la version précédente, si vous en avez une.
2. Allez dans `Paramètres -> Langue et saisie -> Clavier physique` (le chemin exact peut varier), choisissez le clavier que vous souhaitez personnaliser, et sélectionnez `Disposition ExKeyMo`.

## Exécuter le projet localement

### Prérequis
- Java (17 ou supérieur).

### Obtenir
Clonez le code source via Git :
```
git clone git@github.com:ris58h/exkeymo-server.git
```
Ou [téléchargez](https://github.com/ris58h/exkeymo-server/archive/refs/heads/master.zip) le fichier zip.

### Compilation
```
./mvnw clean install
```

### Run
```
java -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
Pour exécuter sur un port spécifique, utilisez la propriété système `server.port` :
```
java -Dserver.port=PORT_NUMBER -jar target/exkeymo-server-*-jar-with-dependencies.jar
```

### Utilisation
Visitez [http://localhost/](http://localhost/) et n'oubliez pas de __RTFM__ ([http://localhost/docs.html](http://localhost/docs.html)).

### Exécuter avec Docker
Vous pouvez exécuter l'application en utilisant Docker. Il y a deux façons de le faire : avec Docker Compose ou simplement Docker.

#### Utiliser Docker
Construisez l'image Docker :
```bash
docker build -t exkeymo-server .
```

Exécutez le conteneur Docker :
```bash
docker run -p 80:80 exkeymo-server
```
Cela démarrera le conteneur et exposera l'application sur le port 80.

#### Utilisation de Docker Compose

Assurez-vous d'avoir Docker et Docker Compose installés. Ensuite, exécutez la commande suivante dans le répertoire contenant le fichier `docker-compose.yml` :
```bash
docker-compose up
```
Cela construira l'image Docker et démarrera le conteneur, exposant l'application sur le port 80.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-16

---