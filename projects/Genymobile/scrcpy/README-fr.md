**Ce dépôt GitHub (<https://github.com/Genymobile/scrcpy>) est la seule source officielle
du projet. Ne téléchargez pas les versions depuis des sites aléatoires, même si
leur nom contient `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_se prononce "**scr**een **c**o**py**"_

Cette application permet de dupliquer les appareils Android (vidéo et audio) connectés via USB ou
[TCP/IP](doc/connection.md#tcpip-wireless) et autorise le contrôle à l’aide du
clavier et de la souris de l’ordinateur. Elle ne requiert pas d’accès _root_ ni l’installation d’une application
sur l’appareil. Elle fonctionne sous _Linux_, _Windows_ et _macOS_.

![capture d’écran](assets/screenshot-debian-600.jpg)

Elle met l’accent sur :

 - **légèreté** : native, affiche uniquement l’écran de l’appareil
 - **performance** : 30~120 fps, selon l’appareil
 - **qualité** : 1920×1080 ou plus
 - **faible latence** : [35~70 ms][lowlatency]
 - **démarrage rapide** : ~1 seconde pour afficher la première image
 - **non-intrusivité** : rien n’est installé sur l’appareil Android
 - **bénéfices utilisateur** : pas de compte, pas de pub, pas d’internet requis
 - **liberté** : logiciel libre et open source

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Ses fonctionnalités incluent :
 - [transmission audio](doc/audio.md) (Android 11+)
 - [enregistrement](doc/recording.md)
 - [affichage virtuel](doc/virtual_display.md)
 - duplication avec [écran de l’appareil éteint](doc/device.md#turn-screen-off)
 - [copier-coller](doc/control.md#copy-paste) dans les deux sens
 - [qualité configurable](doc/video.md)
 - [duplication de la caméra](doc/camera.md) (Android 12+)
 - [duplication en tant que webcam (V4L2)](doc/v4l2.md) (Linux uniquement)
 - simulation physique de [clavier][hid-keyboard] et [souris][hid-mouse] (HID)
 - prise en charge de la [manette de jeu](doc/gamepad.md)
 - [mode OTG](doc/otg.md)
 - et bien plus encore…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Prérequis

L’appareil Android requiert au minimum l’API 21 (Android 5.0).

[La transmission audio](doc/audio.md) est prise en charge pour API >= 30 (Android 11+).

Assurez-vous d’avoir [activé le débogage USB][enable-adb] sur votre(vos) appareil(s).

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Sur certains appareils (notamment Xiaomi), vous pourriez rencontrer l’erreur suivante :

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

Dans ce cas, vous devez activer [une option supplémentaire][control] `Débogage USB
(paramètres de sécurité)` (c’est un élément différent de `Débogage USB`) pour contrôler
l’appareil avec un clavier et une souris. Un redémarrage de l’appareil est nécessaire une fois
cette option activée.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Notez que le débogage USB n’est pas requis pour exécuter scrcpy en [mode OTG](doc/otg.md).


## Obtenir l’application

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (lire [comment lancer](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Conseils essentiels à connaître

 - [Réduire la résolution](doc/video.md#size) peut grandement améliorer les performances
   (`scrcpy -m1024`)
 - [_Clic droit_](doc/mouse.md#mouse-bindings) déclenche `RETOUR`
 - [_Clic du milieu_](doc/mouse.md#mouse-bindings) déclenche `ACCUEIL`
 - <kbd>Alt</kbd>+<kbd>f</kbd> bascule en [plein écran](doc/window.md#fullscreen)
 - De nombreux autres [raccourcis](doc/shortcuts.md) existent


## Exemples d’utilisation

Il existe de nombreuses options, [documentées](#user-documentation) sur des pages séparées.
Voici quelques exemples courants.

 - Capturer l’écran en H.265 (meilleure qualité), limiter la taille à 1920, limiter
   le nombre d’images à 60 fps, désactiver l’audio et contrôler l’appareil en simulant
   un clavier physique :

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # version courte
    ```

 - Démarrer VLC dans un nouvel affichage virtuel (séparé de l’écran de l’appareil) :

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Enregistrer la caméra de l’appareil en H.265 à 1920x1080 (et le microphone) dans un fichier MP4 :

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Capturer la caméra frontale de l’appareil et l’exposer en tant que webcam sur l’ordinateur (sous Linux) :

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Contrôler l’appareil sans duplication en simulant un clavier et une souris physiques (débogage USB non requis) :

    ```bash
    scrcpy --otg
    ```

 - Contrôler l’appareil avec des manettes branchées sur l’ordinateur :

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # version courte
    ```

## Documentation utilisateur

L’application propose de nombreuses fonctionnalités et options de configuration. Elles sont
documentées dans les pages suivantes :

 - [Connexion](doc/connection.md)
 - [Vidéo](doc/video.md)
 - [Audio](doc/audio.md)
 - [Contrôle](doc/control.md)
 - [Clavier](doc/keyboard.md)
 - [Souris](doc/mouse.md)
 - [Manette](doc/gamepad.md)
 - [Appareil](doc/device.md)
 - [Fenêtre](doc/window.md)
 - [Enregistrement](doc/recording.md)
 - [Affichage virtuel](doc/virtual_display.md)
 - [Tunnels](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Caméra](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Raccourcis](doc/shortcuts.md)


## Ressources

 - [FAQ](FAQ.md)
 - [Traductions][wiki] (pas forcément à jour)
 - [Instructions de compilation](doc/build.md)
 - [Développeurs](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Articles

- [Présentation de scrcpy][article-intro]
- [Scrcpy fonctionne maintenant sans fil][article-tcpip]
- [Scrcpy 2.0, avec audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Contact

Vous pouvez ouvrir une [issue] pour signaler un bug, demander une fonctionnalité ou poser une question générale.

Pour les rapports de bugs, veuillez lire d’abord la [FAQ](FAQ.md), vous y trouverez peut-être une solution immédiate à votre problème.

[issue]: https://github.com/Genymobile/scrcpy/issues

Vous pouvez aussi utiliser :

 - Reddit : [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky : [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter : [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Faire un don

Je suis [@rom1v](https://github.com/rom1v), l’auteur et le mainteneur de _scrcpy_.

Si vous appréciez cette application, vous pouvez [soutenir mon travail open source][donate] :
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licence

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Sous licence Apache, version 2.0 (la « Licence ») ;
    vous ne pouvez pas utiliser ce fichier sauf en conformité avec la Licence.
    Vous pouvez obtenir une copie de la Licence à l’adresse suivante :

        http://www.apache.org/licenses/LICENSE-2.0

    Sauf si la loi l’exige ou si cela est stipulé par écrit, le logiciel
    distribué sous la Licence est distribué « EN L’ÉTAT »,
    SANS GARANTIE OU CONDITION D’AUCUNE SORTE, expresse ou implicite.
    Consultez la Licence pour connaître les autorisations et les limitations.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---