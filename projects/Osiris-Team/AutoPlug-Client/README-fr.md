<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Client est un programme Java autonome et exécutable qui dispose de plusieurs modes d'exécution : Server-Wrapper, CLI-Tool, Background-Service. Son objectif principal est d'automatiser la mise à jour de tout logiciel lié aux serveurs et de simplifier la maintenance des serveurs en général. Bien que tous les types de serveurs soient compatibles (y compris les serveurs de jeux Steam), la majorité de ses fonctionnalités s'adressent spécifiquement à Minecraft, reconnu comme le jeu le plus vendu au monde et doté d'une communauté de modding exceptionnellement étendue.
 
## Liens

- Téléchargez les versions stables/bêta sur le dépôt [AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases).
- Suivez le développement de [AutoPlug-Client-Development](https://bit.ly/acprogress) et voyez sur quoi nous travaillons actuellement.
- Soutenez le développement en [donnant](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4).
- Des questions ou des problèmes ? Consultez la [FAQ](/docs/FAQ.md) et/ou rejoignez notre [Discord](https://discord.com/invite/GGNmtCC), pour un support en chat/voix en direct.

## Que peut-il faire ?

- Mise à jour automatisée du programme lui-même, des logiciels serveur, des plugins, des mods et du JRE (Java Runtime Environment)
- Redémarrages programmés du serveur
- Création de sauvegardes automatisée et modulaire
- Exécution rapide, asynchrone et multithreadée des tâches
- Possibilité d'avoir des dossiers synchronisés (partagés)
- Panneau Web pour démarrer, arrêter, redémarrer le serveur et visualiser les derniers résumés des mises à jour

Fonctionnalités Premium [AutoPlug-Web](https://autoplug.one) :

- [Console en ligne](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [Gestionnaire de fichiers en ligne](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- Accès pour le personnel
- Base de données des détails des plugins

## Statut
Stable et complet en fonctionnalités, le développement est désormais communautaire, ce qui signifie que le développeur principal ne développera plus de nouvelles fonctionnalités et se reposera sur les pull requests des autres, sauf pour les problèmes de sécurité et les bugs critiques.

## Projets communautaires

- Support Docker : https://github.com/lkkuma/AutoPlug-Client-Docker
- Support panneau Pterodactly : https://github.com/ImLunaUwU/PteroPlug

Développeurs : 


Vous pouvez également utiliser AutoPlug dans vos projets en l'ajoutant comme dépendance
via [Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT). Certaines classes utiles seraient
par exemple AutoPlugConsole, qui vous permet d'exécuter des commandes AutoPlug de manière programmatique :

```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## Contribuer ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

Merci de penser à contribuer, la communauté 💙 ça ! Gardez simplement ces points à l’esprit :  
- Créez d’abord un ticket si vous souhaitez effectuer des changements importants, afin que nous puissions en discuter.  
- N’oubliez pas que les gros changements nécessitent également l’écriture de tests.  
- Vous pouvez choisir et travailler sur n’importe quel ticket ouvert. Faites-nous savoir que vous y travaillez.  
- Évitez d’utiliser et d’écrire des méthodes/champs/classes statiques pour garantir une utilisation minimale de la mémoire.  

Débutants :  

- [contribute-to-projects](https://www.jetbrains.com/help/idea/contribute-to-projects.html)  
- [clone-a-project-from-github](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)  

Récompenses :  

Certaines issues ouvertes sont marquées avec un tag/label comme celui-ci : `bounty: 15€` (voir la [liste](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)), ce qui signifie que la première personne  
créant une pull request pour corriger/fermer cette issue recevra la récompense (15€). Notez que votre code doit comporter  
au moins un test démontrant que la correction/fonctionnalité implémentée fonctionne. Notez également que les paiements sont effectués uniquement via PayPal, assurez-vous donc  
que la page publique GitHub de votre profil, avec lequel vous validez la pull request, contient quelque part votre adresse email PayPal.  
En vous engageant sur une issue avec le tag bounty, vous acceptez ces conditions.  

Détails :  

- Écrit en [Java](https://java.com/), avec [JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html), dans [IntelliJ IDEA](https://www.jetbrains.com/idea/)  
- Construit avec [1JPM](https://github.com/Osiris-Team/1JPM), commande : `java ./src/main/java/JPM.java`  
(si vous souhaitez l’exécuter directement, ajoutez `andRun` à la fin).  

## Bibliothèques  

Notez que cette liste peut être obsolète. Vérifiez le fichier [build.gradle](/build.gradle) pour nos dépendances actuelles.  
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core) contient le code fréquemment utilisé dans tous les projets AutoPlug  
  dans un seul jar.  
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml) est utilisé pour la gestion des fichiers YAML.  
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread) permet l’affichage des « live-tasks ».  
- Pour la coloration de la console et l’affichage des tâches, [Jansi](https://github.com/fusesource/jansi) et [Jline](https://github.com/jline/jline3) sont utilisés.  
- [Zip4j](https://github.com/srikanth-lingala/zip4j) pour décompresser et gérer les jar/zip.  
- Les redémarrages de serveur sont planifiés avec [Quartz](http://www.quartz-scheduler.org/).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---