# Salut, je suis WxBotClient <img width="30px" src="https://media.tenor.com/images/3b388fe03da271d2674faf85eb7c3fcd/tenor.gif" />
Je suis un logiciel open source de gestion de WeChat, développé avec electron, wechaty et vue, maintenant intégré à ChatGPT. Le paquet d'installation compilé est prêt à l'emploi, ne dépend pas d'un environnement complexe, le programme de gestion ne se déconnecte pas arbitrairement, stable et fiable.

<img align="right" height="200" src="https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./src/assets/icons/icon.png" />

---
## Méthode d'installation
### Télécharger & Installer
[Adresse de téléchargement du paquet releases](https://github.com/WhiteWatson/wx-bot-client/releases), ici vous pouvez télécharger le **paquet d'installation .exe (windows)** déjà construit. Pendant le téléchargement, le logiciel peut indiquer que le fichier est non sécurisé, vous pouvez ignorer cet avertissement, une fois le téléchargement terminé, installez-le localement.

### Gérer votre WeChat
Ouvrez le logiciel, cliquez sur le bouton **Commencer**, dans la fenêtre qui s’ouvre, saisissez votre clé API openAI,

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/one.png)

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/apikeyinput.png)

Après avoir rempli, cliquez sur **C’est maintenant, démarrez le robot**, attendez l’apparition du code QR, une fois le QR code affiché, scannez-le avec WeChat pour vous connecter et gérer WeChat.

astuce : En Chine, utilisez un VPN, sinon l’API ne fonctionnera pas et l’IA restera en mode réflexion.

### Paramètres de base du robot
Après une connexion réussie, accédez au tableau de bord de gestion du robot, cliquez sur le menu **Paramètres GPT** à gauche, vous verrez les paramètres de base du robot.

Modifiez le mot déclencheur du robot dans **Mot déclencheur AI**

Dans **Chat de groupe AI, Chat privé AI** vous pouvez spécifier les groupes ou utilisateurs WeChat que le robot doit servir

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/gptsetting.png)

---
## Présentation des fonctionnalités
### Capacité de dialogue texte AI

```
提问格式： @AI + 问题内容

例：@AI 你是谁？
```
### Capacité de génération d'images par IA

```
提问格式： /image + 图片提示词

例：/image 一个骑马的人
```
tips : Étant donné que l'IA génère facilement des images interdites, le robot envoie directement un lien vers l'image, et ce lien est temporaire.

---

## Déploiement personnalisé
Ce projet nécessite un environnement node pour fonctionner localement

### Installation des dépendances

Veuillez noter qu'il est impératif d'utiliser yarn ou pnpm pour installer les dépendances ici
```
yarn install
```

### Intégration de ChatGPT et exécution locale du projet :

```
npm run electron:serve
```

### Emballage du paquet d'installation client :
```
npm run electron:build
```
### Configuration de la clé API openAI dans le projet  
Accédez au répertoire `/src/bot/config.ts`, puis remplissez les champs `Organization` et `APIKey` dans la fonction `setApiKey` avec les informations obtenues via [le portail officiel de demande d’API openAi](https://platform.openai.com/account/api-keys)  

### En cas de problème, [vous pouvez consulter ce document en premier](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/problem.md)  

---  
## Je suis étudiant en informatique et génie informatique  

- 👨‍💻 Je travaille actuellement sur des technologies de développement web comme JavaScript, Vue, etc.  
- 💪🏼 Objectifs futurs : Apprendre davantage de technologies - Ne jamais cesser de créer de nouvelles idées.  
- ⚡ Anecdote amusante : J’adore jouer à Genshin Impact.  

### Remerciements particuliers à leeguiyu@qq.com pour la création des icônes  

### Langages et outils 🛠  

![JavaScript](https://img.shields.io/badge/-JavaScript-%23F7DF1C?style=flat-square&logo=javascript&logoColor=000000&labelColor=%23F7DF1C&color=%23FFCE5A)  
![HTML5](https://img.shields.io/badge/-HTML5-%23E44D27?style=flat-square&logo=html5&logoColor=ffffff)  
![CSS3](https://img.shields.io/badge/-CSS3-%231572B6?style=flat-square&logo=css3)  
![Sass](https://img.shields.io/badge/-Sass-%23CC6699?style=flat-square&logo=sass&logoColor=ffffff)  
![Bootstrap](https://img.shields.io/badge/-Bootstrap-563D7C?style=flat-square&logo=Bootstrap)  
![Markdown](https://img.shields.io/badge/-Markdown-000000?style=flat-square&logo=markdown)  
![Nodejs](https://img.shields.io/badge/-Nodejs-339933?style=flat-square&logo=Node.js&logoColor=ffffff)  
![Npm](https://img.shields.io/badge/-npm-CB3837?style=flat-square&logo=npm)  
![Git](https://img.shields.io/badge/-Git-%23F05032?style=flat-square&logo=git&logoColor=%23ffffff)  
![GitHub](https://img.shields.io/badge/-GitHub-181717?style=flat-square&logo=github)  
![VS Code](http://img.shields.io/badge/-VS%20Code-007ACC?style=flat-square&logo=visual-studio-code&logoColor=ffffff)  
![Powershell](http://img.shields.io/badge/-Powershell-5391FE?style=flat-square&logo=powershell&logoColor=ffffff)  
![Windows](http://img.shields.io/badge/-Windows-0078D6?style=flat-square&logo=windows&logoColor=ffffff)  

<br/>  

<br/>  

  <h2 align="center"> Statistiques Github 📈 </h2>  
  
  <div align="center">   
     <a href="">  
      <img align="center" src="https://github-readme-stats-sigma-five.vercel.app/api?username=WhiteWatson&show_icons=true&include_all_commits=true&count_private=true&theme=react&line_height=40" />  
    </a>
    <a href="">
      <img align="center" src="https://github-readme-stats.vercel.app/api/top-langs/?username=WhiteWatson&theme=react&line_height=40&hide=css"/>
    </a>
</div
  
<br/>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---