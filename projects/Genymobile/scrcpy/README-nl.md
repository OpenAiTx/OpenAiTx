**Deze GitHub-repo (<https://github.com/Genymobile/scrcpy>) is de enige officiële bron voor het project. Download geen releases van willekeurige websites, zelfs niet als hun naam `scrcpy` bevat.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_uitgesproken als "**scr**een **c**o**py**"_

Deze applicatie spiegelt Android-apparaten (video en audio) die verbonden zijn via USB of
[TCP/IP](doc/connection.md#tcpip-wireless) en maakt bediening mogelijk met het toetsenbord en de muis van de computer. Het vereist geen _root_-toegang of een app die op het apparaat is geïnstalleerd. Het werkt op _Linux_, _Windows_ en _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Het richt zich op:

 - **lichtgewicht**: native, toont alleen het apparaatscherm
 - **prestaties**: 30~120fps, afhankelijk van het apparaat
 - **kwaliteit**: 1920×1080 of hoger
 - **lage latency**: [35~70ms][lowlatency]
 - **korte opstarttijd**: ~1 seconde om de eerste afbeelding te tonen
 - **niet-invasief**: er blijft niets geïnstalleerd achter op het Android-apparaat
 - **gebruikersvoordelen**: geen account, geen advertenties, geen internet nodig
 - **vrijheid**: vrije en open source software

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

De functies omvatten:
 - [audio-doorsturen](doc/audio.md) (Android 11+)
 - [opnemen](doc/recording.md)
 - [virtueel scherm](doc/virtual_display.md)
 - spiegelen met [Android-scherm uit](doc/device.md#turn-screen-off)
 - [kopiëren-plakken](doc/control.md#copy-paste) in beide richtingen
 - [instelbare kwaliteit](doc/video.md)
 - [camera-spiegeling](doc/camera.md) (Android 12+)
 - [spiegelen als webcam (V4L2)](doc/v4l2.md) (alleen Linux)
 - fysieke [toetsenbord][hid-keyboard] en [muis][hid-mouse] simulatie (HID)
 - [gamepad](doc/gamepad.md) ondersteuning
 - [OTG-modus](doc/otg.md)
 - en meer…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Vereisten

Het Android-apparaat vereist minimaal API 21 (Android 5.0).

[Audio-doorsturen](doc/audio.md) wordt ondersteund vanaf API >= 30 (Android 11+).

Zorg ervoor dat je [USB-debugging hebt ingeschakeld][enable-adb] op je apparaat/apparaten.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Op sommige apparaten (vooral Xiaomi) kun je de volgende foutmelding krijgen:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

In dat geval moet je een [extra optie][control] inschakelen:
`USB-debugging (Beveiligingsinstellingen)` (dit is een ander item dan `USB-debugging`) om het te kunnen bedienen met een toetsenbord en muis. Het apparaat moet opnieuw worden opgestart nadat deze optie is ingesteld.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Let op: USB-debugging is niet vereist om scrcpy in de [OTG-modus](doc/otg.md) uit te voeren.


## De app verkrijgen

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (lees [hoe uit te voeren](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Belangrijke tips

 - [Resolutie verlagen](doc/video.md#size) kan de prestaties aanzienlijk verbeteren
   (`scrcpy -m1024`)
 - [_Rechtermuisknop_](doc/mouse.md#mouse-bindings) activeert `BACK`
 - [_Middelste muisknop_](doc/mouse.md#mouse-bindings) activeert `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> schakelt [volledig scherm](doc/window.md#fullscreen) in/uit
 - Er zijn veel andere [sneltoetsen](doc/shortcuts.md)


## Voorbeelden van gebruik

Er zijn veel opties, [gedocumenteerd](#user-documentation) op aparte pagina's.
Hier zijn enkele veelvoorkomende voorbeelden.

 - Leg het scherm vast in H.265 (betere kwaliteit), beperk de grootte tot 1920, beperk
   de framerate tot 60fps, schakel audio uit en bedien het apparaat door een fysiek toetsenbord te simuleren:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # korte versie
    ```

 - Start VLC in een nieuw virtueel scherm (gescheiden van het apparaatscherm):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Neem de apparaatcamera op in H.265 op 1920x1080 (en microfoon) naar een MP4-bestand:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Leg de frontcamera van het apparaat vast en stel deze beschikbaar als webcam op de computer (op Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Bedien het apparaat zonder spiegeling door een fysiek toetsenbord en muis te simuleren (USB-debugging niet vereist):

    ```bash
    scrcpy --otg
    ```

 - Bedien het apparaat met gamepad-controllers die op de computer zijn aangesloten:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # korte versie
    ```

## Gebruikersdocumentatie

De applicatie biedt veel functies en configuratiemogelijkheden. Deze zijn
gedocumenteerd op de volgende pagina's:

 - [Verbinding](doc/connection.md)
 - [Video](doc/video.md)
 - [Audio](doc/audio.md)
 - [Bediening](doc/control.md)
 - [Toetsenbord](doc/keyboard.md)
 - [Muis](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Apparaat](doc/device.md)
 - [Venster](doc/window.md)
 - [Opnemen](doc/recording.md)
 - [Virtueel scherm](doc/virtual_display.md)
 - [Tunnels](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Camera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Sneltoetsen](doc/shortcuts.md)


## Bronnen

 - [FAQ](FAQ.md)
 - [Vertalingen][wiki] (niet noodzakelijk up-to-date)
 - [Bouwinstructies](doc/build.md)
 - [Ontwikkelaars](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artikelen

- [Introductie van scrcpy][article-intro]
- [Scrcpy werkt nu draadloos][article-tcpip]
- [Scrcpy 2.0, met audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Contact

Je kunt een [issue] openen voor bugmeldingen, functieverzoeken of algemene vragen.

Lees voor bugmeldingen eerst de [FAQ](FAQ.md); mogelijk vind je direct een oplossing voor je probleem.

[issue]: https://github.com/Genymobile/scrcpy/issues

Je kunt ook gebruik maken van:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Doneren

Ik ben [@rom1v](https://github.com/rom1v), de auteur en beheerder van _scrcpy_.

Als je deze applicatie waardeert, kun je [mijn open source werk ondersteunen][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licentie

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Gelicentieerd onder de Apache License, Version 2.0 (de "Licentie");
    je mag dit bestand niet gebruiken behalve in overeenstemming met de Licentie.
    Je kunt een kopie van de Licentie verkrijgen op:

        http://www.apache.org/licenses/LICENSE-2.0

    Tenzij vereist door toepasselijk recht of schriftelijk overeengekomen, wordt software
    die onder de Licentie wordt verspreid, verspreid op een "AS IS"-BASIS,
    ZONDER GARANTIES OF VOORWAARDEN VAN WELKE AARD DAN OOK, uitdrukkelijk of impliciet.
    Zie de Licentie voor de specifieke bepalingen die van toepassing zijn op machtigingen en beperkingen.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---