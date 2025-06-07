**To repozytorium GitHub (<https://github.com/Genymobile/scrcpy>) jest jedynym oficjalnym źródłem projektu. Nie pobieraj wydań z losowych stron internetowych, nawet jeśli ich nazwa zawiera `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_wymawiane "**scr**een **c**o**py**"_

Ta aplikacja wyświetla lustrzane odbicie urządzeń z Androidem (wideo i audio) podłączonych przez USB lub
[TCP/IP](doc/connection.md#tcpip-wireless) i pozwala na kontrolę za pomocą
klawiatury i myszy komputera. Nie wymaga _roota_ ani instalowania aplikacji
na urządzeniu. Działa na _Linuksie_, _Windows_ i _macOS_.

![zrzut ekranu](assets/screenshot-debian-600.jpg)

Główne cechy:

 - **lekkość**: natywna, wyświetla tylko ekran urządzenia
 - **wydajność**: 30~120fps, w zależności od urządzenia
 - **jakość**: 1920×1080 lub wyżej
 - **niskie opóźnienia**: [35~70ms][lowlatency]
 - **krótki czas uruchamiania**: ~1 sekunda do wyświetlenia pierwszego obrazu
 - **nieinwazyjność**: nic nie zostaje zainstalowane na urządzeniu z Androidem
 - **korzyści dla użytkownika**: brak konta, brak reklam, brak wymaganego Internetu
 - **wolność**: wolne i otwarte oprogramowanie

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Funkcje obejmują:
 - [przesyłanie dźwięku](doc/audio.md) (Android 11+)
 - [nagrywanie](doc/recording.md)
 - [wirtualny wyświetlacz](doc/virtual_display.md)
 - lustrzane odbicie z [wyłączonym ekranem urządzenia](doc/device.md#turn-screen-off)
 - [kopiowanie-wklejanie](doc/control.md#copy-paste) w obu kierunkach
 - [konfigurowalna jakość](doc/video.md)
 - [lustrzane odbicie kamery](doc/camera.md) (Android 12+)
 - [lustrzane odbicie jako kamera internetowa (V4L2)](doc/v4l2.md) (tylko Linux)
 - fizyczna [symulacja klawiatury][hid-keyboard] i [myszy][hid-mouse] (HID)
 - [obsługa gamepada](doc/gamepad.md)
 - [tryb OTG](doc/otg.md)
 - i więcej…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Wymagania wstępne

Urządzenie z Androidem musi mieć co najmniej API 21 (Android 5.0).

[Przesyłanie dźwięku](doc/audio.md) jest obsługiwane dla API >= 30 (Android 11+).

Upewnij się, że [włączyłeś debugowanie USB][enable-adb] na swoim urządzeniu.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Na niektórych urządzeniach (szczególnie Xiaomi) możesz napotkać taki błąd:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

W takim przypadku musisz włączyć [dodatkową opcję][control] `Debugowanie USB
(Ustawienia zabezpieczeń)` (to inna pozycja niż `Debugowanie USB`), aby
kontrolować urządzenie za pomocą klawiatury i myszy. Po ustawieniu tej opcji
konieczne jest ponowne uruchomienie urządzenia.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Zwróć uwagę, że debugowanie USB nie jest wymagane do uruchomienia scrcpy w [trybie OTG](doc/otg.md).


## Pobierz aplikację

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (przeczytaj [jak uruchomić](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Wskazówki, które musisz znać

 - [Zmniejszenie rozdzielczości](doc/video.md#size) może znacznie poprawić wydajność
   (`scrcpy -m1024`)
 - [_Prawy przycisk myszy_](doc/mouse.md#mouse-bindings) wywołuje `BACK`
 - [_Środkowy przycisk myszy_](doc/mouse.md#mouse-bindings) wywołuje `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> przełącza [pełny ekran](doc/window.md#fullscreen)
 - Istnieje wiele innych [skrótów](doc/shortcuts.md)


## Przykłady użycia

Istnieje wiele opcji, [opisanych](#user-documentation) na osobnych stronach.
Oto kilka najczęstszych przykładów.

 - Przechwyć ekran w H.265 (lepsza jakość), ogranicz rozmiar do 1920, liczbę klatek do 60fps, wyłącz audio i steruj urządzeniem przez symulację fizycznej klawiatury:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # wersja skrócona
    ```

 - Uruchom VLC na nowym wirtualnym wyświetlaczu (osobno od wyświetlacza urządzenia):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Nagraj kamerę urządzenia w H.265 w 1920x1080 (oraz mikrofon) do pliku MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Przechwyć przednią kamerę urządzenia i udostępnij ją jako kamerę internetową na komputerze (na Linuksie):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Steruj urządzeniem bez lustrzanego odbicia przez symulację fizycznej klawiatury i myszy (debugowanie USB nie jest wymagane):

    ```bash
    scrcpy --otg
    ```

 - Steruj urządzeniem za pomocą padów podłączonych do komputera:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # wersja skrócona
    ```

## Dokumentacja użytkownika

Aplikacja oferuje wiele funkcji i opcji konfiguracji. Są one
opisane na następujących stronach:

 - [Połączenie](doc/connection.md)
 - [Wideo](doc/video.md)
 - [Audio](doc/audio.md)
 - [Sterowanie](doc/control.md)
 - [Klawiatura](doc/keyboard.md)
 - [Mysz](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Urządzenie](doc/device.md)
 - [Okno](doc/window.md)
 - [Nagrywanie](doc/recording.md)
 - [Wirtualny wyświetlacz](doc/virtual_display.md)
 - [Tunele](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Kamera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Skróty](doc/shortcuts.md)


## Zasoby

 - [FAQ](FAQ.md)
 - [Tłumaczenia][wiki] (niekoniecznie aktualne)
 - [Instrukcje budowania](doc/build.md)
 - [Dla deweloperów](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artykuły

- [Wprowadzenie do scrcpy][article-intro]
- [Scrcpy działa już bezprzewodowo][article-tcpip]
- [Scrcpy 2.0, z dźwiękiem][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Kontakt

Możesz zgłosić [issue] w przypadku błędów, sugestii nowych funkcji lub ogólnych pytań.

W przypadku zgłoszeń błędów najpierw przeczytaj [FAQ](FAQ.md), być może znajdziesz natychmiastowe rozwiązanie.

[issue]: https://github.com/Genymobile/scrcpy/issues

Możesz też skorzystać z:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Wsparcie

Jestem [@rom1v](https://github.com/rom1v), autorem i opiekunem _scrcpy_.

Jeśli doceniasz tę aplikację, możesz [wesprzeć moją pracę nad otwartym oprogramowaniem][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licencja

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Licencjonowane na podstawie Licencji Apache, wersja 2.0 ("Licencja");
    nie możesz używać tego pliku, chyba że zgodnie z Licencją.
    Kopię Licencji możesz uzyskać pod adresem:

        http://www.apache.org/licenses/LICENSE-2.0

    O ile prawo nie stanowi inaczej lub nie uzgodniono pisemnie, oprogramowanie
    rozpowszechniane na podstawie tej Licencji jest rozpowszechniane
    "TAK JAK JEST", BEZ ŻADNYCH GWARANCJI ANI WARUNKÓW, wyraźnych lub dorozumianych.
    Zobacz Licencję, aby uzyskać szczegółowe informacje dotyczące praw i ograniczeń.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---