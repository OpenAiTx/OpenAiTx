[![Contributeurs](https://img.shields.io/github/contributors/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/graphs/contributors)
[![Forks](https://img.shields.io/github/forks/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/metworks/members)
[![Étoiles](https://img.shields.io/github/stars/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/stargazers)
[![Problèmes](https://img.shields.io/github/issues/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/Wladefant/mshdabiola/Play_NotePad/issues)
[![Licence](https://img.shields.io/github/license/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/master/LICENSE)

# Bloc-notes

[<img src="/images/ic_launcher-playstore.png" align="left"
width="200" hspace="10" vspace="10">](/images/ic_launcher-playstore.png)

Bloc-notes est une application polyvalente de prise de notes qui vous permet de capturer et d'organiser facilement vos
pensées, idées et tâches. Avec une variété de fonctionnalités, Play Notepad facilite la gestion
de vos notes et le maintien de votre organisation.

Play NotePad est disponible sur le Google Play Store :

<p align="left">
<a href="https://play.google.com/store/apps/details?id=com.mshdabiola.playnotepad">
    <img alt="Disponible sur Google Play"
        height="70"
        src="https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png" />
</a>

<a href="https://f-droid.org/packages/com.mshdabiola.playnotepad.foss/">
    <img alt="Disponible sur F-Droid"
        height="70"
        src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png" />
</a>

<a href="https://github.com/mshdabiola/NotePad/releases">
    <img alt="Disponible sur GitHub"
        height="70"
        src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/github_image.png" />
</a>  



<a href="https://github.com/mshdabiola/Play_NotePad">Voir la démo</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">Signaler un bug</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">Demander une fonctionnalité</a>
  </p>

## À propos du projet

[<img src="/images/screenshot1.png" align="left"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot1.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png)

Quelques fonctionnalités phares :

- Mode paresseux : le défilement automatique des publications vous permet de profiter de posts incroyables sans bouger votre
  pouce
- Créez et modifiez facilement des notes texte.
- Prenez une photo ou choisissez-en une dans votre pellicule pour l'attacher à une note.
- Dessinez des croquis et diagrammes à main levée pour annoter vos notes.
- Enregistrez des notes audio et écoutez-les plus tard.
- Gardez les notes importantes en haut de votre liste pour un accès facile.
- Créez des listes de contrôle et suivez vos tâches avec des cases à cocher.
- Organisez vos notes en les étiquetant avec des labels.
- Dupliquez des notes pour une référence facile.
- Partagez vos notes avec d'autres via email ou messagerie.
- Programmez des rappels pour vos notes afin de ne jamais oublier des tâches ou événements importants.
- Supprimez les notes dont vous n'avez plus besoin.
- Gardez vos notes organisées en archivant les tâches anciennes ou terminées.
- Ajoutez de la couleur à vos notes pour les rendre plus attrayantes visuellement.
- Ajoutez une image en arrière-plan de vos notes pour un aspect plus personnalisé.
- Affichez vos notes en format liste ou colonne pour une lecture et modification faciles.
- Recherchez vos notes par mot-clé, label et type.
- Utilisez l'application hors ligne et accédez à vos notes à tout moment.

## Construit avec

## Architecture propre avec 3 modules principaux

[//]: # (<img src="/images/AndroidTemplate-CleanArchitecture.jpeg" alt="Logo Architecture"/>)

- UI déclarative (avec [Jetpack Compose](https://developer.android.com/jetpack/compose))
    - Navigation Compose (
      avec [Support Hilt](https://developer.android.com/jetpack/compose/libraries#hilt-navigation)
      et Exemple d'injection assistée)
- Données (pour la base de données, l'API et le code des préférences)
- Domaine (pour la logique métier et les modèles)
- AndroidApp (pour la logique UI, avec MVVM)
- Cette version intègre la [Modularisation](https://developer.android.com/topic/modularization)
- Gestion des versions (
  avec [Catalogue de versions](https://docs.gradle.org/current/userguide/platforms.html))
- Logique de build partagée (
  avec [Plugins de convention](https://docs.gradle.org/current/samples/sample_convention_plugins.html))
- Injection de dépendances (avec [Hilt](http://google.github.io/hilt/))
- Programmation réactive (
  avec [Kotlin Flows](https://kotlinlang.org/docs/reference/coroutines/flow.html))
- Composants d'architecture Android pour partager les ViewModels lors des changements de configuration
- Support de [Splash Screen](https://developer.android.com/develop/ui/views/launch/splash-screen)
- Bibliothèque Google Material 3 [Material Design](https://material.io/blog/android-material-theme-color)

- Configuration Edge To Edge

[//]: # (## Tests)

[//]: # (- bibliothèque [Mockk]&#40;https://mockk.io/&#41;)

[//]: # (- Tests unitaires)

[//]: # (- Tests d'application)

[//]: # (    - exemple sur comment travailler avec les tests)

[//]: # (- Tests d'activité &#40;avec [Compose Testing]&#40;https://developer.android.com/jetpack/compose/testing&#41;&#41;)

[//]: # (    - exemple sur comment travailler avec les scopes de coroutine dans les tests)

## Contribution

1. Les contributions sont ce qui fait de la communauté open source un endroit incroyable pour apprendre, s'inspirer,
   et créer. Toutes les contributions que vous apportez sont **grandement appréciées**.

2. Que vous nous aidiez à corriger des bugs, améliorer la documentation, ou faire connaître le projet, nous serions ravis de vous
   compter parmi la communauté Gatsby !

3. Merci de votre intérêt pour contribuer ! Il existe de nombreuses façons de contribuer à ce projet. Commencez ici (lien Contributing.md)

### Retour d'expérience

N'oubliez pas de donner une étoile au projet ! Merci encore !

Vous pouvez utiliser [Github Discussions](https://github.com/mshdabiola/Play_NotePad/discussions) pour
les discussions sur l'application ou simplement pour des questions générales. Vous pouvez aussi y soumettre des demandes de fonctionnalités (
merci de lire d'abord les instructions sur la manière de soumettre une demande !) ou si vous êtes développeur,
forkez ce projet et créez une pull request

1. Forkez le projet
2. Créez votre branche de fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Commitez vos modifications (`git commit -m 'Add some AmazingFeature'`)
4. Poussez vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

Voici d'autres moyens de contribuer :

* [Signaler des bugs](https://github.com/mshdabiola/Play_NotePad/issues)

* [Traduire l'application](https://poeditor.com/join/project/rdWI3SpnSW)

## Développement

## Licence

Play Notepad est licencié sous la GNU General Public License (GPL-3.0). Vous pouvez trouver le texte de la licence
dans le fichier `LICENSE`.

## Contact


mshdabiola - [@Mshdabiola](https://twitter.com/mshdabiola) - mshdabiola@gmail.com

## Remerciements


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---