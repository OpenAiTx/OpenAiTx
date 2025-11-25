# TTS-Vue Version Web

🎤 Outil de synthèse vocale Microsoft, version Web, construit avec `Vue` + `ElementPlus` + `Vite`.

## Exemple de site

https://web.tts88.top
### Nouvelle interface
![image](https://github.com/user-attachments/assets/177c8c0d-33d1-48e7-81e3-778f36d8fedd)

### Ancienne interface
![image](https://github.com/user-attachments/assets/67cafd2c-7b0f-4b0d-b14b-bf402aaff0cd)

## Fonctionnalités

- 🌐 Entièrement Web, pas besoin d’installer une application de bureau
- 🔊 Supporte plusieurs synthèses vocales Microsoft
- 🚀 Intégration de l’API TTS88 prise en charge
- 🆓 Appels TTS gratuits pris en charge, quota gratuit quotidien
- 🧠 Prise en charge de la génération de texte OpenAI
- 🌍 Multilingue : chinois, anglais, espagnol
- 🔐 Empreinte digitale du navigateur pour une expérience utilisateur plus sécurisée

## Dernières mises à jour

### Reconstruction de l’interface et amélioration des fonctionnalités (v2.2.0)

- 📱 **Refonte UI** : navigation fixe en haut, zone de texte en mode sticky, optimisation pour mobiles
- 🔤 **Amélioration SSML** : nouvelle fonction de formatage SSML, mise à jour automatique selon les réglages
- 🎵 **Optimisation du lecteur** : intégration du lecteur dans l’interface principale, amélioration de la lecture et du téléchargement audio
- 🎞️ **Fonction sous-titres** : nouvelle fonction de génération de sous-titres en ligne, amélioration de la productivité créative
- 🌓 **Optimisation thème** : amélioration de l’apparence en mode sombre, ajout du changement de thème global
- 🛠️ **Paramètres avancés** : optimisation de l’interface du service TTS gratuit, ajout de réglages de vitesse et de tonalité
- 💡 **Expérience interactive** : ajout d’infobulles, meilleure orientation utilisateur
- 🔄 **Mise à jour des dépendances** : Vue mise à jour en 3.5.11, ElementPlus en 2.9.9
- 🌐 **Mise à jour des liens** : adresse du dépôt GitHub mise à jour

### Intégration du service TTS gratuit (v2.1.0)

- 🆕 **Fonction TTS gratuite** : pas besoin de clé API, quota gratuit quotidien garanti
- 👤 **Identification par empreinte du navigateur** : garantir une utilisation équitable du quota gratuit pour chaque utilisateur  
- 🔄 **Affichage de l'état du quota** : afficher en temps réel le nombre de caractères gratuits restants et l'heure de réinitialisation  
- 🌐 **Détection de l'état du serveur** : détection automatique de l'état de connexion au serveur TTS gratuit  
- 🛡️ **Amélioration de la gestion des erreurs** : messages d'erreur plus conviviaux et retour d'état amélioré  
- 🎛️ **Panneau de configuration TTS gratuit** : faciliter la configuration et la consultation des informations sur le quota  

### Optimisation de l'interface et de l'expérience utilisateur (v2.0.0)  

- ✨ **Optimisation de la zone de réglages** : le panneau de configuration supporte le repli, cliquer sur le titre "Paramètres vocaux" pour déplier/replier  
- 🔘 **Position intelligente du bouton** : le bouton "Démarrer la conversion" est déplacé en haut, accessible sans défilement  
- 💬 **Amélioration des indications d'état** : ajout d’un texte indicatif clair sur l’état de conversion  
- 🎨 **Amélioration des effets visuels** : ajout d’animation lumineuse sur les boutons pour renforcer l’expérience utilisateur  
- 📱 **Optimisation de la mise en page responsive** : amélioration de l’affichage sur différentes tailles d’écran  

Ces améliorations augmentent considérablement l’efficacité d’utilisation, en particulier en résolvant le problème des designs traditionnels où l’utilisateur devait faire défiler jusqu’en bas de la page pour cliquer sur le bouton "Démarrer la conversion". Désormais, quel que soit l’emplacement de l’utilisateur sur la page, il peut facilement lancer la conversion.  

## Plan de développement  

> **📢 Avis important : une version bureau est en cours de développement !**  
> Nous développons une application de bureau multiplateforme, qui supportera plus de fonctionnalités et une meilleure expérience utilisateur.  
> Restez à l’écoute des prochaines mises à jour et suivez le projet pour obtenir les dernières informations.  

## Démarrage rapide  

### Environnement de développement

```bash
# 克隆仓库
git clone https://github.com/henryhu55/tts-web-vue.git

# 安装依赖
yarn install

# 启动开发服务器
yarn dev
```

### Construction de production

```bash
# 构建生产版本
yarn build

# 预览生产版本
yarn preview
```
## Déploiement

Une fois la construction terminée, déployez le contenu du répertoire `dist` sur n'importe quel serveur Web statique.

## Configuration de l'API

Cette version Web prend actuellement en charge le service TTS gratuit, l'API TTS88 et l'API OpenAI :

### Configuration du service TTS gratuit

1. Trouvez l'option "Service TTS gratuit" dans la page des paramètres
2. Le système configure par défaut l'adresse du serveur TTS gratuit
3. Vous pouvez consulter le quota gratuit restant pour la journée et l'heure de réinitialisation
4. Chaque client navigateur dispose d'un quota gratuit indépendant

### Configuration de l'API TTS88

1. Trouvez l'option "URL de l'API tierce" dans la page des paramètres
2. Saisissez l'adresse de votre API TTS88
3. Si vous disposez d'une clé API, saisissez-la dans le champ "Clé API TTS88"

### Configuration de l'API OpenAI

1. Trouvez l'option de configuration OpenAI dans la page des paramètres
2. Saisissez votre clé API OpenAI
3. Choisissez le modèle à utiliser (par défaut gpt-3.5-turbo)
4. Si vous utilisez une instance auto-hébergée ou un proxy, vous pouvez définir une URL de base API personnalisée

## Remarques

- Les données sont uniquement stockées dans le stockage local du navigateur, le rafraîchissement ou la suppression du cache n'affecte pas les autres utilisateurs
- Les fichiers audio convertis peuvent être lus directement dans le navigateur ou téléchargés localement
- Le service TTS gratuit a une limite d'utilisation quotidienne, un dépassement nécessite d'attendre la réinitialisation le jour suivant

## Stack technique

- Vue 3.2
- Pinia
- ElementPlus

- Vite

## Licence

Licence MIT

## Commencer

- [Introduction au projet](https://docs.tts88.top//guide/intro.html)
- [Installation et exécution](https://docs.tts88.top//guide/install.html)
- [Présentation des fonctionnalités](https://docs.tts88.top/guide/features.html)
- [FAQ](https://docs.tts88.top//guide/qa.html)
- [Journal des mises à jour](https://docs.tts88.top//guide/update.html)

## Attention

Ce logiciel et son code sont uniquement destinés à un usage personnel et à des fins d'apprentissage ; veuillez les supprimer dans les 24 heures suivant le téléchargement, et ne pas les utiliser à des fins commerciales, sous peine de conséquences assumées par vous-même. Toute conséquence juridique due à une utilisation illégale ne relève pas de ma responsabilité. Ce logiciel ne sera jamais payant ; si vous avez payé des frais supplémentaires avant de l'utiliser, ou si vous avez payé pour obtenir le code source ou un logiciel fini, alors vous avez certainement été victime d'une arnaque !

**Veuillez indiquer la source lors du transfert. Il est interdit d'inciter d'autres personnes à rejoindre un groupe, à envoyer des messages privés, etc., pour obtenir le dépôt, l'adresse de téléchargement ou le package d'installation du logiciel.**

### Groupe QQ pour retours d’opinions, questions et versions publiées :

`【tts-web-vue groupe de retours 1】279895662`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-25

---