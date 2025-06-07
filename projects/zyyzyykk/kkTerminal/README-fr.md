# kkTerminal

> kkTerminal, un terminal pour la connexion SSH Web
>
> Auteur : [zyyzyykk](https://github.com/zyyzyykk/)
>
> Code source : https://github.com/zyyzyykk/kkTerminal
>
> Adresse Docker Hub : https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Aperçu : https://ssh.kkbpro.com/
>
> Date de mise à jour : 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Intégration rapide

Utilisez la balise `iframe` dans les pages web HTML pour une intégration rapide :

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Déploiement avec Docker

1. Récupérer l'image :

```bash
docker pull zyyzyykk/kkterminal
```

2. Créer et exécuter un conteneur avec mappage de port : `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Personnaliser le mot d'art : `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Accès via le navigateur : `http://server-ip:3000/`

### 🛸 Aperçu

Visitez le site suivant : https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Plus d'aperçus de modules**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Description des fonctionnalités

1. kkTerminal est un terminal pour la connexion SSH Web. Cliquez sur l'icône du terminal en haut à gauche et sélectionnez les paramètres de connexion pour établir une connexion SSH

2. Prise en charge de l'utilisation des balises `iframe` dans les pages web pour une intégration rapide sur des sites tiers

3. Prise en charge de la personnalisation de la configuration du terminal via les [paramètres d'URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Prise en charge de l'internationalisation et du changement de langue entre le chinois et l'anglais

5. Prise en charge du déploiement local sur PC, ouverture automatique de la fenêtre du navigateur au démarrage

6. Prise en charge de la taille de fenêtre adaptative et de la saisie en chinois

7. Prise en charge des paramètres de préférences personnalisées, permettant aux utilisateurs de choisir la couleur d'arrière-plan/avant-plan, la taille de la police, le style d'affichage du curseur, d'activer TCode pour le terminal, etc.

8. Prise en charge du redémarrage : redémarrage automatique après modification des paramètres de connexion SSH ou des préférences personnalisées, ou possibilité de redémarrer manuellement après la déconnexion de la connexion SSH

9. Prise en charge du copier-coller :

   - Copier : Comme dans le terminal `Git`, la sélection de texte le copie automatiquement

   - Coller : Comme dans le terminal `Cmd`, clic droit pour coller (nécessite l'autorisation d'accès du navigateur)


9. Prise en charge de la gestion des fichiers, ouvrez le module de gestion des fichiers pour voir, décompresser, téléverser et télécharger des fichiers/dossiers

10. Prise en charge des opérations par raccourcis clavier telles que la sélection multiple/tous les fichiers, copier-coller, couper, bascule de sélection, ouverture, etc.

11. Prise en charge de la navigation et de l'édition de fichiers, modification du fichier et sauvegarde sur le serveur distant via `ctrl+s`

12. Prise en charge de [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), permettant de réaliser des workflows automatisés similaires aux scripts Shell via des TCode personnalisés

13. Prise en charge de l'enregistrement des opérations et de la synchronisation cloud

14. Prise en charge des fonctions de coopération, de surveillance et de Docker

### 👨‍💻 Historique des mises à jour

##### zyyzyykk/kkterminal:3.6.0: latest

- Ajout de la fonction Avancée de Coopération
- Ajout de la fonction Avancée de Surveillance
- Ajout de la fonction Avancée Docker
- Optimisation du volume du package & de l'affichage de la page web

##### zyyzyykk/kkterminal:3.5.6: 

- Prise en charge de plus de paramètres d'URL
- Ajout de la taille en pourcentage du texte & de l'image dans l'éditeur
- Optimisation de l'affichage de la page web

##### zyyzyykk/kkterminal:3.5.3: 

- Ajout du paramètre d'URL pour personnaliser la configuration du terminal
- Correction du bug de redémarrage multi-fenêtre
- Ajout des fonctions d'enregistrement des opérations et de synchronisation cloud
- Refactoring de certaines logiques de code

[**Historique des mises à jour**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architecture

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ À propos de ce projet

Chers utilisateurs,

J'ai le regret d'annoncer qu'en raison d'un manque de temps et d'énergie, je ne pourrai plus assurer la maintenance de `kkTerminal` à l'avenir.

Si vous êtes intéressé par `kkTerminal` ou souhaitez poursuivre la maintenance, n'hésitez pas à me contacter ou à ouvrir une issue.

Si vous découvrez des bugs ou souhaitez développer de nouvelles fonctionnalités, veuillez également ouvrir une issue.

Enfin, merci pour votre soutien à `kkTerminal` et j'espère sincèrement que `kkTerminal` pourra vraiment vous être utile.

Cordialement,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Étoiles

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---