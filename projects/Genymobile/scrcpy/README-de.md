**Dieses GitHub-Repository (<https://github.com/Genymobile/scrcpy>) ist die einzige offizielle Quelle für das Projekt. Laden Sie keine Releases von beliebigen Webseiten herunter, auch wenn deren Name `scrcpy` enthält.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_ausgesprochen "**scr**een **c**o**py**"_

Diese Anwendung spiegelt Android-Geräte (Video und Audio), die über USB oder [TCP/IP](doc/connection.md#tcpip-wireless) verbunden sind, und ermöglicht die Steuerung über die Tastatur und Maus des Computers. Sie erfordert keinen _Root_-Zugang und keine App-Installation auf dem Gerät. Sie funktioniert unter _Linux_, _Windows_ und _macOS_.

![Screenshot](assets/screenshot-debian-600.jpg)

Der Fokus liegt auf:

 - **Leichtgewichtigkeit**: nativ, zeigt nur den Gerätescreen an
 - **Leistung**: 30~120fps, je nach Gerät
 - **Qualität**: 1920×1080 oder höher
 - **Niedrige Latenz**: [35~70ms][lowlatency]
 - **Kurze Startzeit**: ~1 Sekunde bis zum Anzeigen des ersten Bildes
 - **Nicht-Invasivität**: Es bleibt nichts auf dem Android-Gerät installiert
 - **Nutzerfreundlichkeit**: kein Account, keine Werbung, kein Internet erforderlich
 - **Freiheit**: freie und quelloffene Software

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Zu den Funktionen gehören:
 - [Audio-Weiterleitung](doc/audio.md) (Android 11+)
 - [Aufnahme](doc/recording.md)
 - [Virtuelles Display](doc/virtual_display.md)
 - Spiegeln mit [ausgeschaltetem Android-Bildschirm](doc/device.md#turn-screen-off)
 - [Copy-Paste](doc/control.md#copy-paste) in beide Richtungen
 - [Konfigurierbare Qualität](doc/video.md)
 - [Kamera-Spiegelung](doc/camera.md) (Android 12+)
 - [Spiegelung als Webcam (V4L2)](doc/v4l2.md) (nur Linux)
 - Physische [Tastatur][hid-keyboard] und [Maus][hid-mouse] Simulation (HID)
 - [Gamepad](doc/gamepad.md) Unterstützung
 - [OTG-Modus](doc/otg.md)
 - und mehr…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Voraussetzungen

Das Android-Gerät benötigt mindestens API 21 (Android 5.0).

[Audio-Weiterleitung](doc/audio.md) wird ab API >= 30 (Android 11+) unterstützt.

Stellen Sie sicher, dass Sie [USB-Debugging aktiviert][enable-adb] haben.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Auf manchen Geräten (insbesondere Xiaomi) kann folgender Fehler auftreten:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

In diesem Fall müssen Sie [eine zusätzliche Option][control] `USB-Debugging (Sicherheitseinstellungen)` aktivieren (dies ist ein anderer Punkt als `USB-Debugging`), um das Gerät mit Tastatur und Maus steuern zu können. Ein Neustart des Geräts ist nach dem Setzen dieser Option erforderlich.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Beachten Sie, dass USB-Debugging nicht erforderlich ist, um scrcpy im [OTG-Modus](doc/otg.md) zu verwenden.


## App herunterladen

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (lesen Sie [wie man startet](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Wichtige Tipps

 - [Reduzieren der Auflösung](doc/video.md#size) kann die Leistung deutlich verbessern (`scrcpy -m1024`)
 - [_Rechtsklick_](doc/mouse.md#mouse-bindings) löst `BACK` aus
 - [_Mittelklick_](doc/mouse.md#mouse-bindings) löst `HOME` aus
 - <kbd>Alt</kbd>+<kbd>f</kbd> schaltet [Vollbild](doc/window.md#fullscreen) um
 - Es gibt viele weitere [Shortcuts](doc/shortcuts.md)


## Anwendungsbeispiele

Es gibt viele Optionen, die [dokumentiert](#user-documentation) sind. Hier einige gängige Beispiele.

 - Bildschirm in H.265 (bessere Qualität) aufnehmen, Größe auf 1920 begrenzen, Bildrate auf 60fps begrenzen, Audio deaktivieren und das Gerät durch Simulation einer physischen Tastatur steuern:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # Kurzversion
    ```

 - VLC in einem neuen virtuellen Display (getrennt vom Gerätescreen) starten:

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Gerätekamera in H.265 mit 1920x1080 (und Mikrofon) in eine MP4-Datei aufnehmen:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Die Frontkamera des Geräts erfassen und sie als Webcam am Computer bereitstellen (unter Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Das Gerät ohne Spiegelung durch Simulation von Tastatur und Maus steuern (USB-Debugging nicht erforderlich):

    ```bash
    scrcpy --otg
    ```

 - Das Gerät mit am Computer angeschlossenen Gamepad-Controllern steuern:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # Kurzversion
    ```

## Benutzerdokumentation

Die Anwendung bietet viele Funktionen und Konfigurationsmöglichkeiten. Sie sind auf folgenden Seiten dokumentiert:

 - [Verbindung](doc/connection.md)
 - [Video](doc/video.md)
 - [Audio](doc/audio.md)
 - [Steuerung](doc/control.md)
 - [Tastatur](doc/keyboard.md)
 - [Maus](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Gerät](doc/device.md)
 - [Fenster](doc/window.md)
 - [Aufnahme](doc/recording.md)
 - [Virtuelles Display](doc/virtual_display.md)
 - [Tunnels](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Kamera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Shortcuts](doc/shortcuts.md)


## Ressourcen

 - [FAQ](FAQ.md)
 - [Übersetzungen][wiki] (nicht unbedingt aktuell)
 - [Build-Anleitung](doc/build.md)
 - [Entwickler](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artikel

- [Introducing scrcpy][article-intro]
- [Scrcpy now works wirelessly][article-tcpip]
- [Scrcpy 2.0, with audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Kontakt

Sie können ein [Issue] für Fehlerberichte, Funktionswünsche oder allgemeine Fragen eröffnen.

Für Fehlerberichte lesen Sie bitte zuerst die [FAQ](FAQ.md), vielleicht finden Sie dort direkt eine Lösung.

[issue]: https://github.com/Genymobile/scrcpy/issues

Sie können auch folgende Kanäle nutzen:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Spenden

Ich bin [@rom1v](https://github.com/rom1v), der Autor und Maintainer von _scrcpy_.

Wenn Sie diese Anwendung schätzen, können Sie [meine Open-Source-Arbeit unterstützen][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Lizenz

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Lizenziert unter der Apache License, Version 2.0 (die "Lizenz");
    Sie dürfen diese Datei nur gemäß der Lizenz verwenden.
    Eine Kopie der Lizenz erhalten Sie unter

        http://www.apache.org/licenses/LICENSE-2.0

    Sofern nicht durch geltendes Recht vorgeschrieben oder schriftlich vereinbart,
    wird die Software unter der Lizenz "AS IS" bereitgestellt, OHNE JEGLICHE GARANTIEN ODER BEDINGUNGEN,
    weder ausdrücklich noch stillschweigend.
    Siehe die Lizenz für die spezifischen Bestimmungen zur Genehmigung und Einschränkung.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---