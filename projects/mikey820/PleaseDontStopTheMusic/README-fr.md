# PleaseDontStopTheMusic

Un tweak iOS qui permet à plusieurs sources audio de jouer simultanément en empêchant les interruptions de session audio.

## ❤️ Soutenez le Projet

Si vous trouvez ce projet utile et souhaitez soutenir le développement, les dons sont appréciés.

### Litecoin  
**Réseau :** Litecoin (LTC)  
**Adresse :** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

Veuillez vérifier que vous envoyez bien sur le réseau **Litecoin**.

Merci pour votre soutien !

---

## Aperçu

**PleaseDontStopTheMusic** est un tweak qui s’accroche au `AVAudioSession` d’iOS pour permettre le mixage audio. Cela permet à votre audio en cours de lecture (musique, podcasts, etc.) de continuer sans interruption quand d’autres applications demandent la lecture audio, au lieu du comportement habituel où le système met votre audio en pause et joue uniquement la nouvelle source.

## Fonctionnalités

- **Lecture Continue** – Votre audio continue à jouer même lorsque d’autres apps veulent produire du son.  
- **Mixage Audio** – Plusieurs sources audio se mélangent en utilisant l’option `MixWithOthers`.  
- **Support Universel** – Fonctionne avec des installations rootful, rootless et jailbreakées.  
- **Léger** – Surcharge minimale, implémentation purement basée sur des hooks.

## Fonctionnement

Le tweak intercepte les appels de configuration `AVAudioSession` et, **uniquement lorsqu’une autre app joue déjà de l’audio** (`isOtherAudioPlaying`), applique l’option `AVAudioSessionCategoryOptionMixWithOthers` à la session de l’app entrante. Cela indique à iOS de mixer le nouvel audio avec la lecture existante plutôt que de l’interrompre.

Important, il ne force **pas** le mixage sur l’app principale de musique. Une app qui choisit `MixWithOthers` est traitée par iOS comme une source *secondaire* et perd ses contrôles de transport "Lecture en cours" sur l’écran verrouillé / Centre de contrôle. En laissant la première app intacte, celle-ci conserve tous les contrôles de saut et pause sur l’écran verrouillé, tandis que les apps ultérieures (TikTok, jeux, etc.) sont forcées de se mixer discrètement sans interruption.

### Méthodes Hookées

- `setCategory:error:`  
- `setCategory:mode:options:error:`  
- `setCategory:mode:routeSharingPolicy:options:error:` *(l’API moderne utilisée par TikTok et la plupart des apps actuelles)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

Les sessions `SoloAmbient` (qui ne peuvent pas être mélangées) sont automatiquement basculées en `Ambient` lorsqu'une autre application joue, afin qu'elles ne coupent plus votre musique.

---

## Guide d'installation

Choisissez la méthode ci-dessous qui correspond à la configuration de votre appareil.

### Méthode 1 : Non jailbreaké (Sideloading)
Utilisez cette méthode si votre appareil n'est pas jailbreaké. Vous devrez injecter la tweak `.dylib` des releases dans le fichier IPA de votre application cible.

1. **Préparez :** Assurez-vous d'avoir le fichier `PleaseDontStopTheMusic.dylib`.
2. **Choisissez l'outil :** Utilisez un outil de sideloading tel que **Esign**, **Feather**, ou **Sideloadly**.
3. **Injectez :** Importez l’IPA de votre application cible (l’application sur laquelle vous souhaitez écouter des médias, par ex. si je veux écouter Spotify en jouant à Roblox, je l'injecterais dans Roblox) dans l'outil, sélectionnez le `.dylib` pour l'injection, puis signez l'application.
4. **Installez :** Installez l’IPA modifié résultant sur votre appareil.

### Méthode 2 : Jailbreaké
Utilisez cette méthode si votre appareil est jailbreaké.

1. **Ajoutez le Repo :** Ouvrez https://repo.chariz.com/ et appuyez sur le bouton pour l'ajouter à votre gestionnaire de paquets préféré (cela devrait être un repo par défaut mais si vous ne l'avez pas, ajoutez-le)
2. **Installez :** Naviguez vers le repo dans votre liste pour le récupérer, ou cherchez "PleaseDontStopTheMusic"
3. **Finalisez :** Effectuez un **respring** de votre appareil pour appliquer les hooks.

---

Si vous avez des problèmes ou des questions, n’hésitez pas à m’envoyer un message sur Discord ! dc : fuseegelee

```bash
make all
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---