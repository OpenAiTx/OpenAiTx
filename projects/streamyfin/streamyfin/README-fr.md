<a href="https://www.buymeacoffee.com/fredrikbur3" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/.github/refs/heads/main/streamyfin-github-banner.png" alt="Streamyfin" width="100%">
</p>

**Streamyfin est un client de streaming vidéo Jellyfin convivial construit avec Expo. Conçu comme une alternative aux autres clients Jellyfin, il vise à offrir une expérience de streaming fluide et fiable. Nous espérons que vous le trouverez un ajout précieux à votre boîte à outils de streaming média.**

---

<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot1.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot3.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot2.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/jellyseerr.PNG" width="21%">
</p>


## 🌟 Fonctionnalités

- 🚀 **Support du saut d’intro/crédits** : Permet de passer rapidement les intros et crédits pendant la lecture
- 🖼️ **Images Trickplay** : La nouvelle norme d’or pour les aperçus de chapitres lors de la recherche
- 📥 **Téléchargement de médias** : Enregistrez vos médias localement et regardez-les hors ligne
- ⚙️ **Gestion des paramètres** : Gérez les configurations de l’application pour tous les utilisateurs via notre plugin
- 🤖 **Intégration Seerr (anciennement Jellyseerr)** : Demandez des médias directement dans l’application
- 👁️ **Vue des sessions :** Visualisez toutes les sessions actives en cours de streaming sur votre serveur
- 📡 **Chromecast** : Diffusez vos médias sur n’importe quel appareil compatible Chromecast

## 🧪 Fonctionnalités expérimentales

Streamyfin propose des fonctionnalités expérimentales passionnantes telles que le téléchargement de médias et le support Chromecast. Ces fonctionnalités sont en cours de développement actif, et vos retours ainsi que votre patience nous aident à les améliorer.

### 📥 Téléchargement

Le téléchargement fonctionne en utilisant FFmpeg pour convertir un flux HLS en fichier vidéo sur votre appareil. Cela vous permet de télécharger et de regarder tout contenu que vous pouvez streamer. La conversion est effectuée en temps réel par Jellyfin sur le serveur pendant le téléchargement. Bien que cela puisse prendre un peu plus de temps, cela garantit la compatibilité avec tous les fichiers que votre serveur peut transcoder.

### 🧩 Plugin Streamyfin

Le plugin Jellyfin pour Streamyfin est un plugin que vous installez dans Jellyfin et qui contient tous les paramètres pour le client Streamyfin. Cela vous permet de synchroniser les paramètres entre tous vos utilisateurs, par exemple :

- Connexion automatique à Seerr sans saisie utilisateur requise
- Définir vos langues préférées par défaut
- Configurer la méthode de téléchargement et le fournisseur de recherche
- Personnaliser votre écran d’accueil
- Et bien plus encore

