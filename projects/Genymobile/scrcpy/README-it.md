**Questo repository GitHub (<https://github.com/Genymobile/scrcpy>) è l'unica fonte ufficiale
del progetto. Non scaricare le release da siti web casuali, anche se
il loro nome contiene `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_pronunciato "**scr**een **c**o**py**"_

Questa applicazione effettua il mirroring dei dispositivi Android (video e audio) collegati tramite USB o
[TCP/IP](doc/connection.md#tcpip-wireless) e permette il controllo usando
la tastiera e il mouse del computer. Non richiede l’accesso _root_ né un’app
installata sul dispositivo. Funziona su _Linux_, _Windows_ e _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Si concentra su:

 - **leggerezza**: nativa, mostra solo lo schermo del dispositivo
 - **prestazioni**: 30~120fps, a seconda del dispositivo
 - **qualità**: 1920×1080 o superiore
 - **bassa latenza**: [35~70ms][lowlatency]
 - **avvio rapido**: ~1 secondo per mostrare la prima immagine
 - **non invasività**: nulla viene lasciato installato sul dispositivo Android
 - **vantaggi per l’utente**: nessun account, nessuna pubblicità, nessuna connessione internet richiesta
 - **libertà**: software libero e open source

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Le sue funzionalità includono:
 - [inoltro audio](doc/audio.md) (Android 11+)
 - [registrazione](doc/recording.md)
 - [display virtuale](doc/virtual_display.md)
 - mirroring con [schermo del dispositivo Android spento](doc/device.md#turn-screen-off)
 - [copia-incolla](doc/control.md#copy-paste) in entrambe le direzioni
 - [qualità configurabile](doc/video.md)
 - [mirroring della fotocamera](doc/camera.md) (Android 12+)
 - [mirroring come webcam (V4L2)](doc/v4l2.md) (solo Linux)
 - simulazione fisica di [tastiera][hid-keyboard] e [mouse][hid-mouse] (HID)
 - supporto [gamepad](doc/gamepad.md)
 - [modalità OTG](doc/otg.md)
 - e altro ancora…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Prerequisiti

Il dispositivo Android richiede almeno API 21 (Android 5.0).

[L’inoltro audio](doc/audio.md) è supportato per API >= 30 (Android 11+).

Assicurati di aver [abilitato il debug USB][enable-adb] sul tuo dispositivo.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Su alcuni dispositivi (specialmente Xiaomi), potresti ricevere il seguente errore:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

In tal caso, è necessario abilitare [un’opzione aggiuntiva][control] `USB debugging
(Security Settings)` (questa è una voce diversa da `USB debugging`) per controllare
il dispositivo tramite tastiera e mouse. È necessario riavviare il dispositivo una volta attivata questa opzione.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Nota che il debug USB non è necessario per eseguire scrcpy in [modalità OTG](doc/otg.md).


## Scarica l’app

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (leggi [come eseguire](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Consigli essenziali

 - [Ridurre la risoluzione](doc/video.md#size) può migliorare notevolmente le prestazioni
   (`scrcpy -m1024`)
 - [_Click destro_](doc/mouse.md#mouse-bindings) attiva `BACK`
 - [_Click centrale_](doc/mouse.md#mouse-bindings) attiva `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> attiva/disattiva la [modalità schermo intero](doc/window.md#fullscreen)
 - Ci sono molte altre [scorciatoie](doc/shortcuts.md)


## Esempi di utilizzo

Ci sono molte opzioni, [documentate](#user-documentation) in pagine separate.
Qui solo alcuni esempi comuni.

 - Acquisire lo schermo in H.265 (migliore qualità), limitare la dimensione a 1920, limitare
   il frame rate a 60fps, disabilitare l’audio e controllare il dispositivo simulando
   una tastiera fisica:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # versione breve
    ```

 - Avviare VLC in un nuovo display virtuale (separato dal display del dispositivo):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Registrare la fotocamera del dispositivo in H.265 a 1920x1080 (e microfono) in un file MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Acquisire la fotocamera frontale del dispositivo ed esporla come webcam sul computer (su
   Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Controllare il dispositivo senza mirroring simulando una tastiera e un mouse fisici (debug USB non richiesto):

    ```bash
    scrcpy --otg
    ```

 - Controllare il dispositivo usando gamepad collegati al computer:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # versione breve
    ```

## Documentazione utente

L’applicazione offre molte funzionalità e opzioni di configurazione. Sono
documentate nelle seguenti pagine:

 - [Connessione](doc/connection.md)
 - [Video](doc/video.md)
 - [Audio](doc/audio.md)
 - [Controllo](doc/control.md)
 - [Tastiera](doc/keyboard.md)
 - [Mouse](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Dispositivo](doc/device.md)
 - [Finestra](doc/window.md)
 - [Registrazione](doc/recording.md)
 - [Display virtuale](doc/virtual_display.md)
 - [Tunnel](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Fotocamera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Scorciatoie](doc/shortcuts.md)


## Risorse

 - [FAQ](FAQ.md)
 - [Traduzioni][wiki] (non necessariamente aggiornate)
 - [Istruzioni per la compilazione](doc/build.md)
 - [Sviluppatori](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Articoli

- [Introduzione a scrcpy][article-intro]
- [Scrcpy ora funziona in modalità wireless][article-tcpip]
- [Scrcpy 2.0, con audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Contatti

Puoi aprire una [issue] per segnalazioni di bug, richieste di funzionalità o domande generali.

Per segnalazioni di bug, leggi prima le [FAQ](FAQ.md), potresti trovare subito una soluzione al tuo problema.

[issue]: https://github.com/Genymobile/scrcpy/issues

Puoi anche utilizzare:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Donazioni

Sono [@rom1v](https://github.com/rom1v), l’autore e manutentore di _scrcpy_.

Se apprezzi questa applicazione, puoi [supportare il mio lavoro open source][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licenza

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Concesso in licenza secondo i termini dell’Apache License, Versione 2.0 (la "Licenza");
    non puoi usare questo file se non in conformità alla Licenza.
    Puoi ottenere una copia della Licenza all’indirizzo:

        http://www.apache.org/licenses/LICENSE-2.0

    Salvo quanto richiesto dalla legge applicabile o concordato per iscritto, il software
    distribuito secondo la Licenza è distribuito "COSÌ COM’È",
    SENZA GARANZIE O CONDIZIONI DI ALCUN TIPO, espresse o implicite.
    Consulta la Licenza per le specifiche autorizzazioni e limitazioni.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---