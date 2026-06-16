# RemoteVideoCam

Remote Video Cam est une application Android open-source qui permet à deux appareils de diffuser en continu des vidéos et de l'audio de haute qualité l’un vers l’autre via une connexion locale. Que vous l’utilisiez comme moniteur pour bébé, caméra de sécurité DIY ou talkie-walkie, RemoteVideoCam offre une solution sécurisée, prioritairement hors ligne, sans besoin d’accès internet ni de serveurs tiers.

## ✨ Fonctionnalités

- **Zéro Configuration** : Les appareils se découvrent et se connectent automatiquement.
- **Connexion Robuste** : Négocie automatiquement la meilleure méthode de connexion disponible :
  - **Réseau Local (LAN)** : Utilise votre réseau Wi-Fi existant.
  - **Wi-Fi Aware / Wi-Fi Direct** : Connecte les appareils directement sans point d’accès (hors ligne).
- **Sécurisé & Privé** : Pas de serveurs externes. Pas de cloud. Les flux vidéo et audio ne quittent jamais votre environnement local.
- **Interface Moderne** : Conçue avec **Jetpack Compose** et **Material 3**, offrant une interface belle, réactive et intuitive avec des couleurs dynamiques.
- **Deux Modes** :
  - **Mode Caméra** : Agit en tant qu’émetteur.
  - **Mode Affichage** : Visualisez le flux de l’autre appareil.
    - *Comprend l’option « Miroir » pour inverser la vidéo horizontalement.*
  - *Note : Les deux appareils peuvent être en Mode Affichage pour se voir mutuellement (bidirectionnel).*
- **Support Audio** : Entendez ce qui se passe à l’autre bout.

## ⚠️ Note Importante

**Pas un Dispositif Médical** : Bien que RemoteVideoCam puisse être utile pour la surveillance (ex. : moniteur pour bébé), ce n’est **pas** un dispositif médical certifié. 
- Les flux vidéo peuvent se figer à cause d’interférences réseau.
- Ayez toujours une méthode de surveillance de secours.
- **Astuce** : Placez un objet mobile (comme une horloge avec une trotteuse) dans le cadre pour vérifier facilement que la vidéo est en direct.

## 🛠️ Technologies

- **Langage** : Kotlin
- **Framework UI** : Jetpack Compose (Material 3)
- **Vidéo/Audio** : WebRTC (négociation locale)
- **Vision par Ordinateur** : OpenCV (utilisé pour certaines tâches de traitement d’image)
- **Architecture** : MVVM avec flux de données réactifs (RxJava/RxAndroid)

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="Obtenez-le sur Google Play"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 Contribution

Les contributions sont les bienvenues ! Si vous êtes développeur et souhaitez aider à améliorer RemoteVideoCam, n'hésitez pas à forker le dépôt et à soumettre une pull request.

Pour les changements majeurs ou les questions, veuillez contacter le mainteneur à `izivkov@gmail.com`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---