[Plugin Streamyfin](https://github.com/streamyfin/jellyfin-plugin-streamyfin)

### 📡 Chromecast

Le support Chromecast est actuellement en cours de développement. La diffusion vidéo est déjà disponible, et nous travaillons activement à l’ajout du support des sous-titres et d’autres fonctionnalités.

### 🔍 Jellysearch

[Jellysearch](https://gitlab.com/DomiStyle/jellysearch) fonctionne avec Streamyfin

> Un proxy de recherche en texte intégral rapide pour Jellyfin. S’intègre parfaitement avec la plupart des clients Jellyfin.

## 🛣️ Feuille de route

Consultez notre [Feuille de route](https://github.com/users/fredrikburmester/projects/5) pour voir sur quoi nous travaillons ensuite, nous sommes toujours ouverts aux retours et suggestions. Merci de nous faire savoir si vous avez des idées ou des demandes de fonctionnalités.

## 📥 Télécharger Streamyfin

<div style="display: flex; gap: 5px;">
  <a href="https://apps.apple.com/app/streamyfin/id6593660679?l=en-GB"><img height=50 alt="Obtenir Streamyfin sur l’App Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_the_App_Store_Badge.png"/></a>
  <a href="https://play.google.com/store/apps/details?id=com.fredrikburmester.streamyfin"><img height=50 alt="Obtenir Streamyfin sur Google Play Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Google_Play_Store_badge_EN.svg"/></a>
  <a href="https://github.com/streamyfin/streamyfin/releases/latest"><img height=50 alt="Obtenir Streamyfin sur Github" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_Github_.png"/></a>
</div>

### 🧪 Test Beta

Pour accéder à la version bêta de Streamyfin, vous devez vous abonner au niveau Membre (ou supérieur) sur [Patreon](https://www.patreon.com/streamyfin). Cela vous donne un accès immédiat au canal ⁠🧪-beta-releases sur Discord et me permet de savoir que vous êtes abonné. C’est là que je partage les APK et IPAs. Cela ne donne pas un accès automatique à TestFlight, merci de m’envoyer un DM (Cagemaster) avec l’email que vous utilisez pour Apple afin que nous puissions vous ajouter manuellement.

**Note** : Toute personne contribuant activement au code source de Streamyfin recevra un accès automatique aux versions bêta.

## 🚀 Pour Commencer

### ⚙️ Prérequis

- Votre appareil est sur le même réseau que le serveur Jellyfin (pour les connexions locales)  
- Votre serveur Jellyfin est en marche avec l'accès à distance activé si vous prévoyez de vous connecter depuis l'extérieur de votre réseau local  
- Votre version du serveur est à jour (les versions plus anciennes peuvent causer des problèmes de compatibilité)  
- Vous disposez d'un compte utilisateur Jellyfin valide avec accès aux bibliothèques médias que vous souhaitez consulter  
- Si vous utilisez des fonctionnalités telles que **téléchargements** ou **intégration Seerr**, confirmez que les plugins requis sont installés et configurés sur votre serveur Jellyfin

## 🙌 Contribution

Nous accueillons les contributions qui améliorent Streamyfin. Commencez par forker le dépôt et soumettre une pull request. Pour les changements majeurs ou nouvelles fonctionnalités, veuillez d'abord ouvrir une issue pour discuter de vos idées et assurer leur alignement avec le projet.

## 🌍 Traductions

[![Statut de traduction Crowdin](https://badges.crowdin.net/streamyfin/localized.svg)](https://crowdin.com/project/streamyfin)

Streamyfin est disponible en plusieurs langues, et nous recherchons toujours des contributeurs pour rendre l'application accessible dans le monde entier.  
Vous pouvez contribuer aux traductions directement sur notre [page projet Crowdin](https://crowdin.com/project/streamyfin).

### 👨‍💻 Infos Développement

1. Utilisez node `>20`  
2. Installez les dépendances `bun i && bun run submodule-reload`  
3. Assurez-vous d’avoir xcode et/ou android studio installés. (suivez les guides pour expo : https://docs.expo.dev/workflow/android-studio-emulator/)  
4. Installez l’extension BiomeJS dans VSCode/votre IDE (https://biomejs.dev/)  
4. lancez `npm run prebuild`  
5. Créez une build dev expo en lançant `npm run ios` ou `npm run android`. Cela ouvrira un simulateur sur votre ordinateur et lancera l’application

Pour la version TV, ajoutez le suffixe `:tv` aux commandes npm.

`npm run prebuild:tv`  
`npm run ios:tv ou npm run android:tv`

## 👋 Contactez-Nous

Besoin d’aide ou avez des questions ?

- **Discord :** [Rejoignez notre serveur](https://discord.gg/BuGG9ZNhaE)
- **Problèmes GitHub :** [Signaler des bugs ou demander des fonctionnalités](https://github.com/streamyfin/streamyfin/issues)  
- **Email :** [developer@streamyfin.app](https://raw.githubusercontent.com/streamyfin/streamyfin/develop/mailto:developer@streamyfin.app)  


## ❓ FAQ

1. Q : Pourquoi ne puis-je pas voir mes bibliothèques dans Streamyfin ?  
   R : Assurez-vous que votre serveur utilise l’une des dernières versions et que vous avez au moins une bibliothèque qui n’est pas uniquement audio  
2. Q : Pourquoi ne puis-je pas voir ma bibliothèque musicale ?  
   R : Nous ne supportons pas actuellement la musique et il est peu probable que nous la supportions dans un avenir proche  

## 📝 Crédits

Streamyfin est développé par [Fredrik Burmester](https://github.com/fredrikburmester) et n’est pas affilié à Jellyfin. L’application est construite avec Expo, React Native, et d’autres bibliothèques open source.

## 🎖️ Développeurs principaux

Merci aux contributeurs suivants pour leurs contributions significatives :

<div align="left">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Alexk2309">
        <img src="https://github.com/Alexk2309.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Alexk2309</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/herrrta">
        <img src="https://github.com/herrrta.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@herrrta</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lostb1t">
        <img src="https://github.com/lostb1t.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lostb1t</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Simon-Eklundh">
        <img src="https://github.com/Simon-Eklundh.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Simon-Eklundh</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/topiga">
        <img src="https://github.com/topiga.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@topiga</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lancechant">
        <img src="https://github.com/lancechant.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lancechant</b></sub>
      </a>
    </td>
  </tr>
  <tr>
    <td align="center">
      <a href="https://github.com/simoncaron">
        <img src="https://github.com/simoncaron.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@simoncaron</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/jakequade">
        <img src="https://github.com/jakequade.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@jakequade</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ryan0204">
        <img src="https://github.com/Ryan0204.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Ryan0204</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/retardgerman">
        <img src="https://github.com/retardgerman.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@retardgerman</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/whoopsi-daisy">
        <img src="https://github.com/whoopsi-daisy.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@whoopsi-daisy</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Gauvino">
        <img src="https://github.com/Gauvino.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Gauvino</b></sub>
      </a>
    </td>
  </tr>
</table>
</div>

## ✨ Acknowledgements

We would like to thank the Jellyfin team for their excellent software and support on Discord.

Special thanks to the official Jellyfin clients, which have served as an inspiration for Streamyfin.

We also thank all other developers who have contributed to Streamyfin, your efforts are greatly appreciated.

A special mention to the following people and projects for their contributions:

- [Reiverr](https://github.com/aleksilassila/reiverr) for invaluable help with understanding the Jellyfin API
- [Jellyfin TS SDK](https://github.com/jellyfin/jellyfin-sdk-typescript) for providing the TypeScript SDK
- [Seerr](https://github.com/seerr-team/seerr) for enabling API integration with their project


## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=streamyfin/streamyfin&type=Date)](https://star-history.com/#streamyfin/streamyfin&Date)

## 📄 License
Streamyfin est licencié sous la Mozilla Public License 2.0 (MPL-2.0).  
Cela signifie que vous êtes libre d’utiliser, de modifier et de distribuer ce logiciel. La MPL-2.0 est une licence copyleft qui permet plus de flexibilité dans la combinaison du logiciel avec du code propriétaire.  
Points clés de la MPL-2.0 :  

- Vous pouvez utiliser le logiciel à n’importe quelle fin  
- Vous pouvez modifier le logiciel et distribuer des versions modifiées  
- Vous devez inclure les avis de copyright et de licence originaux  
- Vous devez divulguer votre code source pour toute modification des fichiers couverts  
- Les œuvres plus larges peuvent combiner le code MPL avec du code sous d’autres licences  
- Les composants sous licence MPL doivent rester sous MPL, mais l’œuvre plus large peut être sous une licence différente  
- Pour le texte complet de la licence, veuillez consulter le fichier LICENSE dans ce dépôt  

## ⚠️ Avertissement  
Streamyfin ne promeut, ne soutient ni ne cautionne le piratage sous aucune forme. L’application est destinée uniquement au streaming de médias que vous possédez et contrôlez personnellement. Elle ne fournit ni n’inclut aucun contenu média. Toute discussion, demande de support ou référence au piratage, ainsi que tout outil, logiciel ou site web lié au piratage, sont strictement interdits sur tous nos canaux.  

## 🤝 Parrainage  
Hébergement VPS généreusement fourni par [Hexabyte](https://hexabyte.se/en/vps/?currency=eur) et [SweHosting](https://swehosting.se/en/#tj%C3%A4nster)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---