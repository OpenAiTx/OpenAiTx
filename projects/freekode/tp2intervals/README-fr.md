[![Build branches](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml/badge.svg)](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml)
[![release](https://img.shields.io/github/release/freekode/tp2intervals)](https://github.com/freekode/tp2intervals/releases/latest)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E6W6XZP)

# Third Party to Intervals.icu

Application pour synchroniser les entraînements entre TrainingPeaks, TrainerRoad et Intervals.icu.

Fonctionne sur MacOS (DMG), Windows (installateur EXE), Linux (AppImage). Alternativement, il existe une image Docker et un JAR exécutable.

Tous les fichiers sont disponibles au téléchargement sur la [page de Release](https://github.com/freekode/tp2intervals/releases/latest).

**Uniquement à des fins éducatives**

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp.png?raw=true" width="25%"><img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr.png?raw=true" width="25%">

* [Liste des fonctionnalités](#list-of-features)
* [Configuration](#configuration)
    + [Intervals.icu](#intervalsicu)
    + [TrainingPeaks](#trainingpeaks)
    + [TrainerRoad](#trainerroad)
* [Autres façons d’exécuter l’application](#other-ways-to-run-the-app)
    + [JAR exécutable](#executable-jar)
    + [Docker](#docker)
* [FAQ](#faq)
    + [Général](#general)
    + [Infos concernant la planification pour le lendemain avec un compte TrainingPeaks gratuit](#info-regarding-scheduling-for-the-next-day-with-trainingpeaks-free-account)
* [Dépannage](#troubleshooting)
    + [Comment obtenir les logs](#how-to-get-logs)
    + [Comment enregistrer un fichier HAR](#how-to-record-har-file)



**Nouvel emplacement de l’image Docker ⚠️**

**Nouvelle URL de l’image : `ghcr.io/freekode/tp2intervals`**

Ancienne URL de l’image : `ghcr.io/freekode/tp2intervals/tp2intervals`

**Mises à jour TrainerRoad**

Je n'ai plus accès à TrainerRoad. Le compte que j’utilisais a annulé son abonnement. Je n’utilise pas la plateforme et c’est trop cher pour des corrections occasionnelles.  
Pour résoudre les problèmes, je ne peux compter que sur les journaux et les fichiers HAR que vous fournissez.

## Liste des fonctionnalités

**TrainingPeaks**

Compte athlète  
* Synchroniser les séances planifiées dans le calendrier entre Intervals.icu et TrainingPeaks (pour aujourd’hui et demain avec un compte TP gratuit)  
* Copier le plan d’entraînement complet depuis TrainingPeaks  
* Créer un plan d’entraînement ou un dossier de séances sur Intervals.icu à partir des séances planifiées sur TrainingPeaks

Compte coach  
* Copier le plan d’entraînement complet et la bibliothèque de séances depuis TrainingPeaks

**TrainerRoad**  
* Synchroniser les séances planifiées dans le calendrier de TrainerRoad vers TrainingPeaks ou Intervals.icu  
* Copier les séances de la bibliothèque TrainerRoad vers Intervals  
* Créer un plan d’entraînement ou un dossier de séances sur Intervals.icu à partir des séances planifiées sur TrainerRoad

Planifiez automatiquement les séances pour aujourd’hui en vérifiant votre calendrier toutes les 20 minutes.  
Pour effacer les tâches planifiées, il suffit de redémarrer l’application.

## Configuration  
Avant d’utiliser l’application, vous devez configurer l’accès aux plateformes.  
L’accès à Intervals.icu est requis, l’accès aux autres plateformes est optionnel.

Une fois que vous avez rassemblé toute la configuration requise, vous pouvez cliquer sur le bouton Confirmer.  
Si tout est correct, vous serez redirigé vers la page d’accueil.

Si votre configuration est erronée, vous verrez une erreur indiquant qu’il n’y a pas d’accès à une plateforme particulière.  
Vérifiez toutes vos valeurs et enregistrez la configuration à nouveau.

### Intervals.icu  
Copiez la clé API et l’ID athlète depuis la [page Paramètres](https://intervals.icu/settings) dans la section Paramètres développeur sur la page web d’Intervals.icu.

### TrainingPeaks

Pour utiliser TrainingPeaks, copiez tous les cookies de la requête `https://tpapi.trainingpeaks.com/users/v3/token` et collez-les sur la page de Configuration.  
L'application supprimera automatiquement les parties redondantes et seul le cookie requis restera. Suivez le guide ci-dessous pour savoir comment faire.

L'application nécessite le cookie `Production_tpAuth` (clé et valeur, quelque chose comme `Production_tpAuth=very_long_string`).  
Un autre guide est [disponible ici](https://forum.intervals.icu/t/implemented-push-workout-to-wahoo/783/87)

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp_guide.png?raw=true">

### TrainerRoad  
La configuration est très similaire à TrainingPeaks. Copiez tous les cookies de la requête `https://tpapi.trainingpeaks.com/users/v3/token` et collez-les sur la page de Configuration.  
L'application supprimera automatiquement les parties redondantes et seul le cookie requis restera. Suivez le guide ci-dessous pour savoir comment faire.

Le cookie `SharedTrainerRoadAuth` (clé et valeur, quelque chose comme `SharedTrainerRoadAuth=very_long_string`) est requis pour l'application.

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr_guide.png?raw=true">

Attention, Firefox coupe les longues chaînes dans la fenêtre des outils de développement. Copiez la valeur du cookie avec clic droit -> Copier la valeur.

## Autres façons d’exécuter l’application  
### JAR exécutable  
Le projet possède un jar exécutable avec interface web. Il nécessite JDK 21. Pour lancer le jar :
```shell
java -jar tp2intervals.jar
```
Par défaut, l’interface utilisateur est disponible sur `http://localhost:8080`. Pour changer le port, lancez le jar avec le paramètre :

```shell
java -Dserver.port=9090 -jar tp2intervals.jar
```

### Docker
Image Docker également construite pour chaque version

```yaml
services:
  app:
    image: ghcr.io/freekode/tp2intervals:latest
    container_name: tp2intervals
    volumes:
      - ./tp2intervals.sqlite:/tp2intervals.sqlite
    ports:
      - '8080:8080'
```

## FAQ

### Général
* Les étapes de rampe dans TrainerRoad ne sont pas prises en charge
* **MacOS arm64** Erreur : `"tp2intervals" est endommagé et ne peut pas être ouvert.`
  Exécutez la commande dans le terminal `xattr -d com.apple.quarantine /Applications/tp2intervals.app` puis ouvrez à nouveau l’application
* **MacOS** l’application n’est pas signée. Habituellement, vous devez l’ouvrir deux fois
* **Windows** L’application demandera l’accès au réseau local et à Internet, vous devez l’autoriser. Après tout, elle fait des requêtes HTTP
* Plus d’informations sont disponibles sur le forum https://forum.intervals.icu/t/tp2intervals-copy-trainingpeaks-and-trainerroad-workouts-plans-to-intervals/63375

### Infos concernant la planification pour le lendemain avec un compte TrainingPeaks gratuit
Officiellement, si vous avez un compte TP gratuit, vous ne pouvez pas planifier d’entraînements pour des dates futures, mais en pratique, vous le pouvez.
Vous pouvez planifier un entraînement pour le lendemain par rapport à l’heure locale du serveur TrainingPeaks. Le serveur est dans le fuseau horaire UTC-6. Voyons quelques exemples :

Exemple 1. Votre TZ est UTC+2 et la date locale actuelle est le 20.05.2024 à 06:00. Cela signifie qu’à ce moment, la date locale du serveur TP est le 19.05.2024 à 22:00.
Par conséquent, vous pouvez planifier des entraînements pour le 20.05.2024. Mais vous ne pouvez pas planifier des entraînements pour le 21.05.2024, vous pourrez le faire dans 2 heures, car dans 2 heures, l’heure locale du serveur sera le 20.05.2024 à 00:00.

Exemple 2. Votre TZ est UTC+12, date locale actuelle 20.05.2024 à 18:00. La date locale du serveur TP est le 20.05.2024 à 00:00. À ce moment, vous pouvez planifier des entraînements pour le 21.05.2024.

Différence de temps visible avec [worldtimebuddy](https://www.worldtimebuddy.com/?pl=1&lid=206,100,756135,2193733&h=206&hf=0)

## Dépannage
Pour identifier les problèmes avec n’importe quelle plateforme, les logs des utilisateurs aident beaucoup.

Récupérez les logs à partir du [guide ci-dessous](#how-to-get-logs). Et dans le cas de la plateforme TrainerRoad, essayez de [capturer un fichier HAR](#how-to-record-har-file). Envoyez-moi directement les fichiers.

#### Comment obtenir les logs
1. Allez dans Configuration
2. Dans la section Général, cochez Mode Debug, cliquez sur Confirmer
3. Reproduisez votre problème
4. Trouvez le fichier log selon votre système

* Linux : ~/.config/tp2intervals/logs/main.log
* MacOS : ~/Library/Logs/tp2intervals/main.log
* Windows : %USERPROFILE%\AppData\Roaming\tp2intervals\logs\main.log
* JAR : ./tp2intervals.log

#### Comment enregistrer un fichier HAR
1. Ouvrez un nouvel onglet dans votre navigateur
2. Ouvrez les outils de développement, cochez Conserver le journal (Firefox Roue dentée -> Conserver les journaux)

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-1.png?raw=true" width="70%">
3. Les étapes suivantes sont très importantes, car elles simulent ce que fait l’application.
   Ouvrez la page TrainerRoad, ouvrez la bibliothèque d’entraînements, trouvez un entraînement, ouvrez la page de l’entraînement (la page où vous avez le graphique avec les étapes de l’entraînement, la description, les alternatives, etc.)
4. Dans les outils de développement, cliquez sur Exporter HAR (Firefox - Roue dentée -> Enregistrer tout en HAR), enregistrez le fichier et envoyez-le-moi

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-2.png?raw=true" width="70%">



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---